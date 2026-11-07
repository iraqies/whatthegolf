using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Core
{
	public class Level : MonoBehaviour
	{
		public class State
		{
			public readonly string Name;

			public static readonly State NotPlaying;

			public static readonly State Playing;

			protected State(string name)
			{
			}
		}

		public class AbortState : State
		{
			public readonly int Strokes;

			public AbortState(int strokes)
				: base(null)
			{
			}
		}

		public class RestartState : State
		{
			public readonly int Strokes;

			public RestartState(int strokes)
				: base(null)
			{
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
				: base(null)
			{
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
				: base(null)
			{
			}
		}

		public LevelMusic music;

		[CompilerGenerated]
		private Action m_OnReset;

		[CompilerGenerated]
		private Action m_OnStart;

		[CompilerGenerated]
		private Action<MultiplayerLevelInfo> m_OnMultiplayerSetup;

		[CompilerGenerated]
		private Action<GolfBallController, string, State> m_OnFail;

		[CompilerGenerated]
		private Action<CompletedState> m_OnComplete;

		[CompilerGenerated]
		private Action m_OnAbort;

		[CompilerGenerated]
		private Action m_OnRestart;

		private State state;

		[SerializeField]
		private float postCompletionDelay;

		private LevelManager levelManager;

		private bool isWaitingForGif;

		private bool changeStateAfterGif;

		private MultiplayerConfiguration multiplayerConfiguration;

		private MultiplayerLevelInfo multiplayerLevelInfo;

		private List<GolfBallController> controllers;

		private float mobileCheatTimer;

		[CompilerGenerated]
		private Action m_OnOutOfBounds;

		private GolfBallController _ball;

		private GolfGoal _goal;

		public float WinDelay;

		private static Level instance;

		public int LevelStartStrokes { get; set; }

		public bool IsMultiplayer => false;

		public GolfBallController Ball => null;

		public GolfGoal Goal => null;

		public bool IsAiming => false;

		public static Level Instance => null;

		public static bool HasInstance => false;

		public TransitionTextEffects TransitionTextEffects => null;

		public event Action OnReset
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

		public event Action OnStart
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

		public event Action<MultiplayerLevelInfo> OnMultiplayerSetup
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

		public event Action<GolfBallController, string, State> OnFail
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

		public event Action<CompletedState> OnComplete
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

		public event Action OnAbort
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

		public event Action OnRestart
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

		public event Action OnOutOfBounds
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

		public void AddGolfballController(GolfBallController controller)
		{
		}

		public void RemoveGolfballController(GolfBallController controller)
		{
		}

		public List<GolfBallController> GetControllers()
		{
			return null;
		}

		public bool IsGyro()
		{
			return false;
		}

		private void Awake()
		{
		}

		public int GetLevelStartStrokes(int id)
		{
			return 0;
		}

		public MultiplayerConfiguration GetMultiplayerConfiguration()
		{
			return null;
		}

		public MultiplayerLevelInfo GetMultiplayerLevelInfo()
		{
			return null;
		}

		public void Initialize(LevelManager levelManager)
		{
		}

		public void SetupMultiplayer(MultiplayerConfiguration config)
		{
		}

		public void ResetLevel()
		{
		}

		public void DoCheat()
		{
		}

		public IEnumerator Play(Action<State> onDone = null, Action<int> onStrokeChange = null)
		{
			return null;
		}

		public void WaitForGifStart()
		{
		}

		public void WaitForGifDone()
		{
		}

		public void Fail(bool doReload = true, bool showTransition = true, GolfBallController controller = null, float delay = 0f, bool playFailSFX = true, string message = "")
		{
		}

		public void Complete(string message = null, float? delay = null, TransitionTextEffect transitionTextEffect = null, int levelSkips = 0)
		{
		}

		public void Abort()
		{
		}

		public void Restart()
		{
		}

		private int GetHighestAmountOfStrokes(GolfBallController backupController = null)
		{
			return 0;
		}

		public void ToggleBall(GolfBallController c, bool isEnabled)
		{
		}

		public void ToggleBall(GolfBallController[] controllers, bool isEnabled)
		{
		}
	}
}
