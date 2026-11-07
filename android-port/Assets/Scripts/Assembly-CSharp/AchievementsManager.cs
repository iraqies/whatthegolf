using System.Collections;
using UnityEngine;

public class AchievementsManager : MonoBehaviour
{
	public UnlockAchievement strokes100;

	public UnlockAchievement strokes1000;

	public UnlockAchievement strokes10000;

	public UnlockAchievement strokes100000;

	public UnlockAchievement hours5;

	public UnlockAchievement hours10;

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void SaveGame_OnStrokesUpdated(int strokes)
	{
	}

	private void UpdatePlayTimeAchievement(int seconds)
	{
	}

	private void UpdatetrokesAchievement(int strokes)
	{
	}
}
