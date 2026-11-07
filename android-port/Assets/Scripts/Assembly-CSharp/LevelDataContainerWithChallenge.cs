using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class LevelDataContainerWithChallenge : LevelDataContainerBase
{
	[SerializeField]
	private LevelDataListWithChallenge levels;

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return null;
	}

	public override List<LevelData> GetLevelDatas()
	{
		return null;
	}

	public LevelDataAndChallenge GetLevel(string id)
	{
		return null;
	}
}
