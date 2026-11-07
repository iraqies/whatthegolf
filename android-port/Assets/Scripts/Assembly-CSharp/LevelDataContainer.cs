using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class LevelDataContainer : LevelDataContainerBase
{
	[SerializeField]
	private LevelDataList levels;

	public bool UseFilter;

	public bool UsedInDailyChallenges;

	public float Weight;

	public List<LevelData> GetLevels()
	{
		return null;
	}

	public override List<LevelData> GetLevelDatas()
	{
		return null;
	}

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return null;
	}

	public void SetLevels(List<LevelData> list)
	{
	}

	public LevelData GetLevel(string id)
	{
		return null;
	}

	public int Swap(LevelData oldLvlData, LevelData newLvlData)
	{
		return 0;
	}

	public int CalculateWeight()
	{
		return 0;
	}
}
