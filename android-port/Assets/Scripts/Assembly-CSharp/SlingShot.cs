using System.Collections.Generic;
using Core;
using UnityEngine;

public class SlingShot : MonoBehaviour
{
	public List<LineRope> Lines;

	public Transform LineEnds;

	public Transform ObjectInSling;

	public Vector3 LineOffset;

	public GolfBallController Controller;

	public float ReleaseDistance;

	public float SpringStrength;

	public float Damping;

	public Transform ArrowPosition;

	public float ArrowOffset;

	private Vector3 startPos;

	private Rigidbody rigidbody;

	private Rigidbody2D rigidbody2D;

	private bool hasShot;

	private Vector3 velocity;

	private void Start()
	{
	}

	private void ControllerOnOnReset()
	{
	}

	private void ControllerOnOnShoot(Vector3 vector3)
	{
	}

	private void BallController_OnAimUpdate(Vector3 boost, bool arg2)
	{
	}

	private void LateUpdate()
	{
	}
}
