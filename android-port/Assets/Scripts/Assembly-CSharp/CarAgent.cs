using System;
using System.Collections.Generic;
using UnityEngine;

public class CarAgent : MonoBehaviour
{
	public float Speed;

	public float Gravity;

	public float RotateSpeed = 10f;

	public LayerMask IgnoreLayers;

	public LayerMask GroundLayer;

	public float unlockedForce = 1000f;

	public float groundDist = 1.3f;

	public bool startUnlocked;

	public List<string> ResetTags = new List<string> { "OutOfBounds", "CarDespawner" };

	protected Rigidbody rigid;

	protected TrafficController.TrafficPoint _currentPath;

	private TrafficController trafficController;

	private TrafficController.TrafficPoint trafficPoint;

	public Action _onOutOfBounds;

	public Action _onCarFallingOffSide;

	protected Action _onCarCrashed;

	public Action _onCarSpeeding;

	protected Transform _currentGoal;

	protected bool isLocked;

	protected Vector3 smoothedNormal;

	protected float nonGroundTime;

	protected bool hasBeenFlat;

	protected Vector3 smoothedFlatForward;

	protected bool isFalling;

	protected float startLockTime;

	private bool isSpeedingUp;

	private void Awake()
	{
		int selfLayerBit = (gameObject.layer >= 0 && gameObject.layer < 32) ? (1 << gameObject.layer) : 0;
		IgnoreLayers = (int)IgnoreLayers | selfLayerBit | gameObject.layer;
		rigid = GetComponent<Rigidbody>();
		if (rigid != null)
			rigid.useGravity = false;
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || ResetTags == null) return;
		for (int i = 0; i < ResetTags.Count; i++)
		{
			string tag = ResetTags[i];
			if (!string.IsNullOrEmpty(tag) && other.CompareTag(tag))
			{
				_currentGoal = null;
				if (trafficController != null)
				{
					trafficController.RemoveAndDeactivateCar(trafficPoint, this);
					trafficController = null;
					trafficPoint = null;
				}
				_onOutOfBounds?.Invoke();
				return;
			}
		}
	}

	public void Iniitialize(Vector3 position, Vector3 forward, TrafficController aTrafficController, TrafficController.TrafficPoint point)
	{
		transform.position = position;
		smoothedNormal = Vector3.up;
		Vector3 normal = GetNormal();
		if (normal.y < 0.95f && point != null && point.PathPoints != null && point.PathPoints.Count >= 2 && point.PathPoints[0] != null && point.PathPoints[1] != null)
		{
			Vector3 pathDir = point.PathPoints[1].position - point.PathPoints[0].position;
			if (pathDir.y > 2f && pathDir.sqrMagnitude > 1f)
			{
				Vector3 pNorm = pathDir.normalized;
				Vector3 side = Vector3.Cross(pNorm, Vector3.up);
				if (side.sqrMagnitude > 0.0001f)
				{
					Vector3 climbNormal = Vector3.Cross(side.normalized, pNorm).normalized;
					if (climbNormal.y > 0f)
						normal = climbNormal;
				}
			}
		}
		smoothedFlatForward = Vector3.ProjectOnPlane(transform.forward, smoothedNormal);
		trafficController = aTrafficController;
		trafficPoint = point;
		_currentPath = point;
		_currentGoal = (point != null && point.PathPoints != null && point.PathPoints.Count >= 2) ? point.PathPoints[1] : null;
		if (rigid == null) rigid = GetComponent<Rigidbody>();
		if (rigid != null)
		{
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
			rigid.MovePosition(position);
		}
		smoothedNormal = normal;
		Vector3 lookDir = Vector3.ProjectOnPlane(forward, smoothedNormal);
		if (lookDir.sqrMagnitude < 0.0001f)
			lookDir = forward;
		smoothedFlatForward = lookDir.normalized;
		transform.LookAt(transform.position + smoothedFlatForward, smoothedNormal);
		if (rigid != null)
			rigid.MoveRotation(transform.rotation);
		isLocked = true;
		isFalling = false;
		isSpeedingUp = false;
		hasBeenFlat = false;
		nonGroundTime = 0f;
		startLockTime = Time.time + 1f;
		if (startUnlocked)
		{
			startLockTime = Time.time - 1f;
			Unlock();
		}
		else if (rigid != null)
		{
			rigid.useGravity = false;
		}
	}

	protected Vector3 GetNormal()
	{
		int mask = ((int)GroundLayer != 0) ? (int)GroundLayer : ~((int)IgnoreLayers);
		Vector3 origin = transform.position + smoothedNormal * 1.5f;
		if (Physics.Raycast(origin, -smoothedNormal, out RaycastHit hit, 35f, mask, QueryTriggerInteraction.Ignore))
		{
			return hit.normal;
		}
		if (Physics.Raycast(transform.position, -smoothedNormal, out RaycastHit hit2, 30f, ~((int)IgnoreLayers), QueryTriggerInteraction.Ignore))
		{
			return hit2.normal;
		}
		return Vector3.up;
	}

	protected virtual void Unlock()
	{
		if (isLocked && Time.time > startLockTime)
		{
			if (rigid != null)
				rigid.useGravity = true;
			isLocked = false;
			_onCarCrashed?.Invoke();
		}
	}

	protected bool IsGrounded()
	{
		int mask = ~((int)IgnoreLayers);
		Vector3 origin = transform.position + transform.up * 0.5f;
		if (Physics.Raycast(origin, -transform.up, out _, groundDist + 0.8f, mask, QueryTriggerInteraction.Ignore))
			return true;
		return Physics.Raycast(transform.position, -transform.up, out _, groundDist, mask);
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || collision.gameObject == null || collision.contactCount == 0) return;
		int layer = collision.gameObject.layer;
		int groundMask = (int)GroundLayer;
		ContactPoint contact = collision.GetContact(0);
		if (Vector3.Angle(contact.normal, Vector3.up) > 10f && collision.relativeVelocity.magnitude > 5f && ((1 << layer) & groundMask) == 0)
		{
			Unlock();
		}
	}

	protected virtual void FixedUpdate()
	{
		if (IsGrounded())
		{
			nonGroundTime = 0f;
		}
		else
		{
			nonGroundTime += Time.deltaTime;
			if (nonGroundTime > 0.1f && hasBeenFlat)
			{
				isFalling = true;
			}
		}

		if (isLocked)
		{
			if (rigid != null)
			{
				rigid.velocity = transform.forward * Speed - smoothedNormal * Gravity;
			}
			Vector3 normal = GetNormal();
			if (normal.y < 0.95f && _currentPath != null && _currentPath.PathPoints != null && _currentPath.PathPoints.Count >= 2 && _currentPath.PathPoints[0] != null && _currentPath.PathPoints[1] != null)
			{
				Vector3 pathDir = _currentPath.PathPoints[1].position - _currentPath.PathPoints[0].position;
				if (pathDir.y > 2f && pathDir.sqrMagnitude > 1f)
				{
					Vector3 pNorm = pathDir.normalized;
					Vector3 side = Vector3.Cross(pNorm, Vector3.up);
					if (side.sqrMagnitude > 0.0001f)
					{
						Vector3 climbNormal = Vector3.Cross(side.normalized, pNorm).normalized;
						if (climbNormal.y > 0f && Vector3.Dot(normal, climbNormal) < 0.9f)
							normal = climbNormal;
					}
				}
			}
			smoothedNormal = Vector3.MoveTowards(smoothedNormal, normal, Time.fixedDeltaTime * RotateSpeed);
			Vector3 desiredFwd = transform.forward;
			if (!hasBeenFlat && _currentGoal != null && _currentPath != null && _currentPath.PathPoints != null && _currentPath.PathPoints.Count >= 2 && _currentPath.PathPoints[0] != null && _currentPath.PathPoints[1] != null && (_currentPath.PathPoints[1].position.y - _currentPath.PathPoints[0].position.y) > 2f)
			{
				Vector3 toGoal = _currentGoal.position - transform.position;
				if (toGoal.sqrMagnitude > 0.25f)
					desiredFwd = toGoal.normalized;
			}
			Vector3 projForward = Vector3.ProjectOnPlane(desiredFwd, smoothedNormal);
			if (projForward.sqrMagnitude > 0.0001f)
				projForward.Normalize();
			smoothedFlatForward = Vector3.MoveTowards(smoothedFlatForward, projForward, Time.fixedDeltaTime * 3f * RotateSpeed);
			if (smoothedFlatForward.sqrMagnitude > 0.0001f)
			{
				Quaternion targetRot = Quaternion.LookRotation(smoothedFlatForward, smoothedNormal);
				if (rigid != null)
				{
					rigid.angularVelocity = Vector3.zero;
					rigid.MoveRotation(Quaternion.RotateTowards(rigid.rotation, targetRot, Time.fixedDeltaTime * 3f * RotateSpeed));
				}
			}

			if (Vector3.Angle(transform.up, Vector3.up) < 5f && IsGrounded())
			{
				hasBeenFlat = true;
			}

			float downAngle = Vector3.Angle(transform.forward, Vector3.down);
			if (hasBeenFlat && (downAngle < 60f || nonGroundTime > 0.08f))
			{
				if (downAngle < 60f && rigid != null)
				{
					rigid.AddTorque(transform.right * rigid.velocity.magnitude * 100f, ForceMode.Acceleration);
					_onCarFallingOffSide?.Invoke();
				}
				Unlock();
			}
		}
		else
		{
			if (IsGrounded() && !isFalling && transform.forward.y > -0.2f)
			{
				if (rigid != null)
				{
					rigid.AddForce(transform.forward * Time.fixedDeltaTime * unlockedForce, ForceMode.Acceleration);
				}
				if (!isSpeedingUp)
				{
					isSpeedingUp = true;
					_onCarSpeeding?.Invoke();
				}
			}
		}
	}
}
