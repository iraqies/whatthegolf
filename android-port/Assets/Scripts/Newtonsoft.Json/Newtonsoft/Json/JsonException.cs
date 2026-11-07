using System;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Serializable]
	[Token(Token = "0x2000018")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182778", Offset = "0x182778")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182778", Offset = "0x182778")]
	public class JsonException : Exception
	{
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x22E99C4", Offset = "0x22E99C4", VA = "0x22E99C4")]
		public JsonException()
		{
		}

		[Token(Token = "0x600002F")]
		[Address(RVA = "0x22CFAFC", Offset = "0x22CFAFC", VA = "0x22CFAFC")]
		public JsonException(string message)
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x22E9A40", Offset = "0x22E9A40", VA = "0x22E9A40")]
		public JsonException(string message, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B228", Offset = "0x18B228")] Exception innerException)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x22E9AE4", Offset = "0x22E9AE4", VA = "0x22E9AE4")]
		public JsonException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
