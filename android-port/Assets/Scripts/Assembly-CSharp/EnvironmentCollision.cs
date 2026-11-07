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

	public float ShakeForce;

	public float Shakes;

	public List<ParticleSystem> ShakeParticles;

	public bool Reset;

	private Rigidbody rigidbody;

	private Collider col;

	private Vector3 startPos;

	private Quaternion startRot;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnCollisionEnter(Collision c)
	{
	}

	private void Shake(Collision c)
	{
	}

	private void Break(Collision c)
	{
	}

	private void PlayParticles()
	{
	}
}
