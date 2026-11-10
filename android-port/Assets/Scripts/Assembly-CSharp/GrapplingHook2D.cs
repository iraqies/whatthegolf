using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GrapplingHook2D : MonoBehaviour
{
	public enum HookTypeEnum
	{
		Hitscan = 0,
		Physics = 1
	}

	[Serializable]
	public class RopeJoint
	{
		public Vector2? LineDrawPoint;

		public Vector2 Point;

		public Vector2 Normal;

		public bool StartOfNewRope;

		public LineRenderer Line;

		public SimplePortal EndPortal;

		public SimplePortal StartPortal;

		public float Dot;
	}

	public HookTypeEnum HookType;

	public float PullStrength = 1f;

	public float Speed = 1f;

	public bool HasHitSomething;

	public LayerMask HitLayers;

	public LayerMask DragLayers;

	public float DragSmashDistance = 3f;

	public float LookAheadDistance = 2f;

	public float InheritVelocity;

	public Vector2 LineOffset;

	public Action<Rigidbody2D> OnCollided;

	public GameObject Test;

	private Rigidbody2D rigid;

	private LineRenderer line;

	private Vector2 origin;

	private Vector2 originVelocityWhenFired;

	public List<RopeJoint> ropeJoints;

	private float ignoreCollisionTimer;

	private FixedJoint2D joint;

	private Vector3 lastValidPoint;

	public void Init()
	{
		rigid = GetComponent<Rigidbody2D>();
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

	public void FireHook(Vector2 position, Vector2 direction, Vector2 originVelocity, float RopeLength)
	{
		Reset();
		base.transform.position = position + direction.normalized;
		base.transform.right = direction;
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
			if (Physics.Raycast(ray, out var hitInfo, RopeLength, HitLayers))
			{
				base.transform.position = hitInfo.point;
				HasHitSomething = true;
				base.gameObject.SetActive(value: true);
			}
		}
	}

	public void SetOrigin(Vector2 pos)
	{
		origin = pos;
		ropeJoints[ropeJoints.Count - 1].Point = origin;
		ropeJoints[ropeJoints.Count - 1].LineDrawPoint = origin - (origin - ropeJoints[ropeJoints.Count - 2].Point).normalized * 0.5f;
	}

	public void MoveHook()
	{
		if (HookType == HookTypeEnum.Physics && !HasHitSomething)
		{
			Vector2 position = rigid.position;
			Vector2 normalized = ((Vector2)base.transform.right + (originVelocityWhenFired * InheritVelocity).normalized).normalized;
			position += normalized * Speed * Time.deltaTime;
			RaycastHit2D raycastHit2D = Physics2D.Linecast(rigid.position, position, (int)HitLayers | (int)DragLayers);
			if (raycastHit2D.transform != null)
			{
				Debug.DrawLine(base.transform.position, raycastHit2D.point, Color.green, 5f);
				OnTriggerEnter2D(raycastHit2D.collider);
				rigid.MovePosition(raycastHit2D.point);
			}
			else
			{
				rigid.MovePosition(position);
			}
		}
		ropeJoints[0].Point = rigid.position - (Vector2)base.transform.right * 0.25f;
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

	private void LateUpdate()
	{
		if (!base.gameObject.activeSelf)
		{
			return;
		}
		List<Vector3> list = new List<Vector3>();
		for (int i = 0; i < ropeJoints.Count; i++)
		{
			Vector2 vector = (ropeJoints[i].LineDrawPoint.HasValue ? ropeJoints[i].LineDrawPoint.Value : (ropeJoints[i].Point - ropeJoints[i].Normal));
			list.Add(vector + ropeJoints[i].Normal * line.startWidth + LineOffset);
			if (ropeJoints[i].StartOfNewRope)
			{
				ropeJoints[i].Line.positionCount = list.Count;
				ropeJoints[i].Line.SetPositions(list.ToArray());
				list.Clear();
			}
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (HasHitSomething || ignoreCollisionTimer > 0f)
		{
			return;
		}
		if ((int)HitLayers == ((int)HitLayers | (1 << other.gameObject.layer)))
		{
			HasHitSomething = true;
			if (other.attachedRigidbody == null || other.attachedRigidbody.isKinematic)
			{
				rigid.isKinematic = true;
				rigid.velocity = Vector2.zero;
				rigid.angularVelocity = 0f;
			}
			else
			{
				joint = base.gameObject.AddComponent<FixedJoint2D>();
				joint.connectedBody = other.attachedRigidbody;
			}
		}
		if ((int)DragLayers == ((int)DragLayers | (1 << other.gameObject.layer)))
		{
			HasHitSomething = true;
		}
		if (HasHitSomething)
		{
			OnCollided?.Invoke(null);
		}
	}

	private void FindPathToOrigin()
	{
		RopeJoint ropeJoint = ropeJoints[ropeJoints.Count - 2];
		RopeJoint ropeJoint2 = ropeJoints[ropeJoints.Count - 1];
		RaycastHit2D hit = Physics2D.Linecast(ropeJoint2.Point, ropeJoint.Point, (int)HitLayers | (int)DragLayers);
		PolygonCollider2D polygonCollider2D;
		if (hit.collider != null)
		{
			polygonCollider2D = hit.collider as PolygonCollider2D;
		}
		else
		{
			lastValidPoint = ropeJoint2.Point;
			polygonCollider2D = null;
		}
		if (polygonCollider2D != null)
		{
			Vector2 closestColliderPointFromRaycastHit = GetClosestColliderPointFromRaycastHit(hit, polygonCollider2D);
			if (closestColliderPointFromRaycastHit != ropeJoint.Point)
			{
				ropeJoints.Insert(ropeJoints.Count - 1, new RopeJoint
				{
					Point = closestColliderPointFromRaycastHit
				});
				Vector3 lhs = Vector3.Cross((ropeJoints[ropeJoints.Count - 3].Point - ropeJoints[ropeJoints.Count - 2].Point).normalized, Vector3.forward);
				Vector2 vector = ropeJoints[ropeJoints.Count - 2].Point - ropeJoints[ropeJoints.Count - 1].Point;
				ropeJoints[ropeJoints.Count - 2].Dot = Vector3.Dot(lhs.normalized, vector.normalized);
			}
		}
		if (ropeJoints.Count - 3 >= 0 && !ropeJoints[ropeJoints.Count - 3].StartOfNewRope)
		{
			Vector3 lhs2 = Vector3.Cross((ropeJoints[ropeJoints.Count - 3].Point - ropeJoints[ropeJoints.Count - 2].Point).normalized, Vector3.forward);
			Vector2 vector2 = ropeJoints[ropeJoints.Count - 2].Point - ropeJoints[ropeJoints.Count - 1].Point;
			if (Mathf.Sign(Vector3.Dot(lhs2.normalized, vector2.normalized)) != Mathf.Sign(ropeJoints[ropeJoints.Count - 2].Dot))
			{
				RemoveJoint(ropeJoint);
			}
		}
	}

	private Vector2 GetClosestColliderPointFromRaycastHit(RaycastHit2D hit, PolygonCollider2D polyCollider)
	{
		IOrderedEnumerable<KeyValuePair<float, Vector2>> source = polyCollider.points.ToDictionary((Vector2 position) => Vector2.Distance(hit.point, polyCollider.transform.TransformPoint(position)), (Vector2 position) => (Vector2)polyCollider.transform.TransformPoint(position)).OrderBy((KeyValuePair<float, Vector2> e) => e.Key);
		if (source.Any())
		{
			return source.First().Value;
		}
		return Vector2.zero;
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
		for (int num = ropeJoints.Count - 2; num >= 0; num--)
		{
			RemoveJoint(ropeJoints[num]);
		}
		ropeJoints.Insert(0, new RopeJoint());
		ropeJoints[1].Line.positionCount = 0;
		rigid.isKinematic = false;
		rigid.velocity = Vector2.zero;
		rigid.angularVelocity = 0f;
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
		if ((Vector2)package.EntryPortal.transform.position == ropeJoints[ropeJoints.Count - 2].Point)
		{
			RemoveJoint(ropeJoints[ropeJoints.Count - 2]);
			RemoveJoint(ropeJoints[ropeJoints.Count - 2]);
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
			ropeJoints.Insert(ropeJoints.Count - 1, new RopeJoint
			{
				Point = package.ExitPortal.transform.position,
				Normal = Vector3.zero
			});
		}
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
		ignoreCollisionTimer = 0.1f;
		ropeJoints[0].Point = rigid.position;
		ropeJoints[0].LineDrawPoint = rigid.position;
		LateUpdate();
		base.transform.right = package.ExitPortal.transform.forward;
	}
}
