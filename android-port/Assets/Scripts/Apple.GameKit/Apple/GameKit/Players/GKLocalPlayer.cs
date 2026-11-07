namespace Apple.GameKit.Players
{
	public struct GKLocalPlayer
	{
		public string Alias;

		public string DisplayName;

		public string GamePlayerId;

		public string TeamPlayerId;

		public bool IsUnderage;

		public bool IsMultiplayerGamingRestricted;

		public bool IsPersonalizedCommunicationRestricted;

		public bool IsAuthenticated;

		public static implicit operator GKPlayer(GKLocalPlayer localPlayer)
		{
			return default;
		}
	}
}
