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
using UnityEngine.Tilemaps;

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
	private OverworldBall2D BallOrIslandBall => ball;
	public static OverworldManager2d Instance => instance;
	public static bool HasInstance => instance != null;

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
		if (sectionManager != null)
			sectionManager.Init();

		RemoveNullsFromList(goals);
		RemoveNullsFromList(allButtons);
		RemoveNullsFromList(allSecrets);
		RemoveNullsFromList(allOverworldMainButton);
		RemoveNullsFromList(allOverworldPortals);
		RemoveNullsFromList(allOverworldRobots);
		RemoveNullsFromList(allPuzzleDoors);
		RemoveNullsFromList(allResetProps);

		if (Camera == null)
			Camera = FindObjectOfType<OverworldCamera>();
		if (Camera != null && Camera.MainCamera != null)
			mainCameraCullingMask = Camera.MainCamera.cullingMask;
		HintEffect.Initialize(Camera);

		var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
		if (currentCfg != null && currentCfg.useRotatedOverworldAndCameraInLevels)
			Screen.orientation = ScreenOrientation.Portrait;
		else
			Screen.orientation = ScreenOrientation.LandscapeLeft;

		var ballMgr = GetComponent<OverworldBallManager>();
		if (ballMgr == null)
			ballMgr = FindObjectOfType<OverworldBallManager>();
		if (ballMgr != null)
		{
			ballMgr.OnNewBall -= Instance_OnNewBall;
			ballMgr.OnNewBall += Instance_OnNewBall;
			ballMgr.Initialize();
			ballMgr.OnDeath -= BallMananger_OnDeath;
			ballMgr.OnDeath += BallMananger_OnDeath;
			if (ball == null && ballMgr.Ball != null)
				ball = ballMgr.Ball;
			if (cameraTarget == null && ballMgr.ballProxy != null)
				cameraTarget = ballMgr.ballProxy.transform;
		}
		if (ball == null)
			ball = FindObjectOfType<OverworldBall2D>();
		if (cameraTarget == null && ball != null)
			cameraTarget = ball.transform;

		if (gridfiller != null)
		{
			gridfiller.Init();
			gridRigid = gridfiller.currentRigid;
		}
		if (culling != null)
			culling.Initialize();
		if (deathTransition != null)
			StartCoroutine(deathTransition.EndTransition(true));
	}

	private void Undocking_OnDockingStateChanged(bool isDocked)
	{
		RefreshDoorsAndGoals();
	}

	private void RemoveNullsFromList<T>(List<T> list) => list?.RemoveAll(x => x == null);
	private bool IsPrecompiledListsOk() => true;

	private IEnumerator Start()
	{
		audioManager = AudioManager.Instance;
		if (ball == null && OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
			ball = OverworldBallManager.Instance.Ball;
		if (ball == null)
			ball = FindObjectOfType<OverworldBall2D>();

		if (ball != null)
		{
			ball.Init();
			ballStartPosition = ball.transform.position;
			var ctrl = ball.GetComponent<GolfBallController>();
			if (ctrl != null)
			{
				ctrl.OnShoot -= OnBallShot;
				ctrl.OnShoot += OnBallShot;
			}
			if (ui != null && ui.AimMarker != null && ball.Controller != null)
				ui.AimMarker.SubscribeToController(ball.Controller);
		}

		if (goals == null || goals.Count == 0)
			goals = FindObjectsOfType<OverworldGoal>().ToList();
		foreach (var g in goals)
		{
			if (g == null) continue;
			g.Init(gridfiller);
			g.OnHit -= Goal_OnHitSimple;
			g.OnHit += Goal_OnHitSimple;
			g.OnCrownWon -= Goal_CrownWon;
			g.OnCrownWon += Goal_CrownWon;
		}

		var groundMap = gridfiller != null ? gridfiller.currentGroundMap : null;

		if (allButtons != null)
		{
			foreach (var b in allButtons)
			{
				if (b == null) continue;
				if (debugWithoutDoors)
					b.gameObject.SetActive(false);
				else if (b.gameObject.activeInHierarchy)
					b.Init(groundMap, goals, Camera);
			}
			foreach (var b in allButtons)
			{
				if (b != null && !debugWithoutDoors && b.gameObject.activeInHierarchy)
					b.AfterInit();
			}
		}

		if (OLButtons != null)
		{
			foreach (var ob in OLButtons)
			{
				if (ob == null) continue;
				if (debugWithoutDoors)
					ob.gameObject.SetActive(false);
				else if (ob.gameObject.activeInHierarchy)
					ob.Init(groundMap, goals, Camera);
			}
			foreach (var ob in OLButtons)
			{
				if (ob != null && !debugWithoutDoors && ob.gameObject.activeInHierarchy)
					ob.AfterInit();
			}
		}

		if (overworldMusic != null)
			overworldMusic.Init();

		foreach (var g in goals)
		{
			if (g != null)
				g.RefreshVisuals();
		}

		if (allOverworldRobots != null)
		{
			foreach (var r in allOverworldRobots)
			{
				if (r == null) continue;
				if (debugWithoutComputersAndBigButtons)
					r.gameObject.SetActive(false);
				else
					r.Initialize(this, groundMap);
			}
		}

		if (allSecrets != null)
		{
			foreach (var s in allSecrets)
				if (s != null) s.Init(gridfiller);
		}

		if (allOverworldMainButton != null)
		{
			foreach (var mb in allOverworldMainButton)
			{
				if (mb == null) continue;
				if (debugWithoutComputersAndBigButtons)
				{
					mb.gameObject.SetActive(false);
				}
				else
				{
					mb.Init(groundMap);
					mb.OnPressed -= Mainbutton_OnPressed;
					mb.OnPressed += Mainbutton_OnPressed;
				}
			}
		}

		if (allOverworldPortals != null)
		{
			foreach (var p in allOverworldPortals)
				if (p != null) p.Init(gridfiller);
		}

		if (allPuzzleDoors != null)
		{
			foreach (var pd in allPuzzleDoors)
				if (pd != null) pd.Init(groundMap);
		}

		if (FlagScanner != null)
			FlagScanner.goals = goals;

		if (!isHub)
		{
			foreach (var ms in FindObjectsOfType<MovingStone>())
				if (ms != null) ms.Initialize();
			foreach (var spb in FindObjectsOfType<ShortCutPortalBoxEnableOnComputer>())
				if (spb != null) spb.Init();
			foreach (var uf in FindObjectsOfType<OverworldUnfinishedLevels>())
				if (uf != null) uf.Init();
		}

		state = STATES.active;
		if (ui != null)
			ui.Initialize();
		timeForLastTransitionJingle = Time.unscaledTime - 60f;
		if (Camera != null && Camera.MainCamera != null && mainCameraCullingMask != 0)
			Camera.MainCamera.cullingMask = mainCameraCullingMask;

		if (Camera != null && Camera.ActiveBehavior is CBOrthographicFollow2D orthoFollow && cameraTarget != null)
			orthoFollow.SetFollowTarget(cameraTarget);

		bool introDone = SaveGame.IsIntroAnimationComplete;
		if (isHub && HubSceneLoader.Instance != null && !HubSceneLoader.Instance.HasBeenLoadedBefore)
		{
			introDone = false;
		}
		if (!introDone || (isHub && HubSceneLoader.Instance != null && !HubSceneLoader.Instance.HasBeenLoadedBefore))
		{
			StartCoroutine(StartOverworldMusicDelayed(0.2f));
		}

		if (introDone || introTunnel == null)
		{
			if (ball != null)
			{
				ball.ShowAndEnable();
				if (ball.Controller != null)
				{
					ball.Controller.enabled = true;
					ball.Controller.Activate();
				}
			}
			if (ui != null)
				ui.EnableReturnButton();
			IsIntroAnimationComplete = true;
			if (LevelManager.Exists)
			{
				if (!isComingFromLoaderScene)
					StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
				else
					yield return StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
			}
		}
		else
		{
			if (OverworldLoader.ComingFromOverworldLoader)
			{
				isComingFromLoaderScene = true;
				canStartAtLogoWhenStartingOverworld = true;
				OverworldLoader.ComingFromOverworldLoader = false;
			}
			if (!isComingFromLoaderScene && LevelManager.Exists)
				LevelManager.Instance.InstantTransitionCover(Color.black);
			introTunnel.Init(canStartAtLogoWhenStartingOverworld);
			yield return StartCoroutine(PlayIntroAnimation());
		}
	}

	private void OnBallShot(Vector3 dir)
	{
		m_OnShoot?.Invoke();
	}

	private void Goal_OnHitSimple(OverworldGoal goal, Vector3 hitPos, OverworldBall2D ballHit)
	{
		Goal_OnHit(goal, hitPos, ballHit, false);
	}

	public void RefreshDoorsAndGoals()
	{
		if (goals != null)
		{
			foreach (var g in goals)
				g?.ReloadData();
		}
		if (allButtons != null)
		{
			foreach (var b in allButtons)
				if (b != null && b.gameObject.activeInHierarchy)
					b.UpdateStatus();
		}
	}

	public static void ActivateParticleSystems(Transform root) { }
	private void RestOverworldProps() { }

	private void BallMananger_OnDeath(OverworldBall2D b)
	{
		StartCoroutine(DeathRoutine());
	}

	private IEnumerator DeathRoutine()
	{
		if (ball != null)
		{
			ball.StopBall(false);
			ball.transform.position = ballStartPosition;
			ball.ShowAndEnable();
		}
		yield break;
	}

	public void RegisterBall(OverworldBall2D _ball, Transmogrif.BALLSHAPES newShape)
	{
		ball = _ball;
		if (ball != null)
		{
			var ctrl = ball.GetComponent<GolfBallController>();
			if (ctrl != null)
			{
				ctrl.OnShoot -= OnBallShot;
				ctrl.OnShoot += OnBallShot;
				if (ui != null && ui.AimMarker != null)
					ui.AimMarker.SubscribeToController(ctrl);
			}
		}
	}

	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
			RegisterBall(OverworldBallManager.Instance.Ball, newShape);
	}

	private void Mainbutton_OnPressed(OverworldMainButton button)
	{
		if (button != null)
			StartCoroutine(MainButtonPressRoutine(button));
	}

	private IEnumerator MainButtonPressRoutine(OverworldMainButton button)
	{
		if (button == null) yield break;
		Vector3 btnPos = button.transform.position;
		OverworldBall2D currentBall = OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null
			? OverworldBallManager.Instance.Ball
			: ball;
		if (ball != null)
		{
			if (ball.Controller != null)
			{
				ball.Controller.StopAiming();
				ball.Controller.enabled = false;
			}
			ball.enabled = false;
			if (ball.rigidBody != null)
			{
				ball.rigidBody.isKinematic = true;
				ball.rigidBody.velocity = Vector2.zero;
				ball.rigidBody.angularVelocity = 0f;
			}
			ball.SetColliders(false);
			ball.Hide();
		}

		yield return new WaitForSeconds(0.3f);

		yield return StartCoroutine(button.EnableButtonAndCable(
			cablePos =>
			{
				btnPos = cablePos;
				if (ball != null)
					ball.transform.position = cablePos;
				if (cameraTarget != null)
					cameraTarget.position = cablePos;
			},
			() =>
			{
				if (ball != null)
				{
					float z = currentBall != null ? currentBall.transform.position.z : ball.transform.position.z;
					ball.transform.position = new Vector3(btnPos.x, btnPos.y, z);
				}
				if (cameraTarget != null && ball != null)
					cameraTarget.position = ball.transform.position;
			}
		));
	}

	private IEnumerator StartOverworldMusicDelayed(float delay)
	{
		if (delay > 0f)
			yield return new WaitForSeconds(delay);
		StartMusicWithoutTransition();
	}

	private IEnumerator PlayIntroAnimation()
	{
		if (AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.InitializeBank(null, false);

		GolfBallController ctrl = ball != null ? ball.GetComponent<GolfBallController>() : null;
		if (ctrl != null)
			ctrl.enabled = false;

		state = STATES.inOnboarding;
		ToggleOverworld(true);
		if (culling != null)
			culling.ReturnToOverworld();

		if (!isComingFromLoaderScene)
		{
			if (LevelManager.Exists)
				StartCoroutine(LevelManager.Instance.EndTransition(false, 1f));
			if (delayAfterHidingTransitionOnStartinInTunnel > 0f)
				yield return new WaitForSeconds(delayAfterHidingTransitionOnStartinInTunnel);
		}
		else if (LevelManager.Exists)
		{
			StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
		}

		if (overworldMusic != null && musicOverworldStart != null)
			overworldMusic.StartWithoutTransition(musicOverworldStart);

		bool done = false;
		if (introTunnel != null)
		{
			var routine = introTunnel.PlayAnimationRoutine(
				() => done = true,
				() => true,
				() => true
			);
			StartCoroutine(pTween.Then(routine, 0.1f, () => { }));
			while (!done)
				yield return null;
		}

		state = STATES.active;
		yield return null;

		if (OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
			ball = OverworldBallManager.Instance.Ball;
		if (ball != null)
		{
			ballStartPosition = ball.transform.position;
			ball.ShowAndEnable();
			ctrl = ball.GetComponent<GolfBallController>();
		}
		if (ctrl != null)
		{
			ctrl.enabled = true;
			ctrl.Activate();
		}
		if (ui != null)
			ui.EnableReturnButton();
		if (culling != null)
			culling.UpdateCulling();
		IsIntroAnimationComplete = true;
		SaveGame.Save(false);
	}

	private void Update()
	{
		if (culling != null && (state == STATES.active || state == STATES.inOnboarding || state == STATES.inAnimation || state == STATES.inDialog))
			culling.UpdateCulling();
	}
	private IEnumerator ShowBallDelayed(OverworldGoal goalHit)
	{
		if (ball != null)
		{
			ball.ShowAndEnable();
			if (goalHit == null || goalHit.MoveBallWhenHit)
				ball.transform.position = ballStartPosition;
			ball.StopAndSleep();
			ball.StartAndWakeup();
		}
		yield return null;
	}

	public void StartMusicWithoutTransition()
	{
		if (overworldMusic != null && musicOverworldStart != null)
			overworldMusic.StartWithoutTransition(musicOverworldStart);
	}

	private void ReturnToOverworld(List<LevelData> levelData, bool isCompleted, List<Level.CompletedState> completeState, OverworldGoal goalHit, bool clearPlayAgainDialog = true, OverworldBall2D ballThatHit = null, List<Level.FailState> failStates = null)
	{
		state = STATES.active;
		if (overworldMusic != null)
		{
			LevelData lastLvl = (levelData != null && levelData.Count > 0) ? levelData[levelData.Count - 1] : null;
			if (lastLvl != null && lastLvl.music != null && lastLvl.music.isUsingCustomOverworldMusic && lastLvl.music.customReturnMusic != null)
				overworldMusic.StartWithoutTransition(lastLvl.music.customReturnMusic);
			else
				overworldMusic.StartWithoutTransition();
		}
		ToggleOverworld(true);
		if (culling != null)
			culling.ReturnToOverworld();
		RefreshDoorsAndGoals();
		StartCoroutine(ShowBallDelayed(goalHit));

		if (isCompleted)
		{
			if (levelData != null)
			{
				for (int i = 0; i < levelData.Count; i++)
				{
					if (levelData[i] != null)
						levelData[i].IsCompletedInSaveGame = true;
				}
			}
			bool allChallengesDone = levelData != null && levelData.All(l => l != null && l.HasCompletedAllChallenges());
			if (currentGoal != null)
				currentGoal.ReloadData();
			RefreshDoorsAndGoals();
			OnlevelCompleted?.Invoke(currentGoal ?? goalHit, allChallengesDone);
			if (clearPlayAgainDialog && ui != null)
				ui.ClearPlayagainDialog();
			if (allChallengesDone)
			{
				if (clearLevelCrownClips != null && AudioManager.Instance != null)
					clearLevelCrownClips.PlayRandomClip((currentGoal ?? goalHit) != null ? (currentGoal ?? goalHit).transform.position : Vector3.zero);
			}
			else if (clearLevelClips != null && AudioManager.Instance != null)
			{
				clearLevelClips.PlayRandomClip((currentGoal ?? goalHit) != null ? (currentGoal ?? goalHit).transform.position : Vector3.zero);
			}
		}
		else
		{
			if (currentGoal != null)
				currentGoal.ReloadData();
			OnlevelAbandoned?.Invoke(currentGoal ?? goalHit);
			if (clearPlayAgainDialog && ui != null)
				ui.ClearPlayagainDialog();
		}
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
		if (goal.MoveBallWhenHit)
		{
			ballStartPosition = GetSafeBallPosition(goal, hitPos);
			if (ball != null)
				ball.HideAndStop();
		}

		if (goal.IsCompleted() && goal.HasChallenges() && ui != null)
		{
			if (flagHitClips != null)
				flagHitClips.PlayRandomClip(hitPos);
			if (rumbleEventAssetFlagCompleted != null)
				rumbleEventAssetFlagCompleted.Play(0, 1f);
			if (goal.MoveBallWhenHit && ball != null)
				ball.SetColliders(false);

			state = STATES.inDialog;
			bool prevCtrlEnabled = ballHit != null && ballHit.Controller != null && ballHit.Controller.enabled;
			if (ballHit != null && ballHit.Controller != null)
				ballHit.Controller.enabled = false;

			ui.ShowPlayagainDialog(
				goal,
				challengeID =>
				{
					StartCoroutine(StartGoalLevel(goal, challengeID, ballHit, _ =>
					{
						if (ui != null)
							ui.RefreshElements();
					}));
				},
				() =>
				{
					if (ballHit != null && ballHit.Controller != null)
						ballHit.Controller.enabled = forceBallOn || prevCtrlEnabled;
					Time.timeScale = 1f;
					state = STATES.active;
					if (ball != null)
						ball.ShowAndEnable();
					StartCoroutine(goal.UpdatePlayerTracking(true));
				}
			);
		}
		else
		{
			if (ballHit != null && ballHit.Controller != null)
				ballHit.Controller.enabled = false;
			if (flagHitFirstPlayClips != null)
				flagHitFirstPlayClips.PlayRandomClip(hitPos);
			if (rumbleEventAssetFlagNotCompleted != null)
				rumbleEventAssetFlagNotCompleted.Play(0, 1f);
			if (ui != null)
				ui.DisableUI();
			if (goal.levelData != null)
			{
				StartCoroutine(StartGoalLevel(goal, null, ballHit, _ =>
				{
					if (ui != null)
						ui.EnableUI();
				}));
			}
		}
	}

	private Vector3 GetSafeBallPosition(OverworldGoal goal, Vector3 hitPos)
	{
		if (goal == null) return hitPos;
		if (gridfiller != null && gridfiller.currentGroundMap != null)
		{
			Tilemap gMap = gridfiller.currentGroundMap;
			Vector3 goalPos = goal.transform.position;
			Vector3Int goalCell = gMap.WorldToCell(goalPos);
			Vector3Int left = goalCell + new Vector3Int(-1, 0, 0);
			Vector3Int right = goalCell + new Vector3Int(1, 0, 0);
			Vector3Int down = goalCell + new Vector3Int(0, -1, 0);
			Vector3Int up = goalCell + new Vector3Int(0, 1, 0);

			var candidates = new List<Vector3Int>();
			if (hitPos.x > goalPos.x)
			{
				candidates.Add(right);
				candidates.Add(left);
			}
			else
			{
				candidates.Add(left);
				candidates.Add(right);
			}
			if (hitPos.y > goalPos.y)
			{
				candidates.Add(up);
				candidates.Add(down);
			}
			else
			{
				candidates.Add(down);
				candidates.Add(up);
			}

			Vector3 cellSize = gridfiller.groundMap != null ? gridfiller.groundMap.cellSize : gMap.cellSize;
			foreach (var cell in candidates)
			{
				if (gridfiller.IsTileTarget(cell))
				{
					Vector3 wp = gMap.CellToWorld(cell);
					return new Vector3(wp.x + cellSize.x * 0.5f, wp.y + cellSize.x * 0.5f, 0f);
				}
			}
		}

		Vector3 dir = (hitPos - goal.transform.position).normalized;
		if (dir.sqrMagnitude < 1e-4f) dir = Vector3.down;
		Vector3 gp = goal.transform.position;
		return new Vector3(gp.x + dir.x * 0.35f, gp.y + dir.y * 0.35f, 0f);
	}

	private void StopBallNextToFlag(OverworldGoal goal, Vector3 hitPos)
	{
		ballStartPosition = GetSafeBallPosition(goal, hitPos);
		if (ball != null)
		{
			ball.StopAndSleep();
		}
	}

	private IEnumerator SetLevelMusicRoutine(LevelMusicSettings music, Action onLoaded)
	{
		onLoaded?.Invoke();
		yield break;
	}

	public void ChangeStateToInLevel() => state = STATES.inlevel;

	public void SetBallStartPosition(Vector3 pos) => ballStartPosition = pos;

	public IEnumerator StartBossLevel(LevelData level, Action<bool> callback)
	{
		if (level != null && LevelManager.Instance != null)
		{
			state = STATES.inlevel;
			var completedStates = new List<Level.CompletedState>();
			yield return StartCoroutine(LevelManager.Instance.Play(
				level,
				onTransitionCoverBefore: () => ToggleOverworld(false),
				onComplete: cs =>
				{
					completedStates.Add(cs);
					if (overworldMusic != null)
						overworldMusic.StartWithoutTransition();
				},
				onTransitionCoverAfter: isCompleted =>
				{
					ReturnToOverworld(new List<LevelData> { level }, isCompleted, completedStates, null, false, null, null);
					callback?.Invoke(isCompleted);
				},
				resetStrokesWhenFinished: true,
				showStrokeCounter: true
			));
		}
	}

	public void ToggleOverworld(bool isOverworldActive)
	{
		state = isOverworldActive ? STATES.active : STATES.inlevel;
		m_OnToggleOverworld?.Invoke(isOverworldActive);
		if (disableWhilePlaying != null)
		{
			foreach (var go in disableWhilePlaying)
				if (go != null) go.SetActive(isOverworldActive);
		}
		if (gridRigid != null)
			gridRigid.simulated = isOverworldActive;
		if (gridfiller != null && gridfiller.AllRenders != null)
		{
			for (int i = 0; i < gridfiller.AllRenders.Count; i++)
			{
				var r = gridfiller.AllRenders[i];
				if (r != null) r.enabled = isOverworldActive;
			}
		}
		if (ui != null && ui.gameObject != null)
			ui.gameObject.SetActive(isOverworldActive);
		if (ball != null)
		{
			if (isOverworldActive)
			{
				ball.ShowAndEnable();
				if (ball.Controller != null)
					ball.Controller.Activate();
			}
			else
			{
				ball.HideAndStop();
			}
		}
	}

	private IEnumerator StartGoalLevel(OverworldGoal goal, string challengeID, OverworldBall2D ballHit = null, UnityAction<bool> afterLevelCallback = null)
	{
		if (goal == null || goal.levelData == null) yield break;
		state = STATES.inlevel;
		var allGoalLevels = goal.GetAllGoalLevels();
		OnLevelStarting?.Invoke(allGoalLevels);
		currentGoal = goal;

		List<LevelData> levelsToPlay = allGoalLevels;
		bool wasChallengeAlreadyCompleted = true;
		if (string.IsNullOrEmpty(challengeID))
		{
			if (goal.ExcludeFromSequence != null && goal.ExcludeFromSequence.Count > 0)
				levelsToPlay = allGoalLevels.Except(goal.ExcludeFromSequence).ToList();
		}
		else
		{
			var targetLevel = allGoalLevels.FirstOrDefault(l => l != null && l.levelChallenges != null && l.levelChallenges.Any(c => c != null && c.ID == challengeID));
			if (targetLevel != null)
			{
				levelsToPlay = new List<LevelData> { targetLevel };
				wasChallengeAlreadyCompleted = targetLevel.CompletedChallenges != null && targetLevel.CompletedChallenges.Contains(challengeID);
			}
		}

		if (levelsToPlay == null || levelsToPlay.Count == 0)
			levelsToPlay = new List<LevelData> { goal.levelData };

		var completedStates = new List<Level.CompletedState>();
		var failStates = new List<Level.FailState>();

		for (int i = 0; i < levelsToPlay.Count; i++)
		{
			var lvlData = levelsToPlay[i];
			if (lvlData == null) continue;
			bool isLast = i == levelsToPlay.Count - 1;
			bool leaveSequence = false;
			int prevStrokes = completedStates.Count > 0 ? completedStates[completedStates.Count - 1].Strokes : 0;

			yield return StartCoroutine(LevelManager.Instance.Play(
				lvlData,
				onTransitionCoverBefore: () => ToggleOverworld(false),
				onComplete: cs =>
				{
					completedStates.Add(cs);
					if (cs != null && cs.LeaveLevel)
					{
						leaveSequence = true;
						i = levelsToPlay.Count;
					}
					else if (cs != null && cs.LevelSkips != 0)
					{
						i = Mathf.Clamp(i + cs.LevelSkips, -1, levelsToPlay.Count - 2);
					}
					if (leaveSequence || isLast)
					{
						if (overworldMusic != null)
							overworldMusic.StartWithoutTransition();
						foreach (var ld in levelsToPlay)
						{
							if (ld != null)
								ld.IsCompletedInSaveGame = true;
						}
					}
				},
				onFail: fs =>
				{
					if (fs != null)
						failStates.Add(fs);
				},
				onAbort: () =>
				{
					leaveSequence = true;
					i = levelsToPlay.Count;
				},
				onTransitionCoverAfter: isCompleted =>
				{
					if (leaveSequence || isLast)
					{
						ReturnToOverworld(levelsToPlay, isCompleted, completedStates, goal, string.IsNullOrEmpty(challengeID), ballHit, failStates);
						if (isCompleted && !wasChallengeAlreadyCompleted && ui != null && !string.IsNullOrEmpty(challengeID))
							ui.ChallengeCompleted(challengeID);
						afterLevelCallback?.Invoke(isCompleted);
						if (isCompleted && lastFlag != null && lastFlag.levelData != null && currentGoal != null && currentGoal.levelData == lastFlag.levelData)
							m_OnLastFlagExit?.Invoke(lastFlag.levelData);
					}
				},
				skipTransitionIn: i > 0,
				skipTransitionOut: !isLast && !leaveSequence,
				strokesFromPreviousLevels: prevStrokes,
				resetStrokesWhenFinished: isLast,
				showStrokeCounter: !string.IsNullOrEmpty(challengeID),
				challengeID: challengeID
			));
		}

		if (currentGoal != null)
			StartCoroutine(currentGoal.UpdatePlayerTracking(true));
		SaveGame.Save();
	}

	public void DisableInteraction(bool hide = true)
	{
		IsInteractionDisabled = true;
		if (ui != null && ui.ExitOverworldButton != null)
		{
			ui.ExitOverworldButton.gameObject.SetActive(false);
		}
		var b = BallOrIslandBall;
		if (b != null)
		{
			if (hide) b.HideAndStop(true);
			else b.StopBall(false);
		}
	}

	public void EnableInteraction()
	{
		IsInteractionDisabled = false;
		if (ui != null && ui.ExitOverworldButton != null)
		{
			ui.ExitOverworldButton.gameObject.SetActive(true);
		}
		var b = BallOrIslandBall;
		if (b != null && state == STATES.active)
		{
			b.ShowAndEnable();
			if (b.Controller != null)
			{
				b.Controller.enabled = true;
				b.Controller.Activate();
			}
		}
	}

	public HubSection FindCurrentHubSection()
	{
		if (state != STATES.active || ball == null || gridfiller == null || gridfiller.hubSectionContainer == null)
			return null;
		foreach (var hs in gridfiller.hubSectionContainer.GetComponentsInChildren<HubSection>(false))
		{
			if (hs == null || hs.Container == null || !hs.Container.activeSelf || hs.SectionTilemap == null)
				continue;
			Vector3Int cell = hs.SectionTilemap.WorldToCell(ball.transform.position);
			if (hs.SectionTilemap.GetTile(cell) != null)
				return hs;
		}
		Bounds b = new Bounds(ball.transform.position, new Vector3(1f, 1f, 100f));
		foreach (var hs in FindObjectsOfType<HubSection>())
		{
			if (hs != null && hs.Intersects(b))
				return hs;
		}
		return null;
	}

	public void DisplayCampaignHub(bool display)
	{
		ToggleOverworld(display);
		if (display)
		{
			state = STATES.active;
			if (AudioManager.Instance != null && AudioManager.Instance.AmbientPlayer != null)
				AudioManager.Instance.AmbientPlayer.SetAmbients(new List<Audio.AmbientAudio>());
			if (overworldMusic != null)
				overworldMusic.StartWithoutTransition();
		}
	}

	public void ResetBallPositionToLastSave()
	{
		if (ball != null)
		{
			ball.transform.position = ballStartPosition;
		}
	}

	public IEnumerator CameraMoveCenter(Transform target, float duration)
	{
		if (Camera == null || target == null || duration <= 0f)
			yield break;
		Vector3 startPos = Camera.transform.position;
		Vector3 endPos = new Vector3(target.position.x, target.position.y, startPos.z);
		Camera.enabled = false;
		yield return StartCoroutine(pTween.ToRealTime(duration, t =>
		{
			if (Camera != null)
				Camera.transform.position = Vector3.Lerp(startPos, endPos, TweenFunctions.EaseInOut(t));
		}));
		if (Camera != null)
			Camera.enabled = true;
	}
}
