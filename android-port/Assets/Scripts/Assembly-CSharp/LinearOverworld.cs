using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class LinearOverworld : MonoBehaviour
{
	public bool HideRestart;

	public bool HideExit;

	public bool HideStats;

	public int startIndex;

	public List<GameObject> disableWhilePlaying;

	public LevelDataContainer onboardingLevels;

	public MusicData menuMusic;

	public float MusicVolume;

	private void Start()
	{
	}

	private IEnumerator delayedStartMusic()
	{
		return null;
	}

	private IEnumerator PlayOnboardingLevels()
	{
		return null;
	}
}
