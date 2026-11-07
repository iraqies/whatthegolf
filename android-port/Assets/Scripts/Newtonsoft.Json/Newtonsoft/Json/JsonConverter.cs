using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000014")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182634", Offset = "0x182634")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182634", Offset = "0x182634")]
	public abstract class JsonConverter
	{
		[Token(Token = "0x17000009")]
		public virtual bool CanRead
		{
			[Token(Token = "0x6000027")]
			[Address(RVA = "0x22E7ED0", Offset = "0x22E7ED0", VA = "0x22E7ED0", Slot = "7")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700000A")]
		public virtual bool CanWrite
		{
			[Token(Token = "0x6000028")]
			[Address(RVA = "0x22E7ED8", Offset = "0x22E7ED8", VA = "0x22E7ED8", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000024")]
		public abstract void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B200", Offset = "0x18B200")] object value, JsonSerializer serializer);

		[Token(Token = "0x6000025")]
		public abstract object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18B214", Offset = "0x18B214")] object existingValue, JsonSerializer serializer);

		[Token(Token = "0x6000026")]
		public abstract bool CanConvert(Type objectType);

		[Token(Token = "0x6000029")]
		[Address(RVA = "0x22E7EE0", Offset = "0x22E7EE0", VA = "0x22E7EE0")]
		protected JsonConverter()
		{
		}
	}
}
