using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class PlayerLeaderboardEntry : PlayFabBaseModel
	{
		public string DisplayName;

		public string PlayFabId;

		public int Position;

		public int StatValue;
	}
}
