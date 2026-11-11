using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HotdogCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings CameraSettings;

	public List<SpriteRenderer> backgroundRenderers;

	public Color baseBackground;

	public Color endBackground;

	public Transform center;

	private Coroutine current;

	private float lastPct;

	[SerializeField]
	private OverworldButton2D door;

	[SerializeField]
	private Animator animationController;

	[SerializeField]
	private float delay = 0.5f;

	[SerializeField]
	private float zoomOut = 2f;

	[SerializeField]
	private float duration = 1f;

	[SerializeField]
	private UnityEvent AllGoalsAreDoneFromStart;

	private Coroutine holeRoutine;

	private bool hasShownHoleRoutine;

	private bool checkIfDone()
	{
		if (door == null)
		{
			return false;
		}
		OverworldID oid = door.GetComponent<OverworldID>();
		if (oid != null && SaveGame.GetIsDoorOpen(oid.ID))
		{
			return true;
		}
		return door.openOrOpening;
	}

	private void Awake()
	{
		if (checkIfDone())
		{
			ShowHoleInstant();
		}
		else if (door != null)
		{
			door.OnOpen += OnDoorOpen;
		}
	}

	private void OnDoorOpen()
	{
		if (door != null)
		{
			door.OnOpen -= OnDoorOpen;
		}
		holeRoutine = StartCoroutine(ShowHoleRoutine());
	}

	private void ShowHoleInstant()
	{
		if (animationController != null)
		{
			animationController.enabled = false;
			animationController.StopPlayback();
		}
		hasShownHoleRoutine = true;
		AllGoalsAreDoneFromStart?.Invoke();
	}

	private IEnumerator ShowHoleRoutine()
	{
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnToggleOverworld += InterruptRoutine;
		}
		yield return new WaitForSeconds(delay);
		if (animationController != null)
		{
			animationController.SetTrigger("Open");
		}
		yield return new WaitForSeconds(duration);
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnToggleOverworld -= InterruptRoutine;
		}
		hasShownHoleRoutine = true;
	}

	private void InterruptRoutine(bool show)
	{
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.OnToggleOverworld -= InterruptRoutine;
		}
		if (holeRoutine != null)
		{
			StopCoroutine(holeRoutine);
		}
		ShowHoleInstant();
	}
}
