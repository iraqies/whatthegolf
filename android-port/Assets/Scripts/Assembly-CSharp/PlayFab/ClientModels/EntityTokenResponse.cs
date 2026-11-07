using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011C7")]
	public class EntityTokenResponse : PlayFabBaseModel
	{
		[Token(Token = "0x4005F80")]
		[FieldOffset(Offset = "0x10")]
		public EntityKey Entity;

		[Token(Token = "0x4005F81")]
		[FieldOffset(Offset = "0x18")]
		public string EntityToken;

		[Token(Token = "0x6005142")]
		[Address(RVA = "0x1444C64", Offset = "0x1444C64", VA = "0x1444C64")]
		public EntityTokenResponse()
		{
		}
	}
}
