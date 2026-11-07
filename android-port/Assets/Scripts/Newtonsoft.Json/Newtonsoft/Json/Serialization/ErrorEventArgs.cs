using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x2000099")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183904", Offset = "0x183904")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183904", Offset = "0x183904")]
	public class ErrorEventArgs : EventArgs
	{
		[Token(Token = "0x400023F")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x186C60", Offset = "0x186C60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186C60", Offset = "0x186C60")]
		private readonly object CurrentObject__BackingField;

		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x186C9C", Offset = "0x186C9C")]
		private readonly ErrorContext ErrorContext__BackingField;

		[Token(Token = "0x60003CF")]
		[Address(RVA = "0x22C6DA8", Offset = "0x22C6DA8", VA = "0x22C6DA8")]
		public ErrorEventArgs([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CB80", Offset = "0x18CB80")] object currentObject, ErrorContext errorContext)
		{
		}
	}
}
