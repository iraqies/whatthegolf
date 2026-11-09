using System;
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
				Message = message;
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
		public static Level Instance => instance;
		public static bool HasInstance => instance != null;
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
			if (music == null) music = GetComponent<LevelMusic>() ?? FindObjectOfType<LevelMusic>();
			if (music != null) music.InitializeForCurrentLevel(Goal, Ball, this);
		}

		public int GetLevelStartStrokes(int id) => LevelStartStrokes;
		public MultiplayerConfiguration GetMultiplayerConfiguration() => multiplayerConfiguration;
		public MultiplayerLevelInfo GetMultiplayerLevelInfo() => multiplayerLevelInfo;

		public void Initialize(LevelManager lm)
		{
			levelManager = lm;
			instance = this;
			controllers = FindObjectsOfType<GolfBallController>().ToList();
			if (music == null) music = GetComponent<LevelMusic>() ?? FindObjectOfType<LevelMusic>();
			if (music != null) music.InitializeForCurrentLevel(Goal, Ball, this);
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
			changeStateAfterGif = false;
			foreach (var c in controllers)
			{
				if (c != null)
				{
					c.Activate();
					c.OnPlayerHasShot += (_, s) => onStrokeChange?.Invoke(s);
				}
			}
			m_OnStart?.Invoke();

			while (state == State.Playing || isWaitingForGif)
				yield return null;

			if (state is CompletedState cs)
			{
				m_OnComplete?.Invoke(cs);
			}
			else if (state is FailState fs)
			{
				m_OnFail?.Invoke(Ball, fs.Message, fs);
				m_OnOutOfBounds?.Invoke();
			}

			State finalState = state;
			state = State.NotPlaying;
			onDone?.Invoke(finalState);
			if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
				LevelManager.Instance.InGameMenu.DisableMenu();
		}

		public void WaitForGifStart() => isWaitingForGif = true;
		public void WaitForGifDone() => isWaitingForGif = false;

		public void Fail(bool doReload = true, bool showTransition = true, GolfBallController controller = null, float delay = 0f, bool playFailSFX = true, string message = "")
		{
			if (IsMultiplayer && multiplayerLevelInfo != null && controller != null)
			{
				controller.Reset(0f);
				return;
			}
			if (state is FailState) return;
			var fs = new FailState(doReload, showTransition, delay, playFailSFX, GetHighestAmountOfStrokes(controller), message);
			state = fs;
		}

		public void Complete(string message = null, float? delay = null, TransitionTextEffect transitionTextEffect = null, int levelSkips = 0)
		{
			if (state is CompletedState) return;
			int strokes = GetHighestAmountOfStrokes();
			float actualDelay = delay ?? postCompletionDelay;
			var cs = new CompletedState(message, actualDelay, strokes, transitionTextEffect, levelSkips, false, controllers.ToArray());
			state = cs;
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
