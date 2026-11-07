using CameraStack;
using Core;
using UnityEngine;

public class PositionAndAlignChallenge : Challenge
{
	public GameObject[] deactivatedObjects;

	private GolfBallController _golfBallController;

	private CBFollow _cbFollow;

	public Transform positionTarget;

	public float minimumDistance;

	public float minimumUpAngle;

	public float minimumForwardAngle;

	protected override void Activate()
	{
	}

	protected override void ChallengeUpdate()
	{
	}
}
