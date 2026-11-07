using System;
using System.Collections;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class TargetWavesController : MonoBehaviour
{
	[Serializable]
	public class Wave
	{
		public List<SnowBallTargetBehaviour> Targets;

		public bool StartsDisabled;
	}

	public ClipSettingsCollection sfxOnClimbSpawn;

	public List<Wave> Waves;

	private Wave currentWave;

	private void Start()
	{
	}

	private void OnCollapsed(SnowBallTargetBehaviour snowBallTargetBehaviour)
	{
	}

	private IEnumerator SetupNewWave()
	{
		return null;
	}
}
