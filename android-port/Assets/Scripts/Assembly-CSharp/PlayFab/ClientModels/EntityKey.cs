using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	[Token(Token = "0x20011C6")]
	public class EntityKey : PlayFabBaseModel
	{
		[Token(Token = "0x4005F7E")]
		[FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x4005F7F")]
		[FieldOffset(Offset = "0x18")]
		public string Type;

		[Token(Token = "0x6005141")]
		[Address(RVA = "0x1444C54", Offset = "0x1444C54", VA = "0x1444C54")]
		public EntityKey()
		{
		}
	}
}
