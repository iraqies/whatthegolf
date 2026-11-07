using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class RegisterPlayFabUserResult : PlayFabLoginResultCommon
	{
		public EntityTokenResponse EntityToken;

		public string PlayFabId;

		public string SessionTicket;
	}
}
