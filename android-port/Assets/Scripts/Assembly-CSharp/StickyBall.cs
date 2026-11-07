using System;
using Core;
using UnityEngine;

public class StickyBall : MonoBehaviour
{
	public float Stickiness;

	public bool UseFixedJoint;

	public ParticleSystem Particles;

	public int ParticlesToEmit;

	public float StickDelay;

	public LayerMask BlacklistLayerMask;

	public Action<Vector3> OnStuck;

	public Action OnUnStuck;

	private GolfBallController ball;

	private Rigidbody2D rigid2D;

	private Rigidbody rigid;

	private bool isStuck;

	private ConstantForce force;

	private ConstantForce2D force2D;

	private Vector3 startForce;

	private FixedJoint currentJoint;

	private FixedJoint2D currentJoint2D;

	private float stickDelay;

	private bool attachedToRigidbody;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Ball_OnPreShoot(Vector3 obj)
	{
	}

	private void FixedUpdate()
	{
	}

	private void Unstuck()
	{
	}

	private void Stuck(Vector3 normal)
	{
	}

	private void OnCollisionEnter(Collision collision)
	{
	}

	private void OnCollisionStay(Collision other)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private void OnCollisionStay2D(Collision2D other)
	{
	}
}
