using Core;
using UnityEngine;

public class SpinWhenAiming : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private Rigidbody rigid;

	[SerializeField]
	private float spinSpeed;

	[SerializeField]
	private Vector3 spinAxis = Vector3.up;

	private bool isSpinning;

	private void Start()
	{
		if (controller == null)
		{
			controller = GetComponent<GolfBallController>();
		}
		if (rigid == null)
		{
			rigid = GetComponent<Rigidbody>();
		}
		if (controller != null)
		{
			controller.OnAimUpdate += OnAimUpdate;
			controller.OnCancel += OnCancel;
			controller.OnShoot += OnShoot;
		}
	}

	private void OnShoot(Vector3 obj)
	{
		isSpinning = false;
	}

	private void OnCancel()
	{
		isSpinning = false;
	}

	private void OnAimUpdate(Vector3 arg1, bool arg2)
	{
		isSpinning = true;
	}

	private void FixedUpdate()
	{
		if (isSpinning && rigid != null)
		{
			rigid.angularVelocity = spinAxis * spinSpeed;
		}
	}
}
