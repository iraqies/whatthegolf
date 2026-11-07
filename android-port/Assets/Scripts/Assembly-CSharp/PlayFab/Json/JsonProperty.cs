using System;
using Il2CppDummyDll;

namespace PlayFab.Json
{
	[Token(Token = "0x200119E")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x4815C", Offset = "0x4815C")]
	public class JsonProperty : Attribute
	{
		[Token(Token = "0x4005F04")]
		[FieldOffset(Offset = "0x10")]
		public string PropertyName;

		[Token(Token = "0x4005F05")]
		[FieldOffset(Offset = "0x18")]
		public NullValueHandling NullValueHandling;
	}
}
