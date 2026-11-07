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

	[CompilerGenerated]
	private Action m_OnOpen;

	[CompilerGenerated]
	private Action m_OnStartingToOpen;

	public bool isStartingOpen;

	public Transform flagContainer;

	public int flagsRequiredOffset;

	public TextMeshPro missingFlagsText;

	public Transform openIndicator;

	public PlantParticles openParticles;

	public float BallDistanceThreshold;

	public bool canOpen;

	public float volumeMultiplier;

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

	public List<OverworldGoal> requireGoals;

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

	[NonSerialized]
	public bool openOrOpening;

	private bool hasSubobjectives;

	[SerializeField]
	private PerlinShake bubbleShake;

	private int count;

	public float UnlockBlinkRate;

	public Color[] OpenColors;

	public Color[] UnlockedColors;

	public Color[] LockedColors;

	public SpriteRenderer[] ButtonRenderers;

	public SpriteRenderer[] ButtonBackRenderers;

	private OverworldID overworldID;

	private Coroutine currentBlinkRoutine;

	private bool isActive;

	private bool canShowBubble;

	[SerializeField]
	private AddOrRemoveNotification addOrRemoveNotification;

	[SerializeField]
	private string levelNotificationId;

	public int GetTotalCount => 0;

	public bool IsOpenOrOpening => false;

	public bool CanOpen => false;

	public event Action OnOpen
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

	public event Action OnStartingToOpen
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

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Awake()
	{
	}

	public virtual void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
	}

	private void HandlePreviousOpened()
	{
	}

	public void AfterInit()
	{
	}

	private IEnumerator FlagHintRoutine()
	{
		return null;
	}

	private IEnumerator BlinkRoutine()
	{
		return null;
	}

	private void Goal_OnUpdateData(OverworldGoal obj)
	{
	}

	public virtual int GetFlagsLeft()
	{
		return 0;
	}

	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
	}

	public void ToggleBlinkRoutine(bool turnOn)
	{
	}

	public virtual void UpdateStatus()
	{
	}

	public void CheckOpen()
	{
	}

	private void OnOpenDoorAnalytcis()
	{
	}

	public void InstantOpenDoor()
	{
	}

	public bool CanDoorBeOpened()
	{
		return false;
	}

	public void OpenDoor()
	{
	}

	public void RemoveButton()
	{
	}

	public void JustOpen(bool instant = false)
	{
	}

	public IEnumerator OpenAndClose(float delay)
	{
		return null;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	private Vector3 GetSnappedPosition()
	{
		return default;
	}

	private ButtonType FlipTiltedOrientation(ButtonType orientation)
	{
		return ButtonType.fromLeft;
	}

	public void OnDrawGizmos()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	private IEnumerator CheatingRoutine()
	{
		return null;
	}

	public void OnMouseDown()
	{
	}

	public void OnMouseExit()
	{
	}

	public void OnMouseUp()
	{
	}

	public void DebugOpenDoor()
	{
	}
}
