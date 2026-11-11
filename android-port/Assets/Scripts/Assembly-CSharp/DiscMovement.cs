using CameraStack;
using Core;
using UnityEngine;

public class DiscMovement : MonoBehaviour
{
	public Transform Pivot;

	public float ForceMod = 10f;

	public float MoveSpeed = 10f;

	public float DeadZoneSize = 0.25f;

	public float MaxRotate = 15f;

	public Collider WinCollider;

	private Rigidbody rigidbody;

	private Vector3 currentDirection;

	private ParticleSystem crashParticles;

	private void Start()
	{
		crashParticles = GetComponentInChildren<ParticleSystem>();
		rigidbody = GetComponent<Rigidbody>();
	}

	private void OnCollisionStay(Collision other)
	{
		if (other == null || other.contacts == null || other.contacts.Length == 0 || Pivot == null)
		{
			return;
		}
		Vector3 offset = other.contacts[0].point - Pivot.position;
		offset.y = 0f;
		if (offset.magnitude > DeadZoneSize)
		{
			currentDirection = Vector3.ClampMagnitude(currentDirection + offset, 1f);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.gameObject == null)
		{
			return;
		}
		if (other.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
		{
			if (WinCollider != null && other == WinCollider)
			{
				enabled = false;
				if (Level.Instance != null && Level.Instance.Ball != null)
				{
					Level.Instance.Ball.CheckpointHit(Level.Instance.Ball.transform.position, Quaternion.identity);
				}
			}
			else
			{
				if (Level.Instance != null)
				{
					Level.Instance.Fail(true, true, null, 0f, true, "DiscCrash");
				}
				if (CameraManager.Instance != null)
				{
					CameraManager.Instance.Shake(0.3f, 20f, 1.5f);
				}
				other.isTrigger = false;
				if (crashParticles != null)
				{
					if (Level.Instance != null && Level.Instance.Ball != null)
					{
						crashParticles.transform.position = other.ClosestPoint(Level.Instance.Ball.transform.position);
					}
					crashParticles.Play();
				}
			}
		}
	}

	private void FixedUpdate()
	{
		if (rigidbody == null)
		{
			return;
		}
		if (currentDirection != Vector3.zero)
		{
			Vector3 targetPos = rigidbody.position + currentDirection * ForceMod;
			Vector3 nextPos = Vector3.MoveTowards(rigidbody.position, targetPos, Time.deltaTime * MoveSpeed);
			nextPos += transform.up * (Mathf.Sin(Time.time * 3f) * 0.02f);
			rigidbody.MovePosition(nextPos);
			Quaternion targetRot = Quaternion.Euler(Mathf.Clamp(currentDirection.z * MaxRotate, -MaxRotate, MaxRotate), rigidbody.rotation.eulerAngles.y, Mathf.Clamp(-currentDirection.x * MaxRotate, -MaxRotate, MaxRotate));
			rigidbody.MoveRotation(Quaternion.RotateTowards(rigidbody.rotation, targetRot, Time.deltaTime * MoveSpeed));
			currentDirection = Vector3.MoveTowards(currentDirection, Vector3.zero, Time.deltaTime * MoveSpeed);
		}
		else
		{
			rigidbody.MovePosition(rigidbody.position + transform.up * (Mathf.Sin(Time.time * 3f) * 0.02f));
			Quaternion targetRot = Quaternion.Euler(0f, rigidbody.rotation.eulerAngles.y, 0f);
			rigidbody.MoveRotation(Quaternion.RotateTowards(rigidbody.rotation, targetRot, Time.deltaTime * MoveSpeed));
		}
	}

	private void OnDrawGizmosSelected()
	{
		if (Pivot != null)
		{
			Gizmos.DrawWireSphere(Pivot.position, DeadZoneSize);
		}
	}
}
