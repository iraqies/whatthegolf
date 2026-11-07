using System;
using System.Collections;
using System.Collections.Generic;
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

	[CompilerGenerated]
	private Action<bool> m_OnToggleOverworld;

	[CompilerGenerated]
	private Action<LevelData> m_OnLastFlagExit;

	[SerializeField]
	public bool isHub;

	[SerializeField]
	private SectionManager sectionManager;

	public OverworldLevelData overworldLevelData;

	public ECampaignType overworldType;

	public SectionCulling culling;

	public OverworldUI ui;

	public OverworldBall2D ball;

	public OverworldGoal lastFlag;

	public Transform cameraTarget;

	public List<GameObject> disableWhilePlaying;

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

	public List<SpecialCollectableDoor> CollectableDoors;

	public Transition deathTransition;

	[CompilerGenerated]
	private Action m_OnShoot;

	public WinCrownEffect CrownWonEffect;

	public UncompletedFlagScanner FlagScanner;

	[SerializeField]
	public List<OverworldGoal> goals;

	private Vector3 ballStartPosition;

	private OverworldGoal currentGoal;

	private OverworldArea currentArea;

	[SerializeField]
	private List<OverworldButton2D> allButtons;

	[SerializeField]
	private List<OverworldOLButton2D> OLButtons;

	[SerializeField]
	private List<OverworldSecretWall> allSecrets;

	[SerializeField]
	private List<OverworldMainButton> allOverworldMainButton;

	[SerializeField]
	private List<SimplePortal> allOverworldPortals;

	[SerializeField]
	private List<OverworldMainDoorRobot> allOverworldRobots;

	[SerializeField]
	private List<PuzzleCompletedGate> allPuzzleDoors;

	[SerializeField]
	private List<ResetOnInvisible> allResetProps;

	private STATES state;

	public bool isComingFromLoaderScene;

	private float overworldActiveTime;

	private float onboardingActiveTime;

	private Dictionary<string, float> levelActiveTime;

	public OverworldMusic overworldMusic;

	[SerializeField]
	private OverworldMusicData musicOverworldStart;

	public bool canStartAtLogoWhenStartingOverworld;

	[SerializeField]
	private RandomAudioClips clearLevelClips;

	[SerializeField]
	private RandomAudioClips clearLevelCrownClips;

	[SerializeField]
	private RandomAudioClips flagHitFirstPlayClips;

	[SerializeField]
	private RandomAudioClips flagHitClips;

	[SerializeField]
	private RumbleEventAsset rumbleEventAssetFlagCompleted;

	[SerializeField]
	private RumbleEventAsset rumbleEventAssetFlagNotCompleted;

	private LevelManager levelManager;

	private AudioManager audioManager;

	private float timeForLastTransitionJingle;

	private GarbageCollectorManager GarbageCollector;

	private int mainCameraCullingMask;

	private QuickMenu quickMenu;

	public int NumFailsInLastLevel;

	private static OverworldManager2d instance;

	public STATES State => STATES.active;

	public OverworldMusicData m_music { get; set; }

	public bool IsIntroAnimationComplete { get; private set; }

	public bool IsOverworldPlaying => false;

	public bool IsInteractionDisabled { get; private set; }

	private OverworldBall2D BallOrIslandBall => null;

	public static OverworldManager2d Instance => null;

	public static bool HasInstance => false;

	public event Action<bool> OnToggleOverworld
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

	public event Action<LevelData> OnLastFlagExit
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

	public event Action OnShoot
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

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	public bool CanLoadLevel()
	{
		return false;
	}

	public override void OnPrePlayOrPreCompile()
	{
	}

	public void PostPrcompile()
	{
	}

	public void PrePrcompile()
	{
	}

	private void Awake()
	{
	}

	private void Undocking_OnDockingStateChanged(bool isDocked)
	{
	}

	private void RemoveNullsFromList<T>(List<T> list)
	{
	}

	private bool IsPrecompiledListsOk()
	{
		return false;
	}

	private IEnumerator Start()
	{
		return null;
	}

	public void RefreshDoorsAndGoals()
	{
	}

	public static void ActivateParticleSystems(Transform root)
	{
	}

	private void RestOverworldProps()
	{
	}

	private void BallMananger_OnDeath(OverworldBall2D ball)
	{
	}

	private IEnumerator DeathRoutine()
	{
		return null;
	}

	public void RegisterBall(OverworldBall2D _ball, Transmogrif.BALLSHAPES newShape)
	{
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	private void Mainbutton_OnPressed(OverworldMainButton button)
	{
	}

	private IEnumerator MainButtonPressRoutine(OverworldMainButton button)
	{
		return null;
	}

	private IEnumerator StartOverworldMusicDelayed(float delay)
	{
		return null;
	}

	private IEnumerator PlayIntroAnimation()
	{
		return null;
	}

	private void Update()
	{
	}

	private IEnumerator ShowBallDelayed(OverworldGoal goalHit)
	{
		return null;
	}

	public void StartMusicWithoutTransition()
	{
	}

	private void ReturnToOverworld(List<LevelData> levelData, bool isCompleted, List<Level.CompletedState> completeState, OverworldGoal goalHit, bool clearPlayAgainDialog = true, OverworldBall2D ballThatHit = null, List<Level.FailState> failStates = null)
	{
	}

	private void Maindoor_OnEnter(OverworldMainDoorRobot door, Vector3 pos, Action<bool> shouldPlayLevel)
	{
	}

	private void Goal_CrownWon(OverworldGoal goal)
	{
	}

	private void AskAboutReviewAndNotifications(OverworldGoal goal, int numFails = 0)
	{
	}

	public void Goal_OnHit(OverworldGoal goal, Vector3 hitPos, OverworldBall2D ballHit, bool forceBallOn = false)
	{
	}

	private Vector3 GetSafeBallPosition(OverworldGoal goal, Vector3 hitPos)
	{
		return default;
	}

	private void StopBallNextToFlag(OverworldGoal goal, Vector3 hitPos)
	{
	}

	private IEnumerator SetLevelMusicRoutine(LevelMusicSettings music, Action onLoaded)
	{
		return null;
	}

	public void ChangeStateToInLevel()
	{
	}

	public IEnumerator StartBossLevel(LevelData level, Action<bool> callback)
	{
		return null;
	}

	public void ToggleOverworld(bool isOverworldActive)
	{
	}

	private IEnumerator StartGoalLevel(OverworldGoal goal, string challengeID, OverworldBall2D ballHit = null, UnityAction<bool> afterLevelCallback = null)
	{
		return null;
	}

	public void DisplayCampaignHub(bool display)
	{
	}

	public void ResetBallPositionToLastSave()
	{
	}

	private IEnumerator CameraMoveCenter(Transform target, float time)
	{
		return null;
	}

	private IEnumerator CameraMoveDuringTransition(bool zoomIn, Transform target = null)
	{
		return null;
	}

	public void SaveBallStartPosition(Vector3 position)
	{
	}

	private void NotifyOnShoot(Vector3 boost)
	{
	}

	public HubSection FindCurrentHubSection()
	{
		return null;
	}

	public void DisableInteraction(bool hide = true)
	{
	}

	public void EnableInteraction()
	{
	}

	private void OnDestroy()
	{
	}
}
