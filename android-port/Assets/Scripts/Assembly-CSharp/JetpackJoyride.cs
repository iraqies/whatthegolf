using System.Collections.Generic;
using Core;
using UnityEngine;

public class JetpackJoyride : GolfBall2DShooterBase
{
	public float UpForce;

	public float MoveSpeed;

	public Animator Animator;

	public float GroundedCheckDistance;

	public LayerMask GroundedLayers;

	public List<ParticleSystem> ShootParticles;

	public AudioSource RunSource;

	private bool boosting;

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	protected override void FixedUpdate()
	{
	base.FixedUpdate();
	}

	private void Update()
	{
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
	}
}
