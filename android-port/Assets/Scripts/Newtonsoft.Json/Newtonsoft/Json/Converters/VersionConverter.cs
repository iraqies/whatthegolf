using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F5")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184994", Offset = "0x184994")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184994", Offset = "0x184994")]
	public class VersionConverter : JsonConverter
	{
		[Token(Token = "0x60007C2")]
		[Address(RVA = "0x2327F8C", Offset = "0x2327F8C", VA = "0x2327F8C", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E348", Offset = "0x18E348")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007C3")]
		[Address(RVA = "0x2328084", Offset = "0x2328084", VA = "0x2328084", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E35C", Offset = "0x18E35C")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x2328368", Offset = "0x2328368", VA = "0x2328368", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x2328404", Offset = "0x2328404", VA = "0x2328404")]
		public VersionConverter()
		{
		}
	}
}
