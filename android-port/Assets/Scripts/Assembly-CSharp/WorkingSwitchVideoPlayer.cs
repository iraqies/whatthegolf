using UnityEngine;
using UnityEngine.Events;

public class WorkingSwitchVideoPlayer : MonoBehaviour
{
	[SerializeField]
	private Transform _outputPlane;

	[SerializeField]
	private Renderer _outputRenderer;

	public UnityEvent loopPointReached;

	private CameraPreRenderHook _preRenderHook;

	private void CleanupCameraHook()
	{
	}

	public bool Play(string url, Camera camera, bool loop)
	{
		return false;
	}

	public void Stop()
	{
	}

	private void OnCameraPreRender()
	{
	}
}
