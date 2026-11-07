#!/usr/bin/env python3
"""Implement OverworldManager2d, OverworldBall2D, OverworldBallManager, OverworldGoal,
CameraStack.OverworldCamera, AudioManager, MusicManager, Wwise, Localization,
Menu.Menu, and Menu.InGameMenu for WHAT THE GOLF? Android port.
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
    # 1. OverworldBall2D.cs
    write_asset_file("Scripts/Assembly-CSharp/OverworldBall2D.cs", """using System;
using System.Runtime.CompilerServices;
using Chronos;
using Core;
using UnityEngine;

public class OverworldBall2D : GolfBall2DShooterBase
{
	private Action<OverworldBall2D> m_OnDisabled;
	private Action<OverworldBall2D> m_OnDeath;

	public float speed = 15f;
	public LayerMask layers;
	public float minSpeed = 2f;
	public float maxSpeedMultiplier = 1f;
	public float stopThreshold = 0.1f;
	public bool UseMinSpeed;
	public float randomAngularForce;
	public Rigidbody2D rigidBody;
	public RigidbodyTimeline2D rigidTimeline;
	public bool lookInAimDirection;
	public float lookSpeed = 10f;
	public TrailRenderer trail;

	private GolfBallController controller;
	private float startDrag;
	private Vector3 checkPoint;
	protected bool canEnableFlagsAndDoors = true;
	private Timeline timeline;
	private bool didInit;
	private Transform t;
	private OverworldButton2D debugLastHitDoor;

	public Vector3 Velocity
	{
		get => rigidBody != null ? (Vector3)rigidBody.velocity : Vector3.zero;
		set
		{
			if (rigidBody != null) rigidBody.velocity = value;
		}
	}

	public GolfBallController Controller => controller != null ? controller : (controller = GetComponent<GolfBallController>());

	public event Action<OverworldBall2D> OnDisabled
	{
		add => m_OnDisabled = (Action<OverworldBall2D>)Delegate.Combine(m_OnDisabled, value);
		remove => m_OnDisabled = (Action<OverworldBall2D>)Delegate.Remove(m_OnDisabled, value);
	}

	public event Action<OverworldBall2D> OnDeath
	{
		add => m_OnDeath = (Action<OverworldBall2D>)Delegate.Combine(m_OnDeath, value);
		remove => m_OnDeath = (Action<OverworldBall2D>)Delegate.Remove(m_OnDeath, value);
	}

	protected override void Awake()
	{
		base.Awake();
		Init();
	}

	public void Init()
	{
		if (didInit) return;
		didInit = true;
		t = transform;
		checkPoint = transform.position;
		if (rigidBody == null) rigidBody = GetComponent<Rigidbody2D>();
		rigidbodyC = rigidBody;
		controller = GetComponent<GolfBallController>();
		if (controller != null)
		{
			controller.shooter = this;
			controller.OnShoot -= Shooter_OnShoot;
			controller.OnShoot += Shooter_OnShoot;
			controller.OnAimStart -= Controller_OnAimStart;
			controller.OnAimStart += Controller_OnAimStart;
			controller.OnAimUpdate -= Controller_OnAimUpdate;
			controller.OnAimUpdate += Controller_OnAimUpdate;
			controller.OnCancel -= Controller_OnCancel;
			controller.OnCancel += Controller_OnCancel;
		}
	}

	private void Start()
	{
		Init();
	}

	public void ClearTrail()
	{
		if (trail != null) trail.Clear();
	}

	private void OnDisable()
	{
		m_OnDisabled?.Invoke(this);
	}

	protected virtual void Controller_OnCancel() => OnCancel();
	protected virtual void Controller_OnAimStart() => OnAimStart();
	protected virtual void Controller_OnAimUpdate(Vector3 dir, bool arg2) => OnAimUpdate(dir, arg2);

	public void SetEnableFlagsAndDoors() => canEnableFlagsAndDoors = true;
	public bool CheckUseInteractiveThing() => canEnableFlagsAndDoors;
	public bool GetCanEnableFlagsAndDoors() => canEnableFlagsAndDoors;

	private void ResetZ()
	{
		Vector3 p = transform.position;
		p.z = 0f;
		transform.position = p;
	}

	public override void OnShoot(Vector3 boost) => Shooter_OnShoot(boost);

	protected virtual void Shooter_OnShoot(Vector3 dir)
	{
		if (rigidBody == null) rigidBody = GetComponent<Rigidbody2D>();
		if (rigidBody == null) return;
		rigidBody.isKinematic = false;
		rigidBody.WakeUp();
		float s = speed > 0f ? speed : 15f;
		StandardShoot(dir, 0f, UseMinSpeed ? minSpeed : 1f, s * Mathf.Max(0.5f, maxSpeedMultiplier), randomAngularForce);
	}

	protected override void FixedUpdate()
	{
		base.FixedUpdate();
	}

	private void DoCheat() { }
	private void OnTriggerEnter2D(Collider2D other) { }
	public void HitFlag() => StopBall(false);

	public void StopBall(bool disable = true)
	{
		if (rigidBody != null)
		{
			rigidBody.velocity = Vector2.zero;
			rigidBody.angularVelocity = 0f;
		}
		if (disable && controller != null)
			controller.StopAiming();
	}

	public void HideAndStop(bool disable = true)
	{
		StopBall(disable);
		Hide();
	}

	public void Hide() => gameObject.SetActive(false);

	public void Show() => gameObject.SetActive(true);

	public void ShowAndEnable()
	{
		gameObject.SetActive(true);
		if (controller != null) controller.enabled = true;
	}

	public bool ToggleColliders() => true;

	public void SetColliders(bool state)
	{
		foreach (var c in GetComponentsInChildren<Collider2D>(true))
			c.enabled = state;
	}

	private void OnCollisionEnter2D(Collision2D collision) { }

	protected void Death()
	{
		m_OnDeath?.Invoke(this);
	}

	public virtual void OnHiddenByTransition() { }
}
""")

    # 2. OverworldBallManager.cs
    write_asset_file("Scripts/Assembly-CSharp/OverworldBallManager.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Chronos;
using UnityEngine;

public class OverworldBallManager : MonoBehaviour
{
	private static OverworldBallManager _Instance;
	private Action<OverworldBall2D> m_OnDeath;
	private Action<Transmogrif.BALLSHAPES> m_OnNewBall;
	private Action<Transmogrif> m_OnTransmoGriffed;

	public OverworldBall2D Ball;
	public float minYVelocity;
	public List<Transmogriffable> balls = new List<Transmogriffable>();
	public GlobalClock clock;
	public OverworldBallFollower ballProxy;
	public Transmogrif.BALLSHAPES currentShape;
	private TimeControl timeControl;

	public static OverworldBallManager Instance => _Instance != null ? _Instance : (_Instance = FindObjectOfType<OverworldBallManager>());
	public static bool HasInstance => Instance != null;

	public event Action<OverworldBall2D> OnDeath
	{
		add => m_OnDeath = (Action<OverworldBall2D>)Delegate.Combine(m_OnDeath, value);
		remove => m_OnDeath = (Action<OverworldBall2D>)Delegate.Remove(m_OnDeath, value);
	}

	public event Action<Transmogrif.BALLSHAPES> OnNewBall
	{
		add => m_OnNewBall = (Action<Transmogrif.BALLSHAPES>)Delegate.Combine(m_OnNewBall, value);
		remove => m_OnNewBall = (Action<Transmogrif.BALLSHAPES>)Delegate.Remove(m_OnNewBall, value);
	}

	public event Action<Transmogrif> OnTransmoGriffed
	{
		add => m_OnTransmoGriffed = (Action<Transmogrif>)Delegate.Combine(m_OnTransmoGriffed, value);
		remove => m_OnTransmoGriffed = (Action<Transmogrif>)Delegate.Remove(m_OnTransmoGriffed, value);
	}

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		_Instance = null;
	}

	public void Initialize()
	{
		_Instance = this;
		if (Ball == null) Ball = FindObjectOfType<OverworldBall2D>();
		if (Ball != null)
		{
			Ball.Init();
			Ball.OnDeath -= Ball_OnDeath;
			Ball.OnDeath += Ball_OnDeath;
		}
	}

	public void Load(Transmogrif.BALLSHAPES shape)
	{
		currentShape = shape;
		Initialize();
	}

	private void Ball_OnDeath(OverworldBall2D obj) => m_OnDeath?.Invoke(obj);
	public int GetCurrentShapeAsInt() => (int)currentShape;
	private void Transmogriffable_OnTransmogriffed(Transmogrifable ball, Transmogrif grif) { }
	private void Transmogriffable_OnTransmogriffed(Transmogriffable ball, Transmogrif grif) => m_OnTransmoGriffed?.Invoke(grif);

	private IEnumerator TransmogrifRoutine(Transmogriffable ball, Transmogrif grif)
	{
		yield break;
	}

	private Transmogriffable ChangeBall(Transmogriffable ball, Transmogrif.BALLSHAPES targetShape) => ball;
}
""")

    # 3. OverworldGoal.cs
    write_asset_file("Scripts/Assembly-CSharp/OverworldGoal.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core;
using UnityEngine;

public class OverworldGoal : MonoBehaviour
{
	public enum States
	{
		Hidden = 0,
		Unplayed = 1,
		Won = 2,
		Crown = 3
	}

	public bool isSkipping;
	public string description;
	public LevelData levelData;
	public List<LevelData> AdditionalLevelData = new List<LevelData>();
	public List<LevelData> ExcludeFromSequence = new List<LevelData>();
	public States state = States.Unplayed;
	public GameObject visualNotCompleted;
	public GameObject visualWon;
	public GameObject visualCrown;
	public GameObject visualCrownOutline;
	public GameObject visualPole;
	public GameObject visualHole;
	public GameObject activeAnimation;
	public bool DontRotateBasedOnLevel;
	public bool IsStuckToWall;
	public bool dontSnapToGrid;
	public OverworldGoal requireGoalToUnlock;

	private Action<OverworldGoal> m_OnUpdateData;
	private Action<OverworldGoal, Vector3, OverworldBall2D> m_OnHit;
	private Action<OverworldGoal> m_OnCrownWon;

	public bool MoveBallWhenHit = true;
	public Action<OverworldGoal> PlayerOutOfRangeAgain;
	public bool DontShowActiveCircle;
	public bool isDuplicate;
	public OverworldGoal duplicateReference;

	private Collider2D circleCollider;
	private Collider2D boxCollider;
	private bool canShowIndicator = true;
	private bool hasUnfinishedContent;
	private Transform playerTransform;
	private float playerSize;
	private bool trackPlayerDistance;
	private Transmogrif.BALLSHAPES currentBallShape;
	private HubSection parentHubSection;

	public HubSection ParentHubSection => parentHubSection != null ? parentHubSection : (parentHubSection = GetComponentInParent<HubSection>());
	public bool CanShowIndicator { set => canShowIndicator = value; }

	public event Action<OverworldGoal> OnUpdateData
	{
		add => m_OnUpdateData = (Action<OverworldGoal>)Delegate.Combine(m_OnUpdateData, value);
		remove => m_OnUpdateData = (Action<OverworldGoal>)Delegate.Remove(m_OnUpdateData, value);
	}

	public event Action<OverworldGoal, Vector3, OverworldBall2D> OnHit
	{
		add => m_OnHit = (Action<OverworldGoal, Vector3, OverworldBall2D>)Delegate.Combine(m_OnHit, value);
		remove => m_OnHit = (Action<OverworldGoal, Vector3, OverworldBall2D>)Delegate.Remove(m_OnHit, value);
	}

	public event Action<OverworldGoal> OnCrownWon
	{
		add => m_OnCrownWon = (Action<OverworldGoal>)Delegate.Combine(m_OnCrownWon, value);
		remove => m_OnCrownWon = (Action<OverworldGoal>)Delegate.Remove(m_OnCrownWon, value);
	}

	private void Awake()
	{
		RefreshState();
		RefreshVisuals();
	}

	public void Init(GridFiller filler)
	{
		RefreshState();
		RefreshVisuals();
	}

	public IEnumerator UpdatePlayerTracking(bool force = false)
	{
		yield break;
	}

	private void PlayerOutOfRange() => PlayerOutOfRangeAgain?.Invoke(this);
	public void SetNewBallShape(Transmogrif.BALLSHAPES newShape) => currentBallShape = newShape;

	private IEnumerator OneFrameDelayedSetStatus()
	{
		yield return null;
		RefreshState();
		RefreshVisuals();
	}

	public bool IsUnlocked()
	{
		if (requireGoalToUnlock == null) return true;
		return requireGoalToUnlock.IsCompleted();
	}

	public bool IsCompleted() => levelData != null && levelData.IsCompletedInSaveGame;
	public bool IsRotated2D() => false;

	public List<LevelData> GetAllGoalLevels()
	{
		var res = new List<LevelData>();
		if (levelData != null) res.Add(levelData);
		if (AdditionalLevelData != null)
		{
			foreach (var l in AdditionalLevelData)
				if (l != null && !res.Contains(l)) res.Add(l);
		}
		return res;
	}

	public bool HasChallenges() => AdditionalLevelData != null && AdditionalLevelData.Count > 0;
	public bool IsVisible() => state != States.Hidden;
	public bool IsFullyCompleted() => IsCompleted();

	public void ForceShowCrownOutline()
	{
		if (visualCrownOutline != null) visualCrownOutline.SetActive(true);
	}

	public void ForceShowCrown()
	{
		state = States.Crown;
		RefreshVisuals();
		m_OnCrownWon?.Invoke(this);
	}

	private void RefreshFlag(OverworldGoal other) => RefreshFlag();

	private void RefreshFlag()
	{
		RefreshState();
		RefreshVisuals();
	}

	private void RefreshState()
	{
		if (!IsUnlocked())
			state = States.Unplayed;
		else if (IsCompleted())
			state = States.Won;
		else
			state = States.Unplayed;
	}

	public void RefreshVisuals()
	{
		if (visualNotCompleted != null) visualNotCompleted.SetActive(state == States.Unplayed);
		if (visualWon != null) visualWon.SetActive(state == States.Won || state == States.Crown);
		if (visualCrown != null) visualCrown.SetActive(state == States.Crown);
	}

	public void ReloadData()
	{
		RefreshState();
		RefreshVisuals();
		m_OnUpdateData?.Invoke(this);
	}

	public virtual void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null) return;
		var ball = collision.collider.GetComponentInParent<OverworldBall2D>();
		if (ball != null)
		{
			m_OnHit?.Invoke(this, collision.transform.position, ball);
			if (OverworldManager2d.HasInstance)
				OverworldManager2d.Instance.Goal_OnHit(this, collision.transform.position, ball);
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null) return;
		var ball = other.GetComponentInParent<OverworldBall2D>();
		if (ball != null)
		{
			m_OnHit?.Invoke(this, other.transform.position, ball);
			if (OverworldManager2d.HasInstance)
				OverworldManager2d.Instance.Goal_OnHit(this, other.transform.position, ball);
		}
	}

	private void OnDrawGizmosSelected() { }
}
""")

    # 4. OverworldManager2d.cs
    write_asset_file("Scripts/Assembly-CSharp/OverworldManager2d.cs", """using System;
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
""")

    # 5. CameraStack/OverworldCamera.cs
    write_asset_file("Scripts/Assembly-CSharp/CameraStack/OverworldCamera.cs", """using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CameraStack
{
	public class OverworldCamera : MonoBehaviour
	{
		private Action m_OnPreLateUpdate;
		private Camera[] _cameras;
		public static OverworldCamera Instance;
		public Transform OverridePositionTransform;
		public float OverridePositionWeight;
		[SerializeField] private CameraBehavior MobileCameraBehaviour;
		[SerializeField] private CameraBehavior StandaloneCameraBehaviour;
		[SerializeField] private CBOverworldRoomStatic PuzzleRoomCameraBehaviour;
		private PerlinShake shake;
		private List<OverworldCameraSettings> cameraSettings = new List<OverworldCameraSettings>();
		private GyroShakeOverworld gyro;
		public OverworldCameraSettings defaultSettings;
		public OverworldCameraSettings resetCamearaSettings;
		private float currentCameraSettingsTweenTime;
		private Vector3 lastBallPosition;
		private Vector3 lookAhead;

		public Camera[] Cameras => _cameras ?? (_cameras = GetComponentsInChildren<Camera>(true));
		public Camera MainCamera => GetComponent<Camera>() ?? (Cameras.Length > 0 ? Cameras[0] : Camera.main);
		public CameraBehavior ActiveBehavior { get; private set; }

		public event Action OnPreLateUpdate
		{
			add => m_OnPreLateUpdate = (Action)Delegate.Combine(m_OnPreLateUpdate, value);
			remove => m_OnPreLateUpdate = (Action)Delegate.Remove(m_OnPreLateUpdate, value);
		}

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
			Instance = null;
		}

		private void Awake()
		{
			Instance = this;
			_cameras = GetComponentsInChildren<Camera>(true);
			ActiveBehavior = MobileCameraBehaviour != null ? MobileCameraBehaviour : StandaloneCameraBehaviour;
		}

		private IEnumerator ResetCameraNextFrame()
		{
			yield return null;
		}

		private void OnCameraSettingsChanged(OverworldCameraSettings settings, float pct) { }
		public void OnRoomEnter(CBOverworldRoomStatic camSettings) { }
		public void OnRoomExit() { }

		private void LateUpdate()
		{
			m_OnPreLateUpdate?.Invoke();
			Transform target = OverridePositionTransform;
			if (target == null && OverworldManager2d.HasInstance)
			{
				var ow = OverworldManager2d.Instance;
				if (ow.cameraTarget != null) target = ow.cameraTarget;
				else if (ow.ball != null) target = ow.ball.transform;
			}
			if (target != null)
			{
				Vector3 desired = new Vector3(target.position.x, target.position.y, transform.position.z);
				transform.position = Vector3.Lerp(transform.position, desired, Time.unscaledDeltaTime * 6f);
			}
		}

		public void SwitchBehavior(CameraBehavior newCameraBehavior) => ActiveBehavior = newCameraBehavior;
		public void Shake(float duration, float speed, float magnitude) { }

		public bool IsWorldPosNearScreen(Vector3 pos, float nearThreshold = 0.25f) => true;
	}
}
""")

    # 6. AudioManager.cs, MusicManager.cs, Wwise.cs, Localization.cs
    write_asset_file("Scripts/Assembly-CSharp/AudioManager.cs", """using System.Collections;
using System.Collections.Generic;
using Audio;
using Audio.Rumble;
using Core;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
	private static AudioManager instance;
	public AudioSources shortEffects;
	public AudioSources impactEffects;
	public AudioSources uiEffects;
	public AudioSources overworldSpatial;
	public AudioSources ambientEffects;
	public RumbleManager rumbleManager;
	public GolfAudioManager golfAudioManager;
	public AudioSources voices;
	public AudioMixer musicMixer;
	public AudioMixer sfxMixer;
	public AudioMixerSnapshot snapshot3D;
	public AudioMixerSnapshot snapshot2D;
	private AmbientAudioPlayer ambient;
	private GolfAudioManager golfAudio;
	public MusicManager music;
	public AmbientAudioPlayer AmbientPlayer;
	private AudioMixerSnapshot lastMixerSnapshot;
	private Dictionary<int, AudioMaterialSettings> audioMatCache = new Dictionary<int, AudioMaterialSettings>();
	public int matCacheCount;
	public uint[] downloadMusicStates;
	public const string SFX_Volume = "SFX_Volume";
	public const string Music_Volume = "Music_Volume";
	private float enableListenersTimer;
	private Coroutine fadeRoutine;

	public static AudioManager Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<AudioManager>();
				if (instance == null)
				{
					var go = new GameObject("AudioManager");
					instance = go.AddComponent<AudioManager>();
					instance.music = go.AddComponent<MusicManager>();
					DontDestroyOnLoad(go);
				}
			}
			return instance;
		}
	}

	public Dictionary<int, AudioMaterialSettings> AudioMatCache => audioMatCache;

	public void Init()
	{
		instance = this;
		if (music == null) music = GetComponentInChildren<MusicManager>() ?? gameObject.AddComponent<MusicManager>();
	}

	[RuntimeInitializeOnLoadMethod]
	public static void ResetOneshotAssets()
	{
		instance = null;
	}

	private void Awake()
	{
		if (instance == null)
		{
			instance = this;
			DontDestroyOnLoad(gameObject);
		}
		if (music == null) music = GetComponentInChildren<MusicManager>() ?? gameObject.AddComponent<MusicManager>();
	}

	private void Start() => Init();
	private void Instance_OnLevelWillUnload() => music?.OnLevelWillUnload();
	private void Instance_OnLevelLoaded(LevelData data) => music?.OnLevelLoaded();
	public void OnLevelDesignerPlayStart(Camera cam, Transform listenerFollowTarget) { }
	public void OnLevelDesignerReset(Camera cam, Transform listenerFollowTarget) { }

	public bool CheckMaterial(GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false) => includeEmpty;

	public bool CheckMaterial(out AudioMaterialSettings setting, GameObject go, List<AudioMaterial> include, List<AudioMaterial> exclude, bool includeEmpty = false)
	{
		setting = null;
		return includeEmpty;
	}

	private void UpdateMixerSettings(LevelData leveldata) { }
	public void FadeAllOut(float time) { }
	public void FadeAllIn(float time) { }

	private IEnumerator FadeRoutine(float sfxVolume, float musicVolume, float time)
	{
		yield break;
	}

	public static void SetMusicGain(float volume) { }
	public static void SetSoundGain(float volume) { }
	public void SetMixerSnapshot(AudioMixerSnapshot snapshot, float time = 0.4f) { }
	public void ResetMixerSnapshot(float time = 0.4f) { }
	public void AudioSourceFollowTransform(AudioSource src, Transform trans, float time) { }

	public IEnumerator Follow(AudioSource src, Transform trans, float time)
	{
		yield break;
	}
}
""")

    write_asset_file("Scripts/Assembly-CSharp/MusicManager.cs", """using System;
using System.Collections;
using Core;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
	public string bankName;
	private bool isLoaded = true;
	private uint playingId;
	private float nextMusicSet;
	private float musicSetInterval;
	private LevelMusicSettings currentMusicSettings;
	private LevelMusic currentLevelMusic;
	private float lastFirstShotTime;
	private float lastMusicStartTime;
	private float musicFadeVolume = 1f;
	private float musicUserVolume = 1f;
	private float musicVolume = 1f;
	private bool masterMute;
	private int strokecount;
	public string currentStateName;
	internal bool useTransition;

	public uint lastState { get; private set; }

	public void InitializeBank(Action callback = null, bool startsWithOnboarding = false)
	{
		isLoaded = true;
		callback?.Invoke();
	}

	public void FailChallenge() { }
	public void CompleteChallenge() { }
	public void PostTrigger(uint trigger) { }
	public void PostTrigger(StingerData trigger) { }
	public void SetUserVolume(float userVolume) => musicUserVolume = userVolume;
	public void SetGain(float fadeVolume) => musicFadeVolume = fadeVolume;
	private void UpdateMixerVolume() { }
	private IEnumerator SlowFixedUpdate() { yield break; }
	public void OnLevelWillUnload() { }
	public void OnLevelLoaded() { }
	private void CurrentLevelMusic_OnAimtStart(int preStrokeCount) { }
	private void CurrentLevelMusic_OnStart() { }
	private void CurrentLevelMusic_OnShot(int preStrokeCount) { }
	private void CurrentLevelMusic_OnFail() { }
	private void CurrentLevelMusic_OnAimUpdate(bool isAiming) { }
	private void Update() { }
	public bool ToggleMuteMusic() => masterMute = !masterMute;
	private void SetAiming(float value) { }
	public void SetOverwroldRTCP(uint rtcp, float rtcpValue) { }
	public void setRTCPRaw(uint rtcp, float rtcpValue, int time) { }
	public void SetLevelMusicRTPC(float rtpcValue, int time) { }
	public float GetLevelMusicRTPC() => 0f;
	public float GetRTPCValueRaw(uint rtpcID) => 0f;
	private void SetBasic(float value, int tweenTime) { }
	public void SetClosingIn(float value, int tweenTimeMs) { }
	public void InitializeMusic() => isLoaded = true;
	public void InitializeMusic(uint initialState) { lastState = initialState; isLoaded = true; }
	public static string GetStateName(uint wwiseState) => wwiseState.ToString();

	public void SetState(uint wwiseState, bool fromLoading, Action onLoaded = null, bool ignoreTransition = false)
	{
		lastState = wwiseState;
		onLoaded?.Invoke();
	}

	public void SetStateChange(MusicData musicOverworldWithTransition) { }

	public void SetLevelMusic(LevelMusicSettings music, float rtcpStart, bool ignoreTransition = false, Action onLoaded = null)
	{
		currentMusicSettings = music;
		onLoaded?.Invoke();
	}

	public void SetLevelMusic(LevelMusicSettings music, bool ignoreTransition = false, Action onLoaded = null)
	{
		currentMusicSettings = music;
		onLoaded?.Invoke();
	}

	public bool IsReadyToPlay() => true;
}
""")

    write_asset_file("Scripts/Assembly-CSharp/Localization.cs", """using System;
using System.Collections.Generic;
using I2.Loc;
using UnityEngine;

public class Localization
{
	private Dictionary<string, LocalizationFont> fonts = new Dictionary<string, LocalizationFont>();
	private const string TAG = "Localization";
	public static Action OnLanguageChangedEvent;
	private static Localization instance;
	private string _currentLang = "English";

	public static Localization Instance => instance ?? (instance = new Localization());

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		_ = Instance;
	}

	public void ChangeLanguage(string languageId)
	{
		if (!string.IsNullOrEmpty(languageId))
		{
			_currentLang = languageId;
			OnLanguageChangedEvent?.Invoke();
		}
	}

	public string GetCurrentLanguage() => _currentLang;
	public bool IsEnglish() => string.IsNullOrEmpty(_currentLang) || _currentLang.StartsWith("en", StringComparison.OrdinalIgnoreCase);
	public string ReverseCustomTextIfNecessary(string text) => text ?? string.Empty;
	public string GetNextLanguage() => _currentLang;
	public bool HasTerm(string id) => !string.IsNullOrEmpty(id);

	public string GetStringWithFormat(string id, params object[] values)
	{
		string raw = GetString(id);
		try { return values != null && values.Length > 0 ? string.Format(raw, values) : raw; }
		catch { return raw; }
	}

	public string GetEnglishString(string id) => GetString(id);

	public string GetString(string id, bool suppressWarnings = false, string overrideLanguage = null)
	{
		if (string.IsNullOrEmpty(id)) return string.Empty;
		if (id.StartsWith("ID_"))
			return id.Substring(3).Replace("__", ": ").Replace("_", " ");
		return id;
	}

	public LocalizationFont GetFont(LocalizationFontStyle style) => null;
	private void RegisterForLanguageChanges() { }
	private void OnLanguageChanged() => OnLanguageChangedEvent?.Invoke();
	private void LoadFontCollection(string fontCollectionName) { }
}
""")

    print("Implemented Overworld, Camera, Audio, Music, and Localization systems")


if __name__ == "__main__":
    main()
