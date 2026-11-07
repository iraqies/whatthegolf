using Il2CppDummyDll;

namespace PlayFab.Public
{
	[Token(Token = "0x20011B9")]
	public class PlayFabLogger : PlayFabLoggerBase
	{
		[Token(Token = "0x6005106")]
		[Address(RVA = "0x15EEC34", Offset = "0x15EEC34", VA = "0x15EEC34", Slot = "10")]
		protected override void BeginUploadLog()
		{
		}

		[Token(Token = "0x6005107")]
		[Address(RVA = "0x15EEC38", Offset = "0x15EEC38", VA = "0x15EEC38", Slot = "11")]
		protected override void UploadLog(string message)
		{
		}

		[Token(Token = "0x6005108")]
		[Address(RVA = "0x15EEC3C", Offset = "0x15EEC3C", VA = "0x15EEC3C", Slot = "12")]
		protected override void EndUploadLog()
		{
		}

		[Token(Token = "0x6005109")]
		[Address(RVA = "0x15EC4F8", Offset = "0x15EC4F8", VA = "0x15EC4F8")]
		public PlayFabLogger()
		{
		}
	}
}
