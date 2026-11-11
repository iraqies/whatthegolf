using System.Collections.Generic;
using UnityEngine;

public class EnvironmentCollision : MonoBehaviour
{
	public bool CanBreak;

	public float ForceRequiredToBreak;

	public float BreakForce;

	public List<Collider> ThingsToUnparent;

	public bool CanShake;

	public float ShakeDuration;

	public float ShakeForce = 1f;

	public float Shakes = 1f;

	public List<ParticleSystem> ShakeParticles;

	public bool Reset;

	private Rigidbody rigidbody;

	private Collider col;

	private Vector3 startPos;

	private Quaternion startRot;

	private void Start()
	{
		startPos = transform.position;
		startRot = transform.rotation;
		rigidbody = GetComponent<Rigidbody>();
		col = GetComponent<Collider>();
		if (ThingsToUnparent != null && col != null)
		{
			for (int i = 0; i < ThingsToUnparent.Count; i++)
			{
				if (ThingsToUnparent[i] != null)
				{
					Physics.IgnoreCollision(ThingsToUnparent[i], col, true);
				}
			}
		}
	}

	private void Update()
	{
		if (Reset)
		{
			transform.position = startPos;
			transform.rotation = startRot;
			if (rigidbody != null)
			{
				rigidbody.isKinematic = true;
			}
			Reset = false;
		}
	}

	private void OnCollisionEnter(Collision c)
	{
		if (c == null) return;
		Vector3 force = Time.fixedDeltaTime > 0f ? (c.impulse / Time.fixedDeltaTime) : c.impulse;
		if (CanBreak && force.magnitude >= ForceRequiredToBreak)
		{
			PlayParticles();
			Break(c);
		}
		else if (CanShake)
		{
			Shake(c);
		}
	}

	private void Shake(Collision c)
	{
		if (c == null) return;
		PlayParticles();
		Vector3 dir = Quaternion.Euler(0f, 90f, 0f) * (-c.impulse.normalized);
		StartCoroutine(pTween.To(ShakeDuration, t =>
		{
			Vector3 euler = startRot.eulerAngles;
			Quaternion target = Quaternion.Euler(euler.x + dir.x * ShakeForce, euler.y, euler.z + dir.z * ShakeForce);
			transform.rotation = Quaternion.Lerp(startRot, target, TweenFunctions.punch(1f, t));
		}));
	}

	private void Break(Collision c)
	{
		if (ThingsToUnparent != null)
		{
			for (int i = 0; i < ThingsToUnparent.Count; i++)
			{
				if (ThingsToUnparent[i] != null)
				{
					ThingsToUnparent[i].transform.SetParent(null);
				}
			}
		}
		if (rigidbody != null)
		{
			rigidbody.isKinematic = false;
			if (c != null)
			{
				rigidbody.AddForce(-c.impulse * BreakForce);
			}
		}
	}

	private void PlayParticles()
	{
		if (ShakeParticles == null) return;
		for (int i = 0; i < ShakeParticles.Count; i++)
		{
			if (ShakeParticles[i] != null)
			{
				ShakeParticles[i].Emit(20);
			}
		}
	}
}
