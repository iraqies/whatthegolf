using System;
using UnityEngine;

public class Arrow2D : MonoBehaviour
{
	public Collider2D Collider;

	public Rigidbody2D Rigidbody;

	public Action OnHitGoal;

	public Action OnMissGoal;

	public LayerMask HitLayers = int.MaxValue;

	public Action OnReset;

	public bool CanWin = true;

	public bool Initialized;

	public bool stuck;

	private RotateWithVelocity2D rotator;

	private void OnEnable()
	{
		rotator = GetComponent<RotateWithVelocity2D>();
		if (rotator != null)
		{
			rotator.enabled = true;
		}
		stuck = false;
		if (Rigidbody != null)
		{
			Rigidbody.velocity = Vector2.zero;
			Rigidbody.angularVelocity = 0f;
		}
		Joint2D joint = GetComponent<Joint2D>();
		if (joint != null)
		{
			UnityEngine.Object.Destroy(joint);
		}
	}

	private void HitSomething(Collider2D hit)
	{
		if (stuck || hit == null || hit.gameObject == null)
			return;

		int mask = HitLayers;
		if ((mask | (1 << hit.gameObject.layer)) != mask)
			return;

		stuck = true;
		if (rotator != null)
		{
			rotator.enabled = false;
		}
		if (hit.attachedRigidbody != null)
		{
			FixedJoint2D joint = base.gameObject.AddComponent<FixedJoint2D>();
			if (joint != null)
			{
				joint.connectedBody = hit.attachedRigidbody;
			}
			Vector3 right = base.transform.right;
			Vector3 pos = base.transform.position;
			hit.attachedRigidbody.AddForceAtPosition(new Vector2(right.x * 20f, right.y * 20f), new Vector2(pos.x, pos.y), ForceMode2D.Impulse);
		}
		else if (Rigidbody != null)
		{
			Rigidbody.isKinematic = true;
		}

		if (CanWin && hit.gameObject.GetComponent<GolfGoal>() != null)
		{
			OnHitGoal?.Invoke();
			return;
		}

		if (Rigidbody != null)
		{
			Rigidbody.velocity = Vector2.zero;
			Rigidbody.angularVelocity = 0f;
		}
		OnMissGoal?.Invoke();
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col != null)
		{
			HitSomething(col.collider);
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null)
			return;

		if (other.CompareTag("Killzone"))
		{
			OnReset?.Invoke();
			return;
		}
		if (!other.isTrigger)
		{
			HitSomething(other);
		}
	}

	public void EnteredPortal(PortalPackage package)
	{
		if (!stuck)
			return;

		if (rotator != null)
		{
			rotator.enabled = true;
		}
		stuck = false;
		if (package != null && package.otherPortal != null)
		{
			base.transform.rotation = Quaternion.LookRotation(package.otherPortal.transform.forward);
		}
		if (Rigidbody != null)
		{
			Vector3 fwd = base.transform.forward;
			float speed = UnityEngine.Random.Range(10f, 20f);
			Rigidbody.velocity = new Vector2(fwd.x * speed, fwd.y * speed);
			Rigidbody.angularVelocity = 0f;
			Rigidbody.isKinematic = false;
		}
		Joint2D joint = GetComponent<Joint2D>();
		if (joint != null)
		{
			UnityEngine.Object.Destroy(joint);
		}
	}
}
