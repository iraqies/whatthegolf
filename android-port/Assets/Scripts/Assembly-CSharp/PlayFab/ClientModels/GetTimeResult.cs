using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011CD")]
	public class GetTimeResult : PlayFabResultCommon
	{
		[Token(Token = "0x4005F89")]
		[FieldOffset(Offset = "0x20")]
		public DateTime Time;

		[Token(Token = "0x6005148")]
		[Address(RVA = "0x1485AF4", Offset = "0x1485AF4", VA = "0x1485AF4")]
		public GetTimeResult()
		{
		}
	}
}
