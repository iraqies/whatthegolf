using System;
using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

[Serializable]
public class LevelDataContainerWithChallenge : LevelDataContainerBase
{
	[SerializeField]
	private LevelDataListWithChallenge levels;

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		var res = new List<LevelDataAndChallenge>();
		if (levels != null)
		{
			for (int i = 0; i < levels.Count; i++)
				if (levels[i].level != null) res.Add(levels[i]);
		}
		return res;
	}

	public override List<LevelData> GetLevelDatas()
	{
		return GetLevelDatasWithChallenges().Select(x => x.level).Where(l => l != null).ToList();
	}

	public LevelDataAndChallenge GetLevel(string id)
	{
		return GetLevelDatasWithChallenges().FirstOrDefault(x => x.level != null && (x.level.ID == id || x.level.name == id));
	}
}
