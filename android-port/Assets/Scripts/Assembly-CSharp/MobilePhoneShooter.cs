using Core;
using UnityEngine;

public class MobilePhoneShooter : GolfBallShooterExperimental
{
	public float ShakeDuration;

	public float ShakeSpeed;

	public float MoveSpeed;

	public Vector2 RotationAmount;

	public float ShakeDampener;

	public Material CallMaterial;

	public Material IdleMaterial;

	private MeshRenderer renderer;

	private float shakeTimer;

	private Vector3 currentDirection;

	private Quaternion startRot;

	private Quaternion endRot;

	protected override void Awake()
	{
	}

	private new void FixedUpdate()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
