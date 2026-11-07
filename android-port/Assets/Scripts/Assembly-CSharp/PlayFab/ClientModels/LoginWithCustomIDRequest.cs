using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithCustomIDRequest : PlayFabRequestCommon
	{
		public bool? CreateAccount;

		public string CustomId;

		public string TitleId;
	}
}
