using System.Collections;
using System.Collections.Generic;
using CameraStack;
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

	private List<OverworldOLDoor> doors;

	[SerializeField]
	private bool canOpen;

	[SerializeField]
	private bool useOpenIndicator;

	[SerializeField]
	private Transform openIndicator;

	[SerializeField]
	private float BallDistanceThreshold;

	[SerializeField]
	private Transform hintStartPosition;

	[SerializeField]
	private int maxHintLinesToShow;

	public float UnlockBlinkRate;

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

	private List<bool> doorOpenOrOpening;

	private bool isShowingHintLines;

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

	private bool IsBronzeCompleted()
	{
		return false;
	}

	private bool IsSilverCompleted()
	{
		return false;
	}

	private bool IsGoldCompleted()
	{
		return false;
	}

	private int GetLevelsCompleted(OverworldGoal goal)
	{
		return 0;
	}

	private int GetLevelsCompletedForWorstGoal()
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

	private void ShowHints()
	{
	}

	private bool CheckOpen(OverworldOLDoor relevantDoor)
	{
		return false;
	}

	private void SetButtonColors(Color[] colors)
	{
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
	}
}
