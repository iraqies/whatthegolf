using System;
using System.Collections;
using System.Threading.Tasks;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class Bootstrap : MonoBehaviour
{
	public AASplashScreen arcadeSplashScreen;
	public GameObject SplashScreensContainer;

	private void Start()
	{
		StartCoroutine(BootstrapRoutine());
	}

	private IEnumerator BootstrapRoutine()
	{
		SetWindowSize();
		SetOrientation();

		_ = AudioManager.Instance;

		if (arcadeSplashScreen != null)
		{
			bool splashDone = false;
			yield return StartCoroutine(arcadeSplashScreen.Show(
				OnCoveredBySplash: () => { },
				OnCompleted: () => splashDone = true,
				OnCanShowGCBanner: () => { if (SplashScreensContainer != null) SplashScreensContainer.SetActive(false); }
			));
			while (!splashDone)
				yield return null;
		}
		if (SplashScreensContainer != null)
			SplashScreensContainer.SetActive(false);
		if (StartupLoadingScreen.Instance != null)
			StartupLoadingScreen.Instance.Hide();

		SceneInstance loadedScene = default;
		bool loadedViaAddressables = false;

		AsyncOperationHandle<SceneInstance> handle = default;
		try
		{
			handle = Addressables.LoadSceneAsync("Loading", LoadSceneMode.Single, true);
		}
		catch (Exception)
		{
		}

		if (handle.IsValid())
		{
			while (!handle.IsDone)
				yield return null;
			if (handle.Status == AsyncOperationStatus.Succeeded)
			{
				loadedScene = handle.Result;
				loadedViaAddressables = true;
			}
		}

		if (!loadedViaAddressables)
		{
			AsyncOperation op = null;
			try
			{
				op = SceneManager.LoadSceneAsync("Loading", LoadSceneMode.Single);
			}
			catch (Exception)
			{
			}
			while (op != null && !op.isDone)
				yield return null;
		}

		yield return null;
		var loading = FindObjectOfType<Loading>();
		if (loading != null)
		{
			loading.Init(loadedScene);
		}
	}

	private Task AwaitSplash() => Task.CompletedTask;

	private void SetWindowSize()
	{
	}

	private void SetOrientation()
	{
		var cfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
		Screen.sleepTimeout = cfg != null ? cfg.SleepTimeout : -1;
		Screen.autorotateToPortrait = false;
		Screen.autorotateToPortraitUpsideDown = false;
		Screen.autorotateToLandscapeLeft = false;
		Screen.autorotateToLandscapeRight = false;
		if (cfg != null && cfg.defaultScreenMode == PlatformSettings.ScreenModes.Portrait)
			Screen.orientation = ScreenOrientation.Portrait;
		else
			Screen.orientation = ScreenOrientation.LandscapeLeft;
	}
}
