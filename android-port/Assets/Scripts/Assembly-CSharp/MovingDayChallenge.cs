using System.Collections;
using System.Collections.Generic;
using CameraStack;
using Core;
using UnityEngine;

public class MovingDayChallenge : Challenge
{
	public List<GolfBallController> objectsToGetInCollider;

	public GolfBallController HouseController;

	public GameObject colliderContainer;

	public FollowTransform follower;

	public GameObject ramp;

	public Transform truck;

	public CBFollow cameraFollow;

	private List<GolfBallController> objectsLeft;

	private RigidbodyCollisionInfo colInfo;

	private GolfBallController controller;

	private int triggerCount;

	private bool lastPhase;

	protected override void Activate()
	{
	}

	private void OnTrigger(Collider other)
	{
	}

	private IEnumerator StartChallenge()
	{
		return null;
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	private IEnumerator EnableNextObject()
	{
		return null;
	}
}
