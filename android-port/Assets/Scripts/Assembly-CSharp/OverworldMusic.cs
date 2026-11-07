using System.Collections.Generic;
using Core;
using UnityEngine;

public class OverworldMusic : MonoBehaviour
{
	public OverworldMusicData current;

	private AudioManager audioManager;

	private List<OverworldGoal> currentFlags;

	private bool isUsingTransition;

	private float flagCount;

	public void Init()
	{
	}

	private void Zone_OnMusicTriggered(OverworldMusicData newMusic, List<OverworldGoal> flags)
	{
	}

	public float GetCurrentValue()
	{
		return 0f;
	}

	public void UpdatePercentageFromFlags()
	{
	}

	public void StartWithoutTransition()
	{
	}

	public void StartWithoutTransition(OverworldMusicData newCurrent)
	{
	}

	public void SwitchToWithTransition()
	{
	}

	public void SetPercentage(float pct, bool fromMenu = false)
	{
	}

	public void SetValue(float value)
	{
	}
}
