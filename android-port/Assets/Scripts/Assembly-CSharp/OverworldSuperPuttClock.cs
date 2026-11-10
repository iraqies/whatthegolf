using UnityEngine;

public class OverworldSuperPuttClock : MonoBehaviour
{
	public Rigidbody2D large;

	public Rigidbody2D minor;

	public float largeSpeed = -10f;

	public float minorSpeed = -1f;

	private Rigidbody2D ball;

	private Vector2 lastBallPos;

	private float totalBallMovement;

	private void Start()
	{
		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall;
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall;
			if (OverworldBallManager.Instance.Ball != null)
			{
				ball = OverworldBallManager.Instance.Ball.rigidBody;
				if (ball != null)
					lastBallPos = ball.position;
			}
		}
	}

	private void OnDestroy()
	{
		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			ball = OverworldBallManager.Instance.Ball.rigidBody;
			if (ball != null)
				lastBallPos = ball.position;
		}
	}

	private void FixedUpdate()
	{
		if (ball == null)
			return;
		Vector2 curPos = ball.position;
		totalBallMovement += (curPos - lastBallPos).magnitude;
		if (large != null)
			large.MoveRotation(totalBallMovement * largeSpeed);
		if (minor != null)
			minor.MoveRotation(totalBallMovement * minorSpeed);
		lastBallPos = curPos;
	}
}
