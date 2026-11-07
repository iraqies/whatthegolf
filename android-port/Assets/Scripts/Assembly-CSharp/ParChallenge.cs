using Core;
using UnityEngine;

public class ParChallenge : Challenge
{
	public int ScoreToBeat;

	public Rigidbody controllerRigid;

	public GolfBallController SpecificController;

	public bool FindAdditionalControllers;

	public bool BlockShootingAfterLastShot;

	public bool AutoFail;

	public float AutoFailThreshold;

	public float AutoFailTimer;

	public bool DoDelayedFailOnAllShotsUsed;

	public float Delay;

	private AutoFailBase m_customAutoFail;

	private GolfBallController controller;

	private GolfBallController[] additionalControllers;

	private bool checkVelocity;

	private float m_failTimer;

	private float m_startFailCheckTime;

	private int strokeCount;

	private Vector3 _lastPosition;

	private Vector3 _movementDelta;

	public bool IsLastShotOrPast { get; private set; }

	protected override void Activate()
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

	private void OnShoot(GolfBallController controller, int strokes)
	{
	}

	protected override void ChallengeUpdate()
	{
	}

	private void MovementFailCheck(Vector3 movement)
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
