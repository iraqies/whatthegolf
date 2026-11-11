using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Audio;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OverworldMainDoorRobot : MonoBehaviour
{
	public enum State
	{
		Closed = 0,
		Open = 1,
		Completed = 2
	}

	public LevelData bossLevel;
	public string bossLevelID;
	public string bossLevelName;
	public bool hasLevels;
	public Action OnCompleted;

	[CompilerGenerated]
	private Action m_OnIsReady;

	[CompilerGenerated]
	private Action m_OnPlateChanged;

	[CompilerGenerated]
	private Action<OverworldMainDoorRobot> m_OnBallExitedAndIsExploding;

	[CompilerGenerated]
	private Action m_OnOpen;

	public Transmogrif transmogrif;
	public ShowSpeechbubbleOnHit speech;
	public List<OverworldMainDoorPlate> plates = new List<OverworldMainDoorPlate>();
	public OverworldMainDoorButton button;
	public GameObject hintArrow;
	public Transform ballStartPosition;
	public GameObject normalBase;
	public GameObject normalColliders;
	public GameObject destroyedBase;
	public GameObject destroyedColliders;
	public List<ParticleSystem> particlesBeforeTakingOff;
	public Transform screenCenterTransform;
	public AudioSource srcBootingUp;
	public ClipSettingsCollection sfxShootOutBall;
	public ClipSettingsCollection sfxFirstButtonOn;
	public ClipSettingsCollection sfxFinalButtonOn;
	public ClipSettingsCollection explosionBuildupSFX;
	private readonly string saveFormatUnlockedPlate = "{0}_{1}_unlocked";
	private readonly string saveFormatCompleted = "{0}_completed";

	[CompilerGenerated]
	private Action<OverworldMainDoorRobot> m_OnExitedCable;

	public string notificationId;
	private Tilemap tileMap;
	private OverworldCamera overworldCamera;
	private OverworldBall2D currentBall;
	public Animator AnimatorFace;
	public Animator AnimatorDoor;
	public Explosion2D Explosion;
	public Explosion2D[] ExplosionsSmall;
	public State state;
	private OverworldManager2d overworldManager;
	private OverworldID overworldID;
	private float lastActivationTime;
	private float activationCooldown = 1f;
	private UnlockAchievement achievement;
	private bool currentlyCheating;
	private float cheatUnlockTimer;

	public bool IsInitialized { get; private set; }

	public event Action OnIsReady
	{
		[CompilerGenerated]
		add => m_OnIsReady = (Action)Delegate.Combine(m_OnIsReady, value);
		[CompilerGenerated]
		remove => m_OnIsReady = (Action)Delegate.Remove(m_OnIsReady, value);
	}

	public event Action OnPlateChanged
	{
		[CompilerGenerated]
		add => m_OnPlateChanged = (Action)Delegate.Combine(m_OnPlateChanged, value);
		[CompilerGenerated]
		remove => m_OnPlateChanged = (Action)Delegate.Remove(m_OnPlateChanged, value);
	}

	public event Action<OverworldMainDoorRobot> OnBallExitedAndIsExploding
	{
		[CompilerGenerated]
		add => m_OnBallExitedAndIsExploding = (Action<OverworldMainDoorRobot>)Delegate.Combine(m_OnBallExitedAndIsExploding, value);
		[CompilerGenerated]
		remove => m_OnBallExitedAndIsExploding = (Action<OverworldMainDoorRobot>)Delegate.Remove(m_OnBallExitedAndIsExploding, value);
	}

	public event Action OnOpen
	{
		[CompilerGenerated]
		add => m_OnOpen = (Action)Delegate.Combine(m_OnOpen, value);
		[CompilerGenerated]
		remove => m_OnOpen = (Action)Delegate.Remove(m_OnOpen, value);
	}

	public event Action<OverworldMainDoorRobot> OnExitedCable
	{
		[CompilerGenerated]
		add => m_OnExitedCable = (Action<OverworldMainDoorRobot>)Delegate.Combine(m_OnExitedCable, value);
		[CompilerGenerated]
		remove => m_OnExitedCable = (Action<OverworldMainDoorRobot>)Delegate.Remove(m_OnExitedCable, value);
	}

	private void OnValidate()
	{
		if (bossLevel != null)
		{
			bossLevelID = bossLevel.GetID();
			bossLevelName = bossLevel.SceneName;
		}
	}

	public bool IsOpen() => state == State.Open || state == State.Completed;

	public void Initialize(OverworldManager2d overworldManager, Tilemap tilemap)
	{
		this.overworldManager = overworldManager;
		this.tileMap = tilemap;
		overworldID = GetComponent<OverworldID>();
		overworldCamera = OverworldCamera.Instance != null ? OverworldCamera.Instance : FindObjectOfType<OverworldCamera>();
		if (hintArrow != null)
			hintArrow.SetActive(false);
		achievement = GetComponent<UnlockAchievement>();

		if (plates == null || plates.Count == 0)
			plates = GetComponentsInChildren<OverworldMainDoorPlate>(true).ToList();

		bool savedCompleted = overworldID != null && !string.IsNullOrEmpty(overworldID.ID) && SaveGame.GetIsMainDoorOpen(overworldID.ID);
		string idPrefix = overworldID != null && !string.IsNullOrEmpty(overworldID.ID) ? overworldID.ID : name;

		foreach (var plate in plates)
		{
			if (plate == null) continue;
			plate.Initialize(this);
			string plateKey = string.Format(saveFormatUnlockedPlate, idPrefix, plate.name);
			bool plateUnlocked = savedCompleted || SaveGame.GetValue(plateKey, false);
			if (plateUnlocked)
				plate.SetState(true, true);
			plate.OnStateChange += (on, isLoad) =>
			{
				if (on && !isLoad)
				{
					SaveGame.SetValue(plateKey, true, true);
				}
				m_OnPlateChanged?.Invoke();
				if (on && !isLoad)
				{
					bool isLast = CanBeOpened();
					StartCoroutine(ButtonRoutine(plate, isLast));
				}
			};
		}

		State initialState = State.Closed;
		if (savedCompleted)
		{
			initialState = State.Completed;
			foreach (var p in plates)
				if (p != null) p.SetState(true, true);
			if (speech != null)
				speech.isAbleToTalk = false;
			if (achievement != null)
				achievement.ManualUnlock();
		}
		else if (CanBeOpened())
		{
			initialState = State.Open;
			if (hintArrow != null)
				hintArrow.SetActive(true);
		}
		Change(initialState, true);

		if (button != null)
		{
			button.OnHitWhenInactive -= OnHitInactiveButton;
			button.OnHitWhenInactive += OnHitInactiveButton;
			button.OnHitWhenActive -= OnHitActiveButton;
			button.OnHitWhenActive += OnHitActiveButton;
		}

		m_OnIsReady?.Invoke();
		IsInitialized = true;
	}

	private void OnHitInactiveButton(OverworldBall2D ball)
	{
		var mcs = GetComponent<MainComputerSpeechbubble>();
		if (mcs != null)
			mcs.UpddateSpeechBubbles();
		if (speech != null)
			speech.ShowBubble();
	}

	private bool CanBeOpened()
	{
		if (plates == null || plates.Count == 0)
			return false;
		return plates.All(p => p == null || p.isOn);
	}

	private IEnumerator ButtonRoutine(OverworldMainDoorPlate plate, bool isLastPlate)
	{
		if (plate == null)
			yield break;

		OverworldBall2D ball = OverworldBallManager.HasInstance && OverworldBallManager.Instance != null ? OverworldBallManager.Instance.Ball : null;
		if (ball == null && overworldManager != null)
			ball = overworldManager.ball;

		if (plate.isMovingBallOut && ball != null && plate.returningBallTransform != null)
		{
			Vector3 startPos = ball.transform.position;
			Vector3 targetPos = plate.returningBallTransform.position + plate.returningBallTransform.right * 3f;
			StartCoroutine(pTween.To(0.8f, t =>
			{
				if (ball != null)
				{
					ball.transform.position = Vector3.Lerp(startPos, targetPos, TweenFunctions.EaseInOut(t));
					if (overworldManager != null && overworldManager.cameraTarget != null)
						overworldManager.cameraTarget.position = ball.transform.position;
				}
			}));
		}

		if (sfxFirstButtonOn != null)
			sfxFirstButtonOn.Play(null, transform.position, 1f, 1f);

		yield return new WaitForSeconds(1.8f);

		if (plate.isMovingBallOut && OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
		{
			Transform spawnTrans = plate.returningBallTransform != null ? plate.returningBallTransform : plate.transform;
			if (transmogrif != null)
				OverworldBallManager.Instance.Load(transmogrif.targetShape);
			ball = OverworldBallManager.Instance.Ball;
			if (ball != null)
			{
				ball.transform.position = spawnTrans.position;
				ball.transform.rotation = spawnTrans.rotation;
				ball.ShowAndEnable();
				ball.enabled = true;
				if (ball.rigidBody != null)
					ball.rigidBody.isKinematic = false;
				ball.SetColliders(false);
				if (ball.Controller != null)
				{
					ball.Controller.enabled = true;
					ball.Controller.Activate();
				}
				ball.Velocity = spawnTrans.right * 6f;
				if (overworldManager != null)
				{
					overworldManager.RegisterBall(ball, transmogrif != null ? transmogrif.targetShape : Transmogrif.BALLSHAPES.ball);
					if (overworldManager.cameraTarget != null)
						overworldManager.cameraTarget.position = ball.transform.position;
					if (overworldManager.culling != null)
						overworldManager.culling.UpdateCulling();
				}
			}
			if (sfxShootOutBall != null)
				sfxShootOutBall.Play(null, transform.position, 1f, 1f);
		}
		else if (ball != null)
		{
			ball.ShowAndEnable();
			ball.enabled = true;
			if (ball.rigidBody != null)
				ball.rigidBody.isKinematic = false;
			ball.SetColliders(true);
			if (ball.Controller != null)
			{
				ball.Controller.enabled = true;
				ball.Controller.Activate();
			}
		}

		m_OnExitedCable?.Invoke(this);
		yield return new WaitForSeconds(0.1f);

		ball = OverworldBallManager.HasInstance && OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null
			? OverworldBallManager.Instance.Ball
			: ball;
		if (ball != null)
			ball.SetColliders(true);

		yield return new WaitForSeconds(0.2f);

		if (isLastPlate)
		{
			if (hasLevels && bossLevel != null)
			{
				Change(State.Open, false);
				if (hintArrow != null)
					hintArrow.SetActive(true);
			}
			else
			{
				currentBall = ball;
				StartCoroutine(Explode(true, 0.4f, 0.4f));
			}
		}
		else
		{
			SaveGame.Save(false);
		}
	}

	private void OnHitActiveButton(OverworldBall2D ball)
	{
		if (Time.unscaledTime < lastActivationTime + activationCooldown)
			return;
		lastActivationTime = Time.unscaledTime;
		currentBall = ball;
		StartCoroutine(StartLevelRoutine());
	}

	private void Change(State newState, bool forceChange = false)
	{
		if (!forceChange && state == newState)
			return;
		state = newState;
		if (!string.IsNullOrEmpty(notificationId))
		{
			if (state == State.Open)
				SaveGame.AddLevelNotification(notificationId);
			else if (state == State.Completed)
				SaveGame.RemoveLevelNotification(notificationId);
		}
		if (normalBase != null) normalBase.SetActive(state != State.Completed);
		if (normalColliders != null) normalColliders.SetActive(state != State.Completed);
		if (destroyedBase != null) destroyedBase.SetActive(state == State.Completed);
		if (destroyedColliders != null) destroyedColliders.SetActive(state == State.Completed);
		if (button != null) button.IsActive = (state == State.Open);

		if (state == State.Completed)
		{
			if (overworldID != null && !string.IsNullOrEmpty(overworldID.ID))
			{
				SaveGame.SetMainDoorOpen(overworldID.ID);
				SaveGame.Save(false);
			}
			OnCompleted?.Invoke();
		}
		if (state == State.Open || state == State.Completed)
			m_OnOpen?.Invoke();
	}

	private IEnumerator StartLevelRoutine()
	{
		if (currentBall == null && OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
			currentBall = OverworldBallManager.Instance.Ball;
		if (currentBall == null && overworldManager != null)
			currentBall = overworldManager.ball;

		if (currentBall != null)
			currentBall.HideAndStop(true);
		if (overworldCamera != null)
			overworldCamera.Shake(3.5f, 40f, 0.15f);
		if (overworldManager != null)
			overworldManager.SetBallStartPosition(transform.position + new Vector3(0f, -2f, 0f));

		if (srcBootingUp != null)
		{
			srcBootingUp.Play();
			yield return StartCoroutine(pTween.To(0.06f, 0f, 1f, v =>
			{
				if (srcBootingUp != null)
					srcBootingUp.volume = v;
			}));
		}

		yield return new WaitForSeconds(1.5f);

		if (overworldCamera != null)
			overworldCamera.Shake(2f, 60f, 0.5f);
		if (AnimatorFace != null)
			AnimatorFace.SetBool("Scanlines", true);

		if (overworldManager == null || !hasLevels || bossLevel == null)
		{
			yield return StartCoroutine(Explode(true));
			yield break;
		}

		float startOrtho = overworldCamera != null && overworldCamera.MainCamera != null
			? overworldCamera.MainCamera.orthographicSize
			: 5f;
		float endOrtho = startOrtho * 0.2f;
		if (overworldCamera != null)
			overworldCamera.enabled = false;
		Vector3 startCamPos = overworldCamera != null ? overworldCamera.transform.position : transform.position;
		Vector3 targetCamPos = screenCenterTransform != null ? screenCenterTransform.position : transform.position;
		targetCamPos.z = startCamPos.z;

		yield return StartCoroutine(pTween.To(1f, t =>
		{
			if (overworldCamera != null)
			{
				if (overworldCamera.MainCamera != null)
					overworldCamera.MainCamera.orthographicSize = Mathf.Lerp(startOrtho, endOrtho, TweenFunctions.EaseIn(t));
				overworldCamera.transform.position = Vector3.Lerp(startCamPos, targetCamPos, TweenFunctions.EaseInOut(t));
			}
		}));

		FadeOut(srcBootingUp, 4f);

		overworldManager.StartCoroutine(overworldManager.StartBossLevel(bossLevel, didComplete =>
		{
			if (didComplete && explosionBuildupSFX != null)
				explosionBuildupSFX.Play(null, transform.position, 1f, 1f);
			if (didComplete && currentBall != null)
				currentBall.HideAndStop(true);
			StartCoroutine(Explode(didComplete, 1.8f, 2.2f));
			if (AnimatorFace != null)
				AnimatorFace.SetBool("Scanlines", false);
			if (overworldCamera != null)
			{
				if (overworldCamera.MainCamera != null)
				{
					overworldCamera.MainCamera.orthographicSize = startOrtho;
					overworldCamera.MainCamera.transform.localPosition = Vector3.zero;
				}
				overworldCamera.transform.position = startCamPos;
				overworldCamera.enabled = true;
			}
			lastActivationTime = Time.unscaledTime;
		}));
	}

	private void FadeOut(AudioSource audioSource, float duration)
	{
		if (audioSource == null) return;
		float startVol = audioSource.volume;
		StartCoroutine(pTween.Then(pTween.To(duration, startVol, 0f, v =>
		{
			if (audioSource != null) audioSource.volume = v;
		}), () =>
		{
			if (audioSource != null) audioSource.Stop();
		}));
	}

	public bool IsCompleted() => state == State.Completed;

	public void OpenDoor() => Change(State.Open, false);

	public IEnumerator Explode(bool didComplete, float delayBeforeShake = 1.8f, float delayBeforeExplosion = 2.2f)
	{
		if (currentBall == null && OverworldBallManager.HasInstance && OverworldBallManager.Instance != null)
			currentBall = OverworldBallManager.Instance.Ball;
		if (currentBall == null && overworldManager != null)
			currentBall = overworldManager.ball;

		if (didComplete)
		{
			if (currentBall != null)
				currentBall.HideAndStop(true);
			m_OnBallExitedAndIsExploding?.Invoke(this);
			if (achievement != null)
				achievement.ManualUnlock();
			if (hintArrow != null)
				hintArrow.SetActive(false);
			if (speech != null)
			{
				speech.isAbleToTalk = false;
				speech.Interrupt();
			}
			if (AnimatorFace != null)
				AnimatorFace.SetTrigger("Destroy");
			if (AnimatorDoor != null)
				AnimatorDoor.SetTrigger("Destroy");

			if (delayBeforeShake > 0f)
				yield return new WaitForSeconds(delayBeforeShake);

			if (overworldCamera != null)
				overworldCamera.Shake(2.5f, 40f, 0.15f);

			float extraDelay = Mathf.Max(0f, delayBeforeExplosion - 0.5f);
			if (extraDelay > 0f)
				yield return new WaitForSeconds(extraDelay);

			var rumble = GetComponent<Audio.Rumble.OverworldMainComputerRumble>();
			if (rumble != null)
				rumble.PlayExplosion();

			if (ExplosionsSmall != null && ExplosionsSmall.Length > 0 && ExplosionsSmall[0] != null)
				ExplosionsSmall[0].Explode(0.5f);

			yield return new WaitForSeconds(0.1f);

			if (ExplosionsSmall != null && ExplosionsSmall.Length > 1 && ExplosionsSmall[1] != null)
				ExplosionsSmall[1].Explode(1f);

			yield return new WaitForSeconds(0.05f);

			if (ExplosionsSmall != null && ExplosionsSmall.Length > 2 && ExplosionsSmall[2] != null)
				ExplosionsSmall[2].Explode(1.5f);

			yield return new WaitForSeconds(0.05f);

			if (Explosion != null)
				Explosion.Explode(2.5f);
			if (overworldCamera != null)
				overworldCamera.Shake(0.2f, 100f, 1f);
			FadeOut(srcBootingUp, 1f);

			yield return new WaitForSeconds(0.05f);

			Change(State.Completed, false);

			yield return new WaitForSeconds(0.3f);

			if (currentBall != null)
			{
				if (ballStartPosition != null)
					currentBall.transform.position = ballStartPosition.position;
				currentBall.ShowAndEnable();
			}
			yield return new WaitForSeconds(0.1f);
		}
		else
		{
			Change(State.Open, false);
			if (currentBall != null)
				currentBall.ShowAndEnable();
			yield return new WaitForSeconds(0.3f);
		}
	}

	public void SetCompleted() => Change(State.Completed, true);
	private IEnumerator CheatingRoutine() { yield break; }
	public void OnMouseDown() { }
	public void OnMouseExit() { }
	public void OnMouseUp() { }
}
