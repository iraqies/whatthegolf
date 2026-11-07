using Il2CppDummyDll;

namespace PlayFab.SharedModels
{
	[Token(Token = "0x2001198")]
	public class PlayFabRequestCommon : PlayFabBaseModel
	{
		[Token(Token = "0x4005EFC")]
		[FieldOffset(Offset = "0x10")]
		public PlayFabAuthenticationContext AuthenticationContext;

		[Token(Token = "0x600504E")]
		[Address(RVA = "0x15EFE64", Offset = "0x15EFE64", VA = "0x15EFE64")]
		public PlayFabRequestCommon()
		{
		}
	}
}
