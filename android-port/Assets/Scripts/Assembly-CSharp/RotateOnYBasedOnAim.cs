using Core;
using UnityEngine;

public class RotateOnYBasedOnAim : MonoBehaviour
{
	public float angle;

	public float angleDown;

	public float randomMin;

	public float randomMax;

	public float amplitude;

	public float speed;

	public Rigidbody r;

	public GolfBallController controller;

	public Vector3 axis;

	private float time;

	private Vector3 lastAim;

	private void Start()
	{
	}

	private void OnAimUpdate(Vector3 boost, bool a)
	{
	}
}
