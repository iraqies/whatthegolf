using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CameraStack;
using Core;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OverworldOLButton2D : MonoBehaviour
{
	[SerializeField]
	private List<OverworldGoal> goals;

	[SerializeField]
	private OverworldOLDoor goldDoor;

	[SerializeField]
	private OverworldOLDoor silverDoor;

	[SerializeField]
	private OverworldOLDoor bronzeDoor;

	private List<OverworldOLDoor> doors = new List<OverworldOLDoor>();

	[SerializeField]
	private bool canOpen = true;

	[SerializeField]
	private bool useOpenIndicator = true;

	[SerializeField]
	private Transform openIndicator;

	[SerializeField]
	private float BallDistanceThreshold = 15f;

	[SerializeField]
	private Transform hintStartPosition;

	[SerializeField]
	private int maxHintLinesToShow = 10;

	public float UnlockBlinkRate = 1.2f;

	public Color[] OpenColors;

	public Color[] UnlockedColors;

	public Color[] LockedColors;

	public SpriteRenderer[] ButtonRenderers;

	public SpriteRenderer[] ButtonBackRenderers;

	[SerializeField]
	private bool hideButton;

	[SerializeField]
	private GameObject buttonContainer;

	private Coroutine currentBlinkRoutine;

	private int levelsCompletedForWorstGoal;

	private List<bool> doorOpenOrOpening = new List<bool>();

	private bool isShowingHintLines;

	public virtual void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
		if (goals != null)
		{
			foreach (OverworldGoal goal in goals)
			{
				if (goal != null)
				{
					goal.OnUpdateData += Goal_OnUpdateData;
				}
			}
		}
		if (hideButton && buttonContainer != null)
		{
			buttonContainer.SetActive(false);
		}
		levelsCompletedForWorstGoal = GetLevelsCompletedForWorstGoal();
		Vector2 direction = Vector2.zero;
		if (openIndicator != null)
		{
			direction = new Vector2(0f, base.transform.position.y - openIndicator.position.y);
		}
		if (doors == null)
		{
			doors = new List<OverworldOLDoor>();
		}
		doors.Clear();
		doors.Add(bronzeDoor);
		doors.Add(silverDoor);
		doors.Add(goldDoor);
		if (doorOpenOrOpening == null)
		{
			doorOpenOrOpening = new List<bool>();
		}
		doorOpenOrOpening.Clear();
		for (int i = 0; i < doors.Count; i++)
		{
			OverworldOLDoor overworldOLDoor = doors[i];
			if (overworldOLDoor == null)
			{
				doorOpenOrOpening.Add(false);
				continue;
			}
			overworldOLDoor.SetCamera(camera);
			overworldOLDoor.Init();
			bool flag = overworldOLDoor.overworldID != null && SaveGame.GetIsDoorOpen(overworldOLDoor.overworldID.id);
			if (flag)
			{
				SetOpenIndicator(false);
				overworldOLDoor.OpenDoor(null, direction, true);
			}
			doorOpenOrOpening.Add(flag);
		}
	}

	private void HandlePreviousOpened()
	{
	}

	public void AfterInit()
	{
		UpdateStatus();
	}

	private IEnumerator FlagHintRoutine()
	{
		isShowingHintLines = true;
		SetButtonColors(LockedColors);
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.ball != null)
		{
			if (Vector3.Distance(OverworldBallManager.Instance.ball.transform.position, base.transform.position) < BallDistanceThreshold && hintStartPosition != null && goals != null && HintEffect.Instance != null)
			{
				Vector3 position = hintStartPosition.position;
				List<Vector3> list = goals.Select((OverworldGoal goal) => goal.transform.position).Take(maxHintLinesToShow).ToList();
				HintEffect.Instance.Play(position, list.ToArray());
			}
		}
		yield return new WaitForSeconds(0.3f);
		SetButtonColors(OpenColors);
		isShowingHintLines = false;
	}

	private IEnumerator BlinkRoutine()
	{
		WaitForSeconds waitTime = new WaitForSeconds(UnlockBlinkRate * 0.5f);
		yield return null;
		while (true)
		{
			SetButtonColors(UnlockedColors);
			yield return waitTime;
			SetButtonColors(LockedColors);
			yield return waitTime;
		}
	}

	private void Goal_OnUpdateData(OverworldGoal obj)
	{
		UpdateStatus();
	}

	private bool IsBronzeCompleted()
	{
		return GetLevelsCompletedForWorstGoal() > 0;
	}

	private bool IsSilverCompleted()
	{
		return GetLevelsCompletedForWorstGoal() > 1;
	}

	private bool IsGoldCompleted()
	{
		return GetLevelsCompletedForWorstGoal() > 2;
	}

	private int GetLevelsCompleted(OverworldGoal goal)
	{
		if (goal == null)
		{
			return 0;
		}
		int num = (goal.IsCompleted() ? 1 : 0);
		List<LevelData> allGoalLevels = goal.GetAllGoalLevels();
		if (allGoalLevels != null)
		{
			foreach (LevelData item in allGoalLevels)
			{
				if (item != null && item.CompletedChallenges != null)
				{
					num += item.CompletedChallenges.Count;
				}
			}
		}
		return num;
	}

	private int GetLevelsCompletedForWorstGoal()
	{
		if (goals == null)
		{
			return 0;
		}
		int num = 10000;
		foreach (OverworldGoal goal in goals)
		{
			num = Mathf.Min(num, GetLevelsCompleted(goal));
		}
		return num;
	}

	public void SetOpenIndicator(bool open, bool setRotation = false)
	{
		if (openIndicator == null)
		{
			return;
		}
		Vector3 position = base.transform.position;
		Vector3 position2 = openIndicator.position;
		float num = Mathf.Atan2(position.y - position2.y, position.x - position2.x) * 57.29578f;
		openIndicator.rotation = Quaternion.Euler(0f, 0f, num - 90f);
		if (useOpenIndicator)
		{
			openIndicator.gameObject.SetActive(open);
		}
	}

	public void ToggleBlinkRoutine(bool turnOn)
	{
		if (turnOn)
		{
			if (base.gameObject.activeInHierarchy && currentBlinkRoutine == null)
			{
				currentBlinkRoutine = StartCoroutine(BlinkRoutine());
			}
		}
		else if (currentBlinkRoutine != null)
		{
			StopCoroutine(currentBlinkRoutine);
			currentBlinkRoutine = null;
		}
	}

	public virtual void UpdateStatus()
	{
		levelsCompletedForWorstGoal = GetLevelsCompletedForWorstGoal();
		int num = ((doorOpenOrOpening != null) ? doorOpenOrOpening.Count((bool i) => i) : 0);
		if (num == Mathf.Clamp(levelsCompletedForWorstGoal, 0, 3))
		{
			SetButtonColors(OpenColors);
			if (currentBlinkRoutine != null)
			{
				StopCoroutine(currentBlinkRoutine);
				currentBlinkRoutine = null;
			}
			SetOpenIndicator(false);
		}
		else
		{
			ToggleBlinkRoutine(true);
			SetOpenIndicator(true);
			SetButtonColors(UnlockedColors);
		}
		if (goals == null)
		{
			return;
		}
		bool showFlagCrownLock = levelsCompletedForWorstGoal < 3;
		foreach (OverworldGoal goal in goals)
		{
			if (goal != null)
			{
				goal.showFlagCrownLock = showFlagCrownLock;
				goal.RefreshVisuals();
			}
		}
	}

	public void CheckOpen()
	{
		if (doorOpenOrOpening != null && doorOpenOrOpening.Contains(false))
		{
			UpdateStatus();
		}
		if (levelsCompletedForWorstGoal >= 3)
		{
			CheckOpen(goldDoor);
			SetButtonColors(UnlockedColors);
			return;
		}
		if (levelsCompletedForWorstGoal == 1 || levelsCompletedForWorstGoal == 2)
		{
			OverworldOLDoor relevantDoor = ((levelsCompletedForWorstGoal == 1) ? bronzeDoor : silverDoor);
			if (CheckOpen(relevantDoor))
			{
				SetButtonColors(OpenColors);
			}
			else if (!isShowingHintLines)
			{
				StartCoroutine(FlagHintRoutine());
			}
		}
		else if (!isShowingHintLines)
		{
			StartCoroutine(FlagHintRoutine());
		}
	}

	private void ShowHints()
	{
		if (!isShowingHintLines)
		{
			StartCoroutine(FlagHintRoutine());
		}
	}

	private bool CheckOpen(OverworldOLDoor relevantDoor)
	{
		if (doors == null)
		{
			return false;
		}
		int num = doors.IndexOf(relevantDoor);
		if (num < 0)
		{
			return false;
		}
		Vector2 direction = Vector2.zero;
		if (openIndicator != null)
		{
			direction = new Vector2(0f, base.transform.position.y - openIndicator.position.y);
		}
		bool result = false;
		for (int i = 0; i <= num; i++)
		{
			OverworldOLDoor overworldOLDoor = doors[i];
			if (!doorOpenOrOpening[i])
			{
				doorOpenOrOpening[i] = true;
				if (overworldOLDoor != null && overworldOLDoor.overworldID != null)
				{
					SaveGame.SetDoorOpen(overworldOLDoor.overworldID.id);
				}
				if (currentBlinkRoutine != null)
				{
					StopCoroutine(currentBlinkRoutine);
					currentBlinkRoutine = null;
				}
				SetOpenIndicator(false);
				if (overworldOLDoor != null)
				{
					overworldOLDoor.OpenDoor(null, direction, false);
				}
				result = true;
			}
		}
		return result;
	}

	private void SetButtonColors(Color[] colors)
	{
		if (ButtonRenderers == null || colors == null || colors.Length == 0)
		{
			return;
		}
		for (int i = 0; i < ButtonRenderers.Length; i++)
		{
			if (ButtonRenderers[i] != null)
			{
				ButtonRenderers[i].color = colors[0];
			}
			if (ButtonBackRenderers != null && i < ButtonBackRenderers.Length && ButtonBackRenderers[i] != null && colors.Length > 1)
			{
				ButtonBackRenderers[i].color = colors[1];
			}
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (!canOpen || doorOpenOrOpening == null || !doorOpenOrOpening.Contains(false) || collision == null)
		{
			return;
		}
		OverworldBall2D componentInParent = collision.gameObject.GetComponentInParent<OverworldBall2D>();
		if (componentInParent != null && componentInParent.CheckUseInteractiveThing())
		{
			CheckOpen();
			Rigidbody2D component = componentInParent.GetComponent<Rigidbody2D>();
			if (component != null && openIndicator != null)
			{
				Vector3 normalized = (openIndicator.position - base.transform.position).normalized;
				Vector2 normalized2 = component.velocity.normalized;
				Vector2 vector = new Vector2(normalized.x + normalized2.x, normalized.y + normalized2.y);
				float magnitude = component.velocity.magnitude;
				component.velocity = vector * magnitude;
				component.velocity *= 0.16f;
			}
		}
	}
}
