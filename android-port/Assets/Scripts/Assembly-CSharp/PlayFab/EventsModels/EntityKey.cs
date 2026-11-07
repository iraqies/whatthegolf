using System;
using Il2CppDummyDll;
using PlayFab.SharedModels;

namespace PlayFab.EventsModels
{
	[Serializable]
	[Token(Token = "0x20011B0")]
	public class EntityKey : PlayFabBaseModel
	{
		[Token(Token = "0x4005F2B")]
		[FieldOffset(Offset = "0x10")]
		public string Id;

		[Token(Token = "0x4005F2C")]
		[FieldOffset(Offset = "0x18")]
		public string Type;

		[Token(Token = "0x60050DC")]
		[Address(RVA = "0x1444C5C", Offset = "0x1444C5C", VA = "0x1444C5C")]
		public EntityKey()
		{
		}
	}
}
