using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Wwise2
{
	[Token(Token = "0x2001017")]
	internal class ParseStringConverter : JsonConverter
	{
		[Token(Token = "0x40054D0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ParseStringConverter Singleton;

		[Token(Token = "0x60047F2")]
		[Address(RVA = "0x15DB6F4", Offset = "0x15DB6F4", VA = "0x15DB6F4", Slot = "6")]
		public override bool CanConvert(Type t)
		{
			return default;
		}

		[Token(Token = "0x60047F3")]
		[Address(RVA = "0x15DB7FC", Offset = "0x15DB7FC", VA = "0x15DB7FC", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60047F4")]
		[Address(RVA = "0x15DB914", Offset = "0x15DB914", VA = "0x15DB914", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60047F5")]
		[Address(RVA = "0x15DB9D8", Offset = "0x15DB9D8", VA = "0x15DB9D8")]
		public ParseStringConverter()
		{
		}
	}
}
