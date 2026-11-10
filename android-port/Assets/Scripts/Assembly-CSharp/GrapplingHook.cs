using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
	public enum HookTypeEnum
	{
		Hitscan = 0,
		Physics = 1
	}

	[Serializable]
	public class RopeJoint
	{
		public Vector3? LineDrawPoint;

		public Vector3 Point;

		public Vector3 Normal;

		public bool StartOfNewRope;

		public LineRenderer Line;

		public SimplePortal EndPortal;

		public SimplePortal StartPortal;
	}

	public HookTypeEnum HookType;

	public float PullStrength = 1f;

	public float Speed = 1f;

	public bool HasHitSomething;

	public Rigidbody DraggingObject;

	public LayerMask HitLayers;

	public LayerMask DragLayers;

	public float DragSmashDistance = 3f;

	public float LookAheadDistance = 2f;

	public float InheritVelocity;

	public Vector3 LineOffset;

	public Action<Rigidbody> OnCollided;

	public GameObject Test;

	private Rigidbody rigid;

	private LineRenderer line;

	private Vector3 origin;

	private Vector3 originVelocityWhenFired;

	public List<RopeJoint> ropeJoints;

	private float ignoreCollisionTimer;

	private FixedJoint joint;

	private Vector3 lastValidPoint;

	private bool hitPortalThisFrame;

	public void Init()
	{
		rigid = GetComponent<Rigidbody>();
		line = GetComponentInChildren<LineRenderer>();
		line.positionCount = 0;
		ropeJoints = new List<RopeJoint>();
		ropeJoints.Add(new RopeJoint());
		ropeJoints.Add(new RopeJoint
		{
			StartOfNewRope = true,
			Line = line
		});
	}

	public void FireHook(Vector3 position, Vector3 direction, Vector3 originVelocity, float RopeLength)
	{
		Reset();
		base.transform.position = position;
		base.transform.rotation = Quaternion.LookRotation(direction);
		if (HookType == HookTypeEnum.Physics)
		{
			base.gameObject.SetActive(value: true);
			originVelocityWhenFired = originVelocity;
			ropeJoints[0].Point = rigid.position;
			ropeJoints[ropeJoints.Count - 1].Point = origin;
			ropeJoints[ropeJoints.Count - 1].LineDrawPoint = origin - (origin - ropeJoints[ropeJoints.Count - 2].Point).normalized * 0.5f;
			LateUpdate();
		}
		else
		{
			Ray ray = new Ray(base.transform.position, direction);
			if (Physics.Raycast(ray, out var hitInfo, RopeLength, HitLayers, QueryTriggerInteraction.Ignore))
			{
				base.transform.position = hitInfo.point;
				HasHitSomething = true;
				base.gameObject.SetActive(value: true);
			}
		}
	}

	public void SetOrigin(Vector3 pos)
	{
		origin = pos;
		ropeJoints[ropeJoints.Count - 1].Point = origin;
		ropeJoints[ropeJoints.Count - 1].LineDrawPoint = origin - (origin - ropeJoints[ropeJoints.Count - 2].Point).normalized * 0.5f;
	}

	public void MoveHook()
	{
		if (HookType == HookTypeEnum.Physics)
		{
			if (HasHitSomething)
			{
				if (DraggingObject != null && Vector3.Distance(DraggingObject.transform.position, origin) < DragSmashDistance)
				{
					UnityEngine.Object.Destroy(DraggingObject.gameObject);
					base.gameObject.SetActive(value: false);
				}
			}
			else
			{
				Vector3 position = base.transform.position;
				Vector3 normalized = (base.transform.forward + (originVelocityWhenFired * InheritVelocity).normalized).normalized;
				position += normalized * Speed * Time.deltaTime;
				if (Physics.Linecast(rigid.position, position, out var hitInfo, (int)HitLayers | (int)DragLayers))
				{
					Debug.DrawLine(base.transform.position, hitInfo.point, Color.green, 5f);
					OnTriggerEnter(hitInfo.collider);
					rigid.MovePosition(hitInfo.point);
				}
				else
				{
					rigid.MovePosition(position);
				}
			}
		}
		ropeJoints[0].Point = rigid.position - base.transform.forward * 0.25f;
		ropeJoints[0].LineDrawPoint = rigid.position;
		ropeJoints[ropeJoints.Count - 1].Point = origin;
		ropeJoints[ropeJoints.Count - 1].LineDrawPoint = origin - (origin - ropeJoints[ropeJoints.Count - 2].Point).normalized * 0.5f;
		FindPathToOrigin();
	}

	private void FixedUpdate()
	{
		if (ignoreCollisionTimer > 0f)
		{
			ignoreCollisionTimer -= Time.deltaTime;
		}
	}

	private void Update()
	{
		hitPortalThisFrame = false;
	}

	private void LateUpdate()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		List<Vector3> list = new List<Vector3>();
		for (int i = 0; i < ropeJoints.Count; i++)
		{
			Vector3 vector = (ropeJoints[i].LineDrawPoint.HasValue ? ropeJoints[i].LineDrawPoint.Value : (ropeJoints[i].Point - ropeJoints[i].Normal));
			list.Add(vector + ropeJoints[i].Normal * line.startWidth + LineOffset);
			if (ropeJoints[i].StartOfNewRope)
			{
				ropeJoints[i].Line.positionCount = list.Count;
				ropeJoints[i].Line.SetPositions(list.ToArray());
				list.Clear();
			}
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (HasHitSomething || ignoreCollisionTimer > 0f || other.isTrigger || hitPortalThisFrame)
		{
			return;
		}
		if ((int)HitLayers == ((int)HitLayers | (1 << other.gameObject.layer)))
		{
			HasHitSomething = true;
			if (other.attachedRigidbody == null || other.attachedRigidbody.isKinematic)
			{
				rigid.collisionDetectionMode = CollisionDetectionMode.Discrete;
				rigid.isKinematic = true;
			}
			else
			{
				joint = base.gameObject.AddComponent<FixedJoint>();
				joint.connectedBody = other.attachedRigidbody;
			}
		}
		if ((int)DragLayers == ((int)DragLayers | (1 << other.gameObject.layer)))
		{
			HasHitSomething = true;
			DraggingObject = other.attachedRigidbody;
		}
		if (HasHitSomething)
		{
			OnCollided?.Invoke(DraggingObject);
		}
	}

	private void FindPathToOrigin()
	{
		RopeJoint ropeJoint = ropeJoints[ropeJoints.Count - 2];
		RopeJoint ropeJoint2 = ropeJoints[ropeJoints.Count - 1];
		if (Physics.Linecast(ropeJoint2.Point, ropeJoint.Point, out var hitInfo, (int)HitLayers | (int)DragLayers))
		{
			if (lastValidPoint != Vector3.zero)
			{
				Vector3 point = lastValidPoint;
				for (int i = 0; i < 50; i++)
				{
					Vector3 vector = Vector3.Lerp(lastValidPoint, ropeJoint2.Point, Mathf.Clamp01((float)i / 50f));
					if (Physics.Linecast(ropeJoint.Point, vector, out hitInfo, (int)HitLayers | (int)DragLayers))
					{
						break;
					}
					point = vector;
				}
				Vector3 point2 = ropeJoint.Point;
				Vector3 point3 = hitInfo.point;
				Vector3 rhs = point2 - point;
				float magnitude = rhs.magnitude;
				rhs.Normalize();
				float d = Mathf.Clamp(Vector3.Dot(point3 - point, rhs), 0f, magnitude);
				Vector3 point4 = point + rhs * d;
				ropeJoints.Insert(ropeJoints.Count - 1, new RopeJoint
				{
					Point = point4
				});
				ropeJoint2 = ropeJoints[ropeJoints.Count - 1];
			}
			else
			{
				Debug.Log("oh no");
			}
		}
		else
		{
			lastValidPoint = ropeJoint2.Point;
		}
		if (ropeJoints.Count - 3 >= 0 && !ropeJoints[ropeJoints.Count - 3].StartOfNewRope && !Physics.Linecast(ropeJoint2.Point, ropeJoints[ropeJoints.Count - 3].Point, (int)HitLayers | (int)DragLayers))
		{
			RemoveJoint(ropeJoint);
		}
	}

	public Vector3 FindNearestPointOnLine(Vector3 origin, Vector3 end, Vector3 point)
	{
		Vector3 rhs = end - origin;
		float magnitude = rhs.magnitude;
		rhs.Normalize();
		float d = Mathf.Clamp(Vector3.Dot(point - origin, rhs), 0f, magnitude);
		return origin + rhs * d;
	}

	public void ThrowDraggingObject(Vector3 velocity)
	{
		DraggingObject.velocity = velocity;
		base.gameObject.SetActive(value: false);
	}

	public RopeJoint GetPullPoint()
	{
		return (ropeJoints.Count >= 3) ? ropeJoints[ropeJoints.Count - 2] : ropeJoints[0];
	}

	public float GetRopeLength()
	{
		float num = 0f;
		for (int num2 = ropeJoints.Count - 1; num2 >= 0; num2--)
		{
			if (ropeJoints[num2].Line != null)
			{
				Vector3[] array = new Vector3[ropeJoints[num2].Line.positionCount];
				ropeJoints[num2].Line.GetPositions(array);
				for (int i = 0; i < array.Length - 1; i++)
				{
					num += Vector3.Distance(array[i], array[i + 1]);
				}
			}
		}
		return num;
	}

	private void OnDisable()
	{
		Reset();
	}

	private void Reset()
	{
		if (joint != null)
		{
			UnityEngine.Object.Destroy(joint);
		}
		HasHitSomething = false;
		DraggingObject = null;
		for (int num = ropeJoints.Count - 2; num >= 0; num--)
		{
			RemoveJoint(ropeJoints[num]);
		}
		ropeJoints.Insert(0, new RopeJoint());
		ropeJoints[1].Line.positionCount = 0;
		rigid.isKinematic = false;
		rigid.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		rigid.velocity = Vector3.zero;
		rigid.angularVelocity = Vector3.zero;
	}

	private void RemoveJoint(RopeJoint joint)
	{
		if (joint.Line != null)
		{
			UnityEngine.Object.Destroy(joint.Line.gameObject);
		}
		ropeJoints.Remove(joint);
	}

	private void OnDrawGizmosSelected()
	{
		foreach (RopeJoint ropeJoint in ropeJoints)
		{
			Gizmos.DrawSphere(ropeJoint.Point, 0.5f);
		}
	}

	public void OriginEnteredPortal(PortalPackage package)
	{
		lastValidPoint = Vector3.zero;
		RopeJoint ropeJoint = ropeJoints.FirstOrDefault((RopeJoint j) => j.Point == package.EntryPortal.transform.position);
		if (ropeJoint != null && ropeJoints.IndexOf(ropeJoint) == ropeJoints.Count - 2)
		{
			RemoveJoint(ropeJoint);
		}
		else
		{
			LineRenderer line = UnityEngine.Object.Instantiate(this.line, base.transform);
			ropeJoints.Insert(ropeJoints.Count - 1, new RopeJoint
			{
				Point = package.EntryPortal.transform.position,
				StartOfNewRope = true,
				Line = line
			});
		}
		if (ropeJoints.FirstOrDefault((RopeJoint j) => j.Point == package.ExitPortal.transform.position) == null)
		{
			ropeJoints.Insert(ropeJoints.Count - 1, new RopeJoint
			{
				Point = package.ExitPortal.transform.position,
				Normal = Vector3.zero
			});
		}
		ropeJoints[ropeJoints.Count - 1].LineDrawPoint = origin - (origin - ropeJoints[ropeJoints.Count - 2].Point).normalized * 0.5f;
	}

	private void EnteredPortal(PortalPackage package)
	{
		SimplePortal entryPortal = package.EntryPortal;
		SimplePortal exitPortal = package.ExitPortal;
		LineRenderer lineRenderer = UnityEngine.Object.Instantiate(line, base.transform);
		lineRenderer.positionCount = 0;
		ropeJoints.Insert(1, new RopeJoint
		{
			Point = entryPortal.transform.position,
			Normal = Vector3.zero,
			EndPortal = entryPortal
		});
		ropeJoints.Insert(1, new RopeJoint
		{
			Point = exitPortal.transform.position,
			Normal = Vector3.zero,
			StartOfNewRope = true,
			Line = lineRenderer,
			StartPortal = exitPortal
		});
		HasHitSomething = false;
		rigid.isKinematic = false;
		rigid.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;
		ignoreCollisionTimer = 0f;
		hitPortalThisFrame = true;
		ropeJoints[0].Point = rigid.position;
		ropeJoints[0].LineDrawPoint = rigid.position;
		LateUpdate();
	}
}
