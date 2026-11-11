using Core;
using UnityEngine;

public class BilliardCue : MonoBehaviour
{
	public GolfBallController Controller;

	public float MoveSpeed = 100f;

	public float RotationSpeed = 100f;

	public float ShootDistance = 1f;

	public float ShootSpeed = 10f;

	private Rigidbody rigid;

	private float shootTimer;

	private Vector3 startShootPoint;

	private Rigidbody ballRigid;

	private void Start()
	{
		rigid = GetComponent<Rigidbody>();
		if (Controller != null)
		{
			Controller.OnAimUpdate += OnAimUpdate;
			Controller.OnShoot += OnShoot;
			Controller.OnCancel += OnCancel;
			ballRigid = Controller.gameObject.GetComponent<Rigidbody>();
		}
	}

	private void OnCancel()
	{
		if (ballRigid != null)
		{
			ballRigid.isKinematic = false;
		}
	}

	private void FixedUpdate()
	{
		if (shootTimer > 0f && rigid != null)
		{
			Vector3 b = startShootPoint + base.transform.forward * ShootDistance;
			float t = Mathf.Clamp01(1f - shootTimer);
			rigid.MovePosition(Vector3.Lerp(startShootPoint, b, t));
			shootTimer -= Time.deltaTime * ShootSpeed;
		}
	}

	private void OnShoot(Vector3 vector3)
	{
		shootTimer = 1f;
		startShootPoint = base.transform.position;
		if (ballRigid != null)
		{
			ballRigid.isKinematic = false;
		}
	}

	private void OnAimUpdate(Vector3 dir, bool onlyAimArrow)
	{
		if (onlyAimArrow)
		{
			return;
		}
		shootTimer = 0f;
		if (rigid != null && Controller != null)
		{
			rigid.MovePosition(Vector3.MoveTowards(rigid.position, Controller.transform.position, Time.deltaTime * MoveSpeed));
			if (dir.sqrMagnitude > 0.0001f)
			{
				Quaternion to = Quaternion.LookRotation(dir, Vector3.up);
				rigid.MoveRotation(Quaternion.RotateTowards(rigid.rotation, to, Time.deltaTime * RotationSpeed));
			}
		}
		if (ballRigid != null)
		{
			ballRigid.isKinematic = true;
		}
	}
}
