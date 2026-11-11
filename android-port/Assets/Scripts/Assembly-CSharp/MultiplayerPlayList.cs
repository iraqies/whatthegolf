using System.Collections.Generic;
using System.Linq;
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

	public int LevelsToPlay = 5;

	public LevelSelectionTypes LevelSelection;

	public MatchTypes MatchType;

	public bool HasNextBatch()
	{
		return NextBatch != null && NextBatch.GetLevels().Count > 0;
	}

	public List<LevelData> GetNextBatch()
	{
		return NextBatch != null ? NextBatch.GetLevels() : new List<LevelData>();
	}

	public List<LevelData> GetAllLevels()
	{
		List<LevelData> all = new List<LevelData>();
		if (IntroLevels != null)
		{
			all.AddRange(IntroLevels.GetLevels());
		}
		if (Levels != null)
		{
			for (int i = 0; i < Levels.Count; i++)
			{
				if (Levels[i] != null)
				{
					all.AddRange(Levels[i].GetLevels());
				}
			}
		}
		if (OutroLevels != null)
		{
			all.AddRange(OutroLevels.GetLevels());
		}
		return all;
	}

	public override List<LevelData> GetLevelDatas()
	{
		return GetAllLevels();
	}

	public override List<LevelDataAndChallenge> GetLevelDatasWithChallenges()
	{
		return GetAllLevels().Select(l => new LevelDataAndChallenge { level = l, challengeID = string.Empty }).ToList();
	}
}
