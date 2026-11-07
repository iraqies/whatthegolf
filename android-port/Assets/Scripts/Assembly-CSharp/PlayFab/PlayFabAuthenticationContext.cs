using Il2CppDummyDll;

namespace PlayFab
{
	[Token(Token = "0x200118C")]
	public sealed class PlayFabAuthenticationContext
	{
		[Token(Token = "0x4005EC5")]
		[FieldOffset(Offset = "0x10")]
		public string ClientSessionTicket;

		[Token(Token = "0x4005EC6")]
		[FieldOffset(Offset = "0x18")]
		public string PlayFabId;

		[Token(Token = "0x4005EC7")]
		[FieldOffset(Offset = "0x20")]
		public string EntityToken;

		[Token(Token = "0x4005EC8")]
		[FieldOffset(Offset = "0x28")]
		public string EntityId;

		[Token(Token = "0x4005EC9")]
		[FieldOffset(Offset = "0x30")]
		public string EntityType;

		[Token(Token = "0x6005032")]
		[Address(RVA = "0x15EA010", Offset = "0x15EA010", VA = "0x15EA010")]
		public PlayFabAuthenticationContext()
		{
		}

		[Token(Token = "0x6005033")]
		[Address(RVA = "0x15EA018", Offset = "0x15EA018", VA = "0x15EA018")]
		public PlayFabAuthenticationContext(string clientSessionTicket, string entityToken, string playFabId, string entityId, string entityType)
		{
		}

		[Token(Token = "0x6005034")]
		[Address(RVA = "0x15EA06C", Offset = "0x15EA06C", VA = "0x15EA06C")]
		public void CopyFrom(PlayFabAuthenticationContext other)
		{
		}

		[Token(Token = "0x6005035")]
		[Address(RVA = "0x15EA098", Offset = "0x15EA098", VA = "0x15EA098")]
		public bool IsClientLoggedIn()
		{
			return default;
		}
	}
}
