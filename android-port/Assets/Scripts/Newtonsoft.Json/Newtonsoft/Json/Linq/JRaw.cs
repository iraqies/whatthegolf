using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000D8")]
	[Attribute(Name = "NullableAttribute", RVA = "0x1843EC", Offset = "0x1843EC")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x1843EC", Offset = "0x1843EC")]
	public class JRaw : JValue
	{
		[Token(Token = "0x60006A3")]
		[Address(RVA = "0x22D3914", Offset = "0x22D3914", VA = "0x22D3914")]
		public JRaw(JRaw other)
		{
		}

		[Token(Token = "0x60006A4")]
		[Address(RVA = "0x22D39FC", Offset = "0x22D39FC", VA = "0x22D39FC")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18A8D4", Offset = "0x18A8D4")]
		public JRaw(object rawJson)
		{
		}

		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x22D3B04", Offset = "0x22D3B04", VA = "0x22D3B04")]
		public static JRaw Create(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x22D3E44", Offset = "0x22D3E44", VA = "0x22D3E44", Slot = "11")]
		internal override JToken CloneToken()
		{
			return null;
		}
	}
}
