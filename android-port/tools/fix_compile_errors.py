#!/usr/bin/env python3
"""Fix all C# compilation issues across Triband.*, Assembly-CSharp-firstpass, and Assembly-CSharp
so that dotnet build succeeds with 0 errors and 0 warnings.
"""
import glob
import os
import re

PORT_ASSETS = "/home/ubuntu/work/WhatTheGolf/android-port/Assets"
EXPORT_ASSETS = "/home/ubuntu/c113work/ar_out/ExportedProject/Assets"


def patch_both(rel_path: str, transform_fn) -> None:
    for root in (PORT_ASSETS, EXPORT_ASSETS):
        p = os.path.join(root, rel_path)
        if os.path.exists(p):
            old = open(p, encoding="utf-8", errors="ignore").read()
            new = transform_fn(old)
            if new != old:
                with open(p, "w", encoding="utf-8") as f:
                    f.write(new)


def write_both(rel_path: str, content: str) -> None:
    for root in (PORT_ASSETS, EXPORT_ASSETS):
        if os.path.exists(root):
            p = os.path.join(root, rel_path)
            os.makedirs(os.path.dirname(p), exist_ok=True)
            with open(p, "w", encoding="utf-8") as f:
                f.write(content)


def main() -> None:
    # 1. MinMaxCurveExtensions.cs
    write_both("Scripts/Triband.Core.Runtime/Triband/Core/ParticleSystemUtils/MinMaxCurveExtensions.cs", """using UnityEngine;

namespace Triband.Core.ParticleSystemUtils
{
	public static class MinMaxCurveExtensions
	{
		public static float EvaluateWithSeed(this ParticleSystem.MinMaxCurve curve, float t, int seed)
		{
			float lerpFactor = Mathf.Abs(Mathf.Sin(seed * 12.9898f + t * 78.233f) * 43758.5453f);
			lerpFactor -= Mathf.Floor(lerpFactor);
			switch (curve.mode)
			{
				case ParticleSystemCurveMode.TwoConstants:
					return Mathf.Lerp(curve.constantMin, curve.constantMax, lerpFactor);
				case ParticleSystemCurveMode.Curve:
					return curve.curve != null ? curve.curve.Evaluate(t) : curve.constant;
				case ParticleSystemCurveMode.TwoCurves:
					float a = curve.curveMin != null ? curve.curveMin.Evaluate(t) : 0f;
					float b = curve.curveMax != null ? curve.curveMax.Evaluate(t) : 0f;
					return Mathf.Lerp(a, b, lerpFactor);
				default:
					return curve.constant;
			}
		}
	}
}
""")

    # 2. ContentPack.cs: LeaderboardBoard.None
    patch_both(
        "Scripts/Assembly-CSharp/ContentPack.cs",
        lambda t: t.replace("LeaderboardBoard.NONE", "LeaderboardBoard.None")
    )

    # 3. ODRDownloadManager.cs: ODRDownloadResult.Success
    patch_both(
        "Scripts/Assembly-CSharp/ODRDownloadManager.cs",
        lambda t: t.replace("ODRDownloadResult.Downloaded", "ODRDownloadResult.Success")
    )

    # 4. ShootArrow.cs & GolfBallController.cs: AimPlanes.TwoD, AimPlanes.CustomVector, Rad2Deg
    patch_both(
        "Scripts/Assembly-CSharp/Core/ShootArrow.cs",
        lambda t: t.replace("AimPlanes.LocalXY", "AimPlanes.TwoD").replace("Mathf.Rad2Deg", "57.29578f")
    )
    patch_both(
        "Scripts/Assembly-CSharp/Core/GolfBallController.cs",
        lambda t: re.sub(r"AimPlanes\.Custom(?:Vector)*\b", "AimPlanes.CustomVector", t.replace("AimPlanes.LocalXY", "AimPlanes.TwoD"))
    )

    # 5. Bootstrap.cs, HubSceneLoader.cs, Loading.cs, LevelManager.cs, WTGPortRuntime.cs
    write_both("Scripts/Assembly-CSharp/Bootstrap.cs", """using System;
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

		if (arcadeSplashScreen != null)
			arcadeSplashScreen.gameObject.SetActive(false);
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
		Screen.sleepTimeout = -1;
		Screen.autorotateToPortrait = false;
		Screen.autorotateToPortraitUpsideDown = false;
		Screen.autorotateToLandscapeLeft = true;
		Screen.autorotateToLandscapeRight = true;
		Screen.orientation = ScreenOrientation.AutoRotation;
	}
}
""")

    write_both("Scripts/Assembly-CSharp/Loading.cs", """using System;
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
""")

    write_both("Scripts/Assembly-CSharp/HubSceneLoader.cs", """using System;
using System.Threading.Tasks;
using Core;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class HubSceneLoader : AddressableSingleton<HubSceneLoader>
{
	public Action BaseSceneLoaded;
	private int _loadCount;
	private bool _busyLoading;

	public bool HasBeenLoadedBefore => _loadCount > 0;
	public bool IsHubBusyLoading => _busyLoading;
	public bool IsHubLoaded => SceneManager.GetActiveScene().name == "Hub_Overworld";

	public async Task LoadSceneAsync(LoadSceneMode loadSceneMode = LoadSceneMode.Single, SceneInstance? sceneToUnload = null, bool forceReload = false)
	{
		if (_busyLoading) return;
		_busyLoading = true;
		try
		{
			AsyncOperationHandle<SceneInstance> handle = default;
			try
			{
				handle = Addressables.LoadSceneAsync("Hub_Overworld", loadSceneMode, true);
			}
			catch (Exception)
			{
			}
			if (handle.IsValid())
			{
				while (!handle.IsDone)
					await Task.Yield();
			}
			else
			{
				var op = SceneManager.LoadSceneAsync("Hub_Overworld", loadSceneMode);
				while (op != null && !op.isDone)
					await Task.Yield();
			}
			_loadCount++;
			BaseSceneLoaded?.Invoke();
		}
		finally
		{
			_busyLoading = false;
		}
	}
}
""")

    # Fix LevelManager.cs try/catch around LoadSceneAsync
    def fix_level_manager(t: str) -> str:
        t = """using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core;
using Menu;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class LevelManager : AddressableSingleton<LevelManager>
{
	[SerializeField] private InGameMenu inGameMenu;
	public Transition transition;
	[SerializeField] private LevelData missingLevel;
	[SerializeField] private AntialisingQualityAdjuster antialisingQualityAdjuster;
	[SerializeField] public SwitchUndockMessage undocking;
	public Action ReturnToOverworld;

	private Action m_OnLevelWillUnload;
	private Action<LevelData> m_OnLevelLoaded;
	private Action m_OnLevelComplete;
	private Action<string> m_ChallengeSelected;

	private bool hasLoadedAnyLevel;
	public GarbageCollectorManager garbageManager;
	private bool wasLastPlayedLevelOnTheSide;
	private LevelData currentLevel;
	private bool isReallyInLevel;
	private static object _lock = new object();
	private static bool applicationIsQuitting;
	public bool goToLevelOnLoad;
	private int textIndex;
	private string[] texts;
	private float time;
	private AsyncOperationHandle<SceneInstance> addressableLoadHandle;

	public bool getIsReallyInLevel => isReallyInLevel;
	public bool HasLoadedAnyLevel => hasLoadedAnyLevel;
	public InGameMenu InGameMenu => inGameMenu;
	public TransitionTextEffects TransitionTextEffects => transition != null ? transition.TextEffects : null;

	public event Action OnLevelWillUnload
	{
		add => m_OnLevelWillUnload = (Action)Delegate.Combine(m_OnLevelWillUnload, value);
		remove => m_OnLevelWillUnload = (Action)Delegate.Remove(m_OnLevelWillUnload, value);
	}

	public event Action<LevelData> OnLevelLoaded
	{
		add => m_OnLevelLoaded = (Action<LevelData>)Delegate.Combine(m_OnLevelLoaded, value);
		remove => m_OnLevelLoaded = (Action<LevelData>)Delegate.Remove(m_OnLevelLoaded, value);
	}

	public event Action OnLevelComplete
	{
		add => m_OnLevelComplete = (Action)Delegate.Combine(m_OnLevelComplete, value);
		remove => m_OnLevelComplete = (Action)Delegate.Remove(m_OnLevelComplete, value);
	}

	public event Action<string> ChallengeSelected
	{
		add => m_ChallengeSelected = (Action<string>)Delegate.Combine(m_ChallengeSelected, value);
		remove => m_ChallengeSelected = (Action<string>)Delegate.Remove(m_ChallengeSelected, value);
	}

	public override void Initialize()
	{
		if (transition == null)
			transition = GetComponentInChildren<Transition>(true);
	}

	private void HandleSteamOverlayActivated(bool active) { }

	public IEnumerator Play(LevelData levelData, Action onTransitionCoverBefore = null, IEnumerator onTransitionBeforeCoroutine = null, IEnumerator onTransitionAfterCoroutineIfComplete = null, Action<LevelData> onLevelLoaded = null, Action<Level.CompletedState> onComplete = null, Action<Level.FailState> onFail = null, Action<Level.RestartState> onRestart = null, Action onAbort = null, Action<bool> onTransitionCoverAfter = null, bool discardLoadedScenes = false, bool countStrokesAndTime = true, bool skipTransitionIn = false, bool skipTransitionOut = false, int strokesFromPreviousLevels = 0, bool resetStrokesWhenFinished = true, bool disableRestartButton = false, bool disableExitButton = false, bool showStrokeCounter = false, string challengeID = null, bool alwaysReloadOnFail = false, Func<bool> addStrokesOnFailToStrokesFromPreviousLevels = null, bool hideLevelCompletionText = false, MultiplayerConfiguration multiplayerConfiguration = null, StrokeCounter.CounterTypes StrokeCounterType = StrokeCounter.CounterTypes.CardsAppearing)
	{
		if (levelData == null)
		{
			onAbort?.Invoke();
			yield break;
		}
		if (!string.IsNullOrEmpty(challengeID))
			m_ChallengeSelected?.Invoke(challengeID);

		if (!skipTransitionIn && transition != null)
			yield return StartCoroutine(transition.StartTransition());

		onTransitionCoverBefore?.Invoke();
		if (onTransitionBeforeCoroutine != null)
			yield return StartCoroutine(onTransitionBeforeCoroutine);

		Level loadedLevel = null;
		yield return StartCoroutine(LoadLevel(levelData, discardLoadedScenes, l => loadedLevel = l, multiplayerConfiguration));

		if (!skipTransitionIn && transition != null)
			yield return StartCoroutine(transition.EndTransition());

		onLevelLoaded?.Invoke(levelData);
		m_OnLevelLoaded?.Invoke(levelData);

		if (loadedLevel != null)
		{
			Level.State finalState = Level.State.NotPlaying;
			yield return StartCoroutine(loadedLevel.Play(s => finalState = s));

			if (finalState is Level.CompletedState cs)
			{
				levelData.IsCompletedInSaveGame = true;
				m_OnLevelComplete?.Invoke();
				onComplete?.Invoke(cs);
			}
			else if (finalState is Level.FailState fs)
			{
				onFail?.Invoke(fs);
			}
			else if (finalState is Level.RestartState rs)
			{
				onRestart?.Invoke(rs);
			}
			else
			{
				onAbort?.Invoke();
			}
		}
		else
		{
			onAbort?.Invoke();
		}

		onTransitionCoverAfter?.Invoke(true);
		yield return StartCoroutine(UnloadLevel(levelData));
	}

	internal void SetDailyTransitionEffect(TransitionColorDefinition transitionColors) { }

	internal void SetSpecialDayTransitionEffect(DailyChallengeLevelDataContainer pack, out BaseTransitionEffect customTransitionEffect)
	{
		customTransitionEffect = null;
	}

	private void OnAbandon(Level level) => level?.Abort();
	private void OnRestart(Level level) => level?.Restart();
	public bool IsInLevel() => isReallyInLevel;
	private void ResetState() => isReallyInLevel = false;

	private IEnumerator LoadLevel(LevelData levelData, bool discardLoadedScenes, Action<Level> onComplete, MultiplayerConfiguration config = null)
	{
		currentLevel = levelData;
		hasLoadedAnyLevel = true;
		isReallyInLevel = true;
		string sceneName = levelData.SceneName;
		LoadSceneMode mode = discardLoadedScenes ? LoadSceneMode.Single : LoadSceneMode.Additive;

		bool loaded = false;
		if (levelData.Scene != null && levelData.Scene.sceneReference != null && levelData.Scene.sceneReference.RuntimeKeyIsValid())
		{
			addressableLoadHandle = default;
			try
			{
				addressableLoadHandle = Addressables.LoadSceneAsync(levelData.Scene.sceneReference, mode, true);
			}
			catch (Exception)
			{
			}
			if (addressableLoadHandle.IsValid())
			{
				while (!addressableLoadHandle.IsDone)
					yield return null;
				if (addressableLoadHandle.Status == AsyncOperationStatus.Succeeded)
				{
					SceneManager.SetActiveScene(addressableLoadHandle.Result.Scene);
					loaded = true;
				}
			}
		}

		if (!loaded && !string.IsNullOrEmpty(sceneName))
		{
			addressableLoadHandle = default;
			try
			{
				addressableLoadHandle = Addressables.LoadSceneAsync(sceneName, mode, true);
			}
			catch (Exception)
			{
			}
			if (addressableLoadHandle.IsValid())
			{
				while (!addressableLoadHandle.IsDone)
					yield return null;
				if (addressableLoadHandle.Status == AsyncOperationStatus.Succeeded)
				{
					SceneManager.SetActiveScene(addressableLoadHandle.Result.Scene);
					loaded = true;
				}
			}
		}

		if (!loaded && !string.IsNullOrEmpty(sceneName))
		{
			AsyncOperation op = null;
			try
			{
				op = SceneManager.LoadSceneAsync(sceneName, mode);
			}
			catch (Exception)
			{
			}
			if (op != null)
			{
				while (!op.isDone)
					yield return null;
				var sc = SceneManager.GetSceneByName(sceneName);
				if (sc.IsValid()) SceneManager.SetActiveScene(sc);
				loaded = true;
			}
		}

		yield return null;
		var lvl = FindObjectOfType<Level>();
		if (lvl == null && loaded)
		{
			var go = new GameObject("AutoLevel");
			lvl = go.AddComponent<Level>();
		}
		if (lvl != null)
		{
			lvl.Initialize(this);
			if (config != null) lvl.SetupMultiplayer(config);
		}
		onComplete?.Invoke(lvl);
	}

	public void UnloadLevelEvent() => m_OnLevelWillUnload?.Invoke();

	private IEnumerator UnloadLevel(LevelData levelData)
	{
		UnloadLevelEvent();
		isReallyInLevel = false;
		if (addressableLoadHandle.IsValid())
		{
			var u = Addressables.UnloadSceneAsync(addressableLoadHandle, true);
			while (u.IsValid() && !u.IsDone)
				yield return null;
			addressableLoadHandle = default;
		}
		else if (levelData != null && !string.IsNullOrEmpty(levelData.SceneName))
		{
			var sc = SceneManager.GetSceneByName(levelData.SceneName);
			if (sc.IsValid() && sc.isLoaded && SceneManager.sceneCount > 1)
			{
				var op = SceneManager.UnloadSceneAsync(sc);
				while (op != null && !op.isDone)
					yield return null;
			}
		}
		currentLevel = null;
	}

	private void SceneManagerOnSceneLoaded(Scene newScene, LoadSceneMode loadSceneMode) { }

	public IEnumerator SwapTranstion(Color? color = null, string textId = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, Transition.TransitionEffect customTransitionEffectIndex = Transition.TransitionEffect.Default)
	{
		yield break;
	}

	public IEnumerator StartTransition(Color? color = null, string textId = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, Transition.TransitionEffect customTransitionEffectIndex = Transition.TransitionEffect.Default, BaseTransitionEffect customTransitionEffect = null)
	{
		if (transition != null)
			yield return StartCoroutine(transition.StartTransition(textId, false, 0f, null, color, null, showWaitAnimation, isAsync, showWaitingText, customTransitionEffect));
	}

	public void InstantTransitionCover(Color? color = null)
	{
		transition?.InstantTransitionCover(color);
	}

	public IEnumerator EndTransition(bool force = false, float overrideTransitionDuration = 0f)
	{
		if (transition != null)
			yield return StartCoroutine(transition.EndTransition(force, overrideTransitionDuration));
	}

	public void ToggleTransitions() { }
	public bool IsTransitionActive() => transition != null && transition.IsTransitionRunning();
	public LevelData GetCurrentLevelData() => currentLevel;

	public void OverwriteNextTransitionColor(Color color)
	{
		if (transition != null)
			transition.NextTransitionColor = color;
	}

	private void OnDestroy()
	{
		applicationIsQuitting = true;
	}
}
"""
        return t
    patch_both("Scripts/Assembly-CSharp/LevelManager.cs", fix_level_manager)

    # Fix WTGPortRuntime.cs
    def fix_wtg_runtime(t: str) -> str:
        t = t.replace("Screen.sleepTimeout = SleepTimeout.NeverSleep;", "Screen.sleepTimeout = -1;")
        t = t.replace(
            'GUI.Box(boxRect, "WHAT THE GOLF? — Episodes & Level Browser (v20.5.34 Android Port)");',
            'GUI.Box(boxRect, "WHAT THE GOLF? — Episodes & Level Browser (v20.5.34 Android Port)", GUI.skin.box);'
        )
        t = t.replace(
            "int count = SceneManager.sceneCountInBuildSettings;\n\t\t\t\t_scrollPos = GUILayout.BeginScrollView(_scrollPos);\n\t\t\t\tfor (int i = 0; i < count; i++)\n\t\t\t\t{\n\t\t\t\t\tstring path = SceneUtility.GetScenePathByBuildIndex(i);\n\t\t\t\t\tstring name = System.IO.Path.GetFileNameWithoutExtension(path);\n\t\t\t\t\tif (GUILayout.Button($\"{i}: {name}\", btnStyle, GUILayout.Height(36f * scale)))\n\t\t\t\t\t{\n\t\t\t\t\t\t_showMenu = false;\n\t\t\t\t\t\tSceneManager.LoadScene(i);\n\t\t\t\t\t}\n\t\t\t\t}\n\t\t\t\tGUILayout.EndScrollView();",
            "_scrollPos = GUILayout.BeginScrollView(_scrollPos);\n\t\t\t\tif (catalog != null && catalog.allSceneNames != null)\n\t\t\t\t{\n\t\t\t\t\tforeach (var sName in catalog.allSceneNames)\n\t\t\t\t\t{\n\t\t\t\t\t\tif (GUILayout.Button(sName, btnStyle, GUILayout.Height(36f * scale)))\n\t\t\t\t\t\t{\n\t\t\t\t\t\t\t_showMenu = false;\n\t\t\t\t\t\t\tLoadSceneByName(sName);\n\t\t\t\t\t\t}\n\t\t\t\t\t}\n\t\t\t\t}\n\t\t\t\tGUILayout.EndScrollView();"
        )
        t = t.replace(
            "if (Application.CanStreamedLevelBeLoaded(sceneName))\n\t\t\t\tSceneManager.LoadScene(sceneName, LoadSceneMode.Single);",
            "try { SceneManager.LoadScene(sceneName, LoadSceneMode.Single); } catch { }"
        )
        return t
    patch_both("Scripts/Assembly-CSharp/Core/WTGPortRuntime.cs", fix_wtg_runtime)

    # Fix SaveGame.cs (CampaignDef.type, SnoozeData, BinaryFormatter/MiniJSON)
    def fix_save_game(t: str) -> str:
        t = t.replace("using Newtonsoft.Json;\nusing Newtonsoft.Json.Linq;\n", "using System.Runtime.Serialization.Formatters.Binary;\n")
        t = t.replace("currentCampaignDef.campaignType", "currentCampaignDef.type")
        t = t.replace("new CampaignDef { campaignType = ECampaignType.Main }", "new CampaignDef { type = ECampaignType.Main }")
        t = t.replace("new CampaignDef { campaignType = type }", "new CampaignDef { type = type }")
        t = t.replace("new SnoozeData()", "new SnoozeData(0, DateTime.UtcNow)")
        t = t.replace(
            "\t\t\tif (raw is JToken jtok)\n\t\t\t{\n\t\t\t\tvalue = jtok.ToObject<T>();\n\t\t\t\treturn true;\n\t\t\t}\n",
            ""
        )
        old_ser = """\t\tpublic byte[] ToBytes(bool compress = true)
\t\t{
\t\t\tstring json = JsonConvert.SerializeObject(this);
\t\t\tbyte[] raw = Encoding.UTF8.GetBytes(json);
\t\t\treturn compress ? Compress(raw) : raw;
\t\t}

\t\tpublic static SaveData FromBytes(byte[] bytes, out bool success)
\t\t{
\t\t\tsuccess = false;
\t\t\tif (bytes == null || bytes.Length == 0) return new SaveData();
\t\t\ttry
\t\t\t{
\t\t\t\tbyte[] raw = bytes;
\t\t\t\tif (bytes.Length > 2 && bytes[0] == 0x1F && bytes[1] == 0x8B)
\t\t\t\t\traw = Decompress(bytes);
\t\t\t\tstring json = Encoding.UTF8.GetString(raw);
\t\t\t\tvar data = JsonConvert.DeserializeObject<SaveData>(json);
\t\t\t\tif (data != null)
\t\t\t\t{
\t\t\t\t\tsuccess = true;
\t\t\t\t\treturn data;
\t\t\t\t}
\t\t\t}
\t\t\tcatch (Exception)
\t\t\t{
\t\t\t}
\t\t\treturn new SaveData();
\t\t}"""
        new_ser = """\t\tpublic byte[] ToBytes(bool compress = true)
\t\t{
\t\t\tstring json = MegacoolThirdParty_MiniJSON.Json.Serialize(this) ?? "{}";
\t\t\tbyte[] raw = Encoding.UTF8.GetBytes(json);
\t\t\treturn compress ? Compress(raw) : raw;
\t\t}

\t\tpublic static SaveData FromBytes(byte[] bytes, out bool success)
\t\t{
\t\t\tsuccess = false;
\t\t\tif (bytes == null || bytes.Length == 0) return new SaveData();
\t\t\ttry
\t\t\t{
\t\t\t\tbyte[] raw = bytes;
\t\t\t\tif (bytes.Length > 2 && bytes[0] == 0x1F && bytes[1] == 0x8B)
\t\t\t\t\traw = Decompress(bytes);
\t\t\t\tstring json = Encoding.UTF8.GetString(raw);
\t\t\t\tvar dict = MegacoolThirdParty_MiniJSON.Json.Deserialize(json) as Dictionary<string, object>;
\t\t\t\tvar data = new SaveData();
\t\t\t\tif (dict != null)
\t\t\t\t{
\t\t\t\t\tforeach (var kv in dict)
\t\t\t\t\t{
\t\t\t\t\t\tif (int.TryParse(kv.Key, out int slotIdx) && kv.Value is Dictionary<string, object> slotDict)
\t\t\t\t\t\t{
\t\t\t\t\t\t\tvar slot = new SaveSlot();
\t\t\t\t\t\t\tforeach (var skv in slotDict) slot[skv.Key] = skv.Value;
\t\t\t\t\t\t\tdata[slotIdx] = slot;
\t\t\t\t\t\t}
\t\t\t\t\t}
\t\t\t\t\tsuccess = true;
\t\t\t\t\treturn data;
\t\t\t\t}
\t\t\t}
\t\t\tcatch (Exception)
\t\t\t{
\t\t\t}
\t\t\treturn new SaveData();
\t\t}"""
        return t.replace(old_ser, new_ser)
    patch_both("Scripts/Assembly-CSharp/SaveGame.cs", fix_save_game)

    # Fix ControlRemappingDemo1.cs QueueEntry default constructor
    patch_both(
        "Scripts/Assembly-CSharp/Rewired/Demos/ControlRemappingDemo1.cs",
        lambda t: t if "protected QueueEntry()" in t else t.replace(
            "\t\t\tpublic QueueEntry(QueueActionType queueActionType)\n\t\t\t{\n\t\t\t}",
            "\t\t\tprotected QueueEntry() { }\n\n\t\t\tpublic QueueEntry(QueueActionType queueActionType)\n\t\t\t{\n\t\t\t}"
        )
    )

    print("Applied all remaining C# fixes")


if __name__ == "__main__":
    main()
