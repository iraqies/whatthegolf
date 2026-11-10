using System;
using System.Collections;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
	private enum StartingPoint
	{
		ONBOARDING = 0,
		SECONDONBOARDING = 1,
		HUB = 2
	}

	public Onboarding Onboarding;
	public XboxSplashScreen xboxSplashScreen;
	public PlaystationSplashScreen playstationSplashScreen;
	public GameObject quickmenu;
	public Color SwitchTransitionColor = Color.black;
	public bool forceSecondOnboarding;

	private Camera camera;
	[NonSerialized] public bool IsLoaded;
	private Color transitionColor = Color.black;
	private static Loading instance;
	private SceneInstance _loadingSceneInstance;

	public bool isOnboardingRunning { get; private set; }
	public static bool IsCreated => instance != null;
	public static bool IsReady => instance != null && instance.IsLoaded;

	private void Awake()
	{
		instance = this;
	}

	private void Start()
	{
		if (!IsLoaded)
			Init(default);
	}

	public void Init(SceneInstance sceneInstance)
	{
		if (IsLoaded) return;
		instance = this;
		_loadingSceneInstance = sceneInstance;
		Time.timeScale = 1f;
		var cfg = PlatformSettings.Instance.GetCurrent();
		Application.targetFrameRate = cfg != null && cfg.FPSOnPower > 0 ? cfg.FPSOnPower : 60;
		camera = GetComponent<Camera>();
		if (camera != null) transitionColor = camera.backgroundColor;
		StartCoroutine(InitCR());
	}

	private void OnDestroy()
	{
		if (instance == this) instance = null;
	}

	private IEnumerator InitCR()
	{
		SaveGame.Load();
		SaveGame.SessionCount = SaveGame.SessionCount + 1;
		iOSOnlineServices.IsReady = true;

		if (AudioManager.Instance != null && AudioManager.Instance.music != null)
		{
			AudioManager.Instance.music.InitializeBank(null, WhereToStart() != StartingPoint.HUB);
		}

		if (StartupLoadingScreen.Instance != null)
			StartupLoadingScreen.Instance.Hide();

		IsLoaded = true;
		yield return null;

		StartingPoint start = WhereToStart();
		if (start == StartingPoint.ONBOARDING && Onboarding != null && RuntimeStoreData.instance.mainCampaignPack != null)
		{
			yield return StartCoroutine(StartOnBoardingRoutine(RuntimeStoreData.instance.mainCampaignPack, false, true));
		}
		else if (start == StartingPoint.SECONDONBOARDING && Onboarding != null && RuntimeStoreData.instance.secondOnboarding != null)
		{
			yield return StartCoroutine(StartOnBoardingRoutine(RuntimeStoreData.instance.secondOnboarding, true, false));
		}
		else
		{
			LoadHub();
		}
	}

	private void CreateConsentPopupRequests() { }
	private void DownloadMusic() { }
	private void StartODR(LevelData obj) { }

	private void LoadHub()
	{
		StartCoroutine(LoadHubRoutine());
	}

	private IEnumerator LoadHubRoutine()
	{
		bool loaded = false;
		AsyncOperationHandle<SceneInstance> handle = default;
		try
		{
			handle = Addressables.LoadSceneAsync("Hub_Overworld", LoadSceneMode.Single, true);
		}
		catch (Exception)
		{
		}

		if (handle.IsValid())
		{
			while (!handle.IsDone)
				yield return null;
			if (handle.Status == AsyncOperationStatus.Succeeded)
				loaded = true;
		}

		if (!loaded)
		{
			AsyncOperation op = null;
			try
			{
				op = SceneManager.LoadSceneAsync("Hub_Overworld", LoadSceneMode.Single);
			}
			catch (Exception)
			{
			}
			while (op != null && !op.isDone)
				yield return null;
		}
	}

	private StartingPoint WhereToStart()
	{
		if (forceSecondOnboarding) return StartingPoint.SECONDONBOARDING;
		if (!SaveGame.IsOnboardingComplete)
			return StartingPoint.ONBOARDING;
		return StartingPoint.HUB;
	}

	private bool IsUserBeginner()
	{
		if (SaveGame.GetCompletedPercentage(ECampaignType.Main, null, true) <= 19 && SaveGame.SecondOnboardingIndex <= 2 && RuntimeStoreData.instance != null && RuntimeStoreData.instance.secondOnboarding != null)
		{
			SaveGame.SecondOnboardingIndex = (SaveGame.SecondOnboardingIndex + 1) % 3;
			return true;
		}
		return false;
	}
	private bool HasOnlyPlayedMainCampaign() => true;

	private IEnumerator StartOnBoardingRoutine(ContentPack pack, bool allowMenuButtons, bool isMainOnboarding)
	{
		if (Onboarding == null || pack == null)
		{
			LoadHub();
			yield break;
		}
		isOnboardingRunning = true;
		bool done = false;
		bool aborted = false;
		Action onCompleted = null;
		onCompleted = () =>
		{
			Onboarding.OnOnboardingCompleted -= onCompleted;
			done = true;
		};
		Onboarding.OnOnboardingCompleted += onCompleted;
		Onboarding.StartOnBoarding(pack, allowMenuButtons, () =>
		{
			Onboarding.OnOnboardingCompleted -= onCompleted;
			aborted = true;
			done = true;
			AbandonButtonClicked();
		});
		while (!done)
			yield return null;
		isOnboardingRunning = false;
		if (!aborted)
		{
			if (isMainOnboarding)
			{
				SaveGame.IsOnboardingComplete = true;
				SaveGame.IsFirstTime = false;
				SaveGame.Save();
			}
		}
	}

	public void AbandonButtonClicked()
	{
		StartCoroutine(OnboardingAbandoned());
	}

	private IEnumerator OnboardingAbandoned()
	{
		isOnboardingRunning = false;
		LoadHub();
		yield break;
	}
}
