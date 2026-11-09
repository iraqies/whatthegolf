using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class GiraffeRagdollController : GolfBallShooterBase
{
	public Transform ArrowPositionAfterShot;

	public float Force;

	public float Pitch;

	public Vector2 RandomRange;

	public List<Rigidbody> rigidbodies;

	public Rigidbody[] blacklist;

	public Animator CameraAnimator;

	public PoseMachine Poser;

	public Vector3 FirstShotVelocity;

	private bool firstShot;

	protected override void Awake()
	{
	base.Awake();
	}

	private IEnumerator Start()
	{
		return null;
	}

	public override void OnShoot(Vector3 boost)
	{
	base.OnShoot(boost);
		StandardShoot(boost, Pitch, 5f, (Force > 0f ? Force : 22f), 5f);
	}
}
