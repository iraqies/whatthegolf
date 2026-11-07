using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Audio;
using Audio.Rumble;
using CameraStack;
using Core;
using Hub;
using Puzzle;
using UnityEngine;
using UnityEngine.Events;

public class OverworldManager2d : GolfBehaviour
{
	[Serializable]
	public class SpecialCollectableDoor
	{
		public Collectable Collectable;
		public OverworldButton2D Door;
	}

	public enum STATES
	{
		active = 0,
		inlevel = 1,
		inDialog = 2,
		inAnimation = 3,
		inOnboarding = 4
	}

	private Action<bool> m_OnToggleOverworld;
	private Action<LevelData> m_OnLastFlagExit;
	private Action m_OnShoot;

	[SerializeField] public bool isHub;
	[SerializeField] private SectionManager sectionManager;
	public OverworldLevelData overworldLevelData;
	public ECampaignType overworldType;
	public SectionCulling culling;
	public OverworldUI ui;
	public OverworldBall2D ball;
	public OverworldGoal lastFlag;
	public Transform cameraTarget;
	public List<GameObject> disableWhilePlaying = new List<GameObject>();
	public GridFiller gridfiller;
	public Rigidbody2D gridRigid;
	public float delayAfterHidingTransitionOnStartinInTunnel;
	public bool debugTestLastOnboardingLevel;
	public bool debugWithoutDoors;
	public bool debugWithoutComputersAndBigButtons;
	public LevelDataContainer onboardingLevels;
	public OverworldCamera Camera;
	public IntroTunnelInOverworld introTunnel;
	public Action<OverworldGoal, bool> OnlevelCompleted;
	public Action<OverworldGoal> OnlevelAbandoned;
	public Action<List<LevelData>> OnLevelStarting;
	public List<SpecialCollectableDoor> CollectableDoors = new List<SpecialCollectableDoor>();
	public Transition deathTransition;
	public WinCrownEffect CrownWonEffect;
	public UncompletedFlagScanner FlagScanner;
	[SerializeField] public List<OverworldGoal> goals = new List<OverworldGoal>();

	private Vector3 ballStartPosition;
	private OverworldGoal currentGoal;
	private OverworldArea currentArea;
	[SerializeField] private List<OverworldButton2D> allButtons = new List<OverworldButton2D>();
	[SerializeField] private List<OverworldOLButton2D> OLButtons = new List<OverworldOLButton2D>();
	[SerializeField] private List<OverworldSecretWall> allSecrets = new List<OverworldSecretWall>();
	[SerializeField] private List<OverworldMainButton> allOverworldMainButton = new List<OverworldMainButton>();
	[SerializeField] private List<SimplePortal> allOverworldPortals = new List<SimplePortal>();
	[SerializeField] private List<OverworldMainDoorRobot> allOverworldRobots = new List<OverworldMainDoorRobot>();
	[SerializeField] private List<PuzzleCompletedGate> allPuzzleDoors = new List<PuzzleCompletedGate>();
	[SerializeField] private List<ResetOnInvisible> allResetProps = new List<ResetOnInvisible>();

	private STATES state = STATES.active;
	public bool isComingFromLoaderScene;
	private float overworldActiveTime;
	private float onboardingActiveTime;
	private Dictionary<string, float> levelActiveTime = new Dictionary<string, float>();
	public OverworldMusic overworldMusic;
	[SerializeField] private OverworldMusicData musicOverworldStart;
	public bool canStartAtLogoWhenStartingOverworld;
	[SerializeField] private RandomAudioClips clearLevelClips;
	[SerializeField] private RandomAudioClips clearLevelCrownClips;
	[SerializeField] private RandomAudioClips flagHitFirstPlayClips;
	[SerializeField] private RandomAudioClips flagHitClips;
	[SerializeField] private RumbleEventAsset rumbleEventAssetFlagCompleted;
	[SerializeField] private RumbleEventAsset rumbleEventAssetFlagNotCompleted;

	private LevelManager levelManager;
	private AudioManager audioManager;
	private float timeForLastTransitionJingle;
	private GarbageCollectorManager GarbageCollector;
	private int mainCameraCullingMask;
	private QuickMenu quickMenu;
	public int NumFailsInLastLevel;
	private static OverworldManager2d instance;

	public STATES State => state;
	public OverworldMusicData m_music { get; set; }
	public bool IsIntroAnimationComplete { get; private set; } = true;
	public bool IsOverworldPlaying => state == STATES.active;
	public bool IsInteractionDisabled { get; private set; }
	private OverworldBall2D BallOrIslandBall => ball != null ? ball : (ball = FindObjectOfType<OverworldBall2D>());
	public static OverworldManager2d Instance => instance != null ? instance : (instance = FindObjectOfType<OverworldManager2d>());
	public static bool HasInstance => Instance != null;

	public event Action<bool> OnToggleOverworld
	{
		add => m_OnToggleOverworld = (Action<bool>)Delegate.Combine(m_OnToggleOverworld, value);
		remove => m_OnToggleOverworld = (Action<bool>)Delegate.Remove(m_OnToggleOverworld, value);
	}

	public event Action<LevelData> OnLastFlagExit
	{
		add => m_OnLastFlagExit = (Action<LevelData>)Delegate.Combine(m_OnLastFlagExit, value);
		remove => m_OnLastFlagExit = (Action<LevelData>)Delegate.Remove(m_OnLastFlagExit, value);
	}

	public event Action OnShoot
	{
		add => m_OnShoot = (Action)Delegate.Combine(m_OnShoot, value);
		remove => m_OnShoot = (Action)Delegate.Remove(m_OnShoot, value);
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		instance = null;
	}

	public bool CanLoadLevel() => state == STATES.active;
	public override void OnPrePlayOrPreCompile() { }
	public void PostPrcompile() { }
	public void PrePrcompile() { }

	private void Awake()
	{
		instance = this;
		SaveGame.SetOverworld(overworldType);
		if (ball == null) ball = FindObjectOfType<OverworldBall2D>();
		if (Camera == null) Camera = FindObjectOfType<OverworldCamera>();
		if (goals == null || goals.Count == 0)
			goals = FindObjectsOfType<OverworldGoal>().ToList();
	}

	private void Undocking_OnDockingStateChanged(bool isDocked) { }
	private void RemoveNullsFromList<T>(List<T> list) => list?.RemoveAll(x => x == null);
	private bool IsPrecompiledListsOk() => true;

	private IEnumerator Start()
	{
		if (ball != null)
		{
			ball.Init();
			ballStartPosition = ball.transform.position;
			ball.ShowAndEnable();
			if (ball.Controller != null)
				ball.Controller.Activate();
		}
		RefreshDoorsAndGoals();
		if (LevelManager.Exists)
			yield return LevelManager.Instance.EndTransition(true);
	}

	public void RefreshDoorsAndGoals()
	{
		if (goals != null)
		{
			foreach (var g in goals)
				g?.ReloadData();
		}
	}

	public static void ActivateParticleSystems(Transform root) { }
	private void RestOverworldProps() { }
	private void BallMananger_OnDeath(OverworldBall2D b) { }
	private IEnumerator DeathRoutine() { yield break; }

	public void RegisterBall(OverworldBall2D _ball, Transmogrif.BALLSHAPES newShape)
	{
		ball = _ball;
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape) { }
	private void Mainbutton_OnPressed(OverworldMainButton button) { }
	private IEnumerator MainButtonPressRoutine(OverworldMainButton button) { yield break; }
	private IEnumerator StartOverworldMusicDelayed(float delay) { yield break; }
	private IEnumerator PlayIntroAnimation() { yield break; }
	private void Update() { }
	private IEnumerator ShowBallDelayed(OverworldGoal goalHit) { yield break; }
	public void StartMusicWithoutTransition() { }

	private void ReturnToOverworld(List<LevelData> levelData, bool isCompleted, List<Level.CompletedState> completeState, OverworldGoal goalHit, bool clearPlayAgainDialog = true, OverworldBall2D ballThatHit = null, List<Level.FailState> failStates = null)
	{
		ToggleOverworld(true);
		RefreshDoorsAndGoals();
	}

	private void Maindoor_OnEnter(OverworldMainDoorRobot door, Vector3 pos, Action<bool> shouldPlayLevel)
	{
		shouldPlayLevel?.Invoke(true);
	}

	private void Goal_CrownWon(OverworldGoal goal) { }
	private void AskAboutReviewAndNotifications(OverworldGoal goal, int numFails = 0) { }

	public void Goal_OnHit(OverworldGoal goal, Vector3 hitPos, OverworldBall2D ballHit, bool forceBallOn = false)
	{
		if (goal == null || state != STATES.active) return;
		currentGoal = goal;
		StopBallNextToFlag(goal, hitPos);
		if (goal.levelData != null)
		{
			StartCoroutine(StartGoalLevel(goal, null, ballHit));
		}
	}

	private Vector3 GetSafeBallPosition(OverworldGoal goal, Vector3 hitPos)
	{
		if (goal == null) return hitPos;
		Vector3 dir = (hitPos - goal.transform.position).normalized;
		if (dir.sqrMagnitude < 1e-4f) dir = Vector3.down;
		return goal.transform.position + dir * 1.5f;
	}

	private void StopBallNextToFlag(OverworldGoal goal, Vector3 hitPos)
	{
		if (ball != null)
		{
			ball.StopBall(false);
			ball.transform.position = GetSafeBallPosition(goal, hitPos);
		}
	}

	private IEnumerator SetLevelMusicRoutine(LevelMusicSettings music, Action onLoaded)
	{
		onLoaded?.Invoke();
		yield break;
	}

	public void ChangeStateToInLevel() => state = STATES.inlevel;

	public IEnumerator StartBossLevel(LevelData level, Action<bool> callback)
	{
		if (level != null && LevelManager.Instance != null)
		{
			ToggleOverworld(false);
			bool won = false;
			yield return LevelManager.Instance.Play(level, onComplete: _ => won = true);
			ToggleOverworld(true);
			callback?.Invoke(won);
		}
	}

	public void ToggleOverworld(bool isOverworldActive)
	{
		state = isOverworldActive ? STATES.active : STATES.inlevel;
		if (disableWhilePlaying != null)
		{
			foreach (var go in disableWhilePlaying)
				if (go != null) go.SetActive(isOverworldActive);
		}
		if (ball != null)
		{
			if (isOverworldActive) ball.ShowAndEnable();
			else ball.HideAndStop();
		}
		m_OnToggleOverworld?.Invoke(isOverworldActive);
	}

	private IEnumerator StartGoalLevel(OverworldGoal goal, string challengeID, OverworldBall2D ballHit = null, UnityAction<bool> afterLevelCallback = null)
	{
		if (goal == null || goal.levelData == null) yield break;
		ToggleOverworld(false);
		bool completed = false;
		yield return LevelManager.Instance.Play(
			goal.levelData,
			challengeID: challengeID,
			onComplete: _ => completed = true
		);
		ToggleOverworld(true);
		goal.ReloadData();
		if (completed)
			OnlevelCompleted?.Invoke(goal, true);
		else
			OnlevelAbandoned?.Invoke(goal);
		afterLevelCallback?.Invoke(completed);
	}

	public void DisplayCampaignHub(bool display) { }

	public void ResetBallPositionToLastSave()
	{
		if (ball != null) ball.transform.position = ballStartPosition;
	}

	private IEnumerator CameraMoveCenter(Transform target, float time) { yield break; }
	private IEnumerator CameraMoveDuringTransition(bool zoomIn, Transform target = null) { yield break; }

	public void SaveBallStartPosition(Vector3 position) => ballStartPosition = position;
	private void NotifyOnShoot(Vector3 boost) => m_OnShoot?.Invoke();
	public HubSection FindCurrentHubSection() => FindObjectOfType<HubSection>();

	public void DisableInteraction(bool hide = true) => IsInteractionDisabled = true;
	public void EnableInteraction() => IsInteractionDisabled = false;

	private void OnDestroy()
	{
		if (instance == this) instance = null;
	}
}
