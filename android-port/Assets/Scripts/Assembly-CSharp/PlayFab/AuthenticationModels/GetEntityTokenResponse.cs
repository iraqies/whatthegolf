using System;
using PlayFab.SharedModels;

namespace PlayFab.AuthenticationModels
{
	[Serializable]
	public class GetEntityTokenResponse : PlayFabResultCommon
	{
		public string EntityToken;
	}
}
