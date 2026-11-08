using System.Collections;
using Core;
using UnityEngine;

public class ForkShooter : GolfBallShooterBase
{
	[SerializeField]
	public float minShootVelocity;

	[SerializeField]
	public float fullShootVelocity;

	[SerializeField]
	public float pitch;

	[SerializeField]
	public float spin;

	[SerializeField]
	protected bool lookInShotDirection;

	public bool lookInAimDirection;

	[SerializeField]
	protected bool onlyLookWhenChargingOnController;

	public float LookInAimDirectionSpeed;

	[SerializeField]
	protected bool dontLookInAimDirectionWhenBlocked;

	[SerializeField]
	protected bool useLocalUp;

	[SerializeField]
	public bool zeroPitchIfNotGrouneded;

	[SerializeField]
	private float depthOfStabbing;

	[SerializeField]
	private float SecondsBeforeSticking;

	private Coroutine stickCooldown;

	private FixedJoint stickJoint;

	private Rigidbody collisionRb;

	private bool isAiming;

	private bool canStick;

	private void Start()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	private void Update()
	{
	}

	public override void OnCancel()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	private void OnCollisionStay(Collision collision)
	{
	}

	private IEnumerator StickCooldownRoutine(Vector3 shootDir)
	{
		return null;
	}
}
