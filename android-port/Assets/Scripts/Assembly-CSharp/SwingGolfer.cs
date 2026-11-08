using System;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class SwingGolfer : GolfBallShooterBase
{
	[Serializable]
	public class SwingData
	{
		public Transform Swing;

		public Transform SwingPivot;

		public Transform SwingTarget;

		public Transform SwingSeat;

		public Rigidbody SwingRigidbody;
	}

	public List<SwingData> Swings;

	public Vector2 AngleRange;

	public RagdollOnSwing KidOnSwing;

	public float FullVelocity;

	public float KidForce;

	public float SwingPullBackForce;

	public List<GameObject> Kids;

	public float SuccessDistanceToSwing;

	private bool hasShot;

	private float releaseAngle;

	private CBFollow followCam;

	private Vector3 shotDirection;

	private List<GameObject> kidsInQueue;

	private List<Vector3> kidPositions;

	private int currentSwing;

	private GameObject cameraFollow;

	private void Start()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	StandardShoot(boost, 20f, 18f, 5f);
	}

	private void Update()
	{
	}

	private void KidHitGround(GameObject currentKid)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
