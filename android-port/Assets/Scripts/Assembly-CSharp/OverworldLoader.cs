using System.Collections;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;

public class OverworldLoader : MonoBehaviour
{
	public IntroTunnelInOverworld tunnel;

	public string OverWorldSceneName;

	private Coroutine ballRolling;

	private AsyncOperationHandle<SceneInstance> loadHandle;

	public Animator logoAnimator;

	private bool didPlayAnimation;

	private bool shouldContinueTunnel;

	private float startTunnelTime;

	private IEnumerator LogoSplashRoutine()
	{
		return null;
	}

	private float GetTimeSinceStart()
	{
		return 0f;
	}

	private IEnumerator Start()
	{
		return null;
	}

	private IEnumerator Cleanup(bool blockingUnloadedAssets, bool useGC = true)
	{
		return null;
	}

	private IEnumerator OverworldStartLoadingAsync_(bool skipTunnel)
	{
		return null;
	}

	public IEnumerator OverworldFinshLoadAndSwitch()
	{
		return null;
	}
}
