using System.Collections.Generic;
using Core;
using UnityEngine;

public abstract class LevelDataContainerBase : ScriptableObject
{
	public LeaderboardBoard leaderboard;

	public bool hasLeaderboard => false;

	public abstract List<LevelData> GetLevelDatas();

	public abstract List<LevelDataAndChallenge> GetLevelDatasWithChallenges();
}
