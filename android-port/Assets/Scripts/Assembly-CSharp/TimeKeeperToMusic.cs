using System.Collections;
using Core;
using UnityEngine;

public class TimeKeeperToMusic : MonoBehaviour
{
	private Level level;

	private IEnumerator Start()
	{
		while (Level.Instance == null || Level.Instance.music == null)
		{
			yield return null;
		}
		level = Level.Instance;
		if (level.music.isInitialized)
		{
			Music_OnIntialized();
		}
		else
		{
			level.music.OnIntialized += Music_OnIntialized;
		}
	}

	private void Music_OnIntialized()
	{
		if (level != null && level.music != null)
		{
			level.music.OnIntialized -= Music_OnIntialized;
			level.music.isAimingAffectingTime = false;
			level.music.isSettingSlowmotionContinuesly = true;
		}
	}

	private void Update()
	{
		if (level != null && level.music != null)
		{
			level.music.isSlowmotion = true;
		}
	}
}
