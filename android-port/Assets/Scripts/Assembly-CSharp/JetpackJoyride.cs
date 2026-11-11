using System.Collections.Generic;
using Core;
using UnityEngine;

public class JetpackJoyride : GolfBall2DShooterBase
{
	public float UpForce = 30f;

	public float MoveSpeed = 10f;

	public Animator Animator;

	public float GroundedCheckDistance = 1f;

	public LayerMask GroundedLayers;

	public List<ParticleSystem> ShootParticles;

	public AudioSource RunSource;

	private bool boosting;

	public override void OnAimStart()
	{
		base.OnAimStart();
		boosting = true;
		if (ShootParticles != null)
		{
			for (int i = 0; i < ShootParticles.Count; i++)
			{
				if (ShootParticles[i] != null)
				{
					ShootParticles[i].Play();
				}
			}
		}
		if (RunSource != null)
		{
			RunSource.Stop();
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		base.OnAimUpdate(boost, onlyAimArrow);
	}

	public override void OnCancel()
	{
		base.OnCancel();
		boosting = false;
		if (ShootParticles == null)
		{
			return;
		}
		for (int i = 0; i < ShootParticles.Count; i++)
		{
			if (ShootParticles[i] != null)
			{
				ShootParticles[i].Stop();
			}
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		boosting = false;
		if (ShootParticles == null)
		{
			return;
		}
		for (int i = 0; i < ShootParticles.Count; i++)
		{
			if (ShootParticles[i] != null)
			{
				ShootParticles[i].Stop();
			}
		}
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
		if (rigidbodyC != null)
		{
			if (boosting)
			{
				rigidbodyC.AddForce(Vector2.up * UpForce * Time.fixedDeltaTime, ForceMode2D.Force);
			}
			rigidbodyC.velocity = new Vector2(MoveSpeed * Time.fixedDeltaTime, rigidbodyC.velocity.y);
		}
	}

	private void Update()
	{
		RaycastHit2D raycastHit2D = Physics2D.Raycast(base.transform.position, Vector2.down, GroundedCheckDistance, GroundedLayers);
		bool flag = raycastHit2D.collider != null;
		if (Animator != null)
		{
			Animator.SetBool("Grounded", flag);
		}
		if (RunSource != null && !RunSource.isPlaying && flag)
		{
			RunSource.Play();
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other != null && other.gameObject.layer == LayerMask.NameToLayer("Enemy") && GolfBallController != null)
		{
			GolfBallController.OutOfBounds("Enemy", 0.4f);
		}
	}
}
