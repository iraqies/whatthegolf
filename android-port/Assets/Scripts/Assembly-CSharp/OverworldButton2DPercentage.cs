using System.Collections.Generic;
using System.Text.RegularExpressions;
using CameraStack;
using UnityEngine;
using UnityEngine.Tilemaps;

public class OverworldButton2DPercentage : OverworldButton2D
{
	public float PercentageThreshold = 1f;

	public List<OverworldGoal> ignoreFlags;

	private Regex whitespaceRemover = new Regex("\\s+");

	private float Threshold => PercentageThreshold * 100f;

	public override void Init(Tilemap tilemap, List<OverworldGoal> goals, OverworldCamera camera)
	{
		base.Init(tilemap, goals, camera);
		foreach (OverworldGoal goal in goals)
		{
			if (goal.levelData != null && !goal.isSkipping && !ignoreFlags.Contains(goal))
			{
				requireGoals.Add(goal);
				goal.OnUpdateData += delegate
				{
					UpdateStatus();
				};
			}
		}
	}

	public override void UpdateStatus()
	{
		float completedPercentage = SaveGame.GetCompletedPercentage(SaveGame.LastPlayedCampaignType, null, true);
		missingFlagsText.text = whitespaceRemover.Replace(Mathf.FloorToInt(completedPercentage) + "/" + $"{PercentageThreshold:P0}", "");
		bool flag = previous == null || previous.openOrOpening;
		bool flag2 = previousBoss == null || previousBoss.IsCompleted();
		bool flag3 = Threshold >= completedPercentage && flag && flag2;
		if (flag2 && flag && doorBubble != null)
		{
			doorBubble.State = DoorBubbleState.Visible;
		}
		if (!flag3)
		{
			if (canOpen && flag && flag2)
			{
				SetOpenIndicator(true, true);
				ToggleBlinkRoutine(true);
			}
			else
			{
				ToggleBlinkRoutine(false);
			}
		}
	}

	public override int GetFlagsLeft()
	{
		float completedPercentage = SaveGame.GetCompletedPercentage(SaveGame.LastPlayedCampaignType, null, true);
		return (Threshold > completedPercentage) ? 1 : 0;
	}
}
