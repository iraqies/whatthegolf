using System;
using System.Reflection;
using Il2CppDummyDll;

namespace ThirdParty.Json.LitJson
{
	[Token(Token = "0x200001B")]
	internal struct PropertyMetadata
	{
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x0")]
		public MemberInfo Info;

		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x8")]
		public bool IsField;

		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x10")]
		public Type Type;
	}
}
