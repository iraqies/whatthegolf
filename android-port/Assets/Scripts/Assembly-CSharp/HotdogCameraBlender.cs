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
	private float delay;

	[SerializeField]
	private float zoomOut;

	[SerializeField]
	private float duration;

	[SerializeField]
	private UnityEvent AllGoalsAreDoneFromStart;

	private Coroutine holeRoutine;

	private bool hasShownHoleRoutine;

	private bool checkIfDone()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void OnDoorOpen()
	{
	}

	private void ShowHoleInstant()
	{
	}

	private IEnumerator ShowHoleRoutine()
	{
		return null;
	}

	private void InterruptRoutine(bool show)
	{
	}
}
