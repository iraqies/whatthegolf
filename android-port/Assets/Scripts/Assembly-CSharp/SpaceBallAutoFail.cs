using SpaceGolf;

public class SpaceBallAutoFail : AutoFailBase
{
	public float velocityThreshold = 5f;

	public SpaceGolfBallShooter spaceball;

	public override void Init()
	{
		if (spaceball == null)
			spaceball = GetComponentInChildren<SpaceGolfBallShooter>();
		if (spaceball == null)
			spaceball = FindObjectOfType<SpaceGolfBallShooter>();
	}

	private void FixedUpdate()
	{
		if (!CheckAutoFail)
			return;
		if (spaceball != null && spaceball.isGrounded)
		{
			DecrementFailTimer();
		}
		else
		{
			ResetFailTimer();
		}
	}
}
