using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000AC")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183B1C", Offset = "0x183B1C")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183B1C", Offset = "0x183B1C")]
	internal class JsonFormatterConverter : IFormatterConverter
	{
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x10")]
		private readonly JsonSerializerInternalReader _reader;

		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x18")]
		private readonly JsonISerializableContract _contract;

		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x187630", Offset = "0x187630")]
		private readonly JsonProperty _member;

		[Token(Token = "0x600043D")]
		[Address(RVA = "0x22E9BA8", Offset = "0x22E9BA8", VA = "0x22E9BA8")]
		public JsonFormatterConverter(JsonSerializerInternalReader reader, JsonISerializableContract contract, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18CEEC", Offset = "0x18CEEC")] JsonProperty member)
		{
		}

		[Token(Token = "0x600043E")]
		private T GetTokenValue<T>(object value)
		{
			return (T)null;
		}

		[Token(Token = "0x600043F")]
		[Address(RVA = "0x22E9C58", Offset = "0x22E9C58", VA = "0x22E9C58", Slot = "4")]
		public object Convert(object value, Type type)
		{
			return null;
		}

		[Token(Token = "0x6000440")]
		[Address(RVA = "0x22E9D88", Offset = "0x22E9D88", VA = "0x22E9D88", Slot = "5")]
		public bool ToBoolean(object value)
		{
			return default;
		}

		[Token(Token = "0x6000441")]
		[Address(RVA = "0x22E9DE8", Offset = "0x22E9DE8", VA = "0x22E9DE8", Slot = "6")]
		public int ToInt32(object value)
		{
			return default;
		}

		[Token(Token = "0x6000442")]
		[Address(RVA = "0x22E9E48", Offset = "0x22E9E48", VA = "0x22E9E48", Slot = "7")]
		public long ToInt64(object value)
		{
			return default;
		}

		[Token(Token = "0x6000443")]
		[Address(RVA = "0x22E9EA8", Offset = "0x22E9EA8", VA = "0x22E9EA8", Slot = "8")]
		public float ToSingle(object value)
		{
			return default;
		}

		[Token(Token = "0x6000444")]
		[Address(RVA = "0x22E9F08", Offset = "0x22E9F08", VA = "0x22E9F08", Slot = "9")]
		public string ToString(object value)
		{
			return null;
		}
	}
}
