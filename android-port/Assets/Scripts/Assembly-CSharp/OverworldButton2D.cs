using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Audio;
using CameraStack;
using Core;
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
	public bool isShowingHintLines = true;
	public int maxHintLinesToShow = 15;
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

	public int GetTotalCount
	{
		get
		{
			if (subObjective != null && !UseAllFlagsInOverworld)
				return subObjectiveGoal;
			return requireGoals != null ? requireGoals.Count : 0;
		}
	}

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

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		bubbleShake = GetComponentInChildren<PerlinShake>();
	}

	private void Awake()
	{
		if (flagContainer != null)
			flagContainer.gameObject.SetActive(false);
	}

	public virtual void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
		this.tileMap = tilemap;
		this.camera = camera;
		requireGoals = new List<OverworldGoal>();

		Bounds flagBounds = default;
		bool hasFlagBounds = false;
		if (flagContainer != null)
		{
			flagBounds = new Bounds(flagContainer.position, flagContainer.localScale + Vector3.forward * 100f);
			flagContainer.gameObject.SetActive(false);
			hasFlagBounds = true;
		}

		hasSubobjectives = subObjective != null;

		if (goals != null)
		{
			for (int i = 0; i < goals.Count; i++)
			{
				var g = goals[i];
				if (g == null || !g.gameObject.activeInHierarchy)
					continue;
				if ((hasFlagBounds && flagBounds.Contains(g.transform.position)) || UseAllFlagsInOverworld)
				{
					if (g.levelData != null && !g.isSkipping)
					{
						requireGoals.Add(g);
						g.OnUpdateData -= Goal_OnUpdateData;
						g.OnUpdateData += Goal_OnUpdateData;
					}
				}
			}
		}

		transform.position = GetSnappedPosition();

		var currentCfg = PlatformSettings.Instance != null ? PlatformSettings.Instance.GetCurrent() : null;
		if (currentCfg == null || !currentCfg.useRotatedOverworldAndCameraInLevels)
			isTilted = false;

		ButtonType effOrientation = isTilted ? FlipTiltedOrientation(orientation) : orientation;
		if (effOrientation == ButtonType.fromBelow)
		{
			door = HorizontalDoor;
			if (door != null)
				door.transform.localEulerAngles = Vector3.zero;
		}
		else if (effOrientation == ButtonType.fromLeft)
		{
			door = VerticalDoor;
			if (door != null)
				door.transform.localEulerAngles = new Vector3(0f, 0f, -90f);
		}
		else if (effOrientation == ButtonType.fromRight)
		{
			door = VerticalDoor;
			if (door != null)
				door.transform.localEulerAngles = new Vector3(0f, 0f, 90f);
		}
		else if (effOrientation == ButtonType.fromAboveTilted)
		{
			door = HorizontalDoor;
			if (door != null)
				door.transform.localEulerAngles = new Vector3(0f, 0f, 180f);
		}

		if (HorizontalDoor != null)
			HorizontalDoor.gameObject.SetActive(door == HorizontalDoor);
		if (VerticalDoor != null)
			VerticalDoor.gameObject.SetActive(door == VerticalDoor);

		if (door != null)
		{
			door.SetCamera(camera);
			if (isTilted)
			{
				door.transform.localEulerAngles += new Vector3(0f, 0f, -90f);
			}
			if (DoorBubbleTransform != null)
			{
				Vector3 cornerDir = isTilted ? new Vector3(-1f, 0f, 0f) : new Vector3(1f, 0f, 0f);
				DoorBubbleTransform.position = door.GetCornerInThatDirection(cornerDir) - Vector3.forward;
				float bubbleZRot = isTilted ? (transform.localEulerAngles.z + 270f) : 0f;
				DoorBubbleTransform.localRotation = Quaternion.Euler(0f, 0f, bubbleZRot);
				doorBubble = DoorBubbleTransform.gameObject.GetComponent<DoorBubble>();
				if (doorBubble != null)
					doorBubble.Init();
			}
			if (openIndicator != null)
			{
				openIndicator.position = door.transform.position - door.transform.up;
			}
		}

		count = GetFlagsLeft();
		overworldID = GetComponent<OverworldID>();

		bool alreadyOpen = isStartingOpen || (overworldID != null && !string.IsNullOrEmpty(overworldID.ID) && SaveGame.GetIsDoorOpen(overworldID.ID));
		if (alreadyOpen)
		{
			openOrOpening = true;
			if (useOpenIndicator && openIndicator != null)
				openIndicator.gameObject.SetActive(false);
			if (missingFlagsText != null && missingFlagsText.transform.parent != null)
				missingFlagsText.transform.parent.gameObject.SetActive(false);
			SetButtonColors(OpenColors);
			if (door != null)
			{
				door.Init();
				door.OpenDoor(() => m_OnOpen?.Invoke(), true);
			}
		}

		if (hasSubobjectives)
		{
			if (missingFlagsText != null)
				missingFlagsText.transform.localPosition = new Vector3(0.875f, 0.55f, 0f);
			if (BubbleSprite != null)
				BubbleSprite.transform.localScale = new Vector3(1.75f, 1.75f, 0f);
			if (SubObjectiveSprite != null && subObjective != null)
			{
				SubObjectiveSprite.sprite = subObjective.icon;
				SubObjectiveSprite.gameObject.SetActive(true);
			}
		}

		if (HorizontalDoor != null)
			HorizontalDoor.Init();
		if (VerticalDoor != null)
			VerticalDoor.Init();

		if (previous != null)
		{
			previous.OnOpen -= HandlePreviousOpened;
			previous.OnOpen += HandlePreviousOpened;
		}
		if (previousBoss != null)
		{
			previousBoss.OnCompleted -= HandlePreviousOpened;
			previousBoss.OnCompleted += HandlePreviousOpened;
		}
	}

	private void SetButtonColors(Color[] colors)
	{
		if (colors == null || colors.Length == 0) return;
		if (ButtonRenderers != null)
		{
			for (int i = 0; i < ButtonRenderers.Length; i++)
				if (ButtonRenderers[i] != null) ButtonRenderers[i].color = colors[0];
		}
		if (ButtonBackRenderers != null && colors.Length > 1)
		{
			for (int i = 0; i < ButtonBackRenderers.Length; i++)
				if (ButtonBackRenderers[i] != null) ButtonBackRenderers[i].color = colors[1];
		}
	}

	private void HandlePreviousOpened()
	{
		UpdateStatus();
	}

	public void AfterInit() => UpdateStatus();

	private IEnumerator FlagHintRoutine()
	{
		SetButtonColors(UnlockedColors);
		if (requireGoals != null && HintEffect.Instance != null)
		{
			var positions = requireGoals
				.Where(g => g != null && (OnlyAcceptCrowns ? !g.IsFullyCompleted() : !g.IsCompleted()) && g.IsVisible())
				.Select(g => g.transform.position)
				.Take(maxHintLinesToShow > 0 ? maxHintLinesToShow : 15)
				.ToArray();
			if (positions.Length > 0)
			{
				Vector3 center = (ButtonRenderers != null && ButtonRenderers.Length > 0 && ButtonRenderers[0] != null)
					? ButtonRenderers[0].transform.position
					: transform.position;
				HintEffect.Instance.Play(center, positions);
			}
		}
		yield return new WaitForSeconds(0.3f);
		if (!openOrOpening)
			SetButtonColors(LockedColors);
	}

	private IEnumerator BlinkRoutine()
	{
		while (!openOrOpening)
		{
			SetButtonColors(UnlockedColors);
			yield return new WaitForSeconds(Mathf.Max(0.2f, UnlockBlinkRate * 0.5f));
			if (openOrOpening) break;
			SetButtonColors(OpenColors);
			yield return new WaitForSeconds(Mathf.Max(0.2f, UnlockBlinkRate * 0.5f));
		}
	}

	private void Goal_OnUpdateData(OverworldGoal obj) => UpdateStatus();

	public virtual int GetFlagsLeft()
	{
		int total = GetTotalCount;
		int completed = 0;
		if (subObjective != null)
		{
			completed = SaveGame.GetListCount(subObjective.serializationId);
		}
		else if (requireGoals != null)
		{
			for (int i = 0; i < requireGoals.Count; i++)
			{
				var g = requireGoals[i];
				if (g == null) continue;
				if (OnlyAcceptCrowns)
				{
					if (g.IsFullyCompleted()) completed++;
				}
				else
				{
					if (g.IsCompleted()) completed++;
				}
			}
		}
		return total - completed - flagsRequiredOffset;
	}

	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
		if (useOpenIndicator && openIndicator != null)
			openIndicator.gameObject.SetActive(open);
	}

	public void ToggleBlinkRoutine(bool turnOn)
	{
		if (turnOn)
		{
			if (currentBlinkRoutine == null && gameObject.activeInHierarchy)
				currentBlinkRoutine = StartCoroutine(BlinkRoutine());
		}
		else
		{
			if (currentBlinkRoutine != null)
			{
				StopCoroutine(currentBlinkRoutine);
				currentBlinkRoutine = null;
			}
		}
	}

	public virtual void UpdateStatus()
	{
		int flagsLeft = GetFlagsLeft();
		bool prevOpen = previous == null || previous.openOrOpening;
		bool bossOpen = previousBoss == null || previousBoss.IsCompleted();

		if (count != flagsLeft)
		{
			if (bubbleShake != null)
				bubbleShake.Shake(0.5f, 10f, 0.2f);
			count = flagsLeft;
		}

		if (useOpenIndicator && openIndicator != null)
			openIndicator.gameObject.SetActive(false);

		if (flagsLeft >= 1)
		{
			ToggleBlinkRoutine(false);
			SetButtonColors(LockedColors);
			if (missingFlagsText != null)
			{
				if (hasSubobjectives || UseAllFlagsInOverworld)
				{
					int total = subObjectiveGoal;
					int done = total - flagsLeft;
					missingFlagsText.text = string.Format("{0}/{1}", done, total);
				}
				else if (requireGoals != null)
				{
					int total = requireGoals.Count - flagsRequiredOffset;
					int done = total - flagsLeft;
					missingFlagsText.text = string.Format("{0}/{1}", done, total);
				}
			}
		}
		else
		{
			if (missingFlagsText != null)
				missingFlagsText.text = "!";
			if (!openOrOpening && canOpen && prevOpen && bossOpen)
			{
				if (door != null && openIndicator != null)
				{
					Vector3 dPos = door.transform.position;
					Vector3 iPos = openIndicator.position;
					float angle = Mathf.Atan2(dPos.y - iPos.y, dPos.x - iPos.x) * Mathf.Rad2Deg;
					openIndicator.rotation = Quaternion.Euler(0f, 0f, angle - 90f);
				}
				if (useOpenIndicator && openIndicator != null)
					openIndicator.gameObject.SetActive(true);
				ToggleBlinkRoutine(true);
			}
			else if (!openOrOpening)
			{
				ToggleBlinkRoutine(false);
				SetButtonColors(LockedColors);
			}
		}

		isActive = prevOpen && bossOpen && !openOrOpening;
		canShowBubble = isActive && flagsLeft > 0;

		if (doorBubble != null)
		{
			if (openOrOpening)
				doorBubble.State = DoorBubbleState.Hidden;
			else if (OnlyAcceptCrowns)
				doorBubble.State = SaveGame.CrownAwarenessMode ? (canShowBubble ? DoorBubbleState.Visible : DoorBubbleState.Hidden) : DoorBubbleState.ShowOnHit;
			else
				doorBubble.State = canShowBubble ? DoorBubbleState.Visible : DoorBubbleState.Hidden;
		}

		if (!UseAllFlagsInOverworld && !OnlyAcceptCrowns && requireGoals != null)
		{
			for (int i = 0; i < requireGoals.Count; i++)
			{
				var g = requireGoals[i];
				if (g != null)
				{
					g.CanShowIndicator = canShowBubble;
					g.RefreshVisuals();
				}
			}
		}
	}

	public void CheckOpen()
	{
		if (!openOrOpening)
			UpdateStatus();
		if (GetFlagsLeft() > 0)
		{
			if (isShowingHintLines && gameObject.activeInHierarchy)
				StartCoroutine(FlagHintRoutine());
			if (doorBubble != null)
				doorBubble.Hit();
			return;
		}
		if (openOrOpening)
			return;

		OpenDoor();
	}

	private void OnOpenDoorAnalytcis() { }
	public void InstantOpenDoor() => JustOpen(true);
	public bool CanDoorBeOpened() => !openOrOpening && GetFlagsLeft() <= 0;

	public void OpenDoor()
	{
		if (openOrOpening) return;
		m_OnStartingToOpen?.Invoke();
		openOrOpening = true;
		if (overworldID != null && !string.IsNullOrEmpty(overworldID.ID))
			SaveGame.SetDoorOpen(overworldID.ID);
		if (openParticles != null)
			openParticles.Emit(40);
		if (sfxOpen != null && AudioManager.Instance != null)
			sfxOpen.Play(AudioManager.Instance.sfx, transform.position, 0f);
		ToggleBlinkRoutine(false);
		SetButtonColors(OpenColors);
		if (useOpenIndicator && openIndicator != null)
			openIndicator.gameObject.SetActive(false);
		if (missingFlagsText != null && missingFlagsText.transform.parent != null)
			missingFlagsText.transform.parent.gameObject.SetActive(false);
		if (doorBubble != null)
			doorBubble.State = DoorBubbleState.Hidden;
		if (ConsoleButton != null)
			ConsoleButton.SetBlinking();
		if (door != null)
		{
			door.OpenDoor(() =>
			{
				if (sfxAfterOpen != null && AudioManager.Instance != null)
					sfxAfterOpen.Play(AudioManager.Instance.sfx, transform.position, 0f);
				m_OnOpen?.Invoke();
			}, false);
		}
		else
		{
			m_OnOpen?.Invoke();
		}
	}

	public void RemoveButton()
	{
		if (door != null) door.RemoveButton();
	}

	public void JustOpen(bool instant = false)
	{
		openOrOpening = true;
		m_OnStartingToOpen?.Invoke();
		if (overworldID != null && !string.IsNullOrEmpty(overworldID.ID))
			SaveGame.SetDoorOpen(overworldID.ID);
		ToggleBlinkRoutine(false);
		SetButtonColors(OpenColors);
		if (useOpenIndicator && openIndicator != null)
			openIndicator.gameObject.SetActive(false);
		if (missingFlagsText != null && missingFlagsText.transform.parent != null)
			missingFlagsText.transform.parent.gameObject.SetActive(false);
		if (doorBubble != null)
			doorBubble.State = DoorBubbleState.Hidden;
		if (door != null)
			door.OpenDoor(() => m_OnOpen?.Invoke(), instant);
		else
			m_OnOpen?.Invoke();
	}

	public IEnumerator OpenAndClose(float delay)
	{
		JustOpen(false);
		yield return new WaitForSeconds(delay);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (openOrOpening || !canOpen || collision == null || collision.collider == null)
			return;
		var ball = collision.collider.GetComponent<OverworldBall2D>() ?? collision.collider.GetComponentInParent<OverworldBall2D>();
		if (ball == null)
			return;
		if (!ball.CheckUseInteractiveThing())
			return;

		CheckOpen();

		var rb = collision.collider.GetComponent<Rigidbody2D>();
		if (rb != null && openIndicator != null)
		{
			Vector2 pushOut = (openIndicator.position - transform.position).normalized;
			rb.velocity = (pushOut + rb.velocity.normalized) * rb.velocity.magnitude * 0.16f;
		}
	}

	private Vector3 GetSnappedPosition()
	{
		if (tileMap == null)
		{
			var hs = GetComponentInParent<HubSection>();
			if (hs != null)
				tileMap = hs.SectionTilemap;
		}
		Vector3 pos = transform.position;
		float origZ = pos.z;
		if (tileMap == null)
			return pos;

		Vector3 cellSize = tileMap.cellSize;
		Vector3 adj = pos;
		if (!isTilted)
		{
			adj.x -= cellSize.x;
			adj.y -= cellSize.y * 0.5f;
		}
		if (isSnappingToGrid)
		{
			Vector3Int cell = tileMap.WorldToCell(transform.position);
			adj = tileMap.CellToWorld(cell);
			adj.z = origZ;
		}
		Vector3 res = pos;
		if (orientation == ButtonType.fromBelow)
		{
			res = new Vector3(adj.x + cellSize.x, adj.y + cellSize.y * 0.5f, adj.z);
		}
		else if (orientation == ButtonType.fromLeft || orientation == ButtonType.fromRight)
		{
			res = new Vector3(adj.x + cellSize.x * 0.5f, adj.y, adj.z);
		}
		return res;
	}

	private ButtonType FlipTiltedOrientation(ButtonType orientation)
	{
		if (!isTilted) return orientation;
		switch (orientation)
		{
			case ButtonType.fromLeft: return ButtonType.fromBelow;
			case ButtonType.fromRight: return ButtonType.fromAboveTilted;
			case ButtonType.fromBelow: return ButtonType.fromRight;
			case ButtonType.fromAboveTilted: return ButtonType.fromLeft;
			default: return orientation;
		}
	}

	public void OnDrawGizmos() { }
	private void OnDrawGizmosSelected() { }
	private IEnumerator CheatingRoutine() { yield break; }
	public void OnMouseDown() { }
	public void OnMouseExit() { }
	public void OnMouseUp() { }
	public void DebugOpenDoor() => JustOpen(true);
}
