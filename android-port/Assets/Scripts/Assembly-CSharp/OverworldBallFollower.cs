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
			if (OverworldBallManager.Instance.Ball != null && OverworldBallManager.Instance.Ball.gameObject.scene.IsValid())
				target = OverworldBallManager.Instance.Ball.transform;
		}
		if ((target == null || !target.gameObject.scene.IsValid()) && OverworldManager2d.HasInstance && OverworldManager2d.Instance.ball != null && OverworldManager2d.Instance.ball.gameObject.scene.IsValid())
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
		if (target == null || !target.gameObject.scene.IsValid())
		{
			if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null && OverworldBallManager.Instance.Ball.gameObject.scene.IsValid())
				target = OverworldBallManager.Instance.Ball.transform;
			else if (OverworldManager2d.HasInstance && OverworldManager2d.Instance.ball != null && OverworldManager2d.Instance.ball.gameObject.scene.IsValid())
				target = OverworldManager2d.Instance.ball.transform;
		}
		if (target != null && target.gameObject.scene.IsValid())
			transform.position = target.position;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null && OverworldBallManager.Instance.Ball.gameObject.scene.IsValid())
			target = OverworldBallManager.Instance.Ball.transform;
	}

	public void SetTarget(Transform target)
	{
		if (target != null && !target.gameObject.scene.IsValid())
			return;
		this.target = target;
		if (isFollowing && target != null)
			transform.position = target.position;
	}
}
