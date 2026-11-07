using System.Collections.Generic;
using UnityEngine;

public class GolfBall2D : MonoBehaviour
{
	private GolfBall2DSurface surface;

	private List<GolfBall2DSurface> surfaces;

	private Rigidbody2D rigidbody2D;

	private float radius;

	private float alignedWithGroundAngleMax;

	private float angularVelocityFrictionLimit;

	private float sleepTolerance;

	private void Awake()
	{
	}

	private void FixedUpdate()
	{
	}

	private void RefeshActiveSurface()
	{
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
	}
}
