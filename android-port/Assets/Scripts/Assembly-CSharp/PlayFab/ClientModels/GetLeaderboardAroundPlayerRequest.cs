using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetLeaderboardAroundPlayerRequest : PlayFabRequestCommon
	{
		public int? MaxResultsCount;

		public string StatisticName;
	}
}
