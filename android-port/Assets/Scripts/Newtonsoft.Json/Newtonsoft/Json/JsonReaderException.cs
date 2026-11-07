using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Serializable]
	[Token(Token = "0x2000022")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182948", Offset = "0x182948")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182948", Offset = "0x182948")]
	public class JsonReaderException : JsonException
	{
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18524C", Offset = "0x18524C")]
		private readonly int LineNumber__BackingField;

		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18525C", Offset = "0x18525C")]
		private readonly int LinePosition__BackingField;

		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18526C", Offset = "0x18526C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18526C", Offset = "0x18526C")]
		private readonly string Path__BackingField;

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x22F15E0", Offset = "0x22F15E0", VA = "0x22F15E0")]
		public JsonReaderException()
		{
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x22F15E8", Offset = "0x22F15E8", VA = "0x22F15E8")]
		public JsonReaderException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x22F15F0", Offset = "0x22F15F0", VA = "0x22F15F0")]
		public JsonReaderException(string message, string path, int lineNumber, int linePosition, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B264", Offset = "0x18B264")] Exception innerException)
		{
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x22ECC60", Offset = "0x22ECC60", VA = "0x22ECC60")]
		internal static JsonReaderException Create(JsonReader reader, string message)
		{
			return null;
		}

		[Token(Token = "0x600008B")]
		[Address(RVA = "0x22ED3BC", Offset = "0x22ED3BC", VA = "0x22ED3BC")]
		internal static JsonReaderException Create(JsonReader reader, string message, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B278", Offset = "0x18B278")] Exception ex)
		{
			return null;
		}

		[Token(Token = "0x600008C")]
		[Address(RVA = "0x22F1634", Offset = "0x22F1634", VA = "0x22F1634")]
		internal static JsonReaderException Create([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B28C", Offset = "0x18B28C")] IJsonLineInfo lineInfo, string path, string message, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B2A0", Offset = "0x18B2A0")] Exception ex)
		{
			return null;
		}
	}
}
