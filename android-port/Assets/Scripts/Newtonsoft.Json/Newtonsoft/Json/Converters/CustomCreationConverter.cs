using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000E4")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18464C", Offset = "0x18464C")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18464C", Offset = "0x18464C")]
	public abstract class CustomCreationConverter<T> : JsonConverter
	{
		[Token(Token = "0x1700013F")]
		public override bool CanWrite
		{
			[Token(Token = "0x600076A")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000766")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E168", Offset = "0x18E168")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000767")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E17C", Offset = "0x18E17C")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000768")]
		public abstract T Create(Type objectType);

		[Token(Token = "0x6000769")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x600076B")]
		protected CustomCreationConverter()
		{
		}
	}
}
