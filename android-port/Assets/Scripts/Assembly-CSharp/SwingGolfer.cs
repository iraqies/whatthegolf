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

	public Vector2 AngleRange = new Vector2(-45f, 45f);

	public RagdollOnSwing KidOnSwing;

	public float FullVelocity = 25f;

	public float KidForce = 20f;

	public float SwingPullBackForce = 30f;

	public List<GameObject> Kids;

	public float SuccessDistanceToSwing = 3f;

	private bool hasShot;

	private float releaseAngle;

	private CBFollow followCam;

	private Vector3 shotDirection;

	private List<GameObject> kidsInQueue = new List<GameObject>();

	private List<Vector3> kidPositions = new List<Vector3>();

	private int currentSwing;

	private GameObject cameraFollow;

	private void Start()
	{
		cameraFollow = new GameObject("SwingCameraFollow");
		if (CameraManager.Instance != null)
		{
			followCam = CameraManager.Instance.gameObject.GetComponent<CBFollow>();
		}
		kidsInQueue = new List<GameObject>();
		kidPositions = new List<Vector3>();
		if (Swings != null && Swings.Count > 0 && Swings[0] != null)
		{
			rigidbodyC = Swings[0].SwingRigidbody;
		}
		if (Kids != null)
		{
			for (int i = 0; i < Kids.Count; i++)
			{
				if (Kids[i] != null)
				{
					kidsInQueue.Add(Kids[i]);
					kidPositions.Add(Kids[i].transform.position);
				}
			}
		}
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
		if (GolfBallController != null && GolfBallController.BlockShooting)
		{
			return;
		}
		if (Swings == null || currentSwing >= Swings.Count || Swings[currentSwing] == null)
		{
			return;
		}
		SwingData sd = Swings[currentSwing];
		if (sd.SwingPivot != null)
		{
			float angle = Mathf.LerpAngle(AngleRange.x, AngleRange.y, boost.magnitude);
			sd.SwingPivot.rotation = Quaternion.Euler(0f, angle, 0f);
		}
		if (sd.SwingRigidbody != null && sd.SwingTarget != null)
		{
			Vector3 pullDir = (sd.SwingTarget.position - sd.SwingRigidbody.transform.position).normalized;
			sd.SwingRigidbody.AddForce(pullDir * SwingPullBackForce);
		}
	}

	public override void OnShoot(Vector3 boost)
	{
		if (GolfBallController != null && GolfBallController.BlockShooting)
		{
			return;
		}
		if (Swings != null && currentSwing < Swings.Count && Swings[currentSwing] != null && Swings[currentSwing].SwingPivot != null)
		{
			Swings[currentSwing].SwingPivot.rotation = Quaternion.identity;
			releaseAngle = Vector3.SignedAngle(Swings[currentSwing].SwingPivot.up, transform.up, transform.right);
		}
		base.OnShoot(boost);
		StandardShoot(transform.TransformVector(boost), 15f, 5f, FullVelocity > 0f ? FullVelocity : 22f, 5f);
		shotDirection = boost;
		hasShot = true;
		if (GolfBallController != null)
		{
			GolfBallController.BlockShooting = true;
		}
	}

	private void Update()
	{
		if (!hasShot || Swings == null || currentSwing >= Swings.Count || Swings[currentSwing] == null)
		{
			return;
		}
		SwingData sd = Swings[currentSwing];
		float curAngle = sd.SwingPivot != null ? Vector3.SignedAngle(sd.SwingPivot.up, transform.up, transform.right) : 0f;
		if (Mathf.Abs(curAngle - releaseAngle) > 10f || KidOnSwing != null)
		{
			if (KidOnSwing != null)
			{
				KidOnSwing.LaunchKid(shotDirection, KidHitGround);
				if (followCam != null && KidOnSwing.RootBone != null)
				{
					followCam.FollowTarget = KidOnSwing.RootBone;
				}
			}
			hasShot = false;
		}
	}

	private void KidHitGround(GameObject currentKid)
	{
		if (GolfBallController != null)
		{
			GolfBallController.BlockShooting = false;
		}
		if (followCam != null)
		{
			followCam.FollowTarget = transform;
		}
		if (KidOnSwing != null)
		{
			KidOnSwing.Reset(false);
		}
	}

	private void OnDrawGizmosSelected()
	{
	}
}
