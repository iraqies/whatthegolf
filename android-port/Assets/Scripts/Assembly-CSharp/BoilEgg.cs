using System;
using System.Collections;
using Audio;
using Core;
using UnityEngine;

public class BoilEgg : MonoBehaviour
{
	public GolfBallController Egg;

	public float BoilDuration;

	public LoopRandomAudioClips boilingBubbleSFX;

	public IntroLoopOutro eggTimerIntroLoopOutro;

	public float ShakeSpeed;

	public float ShakeAmount;

	private Coroutine buildRoutine;

	public Action OnBoilStart;

	public Action OnBoilComplete;

	private IEnumerator BoilRoutine()
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
