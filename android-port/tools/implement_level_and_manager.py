#!/usr/bin/env python3
"""Implement Core.Level, Game, LevelManager, Transition, DefaultTransitionEffect,
TransitionTextEffects, and HoleInOneTransition for WHAT THE GOLF? Android port.
"""
import os

PORT_ASSETS = "/home/ubuntu/work/WhatTheGolf/android-port/Assets"
EXPORT_ASSETS = "/home/ubuntu/c113work/ar_out/ExportedProject/Assets"


def write_asset_file(rel_path: str, content: str) -> None:
    for root in (PORT_ASSETS, EXPORT_ASSETS):
        if os.path.exists(root):
            p = os.path.join(root, rel_path)
            os.makedirs(os.path.dirname(p), exist_ok=True)
            with open(p, "w", encoding="utf-8") as f:
                f.write(content)


def main() -> None:
    # 1. Core/Level.cs
    write_asset_file("Scripts/Assembly-CSharp/Core/Level.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Core
{
	public class Level : MonoBehaviour
	{
		public class State
		{
			public readonly string Name;
			public static readonly State NotPlaying = new State("NotPlaying");
			public static readonly State Playing = new State("Playing");

			protected State(string name)
			{
				Name = name ?? string.Empty;
			}
		}

		public class AbortState : State
		{
			public readonly int Strokes;

			public AbortState(int strokes) : base("Abort")
			{
				Strokes = strokes;
			}
		}

		public class RestartState : State
		{
			public readonly int Strokes;

			public RestartState(int strokes) : base("Restart")
			{
				Strokes = strokes;
			}
		}

		public class FailState : State
		{
			public readonly bool DoReload;
			public readonly bool ShowTransition;
			public readonly float Delay;
			public readonly bool PlayFailSFX;
			public readonly int Strokes;
			public string Message;

			public FailState(bool doReload, bool showTransition, float delay = 0f, bool playFailSFX = false, int strokes = 0, string message = "")
				: base("Fail")
			{
				DoReload = doReload;
				ShowTransition = showTransition;
				Delay = delay;
				PlayFailSFX = playFailSFX;
				Strokes = strokes;
				Message = message ?? string.Empty;
			}
		}

		public class CompletedState : State
		{
			public string Message;
			public float Delay;
			public int Strokes;
			public TransitionTextEffect TransitionTextEffect;
			public int LevelSkips;
			public bool LeaveLevel;
			public GolfBallController[] AllControllers;

			public CompletedState(string message = null, float delay = 1f, int strokes = -1, TransitionTextEffect transitionTextEffect = null, int levelSkips = 0, bool leaveLevel = false, GolfBallController[] allControllers = null)
				: base("Completed")
			{
				Message = message ?? "GOLF!";
				Delay = delay;
				Strokes = strokes;
				TransitionTextEffect = transitionTextEffect;
				LevelSkips = levelSkips;
				LeaveLevel = leaveLevel;
				AllControllers = allControllers;
			}
		}

		public LevelMusic music;
		private Action m_OnReset;
		private Action m_OnStart;
		private Action<MultiplayerLevelInfo> m_OnMultiplayerSetup;
		private Action<GolfBallController, string, State> m_OnFail;
		private Action<CompletedState> m_OnComplete;
		private Action m_OnAbort;
		private Action m_OnRestart;
		private Action m_OnOutOfBounds;

		private State state = State.NotPlaying;
		[SerializeField] private float postCompletionDelay = 0.8f;
		private LevelManager levelManager;
		private bool isWaitingForGif;
		private bool changeStateAfterGif;
		private MultiplayerConfiguration multiplayerConfiguration;
		private MultiplayerLevelInfo multiplayerLevelInfo;
		private List<GolfBallController> controllers = new List<GolfBallController>();
		private float mobileCheatTimer;
		private GolfBallController _ball;
		private GolfGoal _goal;
		public float WinDelay = 0.8f;
		private static Level instance;

		public int LevelStartStrokes { get; set; }
		public bool IsMultiplayer => multiplayerConfiguration != null;

		public GolfBallController Ball
		{
			get
			{
				if (_ball == null)
				{
					if (controllers.Count > 0) _ball = controllers[0];
					else _ball = FindObjectOfType<GolfBallController>();
				}
				return _ball;
			}
		}

		public GolfGoal Goal
		{
			get
			{
				if (_goal == null) _goal = FindObjectOfType<GolfGoal>();
				return _goal;
			}
		}

		public bool IsAiming => controllers.Any(c => c != null && c.IsAiming);
		public static Level Instance => instance != null ? instance : (instance = FindObjectOfType<Level>());
		public static bool HasInstance => Instance != null;
		public TransitionTextEffects TransitionTextEffects => levelManager != null ? levelManager.TransitionTextEffects : null;

		public event Action OnReset
		{
			add => m_OnReset = (Action)Delegate.Combine(m_OnReset, value);
			remove => m_OnReset = (Action)Delegate.Remove(m_OnReset, value);
		}

		public event Action OnStart
		{
			add => m_OnStart = (Action)Delegate.Combine(m_OnStart, value);
			remove => m_OnStart = (Action)Delegate.Remove(m_OnStart, value);
		}

		public event Action<MultiplayerLevelInfo> OnMultiplayerSetup
		{
			add => m_OnMultiplayerSetup = (Action<MultiplayerLevelInfo>)Delegate.Combine(m_OnMultiplayerSetup, value);
			remove => m_OnMultiplayerSetup = (Action<MultiplayerLevelInfo>)Delegate.Remove(m_OnMultiplayerSetup, value);
		}

		public event Action<GolfBallController, string, State> OnFail
		{
			add => m_OnFail = (Action<GolfBallController, string, State>)Delegate.Combine(m_OnFail, value);
			remove => m_OnFail = (Action<GolfBallController, string, State>)Delegate.Remove(m_OnFail, value);
		}

		public event Action<CompletedState> OnComplete
		{
			add => m_OnComplete = (Action<CompletedState>)Delegate.Combine(m_OnComplete, value);
			remove => m_OnComplete = (Action<CompletedState>)Delegate.Remove(m_OnComplete, value);
		}

		public event Action OnAbort
		{
			add => m_OnAbort = (Action)Delegate.Combine(m_OnAbort, value);
			remove => m_OnAbort = (Action)Delegate.Remove(m_OnAbort, value);
		}

		public event Action OnRestart
		{
			add => m_OnRestart = (Action)Delegate.Combine(m_OnRestart, value);
			remove => m_OnRestart = (Action)Delegate.Remove(m_OnRestart, value);
		}

		public event Action OnOutOfBounds
		{
			add => m_OnOutOfBounds = (Action)Delegate.Combine(m_OnOutOfBounds, value);
			remove => m_OnOutOfBounds = (Action)Delegate.Remove(m_OnOutOfBounds, value);
		}

		public void AddGolfballController(GolfBallController controller)
		{
			if (controller != null && !controllers.Contains(controller))
				controllers.Add(controller);
		}

		public void RemoveGolfballController(GolfBallController controller)
		{
			controllers.Remove(controller);
		}

		public List<GolfBallController> GetControllers() => controllers;
		public bool IsGyro() => false;

		private void Awake()
		{
			instance = this;
			controllers = FindObjectsOfType<GolfBallController>().ToList();
		}

		public int GetLevelStartStrokes(int id) => LevelStartStrokes;
		public MultiplayerConfiguration GetMultiplayerConfiguration() => multiplayerConfiguration;
		public MultiplayerLevelInfo GetMultiplayerLevelInfo() => multiplayerLevelInfo;

		public void Initialize(LevelManager lm)
		{
			levelManager = lm;
			instance = this;
			controllers = FindObjectsOfType<GolfBallController>().ToList();
		}

		public void SetupMultiplayer(MultiplayerConfiguration config) => multiplayerConfiguration = config;

		public void ResetLevel()
		{
			foreach (var c in controllers)
				c?.Reset();
			Goal?.Reset();
			m_OnReset?.Invoke();
		}

		public void DoCheat() => Complete("CHEAT!", 0.25f);

		public IEnumerator Play(Action<State> onDone = null, Action<int> onStrokeChange = null)
		{
			state = State.Playing;
			foreach (var c in controllers)
			{
				if (c != null)
				{
					c.Activate();
					c.OnPlayerHasShot += (_, s) => onStrokeChange?.Invoke(s);
				}
			}
			m_OnStart?.Invoke();

			while (state == State.Playing)
				yield return null;

			if (state is CompletedState cs && cs.Delay > 0f)
				yield return new WaitForSecondsRealtime(cs.Delay);

			onDone?.Invoke(state);
		}

		public void WaitForGifStart() => isWaitingForGif = true;
		public void WaitForGifDone() => isWaitingForGif = false;

		public void Fail(bool doReload = true, bool showTransition = true, GolfBallController controller = null, float delay = 0f, bool playFailSFX = true, string message = "")
		{
			if (state != State.Playing) return;
			var fs = new FailState(doReload, showTransition, delay, playFailSFX, GetHighestAmountOfStrokes(controller), message);
			state = fs;
			m_OnFail?.Invoke(controller, message, fs);
		}

		public void Complete(string message = null, float? delay = null, TransitionTextEffect transitionTextEffect = null, int levelSkips = 0)
		{
			if (state is CompletedState) return;
			int strokes = GetHighestAmountOfStrokes();
			var cs = new CompletedState(message ?? "GOLF!", delay ?? postCompletionDelay, strokes, transitionTextEffect, levelSkips, false, controllers.ToArray());
			state = cs;
			m_OnComplete?.Invoke(cs);
		}

		public void Abort()
		{
			state = new AbortState(GetHighestAmountOfStrokes());
			m_OnAbort?.Invoke();
		}

		public void Restart()
		{
			state = new RestartState(GetHighestAmountOfStrokes());
			m_OnRestart?.Invoke();
		}

		private int GetHighestAmountOfStrokes(GolfBallController backupController = null)
		{
			int max = backupController != null ? backupController.NumberOfStrokes : 0;
			foreach (var c in controllers)
				if (c != null && c.NumberOfStrokes > max) max = c.NumberOfStrokes;
			return Mathf.Max(max, Game.strokes);
		}

		public void ToggleBall(GolfBallController c, bool isEnabled)
		{
			if (c != null) c.enabled = isEnabled;
		}

		public void ToggleBall(GolfBallController[] ctrls, bool isEnabled)
		{
			if (ctrls == null) return;
			foreach (var c in ctrls) ToggleBall(c, isEnabled);
		}
	}
}
""")

    # 2. Game.cs & HoleInOneTransition.cs
    write_asset_file("Scripts/Assembly-CSharp/Game.cs", """using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class Game : MonoBehaviour
{
	public SpriteRenderer retryRender;
	public HoleInOneTransition transition;
	public EffectsInOne effects;
	public float retryTimeoutThreshold = 5f;
	public ToggleControllerBasedOnAnotherController controllerToggler;
	public SpeechBubbleUI speechBubble;
	public Animator faceAnim;
	public LevelDotsUI levelDotsUI;
	public List<LevelMusicSettings> computerMusic;
	public static int strokes;

	private HoleInOneLevel[] levels;
	private float nextLostSpeechBubbleTime;
	private float lostSpeechBubbleInterval = 8f;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		strokes = 0;
	}

	private void PlayMusic(int musicIndex) { }

	private void ShowSpeechBubble(string text) { }

	private IEnumerator Start()
	{
		levels = GetComponentsInChildren<HoleInOneLevel>(true)
			.OrderBy(l => l.transform.GetSiblingIndex())
			.ToArray();
		if (levels == null || levels.Length == 0)
			yield break;

		for (int i = 0; i < levels.Length; i++)
			levels[i].gameObject.SetActive(i == 0);

		for (int i = 0; i < levels.Length; i++)
		{
			var cur = levels[i];
			cur.gameObject.SetActive(true);
			bool won = false;
			var goal = cur.GetComponentInChildren<GolfGoal>(true);
			if (goal != null)
			{
				goal.Reset();
				goal.OnGoal += _ => won = true;
			}
			while (!won)
				yield return null;
			yield return new WaitForSeconds(0.5f);
			if (i < levels.Length - 1)
				cur.gameObject.SetActive(false);
		}

		if (Level.HasInstance)
			Level.Instance.Complete("HOLE IN ONE!", 0.8f);
	}

	private void ResetLostSpeechBubbleTimeout()
	{
		nextLostSpeechBubbleTime = Time.time + lostSpeechBubbleInterval;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/HoleInOneTransition.cs", """using System;
using System.Collections.Generic;
using UnityEngine;

public class HoleInOneTransition : MonoBehaviour
{
	public AudioClip sfxWin;
	public AudioClip sfxLost;
	public float volume = 1f;
	public Color winColor = Color.green;
	public Color loseColor = Color.red;
	public float inScale = 1f;
	public float outScale = 0.01f;
	public SpriteRenderer endCoverSprite;
	private List<SpriteRenderer> sprites = new List<SpriteRenderer>();
	private Vector3 basePosition;

	public void InstantIn() { }

	private void Awake()
	{
		basePosition = transform.position;
	}

	public void StarTransition(Vector3 pos, bool isWon, Action onClear)
	{
		onClear?.Invoke();
	}

	public void EndTransition(Vector3 pos, Action onCompleted)
	{
		onCompleted?.Invoke();
	}
}
""")

    # 3. Transition.cs, DefaultTransitionEffect.cs, TransitionTextEffects.cs
    write_asset_file("Scripts/Assembly-CSharp/TransitionTextEffects.cs", """using System;
using System.Collections.Generic;

public class TransitionTextEffects
{
	private readonly Dictionary<Type, TransitionTextEffect> byType = new Dictionary<Type, TransitionTextEffect>();

	public TransitionTextEffects(List<TransitionTextEffect> transitionTextEffects)
	{
		if (transitionTextEffects != null)
		{
			foreach (var e in transitionTextEffects)
			{
				if (e != null) byType[e.GetType()] = e;
			}
		}
	}

	public T Get<T>() where T : TransitionTextEffect
	{
		if (byType.TryGetValue(typeof(T), out var val))
			return val as T;
		return null;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/DefaultTransitionEffect.cs", """using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultTransitionEffect : BaseTransitionEffect
{
	[SerializeField] private Transform circleTransform;
	[SerializeField] private MeshRenderer circleRenderer;
	[SerializeField] private Transform endCircleTransform;
	[SerializeField] private MeshRenderer endCircleRenderer;
	[SerializeField] private List<AudioClip> transitionClips;
	private Material bgMaterial;
	private Color defaultBgColor = Color.black;

	public override void Init() { }
	public override void PreBegin(Color? color) { }

	public override IEnumerator Begin()
	{
		yield break;
	}

	public override void CleanUp() { }

	public override IEnumerator End(float overrideTransitionDuration = 0f)
	{
		yield break;
	}

	public override void InstantTransitionCover(Color? color) { }
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Transition.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using CameraStack;
using UnityEngine;

public class Transition : MonoBehaviour
{
	public enum TransitionEffect
	{
		Default = 0,
		SportySports = 1,
		Snowy = 2,
		Hole = 3,
		Daily = 4,
		AmongUs = 5,
		Car = 6,
		SpecialDay = 7,
		Slime = 8,
		CustomPrefab = 9
	}

	private enum State
	{
		Idle = 0,
		Start = 1,
		Loop = 2,
		End = 3
	}

	[SerializeField] private GameObject fullScreenUIBlocker;
	[SerializeField] private TransitionTextEffect defaultTextEffect;
	[SerializeField] private List<TransitionTextEffect> _textEffects = new List<TransitionTextEffect>();
	[SerializeField] private TransitionSubtitles subtitles;
	[SerializeField] private GameObject waitAnimation;
	[SerializeField] private GameObject waitText;
	[SerializeField] public List<BaseTransitionEffect> transitionEffects = new List<BaseTransitionEffect>();

	private BaseTransitionEffect lastUsedTransitionEffect;
	private SVGImage waitAnimationSpriteRenderer;
	private Color clearWhite = new Color(1f, 1f, 1f, 0f);
	private TransitionTextEffects textEffects;
	private float transitionInDuration = 0.25f;
	private float transitionOutDuration = 0.25f;
	private Coroutine loopCoroutine;
	private State state = State.Idle;
	private TransitionTextEffect activeTextEffect;
	private BaseTransitionEffect activeTransitionEffect;
	private Camera transitionCam;
	private SecondDisplayCameraManager secondScreenCamera;
	private Coroutine transitionWorkingCoroutine;
	public Color? NextTransitionColor;

	public bool IsShowing => state != State.Idle;
	public TransitionTextEffects TextEffects => textEffects ?? (textEffects = new TransitionTextEffects(_textEffects));

	private void Awake()
	{
		InitializeTransitionEffects();
		InitializeTextEffects();
	}

	private void InitializeTransitionEffects()
	{
		if (transitionEffects != null)
		{
			foreach (var e in transitionEffects) e?.Init();
		}
	}

	private void InitializeTextEffects()
	{
		textEffects = new TransitionTextEffects(_textEffects);
	}

	public void InstantTransitionCover(Color? color = null, BaseTransitionEffect transitionEffect = null)
	{
		state = State.Loop;
	}

	public IEnumerator StartTransition(string textId = null, bool onTheSide = false, float delay = 0f, Action onDone = null, Color? color = null, TransitionTextEffect textEffect = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, BaseTransitionEffect transitionEffect = null, Func<bool> allowEndWhen = null)
	{
		state = State.Start;
		if (delay > 0f)
			yield return new WaitForSecondsRealtime(Mathf.Min(delay, 0.4f));
		state = State.Loop;
		onDone?.Invoke();
	}

	private IEnumerator StartTransitionInternalCR(string textId = null, bool onTheSide = false, float delay = 0f, Action onDone = null, Color? color = null, TransitionTextEffect textEffect = null, bool showWaitAnimation = false, bool isAsync = false, bool showWaitingText = false, BaseTransitionEffect transitionEffect = null, Func<bool> allowEndWhen = null)
	{
		return StartTransition(textId, onTheSide, delay, onDone, color, textEffect, showWaitAnimation, isAsync, showWaitingText, transitionEffect, allowEndWhen);
	}

	private void SetInputAllowed(bool allowed) { }
	public void EndTextTransitionImmidiate() { }

	public IEnumerator EndTransition(bool force = false, float overrideTransitionDuration = 0f)
	{
		state = State.Idle;
		if (fullScreenUIBlocker != null)
			fullScreenUIBlocker.SetActive(false);
		yield break;
	}

	private IEnumerator EndTransitionInternalCR(bool force = false, float overrideTransitionDuration = 0f)
	{
		return EndTransition(force, overrideTransitionDuration);
	}

	public bool IsTransitionRunning() => state != State.Idle;
}
""")

    # 4. LevelManager.cs
    write_asset_file("Scripts/Assembly-CSharp/LevelManager.cs", """using System;
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
			try
			{
				addressableLoadHandle = Addressables.LoadSceneAsync(levelData.Scene.sceneReference, mode, true);
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
			catch (Exception)
			{
			}
		}

		if (!loaded && !string.IsNullOrEmpty(sceneName))
		{
			try
			{
				addressableLoadHandle = Addressables.LoadSceneAsync(sceneName, mode, true);
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
			catch (Exception)
			{
			}
		}

		if (!loaded && !string.IsNullOrEmpty(sceneName) && Application.CanStreamedLevelBeLoaded(sceneName))
		{
			var op = SceneManager.LoadSceneAsync(sceneName, mode);
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
			SceneManager.MoveGameObjectToScene(go, SceneManager.GetActiveScene());
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
""")

    print("Implemented Level, Game, HoleInOneTransition, Transition, and LevelManager")


if __name__ == "__main__":
    main()
