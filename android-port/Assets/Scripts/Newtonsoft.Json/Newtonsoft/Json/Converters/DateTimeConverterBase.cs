using System;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000E7")]
	public abstract class DateTimeConverterBase : JsonConverter
	{
		[Token(Token = "0x6000776")]
		[Address(RVA = "0x22B50D0", Offset = "0x22B50D0", VA = "0x22B50D0", Slot = "6")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18AC30", Offset = "0x18AC30")]
		public override bool CanConvert(Type objectType)
		{
			return default;
		}

		[Token(Token = "0x6000777")]
		[Address(RVA = "0x22B5288", Offset = "0x22B5288", VA = "0x22B5288")]
		protected DateTimeConverterBase()
		{
		}
	}
}
