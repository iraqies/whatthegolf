using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Serializable]
	[Token(Token = "0x200002D")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182B50", Offset = "0x182B50")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182B50", Offset = "0x182B50")]
	public class JsonWriterException : JsonException
	{
		[Token(Token = "0x400010B")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18562C", Offset = "0x18562C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18562C", Offset = "0x18562C")]
		private readonly string Path__BackingField;

		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x2319ED8", Offset = "0x2319ED8", VA = "0x2319ED8")]
		public JsonWriterException()
		{
		}

		[Token(Token = "0x60001B7")]
		[Address(RVA = "0x2319EE0", Offset = "0x2319EE0", VA = "0x2319EE0")]
		public JsonWriterException(SerializationInfo info, StreamingContext context)
		{
		}

		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x2319EE8", Offset = "0x2319EE8", VA = "0x2319EE8")]
		public JsonWriterException(string message, string path, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B51C", Offset = "0x18B51C")] Exception innerException)
		{
		}

		[Token(Token = "0x60001B9")]
		[Address(RVA = "0x2310E88", Offset = "0x2310E88", VA = "0x2310E88")]
		internal static JsonWriterException Create(JsonWriter writer, string message, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B530", Offset = "0x18B530")] Exception ex)
		{
			return null;
		}

		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x2319F18", Offset = "0x2319F18", VA = "0x2319F18")]
		internal static JsonWriterException Create(string path, string message, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B544", Offset = "0x18B544")] Exception ex)
		{
			return null;
		}
	}
}
