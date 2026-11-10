using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class PlayPack : MonoBehaviour
{
	[SerializeField]
	private DailyChallengeLevelDataContainer _container;

	private void Start()
	{
		StartCoroutine(PlayShowToAFriendLevels());
	}

	public IEnumerator PlayShowToAFriendLevels()
	{
		if (_container == null)
		{
			yield break;
		}
		List<LevelData> levels = _container.GetLevelDatas();
		LevelManager levelManager = LevelManager.Instance;
		yield return null;
		bool shouldQuit = false;
		if (levels == null || levelManager == null)
		{
			yield break;
		}
		for (int i = 0; i < levels.Count; i++)
		{
			LevelData current = levels[i];
			if (current == null)
			{
				break;
			}
			if (AudioManager.Instance != null && AudioManager.Instance.music != null && current.music != null)
			{
				AudioManager.Instance.music.SetLevelMusic(current.music, false);
			}
			yield return StartCoroutine(levelManager.Play(current, null, null, null, null, delegate(Level.CompletedState s)
			{
				if (s != null)
				{
					s.Message = _container.PunCompletionID(current);
					if (s.LevelSkips != 0)
					{
						i = Mathf.Clamp(i + s.LevelSkips, -1, levels.Count - 2);
					}
				}
			}, null, null, delegate
			{
				shouldQuit = true;
			}, delegate(bool isCompleted)
			{
				Debug.Log("Level " + i + " of " + levels.Count + " completed: " + isCompleted);
			}));
			if (shouldQuit)
			{
				break;
			}
		}
	}
}
