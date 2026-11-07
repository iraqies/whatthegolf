using System;

namespace PlayFab
{
	internal class PlayFabSettingsRedirect : PlayFabApiSettings
	{
		private readonly Func<PlayFabSharedSettings> GetSO;

		public override string ProductionEnvironmentUrl => null;

		internal override string VerticalName => null;

		public override string TitleId => null;

		public override bool DisableFocusTimeCollection => false;

		public PlayFabSettingsRedirect(Func<PlayFabSharedSettings> getSO)
		{
		}
	}
}
