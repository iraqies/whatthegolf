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

	public float ReleaseDistance = 1f;

	public float SpringStrength = 50f;

	public float Damping = 5f;

	public Transform ArrowPosition;

	public float ArrowOffset = 1f;

	private Vector3 startPos;

	private Rigidbody rigidbody;

	private Rigidbody2D rigidbody2D;

	private bool hasShot;

	private Vector3 velocity;

	private void Start()
	{
		if (ObjectInSling != null)
		{
			startPos = ObjectInSling.position;
			rigidbody = ObjectInSling.GetComponent<Rigidbody>();
			if (rigidbody != null)
			{
				rigidbody.isKinematic = true;
			}
			rigidbody2D = ObjectInSling.GetComponent<Rigidbody2D>();
			if (rigidbody2D != null)
			{
				rigidbody2D.isKinematic = true;
			}
		}
		if (Controller != null)
		{
			Controller.OnAimUpdate += BallController_OnAimUpdate;
			Controller.OnShoot += ControllerOnOnShoot;
			Controller.OnReset += ControllerOnOnReset;
		}
	}

	private void ControllerOnOnReset()
	{
		hasShot = false;
	}

	private void ControllerOnOnShoot(Vector3 vector3)
	{
		hasShot = true;
		velocity = Vector3.zero;
		if (Controller != null && Controller.ShootArrow != null)
		{
			Controller.ShootArrow.Hide();
		}
		if (rigidbody != null)
		{
			rigidbody.isKinematic = false;
		}
		if (rigidbody2D != null)
		{
			rigidbody2D.isKinematic = false;
		}
	}

	private void BallController_OnAimUpdate(Vector3 boost, bool arg2)
	{
		if (ObjectInSling != null)
		{
			ObjectInSling.position = startPos - boost * ReleaseDistance;
		}
		if (ArrowPosition != null)
		{
			ArrowPosition.position = startPos + boost * ArrowOffset;
		}
	}

	private void LateUpdate()
	{
		if (LineEnds == null || ObjectInSling == null)
		{
			return;
		}
		if (hasShot)
		{
			Vector3 disp = startPos - LineEnds.position;
			velocity += (disp * SpringStrength - velocity * Damping) * Time.deltaTime;
			LineEnds.position += velocity * Time.deltaTime;
		}
		else
		{
			LineEnds.position = ObjectInSling.position + LineOffset;
		}
	}
}
