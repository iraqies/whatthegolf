using Core;
using UnityEngine;

public class SimpleSpiderShooter : ShooterBase
{
	[SerializeField]
	private Rigidbody hook;

	[SerializeField]
	private Rigidbody arm;

	[SerializeField]
	private LayerMask HitLayer;

	[SerializeField]
	private float HookSpeed;

	[SerializeField]
	private float boostY;

	[SerializeField]
	private float HookForwardMovement;

	private bool HasHit;

	private bool HasShot;

	[SerializeField]
	private float HitDotResult;

	[SerializeField]
	private float ExtraUpwardsPullForce;

	[SerializeField]
	private float realInSpeed;

	[SerializeField]
	private float minDistance;

	public override void OnAimStart()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

	protected void FixedUpdate()
	{
	}
}
