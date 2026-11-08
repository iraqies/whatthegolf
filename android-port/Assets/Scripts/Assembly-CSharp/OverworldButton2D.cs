using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Audio;
using CameraStack;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OverworldButton2D : GolfBehaviour
{
	public enum ButtonType
	{
		fromLeft = 0,
		fromRight = 1,
		fromBelow = 2,
		fromAboveTilted = 3
	}

	public enum AddOrRemoveNotification
	{
		Add = 0,
		Remove = 1
	}

	public OverworldButton2D previous;
	public OverworldMainDoorRobot previousBoss;
	private Action m_OnOpen;
	private Action m_OnStartingToOpen;
	public bool isStartingOpen;
	public Transform flagContainer;
	public int flagsRequiredOffset;
	public TextMeshPro missingFlagsText;
	public Transform openIndicator;
	public PlantParticles openParticles;
	public float BallDistanceThreshold = 3f;
	public bool canOpen = true;
	public float volumeMultiplier = 1f;
	public ButtonType orientation;
	public AudioClip sfxOnOpen;
	public AudioClip sfxExplosion;
	public bool isTilted;
	public OverworldDoor HorizontalDoor;
	public OverworldDoor VerticalDoor;
	public Transform DoorBubbleTransform;
	public SpriteRenderer BubbleSprite;
	public SpriteRenderer SubObjectiveSprite;
	public bool isSnappingToGrid;
	public bool isShowingHintLines;
	public int maxHintLinesToShow;
	public bool onlyIncludeFlagsBelowThis;
	public bool useOpenIndicator;
	public Collectable subObjective;
	public int subObjectiveGoal;
	public List<OverworldGoal> requireGoals = new List<OverworldGoal>();
	public ClipSettingsCollection sfxOpen;
	public ClipSettingsCollection sfxAfterOpen;
	public bool OnlyAcceptCrowns;
	public bool UseAllFlagsInOverworld;

	private OverworldCamera camera;
	private bool currentlyCheating;
	private float cheatUnlockTimer;
	private Tilemap tileMap;
	protected DoorBubble doorBubble;
	private OverworldDoor door;
	public OverworldMainButton ConsoleButton;
	[NonSerialized] public bool openOrOpening;
	private bool hasSubobjectives;
	[SerializeField] private PerlinShake bubbleShake;
	private int count;
	public float UnlockBlinkRate = 1f;
	public Color[] OpenColors;
	public Color[] UnlockedColors;
	public Color[] LockedColors;
	public SpriteRenderer[] ButtonRenderers;
	public SpriteRenderer[] ButtonBackRenderers;
	private OverworldID overworldID;
	private Coroutine currentBlinkRoutine;
	private bool isActive = true;
	private bool canShowBubble;
	[SerializeField] private AddOrRemoveNotification addOrRemoveNotification;
	[SerializeField] private string levelNotificationId;

	public int GetTotalCount => requireGoals != null ? requireGoals.Count : 0;
	public bool IsOpenOrOpening => openOrOpening;
	public bool CanOpen => GetFlagsLeft() <= 0;

	public event Action OnOpen
	{
		add => m_OnOpen = (Action)Delegate.Combine(m_OnOpen, value);
		remove => m_OnOpen = (Action)Delegate.Remove(m_OnOpen, value);
	}

	public event Action OnStartingToOpen
	{
		add => m_OnStartingToOpen = (Action)Delegate.Combine(m_OnStartingToOpen, value);
		remove => m_OnStartingToOpen = (Action)Delegate.Remove(m_OnStartingToOpen, value);
	}

	public override void OnPrePlayOrPreCompile() { }

	private void Awake()
	{
		overworldID = GetComponent<OverworldID>();
		door = HorizontalDoor != null ? HorizontalDoor : VerticalDoor;
	}

	private void Start()
	{
		if (isStartingOpen || (overworldID != null && SaveGame.GetIsDoorOpen(overworldID.ID)))
			JustOpen(true);
		else
			UpdateStatus();
	}

	public virtual void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
		this.tileMap = tilemap;
		this.camera = camera;
		UpdateStatus();
	}

	private void HandlePreviousOpened() => UpdateStatus();
	public void AfterInit() => UpdateStatus();
	private IEnumerator FlagHintRoutine() { yield break; }
	private IEnumerator BlinkRoutine() { yield break; }
	private void Goal_OnUpdateData(OverworldGoal obj) => UpdateStatus();

	public virtual int GetFlagsLeft()
	{
		if (requireGoals == null || requireGoals.Count == 0) return 0;
		int completed = 0;
		foreach (var g in requireGoals)
		{
			if (g != null && g.IsCompleted()) completed++;
		}
		return Mathf.Max(0, requireGoals.Count + flagsRequiredOffset - completed);
	}

	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
		if (openIndicator != null) openIndicator.gameObject.SetActive(open);
	}

	public void ToggleBlinkRoutine(bool turnOn) { }

	public virtual void UpdateStatus()
	{
		int left = GetFlagsLeft();
		if (missingFlagsText != null)
			missingFlagsText.text = left > 0 ? left.ToString() : string.Empty;
	}

	public void CheckOpen()
	{
		if (CanDoorBeOpened()) OpenDoor();
	}

	private void OnOpenDoorAnalytcis() { }
	public void InstantOpenDoor() => JustOpen(true);
	public bool CanDoorBeOpened() => !openOrOpening && GetFlagsLeft() <= 0;

	public void OpenDoor()
	{
		if (openOrOpening) return;
		JustOpen(false);
	}

	public void RemoveButton() => gameObject.SetActive(false);

	public void JustOpen(bool instant = false)
	{
		openOrOpening = true;
		m_OnStartingToOpen?.Invoke();
		if (overworldID != null && !string.IsNullOrEmpty(overworldID.ID))
			SaveGame.SetDoorOpen(overworldID.ID);
		if (HorizontalDoor != null) HorizontalDoor.gameObject.SetActive(false);
		if (VerticalDoor != null) VerticalDoor.gameObject.SetActive(false);
		if (door != null) door.gameObject.SetActive(false);
		SetOpenIndicator(true);
		m_OnOpen?.Invoke();
	}

	public IEnumerator OpenAndClose(float delay)
	{
		JustOpen(false);
		yield return new WaitForSeconds(delay);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision != null && collision.collider.GetComponentInParent<OverworldBall2D>() != null)
			CheckOpen();
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other != null && other.GetComponentInParent<OverworldBall2D>() != null)
			CheckOpen();
	}

	private Vector3 GetSnappedPosition() => transform.position;
	private ButtonType FlipTiltedOrientation(ButtonType orientation) => orientation;
	public void OnDrawGizmos() { }
	private void OnDrawGizmosSelected() { }
	private IEnumerator CheatingRoutine() { yield break; }
	public void OnMouseDown() => CheckOpen();
	public void OnMouseExit() { }
	public void OnMouseUp() { }
	public void DebugOpenDoor() => JustOpen(true);
}
