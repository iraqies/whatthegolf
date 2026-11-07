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
		try
		{
			var handle = Addressables.LoadSceneAsync("Hub_Overworld", LoadSceneMode.Single, true);
			if (handle.IsValid())
			{
				while (!handle.IsDone)
					yield return null;
				if (handle.Status == AsyncOperationStatus.Succeeded)
					loaded = true;
			}
		}
		catch (Exception)
		{
		}

		if (!loaded)
		{
			if (Application.CanStreamedLevelBeLoaded("Hub_Overworld"))
			{
				var op = SceneManager.LoadSceneAsync("Hub_Overworld", LoadSceneMode.Single);
				while (op != null && !op.isDone)
					yield return null;
				loaded = true;
			}
			else if (Application.CanStreamedLevelBeLoaded("main overworld new"))
			{
				var op = SceneManager.LoadSceneAsync("main overworld new", LoadSceneMode.Single);
				while (op != null && !op.isDone)
					yield return null;
				loaded = true;
			}
		}
	}

	private StartingPoint WhereToStart()
	{
		if (forceSecondOnboarding) return StartingPoint.SECONDONBOARDING;
		if (SaveGame.IsFirstTime && !SaveGame.IsOnboardingComplete)
			return StartingPoint.ONBOARDING;
		return StartingPoint.HUB;
	}

	private bool IsUserBeginner() => SaveGame.IsFirstTime;
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
		Onboarding.OnOnboardingCompleted += () => done = true;
		Onboarding.StartOnBoarding(pack, allowMenuButtons, () => done = true);
		while (!done)
			yield return null;
		isOnboardingRunning = false;
		SaveGame.IsOnboardingComplete = true;
		SaveGame.IsFirstTime = false;
		SaveGame.Save();
		LoadHub();
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
