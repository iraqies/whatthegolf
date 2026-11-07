using CameraStack;
using UnityEngine;

public class OverworldBallFollower : MonoBehaviour
{
	public bool isFollowing;

	private Transform target;

	public OverworldCamera camera;

	private void Start()
	{
	}

	private void Camera_OnPreLateUpdate()
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	public void SetTarget(Transform target)
	{
	}
}
