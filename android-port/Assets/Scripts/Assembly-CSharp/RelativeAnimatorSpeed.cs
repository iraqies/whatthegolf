using UnityEngine;

public class RelativeAnimatorSpeed : MonoBehaviour
{
	public float Speed = 1f;

	private Animator animator;

	private Rigidbody2D ball;

	private void Start()
	{
		animator = GetComponent<Animator>();
		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall;
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall;
			if (OverworldBallManager.Instance.Ball != null)
				ball = OverworldBallManager.Instance.Ball.rigidBody;
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
			ball = OverworldBallManager.Instance.Ball.rigidBody;
	}

	private void Update()
	{
		if (animator != null && ball != null)
		{
			animator.speed = ball.velocity.magnitude * Speed;
		}
	}
}
