using System;
using System.Collections.Generic;
using Core;
using UnityEngine;

[Serializable]
public class DailyChallengeLevelDataContainerContainer : LevelDataContainerBase
{
	[SerializeField]
	private DailyChallengeLevelContainerList levelContainers;

	public DailyChallengeLevelDataContainer DebugContainer;

	public List<DailyChallengeLevelDataContainer> GetContainers()
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
}
