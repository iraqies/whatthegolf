using SpaceGolf;
using UnityEngine;

public class SpaceBallAutoFail : AutoFailBase
{
	public float velocityThreshold = 0.05f;

	public SpaceGolfBallShooter spaceball;

	public override void Init()
	{
		if (spaceball == null)
			spaceball = GetComponent<SpaceGolfBallShooter>();
	}

	private void FixedUpdate()
	{
		if (spaceball == null)
			return;
		Rigidbody2D rb = spaceball.GetComponent<Rigidbody2D>();
		if (rb != null && rb.velocity.sqrMagnitude < velocityThreshold * velocityThreshold)
		{
			CheckAutoFail();
		}
	}
}
