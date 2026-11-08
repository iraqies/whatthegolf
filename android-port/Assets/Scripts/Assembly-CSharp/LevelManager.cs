using System;
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
	private string[] texts = new string[] { "GOLF?", "WHAT?", "PUTT!" };
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
		if (inGameMenu == null)
			inGameMenu = GetComponentInChildren<InGameMenu>(true);
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

		currentLevel = levelData;
		bool onTheSide = levelData.GetWindowType() == LevelData.WindowType.TwoD;
		Color? customColor = levelData.userCustomTransitionColor ? (Color?)levelData.customTransitionColor : null;
		BaseTransitionEffect customEffect = null;
		if (levelData.useCustomTransitionEffect && transition != null && transition.transitionEffects != null)
		{
			int idx = (int)levelData.customTransitionEffectIndex;
			if (idx >= 0 && idx < transition.transitionEffects.Count)
				customEffect = transition.transitionEffects[idx];
		}

		if (!skipTransitionIn && transition != null)
		{
			string startText = null;
			if (onTheSide != wasLastPlayedLevelOnTheSide && levelData.isShowingFlipText && texts != null && texts.Length > 0)
			{
				startText = texts[textIndex % texts.Length];
				textIndex = (textIndex + 1) % texts.Length;
			}
			yield return StartCoroutine(transition.StartTransition(startText, onTheSide, 0f, null, customColor, null, false, false, false, customEffect));
		}

		if (inGameMenu != null)
		{
			if (showStrokeCounter)
			{
				inGameMenu.SetStrokeCounterSettings(StrokeCounterType, false);
				if (multiplayerConfiguration == null)
					inGameMenu.ResetStrokes(strokesFromPreviousLevels);
			}
			else
			{
				inGameMenu.ToggleStrokeCounter(false);
			}
			inGameMenu.ToggleLookUp(false);
		}

		onTransitionCoverBefore?.Invoke();
		if (onTransitionBeforeCoroutine != null)
			yield return StartCoroutine(onTransitionBeforeCoroutine);

		bool keepPlaying = true;
		bool shouldLoadScene = true;
		Level loadedLevel = null;

		while (keepPlaying)
		{
			keepPlaying = false;
			if (shouldLoadScene)
			{
				yield return StartCoroutine(LoadLevel(levelData, discardLoadedScenes, l => loadedLevel = l, multiplayerConfiguration));
				onLevelLoaded?.Invoke(levelData);
				m_OnLevelLoaded?.Invoke(levelData);
			}
			else if (loadedLevel != null)
			{
				loadedLevel.ResetLevel();
			}

			if (inGameMenu != null)
			{
				inGameMenu.ShowMenu();
				inGameMenu.OnAbandonButtonClicked = () => OnAbandon(loadedLevel);
				inGameMenu.OnRestartButtonClicked = () => OnRestart(loadedLevel);
				inGameMenu.ToggleExitButton(!disableExitButton);
				inGameMenu.ToggleRestartButton(!disableRestartButton);
				inGameMenu.ActivateMenu();
			}

			if (transition != null && transition.IsShowing)
				yield return StartCoroutine(transition.EndTransition());

			Level.State finalState = Level.State.NotPlaying;
			if (loadedLevel != null)
			{
				yield return StartCoroutine(loadedLevel.Play(s => finalState = s));
			}

			if (finalState is Level.CompletedState cs)
			{
				levelData.IsCompletedInSaveGame = true;
				m_OnLevelComplete?.Invoke();
				onComplete?.Invoke(cs);
				keepPlaying = false;

				if (!skipTransitionOut && transition != null)
				{
					string winText = null;
					if (!hideLevelCompletionText)
					{
						winText = !string.IsNullOrEmpty(cs.Message) ? cs.Message : levelData.GetCompletionTextID();
					}
					yield return StartCoroutine(transition.StartTransition(winText, onTheSide, cs.Delay, null, customColor, cs.TransitionTextEffect, false, false, false, customEffect));
				}
			}
			else if (finalState is Level.FailState fs)
			{
				onFail?.Invoke(fs);
				if (alwaysReloadOnFail || fs.DoReload)
				{
					keepPlaying = true;
					shouldLoadScene = fs.DoReload;
					if (fs.ShowTransition && transition != null)
					{
						string failMsg = !string.IsNullOrEmpty(fs.Message) ? fs.Message : null;
						yield return StartCoroutine(transition.StartTransition(failMsg, onTheSide, fs.Delay, null, customColor, null, false, false, false, customEffect));
					}
					if (shouldLoadScene)
						yield return StartCoroutine(UnloadLevel(levelData));
				}
				else if (!skipTransitionOut && transition != null)
				{
					string failMsg = !string.IsNullOrEmpty(fs.Message) ? fs.Message : null;
					yield return StartCoroutine(transition.StartTransition(failMsg, onTheSide, fs.Delay, null, customColor, null, false, false, false, customEffect));
				}
			}
			else if (finalState is Level.RestartState rs)
			{
				onRestart?.Invoke(rs);
				keepPlaying = true;
				shouldLoadScene = true;
				if (transition != null)
					yield return StartCoroutine(transition.StartTransition(null, onTheSide, 0f, null, customColor, null, false, false, false, customEffect));
				yield return StartCoroutine(UnloadLevel(levelData));
			}
			else
			{
				onAbort?.Invoke();
				keepPlaying = false;
				if (!skipTransitionOut && transition != null)
					yield return StartCoroutine(transition.StartTransition(null, onTheSide, 0f, null, customColor, null, false, false, false, customEffect));
			}
		}

		if (inGameMenu != null)
		{
			inGameMenu.DisableMenu();
			inGameMenu.HideMenu();
			if (resetStrokesWhenFinished)
				inGameMenu.ResetStrokes(0);
			inGameMenu.ToggleLookUp(false);
		}

		if (finalStateIsCompleted(loadedLevel) && onTransitionAfterCoroutineIfComplete != null)
			yield return StartCoroutine(onTransitionAfterCoroutineIfComplete);

		onTransitionCoverAfter?.Invoke(true);
		wasLastPlayedLevelOnTheSide = onTheSide;
		SaveGame.Save();
		yield return StartCoroutine(UnloadLevel(levelData));

		if (!skipTransitionOut && transition != null)
			yield return StartCoroutine(transition.EndTransition());
	}

	private bool finalStateIsCompleted(Level lvl) => true;

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
