using CameraStack;
using Cinemachine;
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

	public static MainAudioListener Instance
	{
		get
		{
			CreateInstanceIfNeeded();
			return instance;
		}
	}

	public static void CreateInstanceIfNeeded()
	{
		if (instance != null) return;
		var existingListeners = FindObjectsOfType<AudioListener>();
		if (existingListeners != null)
		{
			for (int i = 0; i < existingListeners.Length; i++)
			{
				if (existingListeners[i] != null)
					Destroy(existingListeners[i]);
			}
		}
		var go = new GameObject("AudioListener");
		DontDestroyOnLoad(go);
		go.AddComponent<AudioListener>();
		instance = go.AddComponent<MainAudioListener>();
		AudioListener.volume = 1f;
		AudioListener.pause = false;
	}

	public void SubscribeToOverworld(OverworldManager2d owManager)
	{
		if (owManager != null)
		{
			owManager.OnToggleOverworld -= OwManager_OnToggleOverworld;
			owManager.OnToggleOverworld += OwManager_OnToggleOverworld;
		}
		inOverworld = true;
		SetOverworldListener();
	}

	private void OwManager_OnToggleOverworld(bool status)
	{
		inOverworld = status;
		if (status)
			SetOverworldListener();
	}

	public void OnCameraBehaviourChanged(CameraBehavior cb)
	{
		inOverworld = false;
		if (cb == null) return;
		followTransform = cb.transform;
		cameraTransform = cb.transform;

		var follow = cb.GetComponent<ICameraBehaviourFollowing>();
		if (follow != null && follow.GetFollowTarget() != null)
		{
			follower = follow;
			followTransform = follow.GetFollowTarget();
		}
		else if (CinemachineCore.Instance != null && CinemachineCore.Instance.BrainCount > 0)
		{
			var brain = CinemachineCore.Instance.GetActiveBrain(0);
			if (brain != null && brain.ActiveVirtualCamera != null)
			{
				if (brain.ActiveVirtualCamera.Follow != null)
					followTransform = brain.ActiveVirtualCamera.Follow;
				if (brain.ActiveVirtualCamera.VirtualCameraGameObject != null)
					cameraTransform = brain.ActiveVirtualCamera.VirtualCameraGameObject.transform;
			}
		}

		var sceneSettings = FindObjectOfType<SceneListenerSettings>();
		if (sceneSettings != null)
			sceneSettings.Init();
	}

	public void SetFollowTarget(Transform target)
	{
		followTransform = target;
	}

	public void SetCameraTransform(Transform target)
	{
		cameraTransform = target;
	}

	public void SetListenerDistanceFromCamera(bool isFollow)
	{
		if (FindObjectOfType<SceneListenerSettings>() != null || isFollow)
			return;
		if (CameraManager.Instance != null && CameraManager.Instance.transform != null)
		{
			var camTrans = CameraManager.Instance.transform;
			transform.rotation = camTrans.rotation;
			transform.position = camTrans.position + camTrans.forward * 20f;
			followTransform = null;
			cameraTransform = camTrans;
		}
	}

	private GameObject CreateDummyListenerTransform(Transform cameraTransform)
	{
		if (cameraTransform == null) return null;
		var go = new GameObject("DummyListenerTransform");
		go.transform.position = cameraTransform.position;
		return go;
	}

	private bool IsFakeForward(Transform cameraTrans)
	{
		if (cameraTrans == null) return false;
		return Vector3.Dot(cameraTrans.forward, Vector3.forward) < 0.1f;
	}

	private void SetOverworldListener()
	{
		var go = GameObject.Find("OverworldBallFollower");
		if (go != null)
			owFollower = go.GetComponent<OverworldBallFollower>();
		if (owFollower == null)
			owFollower = FindObjectOfType<OverworldBallFollower>();
		if (owFollower != null)
		{
			cameraTransform = owFollower.transform;
			followTransform = owFollower.transform;
		}
		else if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			cameraTransform = OverworldBallManager.Instance.Ball.transform;
			followTransform = OverworldBallManager.Instance.Ball.transform;
		}
		else if (Camera.main != null)
		{
			cameraTransform = Camera.main.transform;
			followTransform = Camera.main.transform;
		}
	}

	private void Update()
	{
		if (inOverworld && (followTransform == null || !followTransform.gameObject.activeInHierarchy))
		{
			SetOverworldListener();
		}
		if (followTransform == null && Camera.main != null)
		{
			followTransform = Camera.main.transform;
			cameraTransform = Camera.main.transform;
		}
		if (followTransform != null)
		{
			if (inOverworld)
			{
				Vector3 p = followTransform.position;
				p.z = 0f;
				transform.position = p;
				transform.rotation = followTransform.rotation;
				return;
			}
			if (cameraTransform != null)
				transform.rotation = cameraTransform.rotation;
			transform.position = followTransform.position;
			if (follower != null && follower.GetFollowTarget() != null)
				transform.position = follower.GetFollowTarget().position;
		}
	}
}
