using System;
using Audio;
using UnityEngine;

public class Spit2D : MonoBehaviour
{
	public Collider2D Collider;

	public Rigidbody2D Rigidbody;

	public Action OnHitGoal;

	public Action OnMissGoal;

	public LayerMask HitLayers = ~0;

	public Action OnReset;

	public ParticleSystem particleSystem;

	public RandomAudioClips hitclips;

	public Renderer MainSpitRenderer;

	public bool Initialized;

	private bool stuck;

	private void OnEnable()
	{
		stuck = false;
		if (Rigidbody != null)
		{
			Rigidbody.velocity = Vector2.zero;
			Rigidbody.angularVelocity = 0f;
		}
		Joint2D joint = GetComponent<Joint2D>();
		if (joint != null)
		{
			Destroy(joint);
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
		if (hit.attachedRigidbody != null)
		{
			FixedJoint2D joint = gameObject.AddComponent<FixedJoint2D>();
			if (joint != null)
				joint.connectedBody = hit.attachedRigidbody;
		}
		else if (Rigidbody != null)
		{
			Rigidbody.isKinematic = true;
		}

		if (hit.gameObject.GetComponent<GolfGoal>() != null)
		{
			OnHitGoal?.Invoke();
			if (hitclips != null)
				hitclips.PlayRandomClip(transform.position);
			if (particleSystem != null)
				particleSystem.Emit(10);
			if (MainSpitRenderer != null)
				MainSpitRenderer.enabled = false;
			Destroy(gameObject, 3f);
		}
		else
		{
			if (Rigidbody != null)
			{
				Rigidbody.velocity = Vector2.zero;
				Rigidbody.angularVelocity = 0f;
			}
			OnMissGoal?.Invoke();
			if (hitclips != null)
				hitclips.PlayRandomClip(transform.position);
			if (particleSystem != null)
				particleSystem.Emit(10);
			if (MainSpitRenderer != null)
				MainSpitRenderer.enabled = false;
			Destroy(gameObject, 3f);
		}
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
		if (col != null)
			HitSomething(col.collider);
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
		stuck = false;
		if (package != null && package.otherPortal != null)
		{
			transform.rotation = Quaternion.LookRotation(package.otherPortal.transform.forward);
		}
		if (Rigidbody != null)
		{
			Vector3 fwd = transform.forward;
			float speed = UnityEngine.Random.Range(10f, 20f);
			Rigidbody.velocity = new Vector2(fwd.x * speed, fwd.y * speed);
			Rigidbody.angularVelocity = 0f;
			Rigidbody.isKinematic = false;
		}
		Joint2D joint = GetComponent<Joint2D>();
		if (joint != null)
		{
			Destroy(joint);
		}
	}
}
