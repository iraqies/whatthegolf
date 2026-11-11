using System;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class RussianDollController : GolfBallController
{
	[Serializable]
	public class Controllers
	{
		public GameObject gameObject;

		public GolfBallShooterBase shooter;

		public Collider collider;

		public Rigidbody rb;

		public int hits;
	}

	public Controllers[] controllerList;

	public Transform cameraTransform;

	public CBFollow cbFollow;

	public bool blockIfMoving;

	public float maxVelocitySqr = 5f;

	private Rigidbody movingRB;

	private float shootCooldown = 0.2f;

	private float nextShotTime;

	private List<GolfBallController> golfballControllerList = new List<GolfBallController>();

	private GolfBallShooterBase currentShooter;

	private int shooterIndex;

	private int strokes;

	private int totalStrokes;

	protected override void Start()
	{
		base.Start();
		if (controllerList == null || controllerList.Length == 0)
		{
			return;
		}
		currentShooter = controllerList[0].shooter;
		base.shooter = currentShooter;
		if (base.shooter != null)
		{
			movingRB = base.shooter.GetComponent<Rigidbody>();
		}
		for (int i = 0; i < controllerList.Length; i++)
		{
			if (i != 0 && controllerList[i] != null)
			{
				if (controllerList[i].shooter != null)
				{
					controllerList[i].shooter.enabled = false;
				}
				if (controllerList[i].collider != null)
				{
					controllerList[i].collider.enabled = false;
				}
				if (controllerList[i].rb != null)
				{
					controllerList[i].rb.useGravity = false;
					controllerList[i].rb.velocity = Vector3.zero;
				}
				if (controllerList[i].shooter != null)
				{
					controllerList[i].shooter.enabled = false;
				}
			}
		}
		if (blockIfMoving)
		{
			AddBlockingFunction(BlockIfMoving);
		}
		base.OnShoot += AddStroke;
		base.OnShoot += SwitchControllers;
		if (shooterIndex < controllerList.Length && controllerList[shooterIndex] != null)
		{
			currentShooter = controllerList[shooterIndex].shooter;
			base.shooter = currentShooter;
			if (controllerList[shooterIndex].gameObject != null)
			{
				base.ArrowPosition = controllerList[shooterIndex].gameObject.transform;
			}
			if (controllerList[shooterIndex].shooter != null)
			{
				controllerList[shooterIndex].shooter.enabled = true;
			}
		}
		ActivatePhysics();
	}

	public void CheckOutOfBoundsFromColliders(Collider other)
	{
		if (other != null)
		{
			CheckOutOfBounds(other.tag);
		}
	}

	private void AddStroke(Vector3 unused)
	{
		strokes++;
		totalStrokes++;
		if (blockIfMoving)
		{
			nextShotTime = Time.time + shootCooldown;
		}
	}

	private void SwitchControllers(Vector3 unused)
	{
		if (controllerList == null || shooterIndex + 1 >= controllerList.Length)
		{
			return;
		}
		if (strokes == controllerList[shooterIndex].hits)
		{
			base.shooter = controllerList[shooterIndex + 1].shooter;
		}
		else if (strokes > controllerList[shooterIndex].hits)
		{
			strokes = 0;
			if (currentShooter != null && controllerList[shooterIndex] != null)
			{
				UnityEngine.Object.Destroy(controllerList[shooterIndex].shooter);
			}
			if (shooterIndex == 0)
			{
				IceCubeShatter componentInChildren = GetComponentInChildren<IceCubeShatter>();
				if (componentInChildren != null)
				{
					componentInChildren.Shatter();
				}
			}
			shooterIndex++;
			if (shooterIndex < controllerList.Length && controllerList[shooterIndex] != null)
			{
				currentShooter = controllerList[shooterIndex].shooter;
				base.shooter = currentShooter;
				if (controllerList[shooterIndex].gameObject != null)
				{
					base.ArrowPosition = controllerList[shooterIndex].gameObject.transform;
				}
				if (controllerList[shooterIndex].shooter != null)
				{
					controllerList[shooterIndex].shooter.enabled = true;
				}
			}
			ActivatePhysics();
			if (cbFollow != null)
			{
				cbFollow.elevation += -3f;
			}
		}
		if (shooterIndex >= controllerList.Length)
		{
			return;
		}
		if (shooterIndex + 1 < controllerList.Length && controllerList[shooterIndex + 1] != null && controllerList[shooterIndex + 1].gameObject != null)
		{
			controllerList[shooterIndex + 1].gameObject.layer = LayerMask.NameToLayer("IgnoreGolfBall");
		}
		if (controllerList[shooterIndex] != null)
		{
			if (controllerList[shooterIndex].collider != null)
			{
				controllerList[shooterIndex].collider.enabled = true;
			}
			if (controllerList[shooterIndex].gameObject != null)
			{
				MeshRenderer componentInChildren2 = controllerList[shooterIndex].gameObject.GetComponentInChildren<MeshRenderer>();
				if (componentInChildren2 != null)
				{
					componentInChildren2.enabled = true;
				}
				movingRB = controllerList[shooterIndex].gameObject.GetComponent<Rigidbody>();
			}
			if (controllerList[shooterIndex].rb != null)
			{
				controllerList[shooterIndex].rb.useGravity = true;
			}
		}
	}

	private void ActivatePhysics()
	{
		if (controllerList != null && shooterIndex < controllerList.Length && controllerList[shooterIndex] != null && controllerList[shooterIndex].shooter != null)
		{
			controllerList[shooterIndex].shooter.enabled = true;
		}
	}

	protected override void Update()
	{
		base.Update();
		if (controllerList == null)
		{
			return;
		}
		for (int i = shooterIndex + 1; i < controllerList.Length; i++)
		{
			if (controllerList[i] != null && controllerList[i].gameObject != null && controllerList[i - 1] != null && controllerList[i - 1].gameObject != null)
			{
				controllerList[i].gameObject.transform.position = controllerList[i - 1].gameObject.transform.position;
				controllerList[i].gameObject.transform.rotation = controllerList[i - 1].gameObject.transform.rotation;
			}
		}
		if (currentShooter != null && cameraTransform != null)
		{
			cameraTransform.position = currentShooter.gameObject.transform.position;
		}
	}

	private bool BlockIfMoving()
	{
		if (Time.time < nextShotTime)
		{
			return true;
		}
		if (movingRB != null)
		{
			return movingRB.velocity.sqrMagnitude > maxVelocitySqr;
		}
		return false;
	}
}
