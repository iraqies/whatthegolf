using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F0")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184854", Offset = "0x184854")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184854", Offset = "0x184854")]
	public class JavaScriptDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x22E28F8", Offset = "0x22E28F8", VA = "0x22E28F8", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E280", Offset = "0x18E280")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x22E2AF0", Offset = "0x22E2AF0", VA = "0x22E2AF0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E294", Offset = "0x18E294")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x22E32B8", Offset = "0x22E32B8", VA = "0x22E32B8")]
		public JavaScriptDateTimeConverter()
		{
		}
	}
}
