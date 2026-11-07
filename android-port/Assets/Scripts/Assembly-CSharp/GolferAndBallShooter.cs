using System.Collections;
using Core;
using UnityEngine;

public class GolferAndBallShooter : GolfBallShooterBase
{
	[SerializeField]
	private Rigidbody ball;

	[SerializeField]
	private Rigidbody golfer;

	[SerializeField]
	private float fullVelocity;

	[SerializeField]
	private float fullPitch;

	[SerializeField]
	private float fullSpin;

	[SerializeField]
	private float golferRunSpeed;

	private bool hasBall;

	private Animator golfAnimator;

	private bool isShooting;

	private Vector3 ballOffset;

	private NearestVertGravity ballGravity;

	protected override void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		return null;
	}

	private Vector3 PitchBoost(Vector3 boost)
	{
		return default;
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
