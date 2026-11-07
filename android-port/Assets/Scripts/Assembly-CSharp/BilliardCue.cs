using Core;
using UnityEngine;

public class BilliardCue : MonoBehaviour
{
	public GolfBallController Controller;

	public float MoveSpeed;

	public float RotationSpeed;

	public float ShootDistance;

	public float ShootSpeed;

	private Rigidbody rigid;

	private float shootTimer;

	private Vector3 startShootPoint;

	private Rigidbody ballRigid;

	private void Start()
	{
	}

	private void OnCancel()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnShoot(Vector3 vector3)
	{
	}

	private void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
	}
}
