using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000B0")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183B9C", Offset = "0x183B9C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183B9C", Offset = "0x183B9C")]
	public class JsonPrimitiveContract : JsonContract
	{
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1878C8", Offset = "0x1878C8")]
		private PrimitiveTypeCode TypeCode__BackingField;

		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<Type, ReadType> ReadTypeMap;

		[Token(Token = "0x170000BA")]
		internal PrimitiveTypeCode TypeCode
		{
			[Token(Token = "0x6000461")]
			[Address(RVA = "0x22EB3EC", Offset = "0x22EB3EC", VA = "0x22EB3EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D04", Offset = "0x189D04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000462")]
			[Address(RVA = "0x22EB3F4", Offset = "0x22EB3F4", VA = "0x22EB3F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x189D14", Offset = "0x189D14")]
			set
			{
			}
		}

		[Token(Token = "0x6000463")]
		[Address(RVA = "0x22EB3FC", Offset = "0x22EB3FC", VA = "0x22EB3FC")]
		public JsonPrimitiveContract(Type underlyingType)
		{
		}
	}
}
