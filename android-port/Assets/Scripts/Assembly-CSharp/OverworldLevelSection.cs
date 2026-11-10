using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class OverworldLevelSection
{
	public string name;
	public bool hasBoss;
	public Sprite image;
	public List<LevelData> levels;
	public string saveSpotId;
	public Transmogrif.BALLSHAPES ballShape;
	public string unlockTriggerId;

	[NonSerialized] public bool isAvailable;
	[NonSerialized] public float completionPercentage;

	public string ID => unlockTriggerId;
	public List<LevelData> Levels => levels;

	public void Refresh()
	{
		completionPercentage = GetCompletionPercentage();
		isAvailable = GetIsAvailable();
	}

	private bool GetIsAvailable()
	{
		if (string.IsNullOrWhiteSpace(unlockTriggerId))
			return true;
		if (SaveGame.GetIsDoorOpen(unlockTriggerId))
			return true;
		return SaveGame.GetIsMainDoorOpen(unlockTriggerId);
	}

	private float GetCompletionPercentage()
	{
		if (levels == null || levels.Count == 0)
			return 0f;
		int total = 0;
		int done = 0;
		for (int i = 0; i < levels.Count; i++)
		{
			var lv = levels[i];
			if (lv == null || string.IsNullOrEmpty(lv.SceneName))
				continue;
			total++;
			if (SaveGame.GetIsLevelCompleted(lv.SceneName, null))
				done++;
			if (lv.levelChallenges != null)
			{
				total += lv.levelChallenges.Count;
				var completedCh = lv.CompletedChallenges;
				if (completedCh != null)
					done += completedCh.Count;
			}
		}
		return total > 0 ? (float)done / total : 0f;
	}
}
