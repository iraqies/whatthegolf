using System;
using System.Collections;
using Audio;
using Core;
using Effects;
using UnityEngine;

public class BeachBallWithAvatarController : GolfBallController
{
	[Header("Balloon Specific")]
	public float MaxShots = 5f;

	public float ExplosionDelay = 0.7f;

	public float SizeIncrementPerShot = 0.05f;

	public Vector3 BallPopSpawnPieceRandomForceRange = new Vector3(5f, 5f, 0f);

	public float AutoCompleteMaxSpeed;

	[Header("Internal Settings")]
	[SerializeField]
	private Transform balloonParentObject;

	[SerializeField]
	private Transform balloonScaleObject;

	[SerializeField]
	private BalloonPopPieces balloonPiecesObject;

	[SerializeField]
	private ParticleSystem airTrailParticles;

	[SerializeField]
	private ExplosionEffect explosionParticlesPrefab;

	[SerializeField]
	private ClipSettingsCollection balloonAirTrailClip;

	[SerializeField]
	private ClipSettingsCollection balloonExplodeClip;

	[SerializeField]
	private ClipSettingsCollection balloonInflateClip;

	private AudioSource airTrailAudioSource;

	private float shotsCounter;

	private bool hasPopped;

	private bool explosionTriggered;

	public override void ResetGolfBall()
	{
		base.ResetGolfBall();
		shotsCounter = 0f;
		hasPopped = false;
		explosionTriggered = false;
		if (balloonParentObject != null)
		{
			balloonParentObject.gameObject.SetActive(true);
		}
		if (balloonPiecesObject != null)
		{
			balloonPiecesObject.gameObject.SetActive(false);
		}
		if (balloonScaleObject != null)
		{
			balloonScaleObject.localScale = Vector3.one;
		}
		Rigidbody component = GetComponent<Rigidbody>();
		if (component != null)
		{
			component.constraints = (RigidbodyConstraints)56;
		}
	}

	public override bool CanShoot(Vector3 pos, bool ignoreLayerMask)
	{
		if (!hasPopped)
		{
			return base.CanShoot(pos, ignoreLayerMask);
		}
		return false;
	}

	public override void Shoot(Vector3 force, float charge = 1f)
	{
		shotsCounter += 1f;
		if (shotsCounter < MaxShots)
		{
			base.Shoot(force, charge);
			if (balloonScaleObject != null)
			{
				balloonScaleObject.localScale += Vector3.one * SizeIncrementPerShot;
			}
			if (airTrailParticles != null)
			{
				airTrailParticles.Play();
			}
			if (balloonAirTrailClip != null)
			{
				airTrailAudioSource = balloonAirTrailClip.Play(null, base.transform.position, 1f, 1f);
			}
			return;
		}
		hasPopped = true;
		Invoke("Explode", ExplosionDelay);
		float num = Math.Min(force.magnitude, 25f);
		if (balloonScaleObject != null)
		{
			balloonScaleObject.localScale += Vector3.one * (SizeIncrementPerShot * num * 0.1f);
		}
		StartCoroutine(BallInflationSoundRoutine());
	}

	protected override void DoneMoving()
	{
		base.DoneMoving();
		if (airTrailParticles != null)
		{
			airTrailParticles.Stop();
		}
		if (airTrailAudioSource != null)
		{
			airTrailAudioSource.Stop();
		}
	}

	protected override void OnCollisionEnter(Collision collision)
	{
		base.OnCollisionEnter(collision);
		if (collision != null && collision.collider != null && collision.collider.CompareTag("Obstacle"))
		{
			Explode();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.CompareTag("Obstacle"))
		{
			Explode();
		}
	}

	private void Explode()
	{
		if (explosionTriggered)
		{
			return;
		}
		explosionTriggered = true;
		if (balloonParentObject != null)
		{
			balloonParentObject.gameObject.SetActive(false);
		}
		if (balloonPiecesObject != null)
		{
			balloonPiecesObject.gameObject.SetActive(true);
			balloonPiecesObject.ExplodePieces(BallPopSpawnPieceRandomForceRange);
		}
		if (explosionParticlesPrefab != null)
		{
			ExplosionEffect explosionEffect = UnityEngine.Object.Instantiate(explosionParticlesPrefab, base.transform.position, Quaternion.identity);
			if (explosionEffect != null)
			{
				explosionEffect.Explode();
			}
		}
		if (airTrailParticles != null)
		{
			airTrailParticles.Stop();
		}
		if (airTrailAudioSource != null)
		{
			airTrailAudioSource.Stop();
		}
		if (balloonExplodeClip != null)
		{
			balloonExplodeClip.Play(null, base.transform.position, 1f, 1f);
		}
		DoneMoving();
		Rigidbody component = GetComponent<Rigidbody>();
		if (component != null)
		{
			component.constraints = RigidbodyConstraints.FreezeAll;
		}
		StartCoroutine(RemoveExplosionLock());
	}

	private IEnumerator BallInflationSoundRoutine()
	{
		yield return new WaitForSecondsRealtime(0.02f);
		if (balloonInflateClip != null)
		{
			balloonInflateClip.Play(null, base.transform.position, 1f, 1f);
		}
	}

	private IEnumerator RemoveExplosionLock()
	{
		yield return new WaitForSecondsRealtime(1f);
		explosionTriggered = false;
	}
}
