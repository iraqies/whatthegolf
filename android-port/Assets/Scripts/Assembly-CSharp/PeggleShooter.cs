using System.Collections.Generic;
using Core;
using UnityEngine;

public class PeggleShooter : GolfBall2DShooterBase
{
	public Rigidbody2D Ball;

	public Transform BallSpawnPoint;

	public float ShootForce;

	public Transform BobContainer;

	public AudioSource HitSource;

	public List<AudioClip> ShootClips;

	private List<PeggleBob> bobs;

	private float startPitch;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
