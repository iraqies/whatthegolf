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
	private Vector3 spinAxis;

	private bool isSpinning;

	private void Start()
	{
	}

	private void OnShoot(Vector3 obj)
	{
	}

	private void OnCancel()
	{
	}

	private void OnAimUpdate(Vector3 arg1, bool arg2)
	{
	}

	private void FixedUpdate()
	{
	}
}
