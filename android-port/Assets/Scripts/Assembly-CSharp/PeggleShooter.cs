using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class PeggleShooter : GolfBall2DShooterBase
{
	public Rigidbody2D Ball;

	public Transform BallSpawnPoint;

	public float ShootForce = 10f;

	public Transform BobContainer;

	public AudioSource HitSource;

	public List<AudioClip> ShootClips;

	private List<PeggleBob> bobs;

	private float startPitch;

	private void Start()
	{
		if (HitSource != null)
			startPitch = HitSource.pitch;
		if (BobContainer != null)
			bobs = BobContainer.GetComponentsInChildren<PeggleBob>().ToList();
	}

	private void Update()
	{
		if (Ball == null || !Ball.gameObject.activeSelf)
			return;
		if (Ball.transform.position.y < -22f)
		{
			Ball.gameObject.SetActive(false);
			if (GolfBallController != null)
				GolfBallController.enabled = true;
			if (bobs != null)
			{
				for (int i = bobs.Count - 1; i >= 0; i--)
				{
					if (bobs[i] != null && bobs[i].HasBeenHit)
					{
						bobs[i].Remove();
						bobs.Remove(bobs[i]);
					}
				}
			}
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (Ball == null || Ball.gameObject.activeSelf)
			return;
		bool invert = true;
		if (GolfBallController != null && !onlyAimArrow)
		{
			if (!GolfBallController.GetPlayerButton(true, "Shoot"))
			{
				invert = GolfBallController.GetPlayerButtonUp(true, "Shoot");
			}
		}
		float x = invert ? (-boost.x) : boost.x;
		if (Mathf.Abs(boost.x) < 0.9f)
		{
			transform.up = new Vector3(x, 1f, 0f);
		}
		if (GolfBallController != null)
		{
			GolfBallController.FlipAim = !invert;
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (Ball == null || Ball.gameObject.activeSelf)
			return;
		if (AudioManager.Instance != null && AudioManager.Instance.shortEffects != null && ShootClips != null)
		{
			AudioManager.Instance.shortEffects.Play(ShootClips);
		}
		if (HitSource != null)
			HitSource.pitch = startPitch;
		Ball.gameObject.SetActive(true);
		if (BallSpawnPoint != null)
			Ball.transform.position = BallSpawnPoint.position;
		Vector3 up = transform.up;
		Ball.velocity = new Vector2(-up.x * ShootForce, -up.y * ShootForce);
		if (GolfBallController != null)
		{
			GolfBallController.enabled = false;
			if (GolfBallController.shootArrow != null)
				GolfBallController.shootArrow.Hide();
		}
	}
}
