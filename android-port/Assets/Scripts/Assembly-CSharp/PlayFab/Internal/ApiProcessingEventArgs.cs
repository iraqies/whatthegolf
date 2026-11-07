using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.Internal
{
	[Token(Token = "0x20011C3")]
	public class ApiProcessingEventArgs
	{
		[Token(Token = "0x4005F75")]
		[FieldOffset(Offset = "0x10")]
		public string ApiEndpoint;

		[Token(Token = "0x4005F76")]
		[FieldOffset(Offset = "0x18")]
		public ApiProcessingEventType EventType;

		[Token(Token = "0x4005F77")]
		[FieldOffset(Offset = "0x20")]
		public PlayFabRequestCommon Request;

		[Token(Token = "0x4005F78")]
		[FieldOffset(Offset = "0x28")]
		public PlayFabResultCommon Result;

		[Token(Token = "0x600513A")]
		[Address(RVA = "0x14191A4", Offset = "0x14191A4", VA = "0x14191A4")]
		public ApiProcessingEventArgs()
		{
		}
	}
}
