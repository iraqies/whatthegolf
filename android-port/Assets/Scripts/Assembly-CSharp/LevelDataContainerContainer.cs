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
