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

	private void Start()
	{
		Init();
		StartWithoutTransition();
	}

	public void Init()
	{
		audioManager = AudioManager.Instance;
	}

	private void Zone_OnMusicTriggered(OverworldMusicData newMusic, List<OverworldGoal> flags)
	{
		if (newMusic != null)
			StartWithoutTransition(newMusic);
	}

	public float GetCurrentValue() => 0f;
	public void UpdatePercentageFromFlags() { }

	public void StartWithoutTransition()
	{
		if (current != null && current.withoutTransition != null && AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.SetLevelMusic(current.withoutTransition, true);
	}

	public void StartWithoutTransition(OverworldMusicData newCurrent)
	{
		current = newCurrent;
		StartWithoutTransition();
	}

	public void SwitchToWithTransition()
	{
		if (current != null && current.withTransition != null && AudioManager.Instance != null && AudioManager.Instance.music != null)
			AudioManager.Instance.music.SetLevelMusic(current.withTransition, false);
	}

	public void SetPercentage(float pct, bool fromMenu = false) { }
	public void SetValue(float value) { }
}
