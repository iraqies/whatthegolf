using System.Collections.Generic;
using System.Linq;
using Core;
using TMPro;
using UnityEngine;

public class OverworldUnfinishedLevels : MonoBehaviour
{
	public List<HubSection> Sections;

	public TextMeshPro Text;

	private List<LevelData> allLevels;

	public void Init()
	{
		allLevels = new List<LevelData>();
		foreach (HubSection section in Sections)
		{
			if (section == null || section.gameObject == null || !section.gameObject.activeInHierarchy)
			{
				continue;
			}
			OverworldGoal[] componentsInChildren = section.GetComponentsInChildren<OverworldGoal>();
			foreach (OverworldGoal overworldGoal in componentsInChildren)
			{
				if (!(overworldGoal.levelData == null))
				{
					allLevels.AddRange(overworldGoal.GetAllGoalLevels());
					overworldGoal.OnUpdateData += OnUpdateData;
				}
			}
			OverworldLinkedGoal[] componentsInChildren2 = section.GetComponentsInChildren<OverworldLinkedGoal>();
			foreach (OverworldLinkedGoal overworldLinkedGoal in componentsInChildren2)
			{
				foreach (OverworldLinkedGoal.LinkedLevelData orderedLevel in overworldLinkedGoal.OrderedLevels)
				{
					allLevels.Add(orderedLevel.LevelData);
					allLevels.AddRange(orderedLevel.AdditionalLevels);
				}
				foreach (OverworldGoal flag in overworldLinkedGoal.Flags)
				{
					flag.OnUpdateData += OnUpdateData;
				}
			}
		}
		allLevels = allLevels.Distinct().ToList();
		UpdateThings();
	}

	private void UpdateThings()
	{
		if (allLevels.Count((LevelData l) => l.IsCompletedInSaveGame) > 0)
		{
			CountUncompletedChallenges();
		}
		else
		{
			Text.text = "0%";
		}
	}

	private void CountUncompletedChallenges()
	{
		float num = 0f;
		float num2 = 0f;
		foreach (LevelData allLevel in allLevels)
		{
			foreach (LevelData.ChallengeData challenge in allLevel.Challenges)
			{
				num += 1f;
				if (allLevel.CompletedChallenges.Any((string c) => c == challenge.ID))
				{
					num2 += 1f;
				}
			}
			num += 1f;
			if (allLevel.IsCompletedInSaveGame)
			{
				num2 += 1f;
			}
		}
		Text.text = string.Format("{0:0%}", num2 / num);
	}

	private void OnUpdateData(OverworldGoal overworldGoal)
	{
		UpdateThings();
	}
}
