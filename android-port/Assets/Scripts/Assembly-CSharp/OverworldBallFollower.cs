using CameraStack;
using UnityEngine;

public class OverworldBallFollower : MonoBehaviour
{
	public bool isFollowing = true;
	private Transform target;
	public OverworldCamera camera;

	private void Start()
	{
		if (OverworldBallManager.Instance != null)
		{
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall;
			OverworldBallManager.Instance.OnNewBall += Instance_OnNewBall;
			if (OverworldBallManager.Instance.Ball != null)
				target = OverworldBallManager.Instance.Ball.transform;
		}
		if (target == null && OverworldManager2d.HasInstance && OverworldManager2d.Instance.ball != null)
			target = OverworldManager2d.Instance.ball.transform;
		if (camera == null)
			camera = OverworldCamera.Instance != null ? OverworldCamera.Instance : FindObjectOfType<OverworldCamera>();
		if (camera != null)
		{
			camera.OnPreLateUpdate -= Camera_OnPreLateUpdate;
			camera.OnPreLateUpdate += Camera_OnPreLateUpdate;
		}
		if (isFollowing && target != null)
			transform.position = target.position;
	}

	private void OnDestroy()
	{
		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
			OverworldBallManager.Instance.OnNewBall -= Instance_OnNewBall;
		if (camera != null)
			camera.OnPreLateUpdate -= Camera_OnPreLateUpdate;
	}

	private void Camera_OnPreLateUpdate()
	{
		if (!isFollowing) return;
		if (target == null)
		{
			if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
				target = OverworldBallManager.Instance.Ball.transform;
			else if (OverworldManager2d.HasInstance && OverworldManager2d.Instance.ball != null)
				target = OverworldManager2d.Instance.ball.transform;
		}
		if (target != null)
			transform.position = target.position;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
			target = OverworldBallManager.Instance.Ball.transform;
	}

	public void SetTarget(Transform target)
	{
		this.target = target;
		if (isFollowing && target != null)
			transform.position = target.position;
	}
}
