using System;
using Core;
using UnityEngine;

public class WhackHammerController : GolfBallShooterBase
{
	[SerializeField]
	private Animator hammerAnimator;

	[SerializeField]
	private float moveSpeed = 1f;

	[SerializeField]
	private float rotateSpeed = 10f;

	[SerializeField]
	private float blockTime = 0.5f;

	public Action<float> OnHit;

	private float blockTimer;

	private Rigidbody rigid;

	private float lastShootVelMag;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
	}

	private void Update()
	{
		if (blockTimer > 0f)
		{
			blockTimer -= Time.deltaTime;
		}
	}

	public override void OnAimStart()
	{
		if (blockTimer <= 0f && hammerAnimator != null)
		{
			hammerAnimator.SetBool("Charging", true);
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (blockTimer <= 0f && rigid != null)
		{
			Quaternion to = Quaternion.LookRotation(boost.normalized);
			rigid.MoveRotation(Quaternion.RotateTowards(rigid.rotation, to, Time.deltaTime * rotateSpeed));
			rigid.MovePosition(rigid.position + boost * Time.deltaTime * moveSpeed);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (hammerAnimator != null)
		{
			hammerAnimator.SetBool("Charging", false);
		}
		if (GolfBallController != null)
		{
			GolfBallController.TimedBlockShot(blockTime);
		}
		blockTimer = blockTime;
		lastShootVelMag = boost.magnitude;
	}

	public void HitSomething()
	{
		OnHit?.Invoke(lastShootVelMag);
	}
}
