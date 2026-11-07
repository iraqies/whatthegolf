using System;
using System.Data;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Converters
{
	[Token(Token = "0x20000E6")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1846CC", Offset = "0x1846CC")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1846CC", Offset = "0x1846CC")]
	public class DataTableConverter : JsonConverter
	{
		[Token(Token = "0x6000770")]
		[Address(RVA = "0x22B3D78", Offset = "0x22B3D78", VA = "0x22B3D78", Slot = "4")]
		public override void WriteJson(JsonWriter writer, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E1B8", Offset = "0x18E1B8")] object value, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x22B455C", Offset = "0x22B455C", VA = "0x22B455C", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, [AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E1CC", Offset = "0x18E1CC")] object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x22B48A4", Offset = "0x22B48A4", VA = "0x22B48A4")]
		private static void CreateRow(JsonReader reader, DataTable dt, JsonSerializer serializer)
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x22B4DF4", Offset = "0x22B4DF4", VA = "0x22B4DF4")]
		private static Type GetColumnDataType(JsonReader reader)
		{
			return null;
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x22B5028", Offset = "0x22B5028", VA = "0x22B5028", Slot = "6")]
		public override bool CanConvert(Type valueType)
		{
			return default;
		}

		[Token(Token = "0x6000775")]
		[Address(RVA = "0x22B3988", Offset = "0x22B3988", VA = "0x22B3988")]
		public DataTableConverter()
		{
		}
	}
}
