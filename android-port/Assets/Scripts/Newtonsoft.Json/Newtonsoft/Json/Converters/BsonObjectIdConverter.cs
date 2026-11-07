using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000E3")]
	[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x184614", Offset = "0x184614")]
	public class BsonObjectIdConverter : JsonConverter
	{
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x22AD3DC", Offset = "0x22AD3DC", VA = "0x22AD3DC", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000763")]
		[Address(RVA = "0x22AD614", Offset = "0x22AD614", VA = "0x22AD614", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000764")]
		[Address(RVA = "0x22AD7C4", Offset = "0x22AD7C4", VA = "0x22AD7C4", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x6000765")]
		[Address(RVA = "0x22AD860", Offset = "0x22AD860", VA = "0x22AD860")]
		public BsonObjectIdConverter()
		{
		}
	}
}
