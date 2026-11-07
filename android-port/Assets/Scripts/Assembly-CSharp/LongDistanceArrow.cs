using Core;
using UnityEngine;

public class LongDistanceArrow : MonoBehaviour
{
	public ArrowShooter2D shooter;

	private Arrow2D target;

	private GolfBallController controller;

	private Vector3 tmpVel;

	private float resetTimer;

	private bool isResetting;

	private void Start()
	{
	}

	private void Shooter_OnShootArrow(Arrow2D newArrow)
	{
	}

	private void FixedUpdate()
	{
	}
}
