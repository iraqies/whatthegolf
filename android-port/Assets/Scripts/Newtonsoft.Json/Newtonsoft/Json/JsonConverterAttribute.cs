using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000015")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182674", Offset = "0x182674")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182674", Offset = "0x182674")]
	[AttributeAttribute(Name = "AttributeUsageAttribute", RVA = "0x182674", Offset = "0x182674")]
	public sealed class JsonConverterAttribute : Attribute
	{
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x10")]
		private readonly Type _converterType;

		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185048", Offset = "0x185048")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x185048", Offset = "0x185048")]
		private readonly object[] ConverterParameters__BackingField;

		[Token(Token = "0x1700000B")]
		public Type ConverterType
		{
			[Token(Token = "0x600002A")]
			[Address(RVA = "0x22E7EE8", Offset = "0x22E7EE8", VA = "0x22E7EE8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700000C")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E898", Offset = "0x18E898")]
		public object[] ConverterParameters
		{
			[Token(Token = "0x600002B")]
			[Address(RVA = "0x22E7EF0", Offset = "0x22E7EF0", VA = "0x22E7EF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188774", Offset = "0x188774")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002C")]
		[Address(RVA = "0x22E7EF8", Offset = "0x22E7EF8", VA = "0x22E7EF8")]
		public JsonConverterAttribute(Type converterType)
		{
		}
	}
}
