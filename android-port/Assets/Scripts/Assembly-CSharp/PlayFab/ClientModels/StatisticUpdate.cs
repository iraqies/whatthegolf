using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011D2")]
	public class StatisticUpdate : PlayFabBaseModel
	{
		[Token(Token = "0x4005F97")]
		[FieldOffset(Offset = "0x10")]
		public string StatisticName;

		[Token(Token = "0x4005F98")]
		[FieldOffset(Offset = "0x18")]
		public int Value;

		[Token(Token = "0x600514D")]
		[Address(RVA = "0x16DD54C", Offset = "0x16DD54C", VA = "0x16DD54C")]
		public StatisticUpdate()
		{
		}
	}
}
