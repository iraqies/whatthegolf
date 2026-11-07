using Core;
using UnityEngine;

public class ChangeRotateAxisOnShot : MonoBehaviour
{
	public float speed;

	public RotateAxis rotateAxis;

	public RotateAxis2D rotateAxis2D;

	public GolfBallController controller;

	private void Awake()
	{
	}

	private void Controller_OnShoot(Vector3 obj)
	{
	}
}
