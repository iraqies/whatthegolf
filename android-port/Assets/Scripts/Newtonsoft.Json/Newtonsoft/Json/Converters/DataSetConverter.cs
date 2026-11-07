using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000E5")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18468C", Offset = "0x18468C")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18468C", Offset = "0x18468C")]
	public class DataSetConverter : JsonConverter
	{
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x22B34DC", Offset = "0x22B34DC", VA = "0x22B34DC", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E190", Offset = "0x18E190")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600076D")]
		[Address(RVA = "0x22B39A0", Offset = "0x22B39A0", VA = "0x22B39A0", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E1A4", Offset = "0x18E1A4")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x22B3CC8", Offset = "0x22B3CC8", VA = "0x22B3CC8", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default;
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x22B3D70", Offset = "0x22B3D70", VA = "0x22B3D70")]
		public DataSetConverter()
		{
		}
	}
}
