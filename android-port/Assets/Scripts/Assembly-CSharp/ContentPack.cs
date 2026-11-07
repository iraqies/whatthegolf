using System.Collections.Generic;
using Core;
using UnityEngine;

public class ContentPack : ScriptableObject, IPackWithData
{
	public string contentPackID;
	public bool isODRContent;
	public ECampaignType campaignType;
	[SerializeField] public AssetReferenceScene overworldSceneReference;
	[SerializeField] public AssetReferenceScene tunnelLoaderSceneReference;
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

	public bool IsNew => IsConsideredNew();
	public bool hasLeaderboard => leaderboard != LeaderboardBoard.None;
	public string TitleID => titleID;
	public string ContentID => !string.IsNullOrEmpty(contentPackOverrideID) ? contentPackOverrideID : contentPackID;
	public string PackID => contentPackID;
	public string PackName => name;
	public List<UserCriteria> Criteria => new List<UserCriteria>();

	public List<LevelData> GetAllLevelDatas()
	{
		var res = new List<LevelData>();
		if (onboardingContainer != null)
		{
			var ol = onboardingContainer.GetLevelDatas();
			if (ol != null) res.AddRange(ol);
		}
		if (mainContainer != null)
		{
			var ml = mainContainer.GetLevelDatas();
			if (ml != null) res.AddRange(ml);
		}
		return res;
	}

	public bool IsFresh() => SaveGame.GetContentPackPlayCount(contentPackID) == 0;
	public bool IsConsideredNew() => IsFresh();
	private string Formatted(string s) => s;
	public bool IsAvailable() => true;
}
