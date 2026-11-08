using System;
using Core;
using UnityEngine;

public class WhackHammerController : GolfBallShooterBase
{
	[SerializeField]
	private Animator hammerAnimator;

	[SerializeField]
	private float moveSpeed;

	[SerializeField]
	private float rotateSpeed;

	[SerializeField]
	private float blockTime;

	public Action<float> OnHit;

	private float blockTimer;

	private Rigidbody rigid;

	private float lastShootVelMag;

	private void Start()
	{
	}

	private void Update()
	{
	}

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	public void HitSomething()
	{
	}
}
