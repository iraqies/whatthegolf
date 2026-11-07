using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class LevelDataContainerContainer : LevelDataContainerBase
{
	[SerializeField]
	private LevelContainerList levelContainers;

	public LevelDataContainer DebugContainer;

	public List<LevelDataContainer> GetContainers()
	{
		var res = new List<LevelDataContainer>();
		if (levelContainers != null)
		{
			for (int i = 0; i < levelContainers.Count; i++)
				if (levelContainers[i] != null) res.Add(levelContainers[i]);
		}
		return res;
	}

	public override List<LevelData> GetLevelDatas()
	{
		var res = new List<LevelData>();
		foreach (var c in GetContainers())
		{
			var l = c.GetLevelDatas();
			if (l != null) res.AddRange(l);
		}
		return res;
	}

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		var res = new List<LevelDataAndChallenge>();
		foreach (var c in GetContainers())
		{
			var l = c.GetLevelDatasWithChallenges();
			if (l != null) res.AddRange(l);
		}
		return res;
	}
}
