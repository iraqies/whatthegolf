using System.Collections;
using UnityEngine;

public class SceneListenerSettings : MonoBehaviour
{
	public enum InitMode
	{
		FromMainAudioListener = 0,
		OnAwake = 1,
		OnStart = 2,
		OnEnable = 3
	}

	public InitMode initMode;

	public float delay;

	public bool SetRotation;

	public Vector3 Rotation;

	public Transform InitializeFollowTo;

	public Transform cameraTransform;

	public void Init()
	{
	}

	private void OnEnable()
	{
	}

	private void Execute()
	{
	}

	private void SetFollow()
	{
	}

	private IEnumerator SetFollowAfterDelay()
	{
		return null;
	}
}
