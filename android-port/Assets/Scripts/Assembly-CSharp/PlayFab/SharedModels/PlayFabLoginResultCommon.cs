using Il2CppDummyDll;

namespace PlayFab.SharedModels
{
	[Token(Token = "0x200119A")]
	public class PlayFabLoginResultCommon : PlayFabResultCommon
	{
		[Token(Token = "0x4005EFF")]
		[FieldOffset(Offset = "0x20")]
		public PlayFabAuthenticationContext AuthenticationContext;

		[Token(Token = "0x6005050")]
		[Address(RVA = "0x15EFE54", Offset = "0x15EFE54", VA = "0x15EFE54")]
		public PlayFabLoginResultCommon()
		{
		}
	}
}
