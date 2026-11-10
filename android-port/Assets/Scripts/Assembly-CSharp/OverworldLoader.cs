using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using Core;
using UnityEngine.SceneManagement;

public class OverworldLoader : MonoBehaviour
{
	public IntroTunnelInOverworld tunnel;
	public string OverWorldSceneName;
	private Coroutine ballRolling;
	private AsyncOperationHandle<SceneInstance> loadHandle;
	private AsyncOperation sceneLoadOp;
	public Animator logoAnimator;
	private bool didPlayAnimation;
	private bool shouldContinueTunnel;
	private float startTunnelTime;

	public static bool ComingFromOverworldLoader;

	private IEnumerator LogoSplashRoutine()
	{
		yield return new WaitForSecondsRealtime(2f);
		Application.backgroundLoadingPriority = ThreadPriority.Low;
		yield return null;
		if (logoAnimator != null)
			logoAnimator.SetTrigger("Splash");
		yield return new WaitForSecondsRealtime(3.05f);
		didPlayAnimation = true;
	}

	private float GetTimeSinceStart()
	{
		return Time.realtimeSinceStartup - startTunnelTime;
	}

	private IEnumerator Start()
	{
		startTunnelTime = Time.realtimeSinceStartup;
		yield return StartCoroutine(Cleanup(!PlatformSettings.IsConsole, true));
		if (logoAnimator != null)
			logoAnimator.SetBool("QuickSplash", false);
		bool skipTunnel = SaveGame.IsIntroAnimationComplete;
		if (AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.InitializeBank(null, false);
		StartCoroutine(OverworldStartLoadingAsync_(skipTunnel));
		if (skipTunnel)
		{
			while (!IsOverworldDoneLoading())
				yield return null;
			Application.backgroundLoadingPriority = ThreadPriority.Low;
			yield break;
		}
		if (tunnel != null)
			tunnel.Init(false);
		if (LevelManager.Exists)
			StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));

		bool finishedTunnel = false;
		bool canFinishSwitch = true;
		bool startedSplash = false;
		if (tunnel != null)
		{
			var routine = tunnel.PlayAnimationRoutine(
				() => finishedTunnel = true,
				() =>
				{
					if (!IsOverworldReadyToActivate())
						return false;
					if (canFinishSwitch)
					{
						canFinishSwitch = false;
						StartCoroutine(OverworldFinshLoadAndSwitch());
					}
					return shouldContinueTunnel;
				},
				() =>
				{
					bool ready = IsOverworldReadyToActivate();
					if (ready && !startedSplash)
					{
						startedSplash = true;
						StartCoroutine(LogoSplashRoutine());
					}
					return ready;
				}
			);
			ballRolling = StartCoroutine(pTween.Then(routine, 0.1f, () => { }));
		}
		else
		{
			StartCoroutine(LogoSplashRoutine());
			StartCoroutine(OverworldFinshLoadAndSwitch());
			finishedTunnel = true;
		}
		while (!finishedTunnel)
			yield return null;
		Application.backgroundLoadingPriority = ThreadPriority.Low;
	}

	private bool IsOverworldReadyToActivate()
	{
		if (sceneLoadOp != null)
			return sceneLoadOp.progress >= 0.89f || sceneLoadOp.isDone;
		if (loadHandle.IsValid())
			return loadHandle.PercentComplete >= 0.9f || loadHandle.IsDone;
		return true;
	}

	private bool IsOverworldDoneLoading()
	{
		if (sceneLoadOp != null)
			return sceneLoadOp.isDone;
		if (loadHandle.IsValid())
			return loadHandle.IsDone;
		return true;
	}

	private IEnumerator Cleanup(bool blockingUnloadedAssets, bool useGC = true)
	{
		var op = Resources.UnloadUnusedAssets();
		if (blockingUnloadedAssets && op != null)
			yield return op;
		if (useGC)
			GC.Collect(0, GCCollectionMode.Optimized, false);
	}

	private IEnumerator OverworldStartLoadingAsync_(bool skipTunnel)
	{
		ComingFromOverworldLoader = !skipTunnel;
		Application.backgroundLoadingPriority = ThreadPriority.Low;
		string sceneName = !string.IsNullOrEmpty(OverWorldSceneName) ? OverWorldSceneName : "main overworld new";
		if (Application.CanStreamedLevelBeLoaded(sceneName))
		{
			try
			{
				sceneLoadOp = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);
				if (sceneLoadOp != null)
					sceneLoadOp.allowSceneActivation = skipTunnel;
			}
			catch (Exception)
			{
			}
		}
		if (sceneLoadOp == null)
		{
			try
			{
				loadHandle = Addressables.LoadSceneAsync(sceneName, LoadSceneMode.Single, skipTunnel, 100);
			}
			catch (Exception)
			{
			}
		}
		while (!IsOverworldReadyToActivate())
			yield return null;
		if (!skipTunnel)
			yield return null;
	}

	public IEnumerator OverworldFinshLoadAndSwitch()
	{
		while (!IsOverworldReadyToActivate() || !didPlayAnimation)
			yield return null;
		Application.backgroundLoadingPriority = ThreadPriority.High;
		if (sceneLoadOp != null)
		{
			sceneLoadOp.allowSceneActivation = true;
		}
		else if (loadHandle.IsValid())
		{
			try
			{
				loadHandle.Result.ActivateAsync();
			}
			catch (Exception)
			{
			}
		}
		yield return null;
		for (int i = 0; i < 2; i++)
			yield return null;
		Application.backgroundLoadingPriority = ThreadPriority.Normal;
		shouldContinueTunnel = true;
	}
}
