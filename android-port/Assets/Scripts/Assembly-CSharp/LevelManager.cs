using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Core;
using Menu;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.SceneManagement;

public class LevelManager : AddressableSingleton<LevelManager>
{
	[SerializeField]
	private InGameMenu inGameMenu;

	public Transition transition;

	[SerializeField]
	private LevelData missingLevel;

	[SerializeField]
	private AntialisingQualityAdjuster antialisingQualityAdjuster;

	[SerializeField]
	public SwitchUndockMessage undocking;

	public Action ReturnToOverworld;

	[CompilerGenerated]
	private Action m_OnLevelWillUnload;

	[CompilerGenerated]
	private Action<LevelData> m_OnLevelLoaded;

	[CompilerGenerated]
	private Action m_OnLevelComplete;

	[CompilerGenerated]
	private Action<string> m_ChallengeSelected;

	private bool hasLoadedAnyLevel;

	public GarbageCollectorManager garbageManager;

	private bool wasLastPlayedLevelOnTheSide;

	private LevelData currentLevel;

	private bool isReallyInLevel;

	private static object _lock;

	private static bool applicationIsQuitting;

	public bool goToLevelOnLoad;

	private int textIndex;

	private string[] texts;

	private float time;

	private AsyncOperationHandle<SceneInstance> addressableLoadHandle;

	public bool getIsReallyInLevel => false;

	public bool HasLoadedAnyLevel => false;

	public InGameMenu InGameMenu => null;

	public TransitionTextEffects TransitionTextEffects => null;

	public event Action OnLevelWillUnload
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<LevelData> OnLevelLoaded
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action OnLevelComplete
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event Action<string> ChallengeSelected
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void Initialize()
	{
	}

	private void HandleSteamOverlayActivated(bool active)
	{
	}

	public IEnumerator Play(LevelData levelData, Action onTransitionCoverBefore = null, IEnumerator onTransitionBeforeCoroutine = null, IEnumerator onTransitionAfterCoroutineIfComplete = null, Action<LevelData> onLevelLoaded = null, Action<Level.CompletedState> onComplete = null, Action<Level.FailState> onFail = null, Action<Level.RestartState> onRestart = null, Action onAbort = null, Action<bool> onTransitionCoverAfter = null, bool discardLoadedScenes = false, bool countStrokesAndTime = true, bool skipTransitionIn = false, bool skipTransitionOut = false, int strokesFromPreviousLevels = 0, bool resetStrokesWhenFinished = true, bool disableRestartButton = false, bool disableExitButton = false, bool showStrokeCounter = false, string challengeID = null, bool alwaysReloadOnFail = false, Func<bool> addStrokesOnFailToStrokesFromPreviousLevels = null, bool hideLevelCompletionText = false, MultiplayerConfiguration multiplayerConfiguration = null, StrokeCounter.CounterTypes StrokeCounterType = StrokeCounter.CounterTypes.CardsAppearing)
	{
		return null;
	}

	internal void SetDailyTransitionEffect(TransitionColorDefinition transitionColors)
	{
	}

	internal void SetSpecialDayTransitionEffect(DailyChallengeLevelDataContainer pack, out BaseTransitionEffect customTransitionEffect)
	{
		customTransitionEffect = null;
	}

	private void OnAbandon(Level level)
	{
	}

	private void OnRestart(Level level)
	{
	}

	public bool IsInLevel()
	{
		return false;
	}

	private void ResetState()
	{
	}

	private IEnumerator LoadLevel(LevelData levelData, bool discardLoadedScenes, Action<Level> onComplete, MultiplayerConfiguration config = null)
	{
		return null;
	}

	public void UnloadLevelEvent()
	{
	}

	private IEnumerator UnloadLevel(LevelData levelData)
	{
		return null;
	}

	private void SceneManagerOnSceneLoaded(Scene newScene, LoadSceneMode loadSceneMode)
	{
	}

	public IEnumerator SwapTranstion(Color? color = null, string textId = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, Transition.TransitionEffect customTransitionEffectIndex = Transition.TransitionEffect.Default)
	{
		return null;
	}

	public IEnumerator StartTransition(Color? color = null, string textId = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, Transition.TransitionEffect customTransitionEffectIndex = Transition.TransitionEffect.Default, BaseTransitionEffect customTransitionEffect = null)
	{
		return null;
	}

	public void InstantTransitionCover(Color? color = null)
	{
	}

	public IEnumerator EndTransition(bool force = false, float overrideTransitionDuration = 0f)
	{
		return null;
	}

	public void ToggleTransitions()
	{
	}

	public bool IsTransitionActive()
	{
		return false;
	}

	public LevelData GetCurrentLevelData()
	{
		return null;
	}

	public void OverwriteNextTransitionColor(Color color)
	{
	}

	private void OnDestroy()
	{
	}
}
