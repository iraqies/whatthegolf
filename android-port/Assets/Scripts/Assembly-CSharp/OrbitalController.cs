using Core;
using UnityEngine;

public class OrbitalController : GolfBallShooterBase
{
	public Transform OrbitCenter;

	public float HeightFromCenter;

	public float MoveSpeed;

	public float RotateSpeed;

	public float Gravity;

	private Rigidbody rigid;

	private Vector3 aimDir;

	private void Start()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	protected override void FixedUpdate()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
