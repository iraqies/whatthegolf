using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class CompetitionOverworld : MonoBehaviour
{
	public int startIndex;

	public List<GameObject> disableWhilePlaying;

	public LevelDataContainer onboardingLevels;

	public MusicData music;

	public GameObject saveText;

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
