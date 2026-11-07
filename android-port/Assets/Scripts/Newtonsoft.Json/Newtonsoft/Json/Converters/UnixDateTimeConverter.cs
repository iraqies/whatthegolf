using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000F4")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x184954", Offset = "0x184954")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x184954", Offset = "0x184954")]
	public class UnixDateTimeConverter : DateTimeConverterBase
	{
		[Token(Token = "0x4000360")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly DateTime UnixEpoch;

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x23277B8", Offset = "0x23277B8", VA = "0x23277B8", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E320", Offset = "0x18E320")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x2327A54", Offset = "0x2327A54", VA = "0x2327A54", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E334", Offset = "0x18E334")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x2327F04", Offset = "0x2327F04", VA = "0x2327F04")]
		public UnixDateTimeConverter()
		{
		}
	}
}
