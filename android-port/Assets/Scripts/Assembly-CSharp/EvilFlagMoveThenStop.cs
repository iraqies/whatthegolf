using Core;
using UnityEngine;

public class EvilFlagMoveThenStop : MonoBehaviour
{
	public Transform otherPosition;

	public float velocity;

	public GolfBallController ball;

	private Vector3 startPos;

	private Rigidbody rigidbody;

	private int currentStep;

	private Vector3 currentTarget;

	private bool isMoving;

	private void Awake()
	{
	}

	private void Ball_OnShoot(Vector3 aim)
	{
	}

	private void FixedUpdate()
	{
	}
}
