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

	public float maxVelocitySqr;

	private Rigidbody movingRB;

	private float shootCooldown;

	private float nextShotTime;

	private List<GolfBallController> golfballControllerList;

	private GolfBallShooterBase currentShooter;

	private int shooterIndex;

	private int strokes;

	private int totalStrokes;

	protected override void Start()
	{
	}

	public void CheckOutOfBoundsFromColliders(Collider other)
	{
	}

	private void AddStroke(Vector3 unused)
	{
	}

	private void SwitchControllers(Vector3 unused)
	{
	}

	private void ActivatePhysics()
	{
	}

	protected override void Update()
	{
	}

	private bool BlockIfMoving()
	{
		return false;
	}
}
