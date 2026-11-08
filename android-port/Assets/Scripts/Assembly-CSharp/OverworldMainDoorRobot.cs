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

		foreach (var plate in plates)
		{
			if (plate == null) continue;
			plate.Initialize(this);
			plate.OnStateChange += (on, isLoad) =>
			{
				m_OnPlateChanged?.Invoke();
				if (on && !isLoad)
				{
					bool isLast = CanBeOpened();
					StartCoroutine(ButtonRoutine(plate, isLast));
				}
			};
		}

		bool savedCompleted = overworldID != null && !string.IsNullOrEmpty(overworldID.ID) && SaveGame.GetIsMainDoorOpen(overworldID.ID);
		State initialState = State.Closed;
		if (savedCompleted)
		{
			initialState = State.Completed;
			foreach (var p in plates)
				if (p != null) p.SetState(true, true);
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
		var sfx = isLastPlate ? sfxFinalButtonOn : sfxFirstButtonOn;
		if (sfx != null && AudioManager.Instance != null)
			sfx.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);

		yield return new WaitForSeconds(0.5f);

		var ball = OverworldBallManager.HasInstance && OverworldBallManager.Instance != null ? OverworldBallManager.Instance.Ball : null;
		if (ball != null && plate != null && plate.returningBallTransform != null)
		{
			ball.transform.position = plate.returningBallTransform.position;
			ball.ShowAndEnable();
			ball.Velocity = plate.returningBallTransform.right * 6f;
		}
		if (sfxShootOutBall != null && AudioManager.Instance != null)
			sfxShootOutBall.Play(AudioManager.Instance.sfx, Vector3.zero, 0f);
		m_OnExitedCable?.Invoke(this);

		if (isLastPlate)
		{
			yield return new WaitForSeconds(0.5f);
			if (hintArrow != null)
				hintArrow.SetActive(true);
			Change(State.Open, false);
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
		if (currentBall != null)
			currentBall.HideAndStop(true);
		if (overworldCamera != null)
			overworldCamera.Shake(3.5f, 40f, 0.15f);
		if (srcBootingUp != null)
			srcBootingUp.Play();
		yield return new WaitForSeconds(0.5f);

		if (AnimatorFace != null)
			AnimatorFace.SetBool("On", true);

		if (overworldManager != null && bossLevel != null)
		{
			bool didComplete = false;
			yield return StartCoroutine(overworldManager.StartBossLevel(bossLevel, won => didComplete = won));
			yield return StartCoroutine(Explode(didComplete));
		}
		else
		{
			yield return StartCoroutine(Explode(true));
		}
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
		if (didComplete)
		{
			m_OnBallExitedAndIsExploding?.Invoke(this);
			if (hintArrow != null)
				hintArrow.SetActive(false);
			if (AnimatorFace != null)
				AnimatorFace.SetTrigger("Explode");
			if (AnimatorDoor != null)
				AnimatorDoor.SetTrigger("Explode");
			yield return new WaitForSeconds(0.4f);
			if (Explosion != null)
				Explosion.Explode(2.5f);
			if (overworldCamera != null)
				overworldCamera.Shake(0.2f, 100f, 1f);
			FadeOut(srcBootingUp, 1f);
			Change(State.Completed, false);
			yield return new WaitForSeconds(0.3f);
		}
		else
		{
			Change(State.Open, false);
		}
		if (currentBall != null)
		{
			if (ballStartPosition != null)
				currentBall.transform.position = ballStartPosition.position;
			currentBall.ShowAndEnable();
		}
		yield return new WaitForSeconds(0.1f);
	}

	public void SetCompleted() => Change(State.Completed, true);
	private IEnumerator CheatingRoutine() { yield break; }
	public void OnMouseDown() { }
	public void OnMouseExit() { }
	public void OnMouseUp() { }
}
