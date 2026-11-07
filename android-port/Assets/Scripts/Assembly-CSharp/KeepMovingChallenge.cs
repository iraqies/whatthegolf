using Core;
using UnityEngine;

public class KeepMovingChallenge : Challenge
{
	private Rigidbody _ballRigidbody;

	private GolfBallController _controller;

	private float _failChallengeTimer;

	private bool _challengeStarted;

	private float _levelTimer;

	public float timeToBeat;

	private int _currentTimeInt;

	public bool beginOnAim;

	public float minVelocity;

	protected override void Activate()
	{
	}

	private void ControllerOnAimStart()
	{
	}

	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	protected override void ChallengeUpdate()
	{
	}

	public override string GetDescription()
	{
		return null;
	}

	public override string GetWinMessageID()
	{
		return null;
	}
}
