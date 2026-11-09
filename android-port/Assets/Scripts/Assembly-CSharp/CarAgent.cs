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
		IgnoreLayers = (int)IgnoreLayers | (1 << gameObject.layer);
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
		smoothedFlatForward = Vector3.ProjectOnPlane(transform.forward, smoothedNormal);
		trafficController = aTrafficController;
		trafficPoint = point;
		if (rigid == null) rigid = GetComponent<Rigidbody>();
		if (rigid != null)
		{
			rigid.velocity = Vector3.zero;
			rigid.angularVelocity = Vector3.zero;
		}
		smoothedNormal = normal;
		transform.LookAt(transform.position + forward, smoothedNormal);
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
		int mask = ~((int)IgnoreLayers);
		if (Physics.Raycast(transform.position, -smoothedNormal, out RaycastHit hit, 30f, mask))
		{
			return hit.normal;
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
			smoothedNormal = Vector3.MoveTowards(smoothedNormal, normal, Time.fixedDeltaTime * RotateSpeed);
			Vector3 projForward = Vector3.ProjectOnPlane(transform.forward, smoothedNormal);
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
