using System.Collections.Generic;
using Core;

public class MultiplayerPlayList : LevelDataContainerBase
{
	public enum LevelSelectionTypes
	{
		Random = 0,
		Ordered = 1
	}

	public enum MatchTypes
	{
		FewestStrokes = 0,
		FirstToFlag = 1
	}

	public LevelDataContainer IntroLevels;

	public List<LevelDataContainer> Levels;

	public LevelDataContainer OutroLevels;

	public LevelDataContainer NextBatch;

	public LevelDataContainer UnusedLevels;

	public int LevelsToPlay;

	public LevelSelectionTypes LevelSelection;

	public MatchTypes MatchType;

	public bool HasNextBatch()
	{
		return false;
	}

	public List<LevelData> GetNextBatch()
	{
		return null;
	}

	public List<LevelData> GetAllLevels()
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
