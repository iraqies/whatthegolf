using UnityEngine;

public class BoatSail : OverworldBall2D
{
	public Transform MastPivot;

	public float MastRotateSpeed;

	public Transform SailControl;

	public Vector2 SailRange;

	public float SailSpeedMod;

	public LineRenderer Line;

	public Rigidbody2D Rigid;

	public float BaseSpeed;

	public float MaxSpeed;

	public float BoatRotateSpeed;

	public float sidewaysDrag;

	private Vector3 boatDir;

	private Vector3 dir;

	private float curSpeed;

	private Vector3 currentWindForce;

	private Vector3 baseWindForce;

	private float windDecrease;

	private float sailCurrent;

	protected override void Controller_OnCancel()
	{
	}

	protected override void Shooter_OnShoot(Vector3 dir)
	{
	}

	protected override void Controller_OnAimUpdate(Vector3 dir, bool arg2)
	{
	}

	private void Update()
	{
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}
}
