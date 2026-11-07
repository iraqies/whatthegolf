using CameraStack;
using UnityEngine;

public class MainAudioListener : MonoBehaviour
{
	private static MainAudioListener instance;

	private OverworldBallFollower owFollower;

	private Transform cameraTransform;

	private Transform followTransform;

	private Vector3 offset;

	private ICameraBehaviourFollowing follower;

	private bool inOverworld;

	public static MainAudioListener Instance => null;

	public static void CreateInstanceIfNeeded()
	{
	}

	public void SubscribeToOverworld(OverworldManager2d owManager)
	{
	}

	private void OwManager_OnToggleOverworld(bool status)
	{
	}

	public void OnCameraBehaviourChanged(CameraBehavior cb)
	{
	}

	public void SetFollowTarget(Transform target)
	{
	}

	public void SetCameraTransform(Transform target)
	{
	}

	public void SetListenerDistanceFromCamera(bool isFollow)
	{
	}

	private GameObject CreateDummyListenerTransform(Transform cameraTransform)
	{
		return null;
	}

	private bool IsFakeForward(Transform cameraTrans)
	{
		return false;
	}

	private void SetOverworldListener()
	{
	}

	private void Update()
	{
	}
}
