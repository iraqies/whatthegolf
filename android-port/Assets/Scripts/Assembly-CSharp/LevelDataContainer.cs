using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

[Serializable]
public class LevelDataContainer : LevelDataContainerBase
{
	[SerializeField]
	private LevelDataList levels;

	public bool UseFilter;
	public bool UsedInDailyChallenges;
	public float Weight = 1f;

	public List<LevelData> GetLevels()
	{
		if (levels == null) return new List<LevelData>();
		var list = new List<LevelData>(levels.Count);
		for (int i = 0; i < levels.Count; i++)
		{
			if (levels[i] != null) list.Add(levels[i]);
		}
		return list;
	}

	public override List<LevelData> GetLevelDatas() => GetLevels();

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return GetLevels().Select(l => new LevelDataAndChallenge { level = l, challengeID = string.Empty }).ToList();
	}

	public void SetLevels(List<LevelData> list)
	{
		if (levels == null) levels = new LevelDataList();
		levels.Clear();
		if (list != null)
		{
			foreach (var l in list) levels.Add(l);
		}
	}

	public LevelData GetLevel(string id)
	{
		return GetLevels().FirstOrDefault(l => l != null && (l.ID == id || l.name == id));
	}

	public int Swap(LevelData oldLvlData, LevelData newLvlData)
	{
		if (levels == null) return -1;
		int idx = levels.IndexOf(oldLvlData);
		if (idx >= 0) levels[idx] = newLvlData;
		return idx;
	}

	public int CalculateWeight() => Mathf.Max(1, Mathf.RoundToInt(Weight));
}
