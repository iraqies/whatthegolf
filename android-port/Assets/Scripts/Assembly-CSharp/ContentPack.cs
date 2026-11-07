using System.Collections.Generic;
using Core;
using UnityEngine;

public class ContentPack : ScriptableObject, IPackWithData
{
	public string contentPackID;

	public bool isODRContent;

	public ECampaignType campaignType;

	[SerializeField]
	public AssetReferenceScene overworldSceneReference;

	[SerializeField]
	public AssetReferenceScene tunnelLoaderSceneReference;

	public List<Object> requiredScenes;

	public LeaderboardBoard leaderboard;

	public LevelDataContainerBase mainContainer;

	public LevelDataContainerBase onboardingContainer;

	public string titleID;

	public string contentPackOverrideID;

	public bool ps5ActivityEnable;

	public bool ps5ActivityTrackProgress;

	public bool ps5ActivityHideWhenDone;

	public bool HasDownloadableMusic;

	public bool IsNew => false;

	public bool hasLeaderboard => false;

	public string TitleID => null;

	public string ContentID => null;

	public string PackID => null;

	public string PackName => null;

	public List<UserCriteria> Criteria => null;

	public List<LevelData> GetAllLevelDatas()
	{
		return null;
	}

	public bool IsFresh()
	{
		return false;
	}

	public bool IsConsideredNew()
	{
		return false;
	}

	private string Formatted(string s)
	{
		return null;
	}

	public bool IsAvailable()
	{
		return false;
	}
}
