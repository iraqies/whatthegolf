using Il2CppDummyDll;

namespace PlayFab.SharedModels
{
	[Token(Token = "0x2001199")]
	public class PlayFabResultCommon : PlayFabBaseModel
	{
		[Token(Token = "0x4005EFD")]
		[FieldOffset(Offset = "0x10")]
		public PlayFabRequestCommon Request;

		[Token(Token = "0x4005EFE")]
		[FieldOffset(Offset = "0x18")]
		public object CustomData;

		[Token(Token = "0x600504F")]
		[Address(RVA = "0x15EFE5C", Offset = "0x15EFE5C", VA = "0x15EFE5C")]
		public PlayFabResultCommon()
		{
		}
	}
}
