using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Serializable]
	[Token(Token = "0x2000024")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1829BC", Offset = "0x1829BC")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1829BC", Offset = "0x1829BC")]
	public class JsonSerializationException : JsonException
	{
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1852A8", Offset = "0x1852A8")]
		private readonly int LineNumber__BackingField;

		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1852B8", Offset = "0x1852B8")]
		private readonly int LinePosition__BackingField;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1852C8", Offset = "0x1852C8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1852C8", Offset = "0x1852C8")]
		private readonly string Path__BackingField;

		[Token(Token = "0x600008D")]
		[Address(RVA = "0x22F187C", Offset = "0x22F187C", VA = "0x22F187C")]
		public JsonSerializationException()
		{
		}

		[Token(Token = "0x600008E")]
		[Address(RVA = "0x22EC104", Offset = "0x22EC104", VA = "0x22EC104")]
		public JsonSerializationException(string message)
		{
		}

		[Token(Token = "0x600008F")]
		[Address(RVA = "0x22F1884", Offset = "0x22F1884", VA = "0x22F1884")]
		public JsonSerializationException(string message, Exception innerException)
		{
		}

		[Token(Token = "0x6000090")]
		[Address(RVA = "0x22F188C", Offset = "0x22F188C", VA = "0x22F188C")]
		public JsonSerializationException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x6000091")]
		[Address(RVA = "0x22F1894", Offset = "0x22F1894", VA = "0x22F1894")]
		public JsonSerializationException(string message, string path, int lineNumber, int linePosition, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B2B4", Offset = "0x18B2B4")] Exception innerException)
		{
		}

		[Token(Token = "0x6000092")]
		[Address(RVA = "0x22F10B4", Offset = "0x22F10B4", VA = "0x22F10B4")]
		internal static JsonSerializationException Create(JsonReader reader, string message)
		{
			return null;
		}

		[Token(Token = "0x6000093")]
		[Address(RVA = "0x22F18D8", Offset = "0x22F18D8", VA = "0x22F18D8")]
		internal static JsonSerializationException Create(JsonReader reader, string message, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B2C8", Offset = "0x18B2C8")] Exception ex)
		{
			return null;
		}

		[Token(Token = "0x6000094")]
		[Address(RVA = "0x22F1968", Offset = "0x22F1968", VA = "0x22F1968")]
		internal static JsonSerializationException Create([AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B2DC", Offset = "0x18B2DC")] IJsonLineInfo lineInfo, string path, string message, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B2F0", Offset = "0x18B2F0")] Exception ex)
		{
			return null;
		}
	}
}
