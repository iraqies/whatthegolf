using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilBoss : MonoBehaviour
{
	public Rigidbody ball;

	public bool KickTarget;

	public float KickForce;

	public float kickRange;

	public float speed;

	public float reactDistance;

	public float stopDistance;

	public List<AudioClip> sfxKick;

	public float rotateSpeed;

	public bool lookAlongVelocity;

	public int StrokePenaltiesOnCatch;

	public Animator Animator;

	public float StunDuration;

	public ParticleSystem StunParticles;

	private Vector3 startPosition;

	private Quaternion startRotation;

	private Rigidbody rigid;

	private float nextHit;

	private Collider collider;

	private float waitTime;

	private bool targetIsTouching;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionExit(Collision collision)
	{
	}

	private IEnumerator DoKick(Rigidbody other)
	{
		return null;
	}

	public void Stunned()
	{
	}

	private void FixedUpdate()
	{
	}
}
