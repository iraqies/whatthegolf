using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011D0")]
	public class PlayerLeaderboardEntry : PlayFabBaseModel
	{
		[Token(Token = "0x4005F90")]
		[FieldOffset(Offset = "0x10")]
		public string DisplayName;

		[Token(Token = "0x4005F91")]
		[FieldOffset(Offset = "0x18")]
		public string PlayFabId;

		[Token(Token = "0x4005F92")]
		[FieldOffset(Offset = "0x20")]
		public int Position;

		[Token(Token = "0x4005F93")]
		[FieldOffset(Offset = "0x24")]
		public int StatValue;

		[Token(Token = "0x600514B")]
		[Address(RVA = "0x15F89C4", Offset = "0x15F89C4", VA = "0x15F89C4")]
		public PlayerLeaderboardEntry()
		{
		}
	}
}
