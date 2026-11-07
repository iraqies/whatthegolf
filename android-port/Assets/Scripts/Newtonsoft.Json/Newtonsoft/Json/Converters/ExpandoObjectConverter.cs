using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000EE")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1847D4", Offset = "0x1847D4")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1847D4", Offset = "0x1847D4")]
	public class ExpandoObjectConverter : JsonConverter
	{
		[Token(Token = "0x17000140")]
		public override bool CanWrite
		{
			[Token(Token = "0x6000791")]
			[Address(RVA = "0x22C73EC", Offset = "0x22C73EC", VA = "0x22C73EC", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x22C6E2C", Offset = "0x22C6E2C", VA = "0x22C6E2C", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E230", Offset = "0x18E230")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x22C6E30", Offset = "0x22C6E30", VA = "0x22C6E30", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E244", Offset = "0x18E244")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x22C6E34", Offset = "0x22C6E34", VA = "0x22C6E34")]
		private object ReadValue(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x22C71A4", Offset = "0x22C71A4", VA = "0x22C71A4")]
		private object ReadList(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x22C6FCC", Offset = "0x22C6FCC", VA = "0x22C6FCC")]
		private object ReadObject(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x22C7350", Offset = "0x22C7350", VA = "0x22C7350", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x22C1760", Offset = "0x22C1760", VA = "0x22C1760")]
		public ExpandoObjectConverter()
		{
		}
	}
}
