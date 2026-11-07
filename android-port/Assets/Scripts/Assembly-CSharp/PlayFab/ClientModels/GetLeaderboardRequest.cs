using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetLeaderboardRequest : PlayFabRequestCommon
	{
		public int? MaxResultsCount;

		public int StartPosition;

		public string StatisticName;
	}
}
