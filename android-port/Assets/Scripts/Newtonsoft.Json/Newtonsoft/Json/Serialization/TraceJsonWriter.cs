using System;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000C8")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183FC4", Offset = "0x183FC4")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183FC4", Offset = "0x183FC4")]
	internal class TraceJsonWriter : JsonWriter
	{
		[Token(Token = "0x40002E7")]
		[FieldOffset(Offset = "0x60")]
		private readonly JsonWriter _innerWriter;

		[Token(Token = "0x40002E8")]
		[FieldOffset(Offset = "0x68")]
		private readonly JsonTextWriter _textWriter;

		[Token(Token = "0x40002E9")]
		[FieldOffset(Offset = "0x70")]
		private readonly StringWriter _sw;

		[Token(Token = "0x600057C")]
		[Address(RVA = "0x23252C4", Offset = "0x23252C4", VA = "0x23252C4")]
		public TraceJsonWriter(JsonWriter innerWriter)
		{
		}

		[Token(Token = "0x600057D")]
		[Address(RVA = "0x232549C", Offset = "0x232549C", VA = "0x232549C")]
		public string GetSerializedJsonMessage()
		{
			return null;
		}

		[Token(Token = "0x600057E")]
		[Address(RVA = "0x23254BC", Offset = "0x23254BC", VA = "0x23254BC", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x600057F")]
		[Address(RVA = "0x2325534", Offset = "0x2325534", VA = "0x2325534", Slot = "55")]
		public override void WriteValue(decimal? value)
		{
		}

		[Token(Token = "0x6000580")]
		[Address(RVA = "0x2325618", Offset = "0x2325618", VA = "0x2325618", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x6000581")]
		[Address(RVA = "0x232567C", Offset = "0x232567C", VA = "0x232567C", Slot = "49")]
		public override void WriteValue(bool? value)
		{
		}

		[Token(Token = "0x6000582")]
		[Address(RVA = "0x2325734", Offset = "0x2325734", VA = "0x2325734", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000583")]
		[Address(RVA = "0x2325798", Offset = "0x2325798", VA = "0x2325798", Slot = "53")]
		public override void WriteValue(byte? value)
		{
		}

		[Token(Token = "0x6000584")]
		[Address(RVA = "0x2325850", Offset = "0x2325850", VA = "0x2325850", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000585")]
		[Address(RVA = "0x23258B4", Offset = "0x23258B4", VA = "0x23258B4", Slot = "52")]
		public override void WriteValue(char? value)
		{
		}

		[Token(Token = "0x6000586")]
		[Address(RVA = "0x2325970", Offset = "0x2325970", VA = "0x2325970", Slot = "60")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A458", Offset = "0x18A458")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x6000587")]
		[Address(RVA = "0x23259E8", Offset = "0x23259E8", VA = "0x23259E8", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000588")]
		[Address(RVA = "0x2325A4C", Offset = "0x2325A4C", VA = "0x2325A4C", Slot = "56")]
		public override void WriteValue(DateTime? value)
		{
		}

		[Token(Token = "0x6000589")]
		[Address(RVA = "0x2325B0C", Offset = "0x2325B0C", VA = "0x2325B0C", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x600058A")]
		[Address(RVA = "0x2325B84", Offset = "0x2325B84", VA = "0x2325B84", Slot = "57")]
		public override void WriteValue(DateTimeOffset? value)
		{
		}

		[Token(Token = "0x600058B")]
		[Address(RVA = "0x2325C68", Offset = "0x2325C68", VA = "0x2325C68", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x600058C")]
		[Address(RVA = "0x2325CD4", Offset = "0x2325CD4", VA = "0x2325CD4", Slot = "48")]
		public override void WriteValue(double? value)
		{
		}

		[Token(Token = "0x600058D")]
		[Address(RVA = "0x2325D98", Offset = "0x2325D98", VA = "0x2325D98", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x600058E")]
		[Address(RVA = "0x2325DF0", Offset = "0x2325DF0", VA = "0x2325DF0", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x600058F")]
		[Address(RVA = "0x2325E48", Offset = "0x2325E48", VA = "0x2325E48", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x6000590")]
		[Address(RVA = "0x2325EB4", Offset = "0x2325EB4", VA = "0x2325EB4", Slot = "47")]
		public override void WriteValue(float? value)
		{
		}

		[Token(Token = "0x6000591")]
		[Address(RVA = "0x2325F6C", Offset = "0x2325F6C", VA = "0x2325F6C", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x6000592")]
		[Address(RVA = "0x2325FE4", Offset = "0x2325FE4", VA = "0x2325FE4", Slot = "58")]
		public override void WriteValue(Guid? value)
		{
		}

		[Token(Token = "0x6000593")]
		[Address(RVA = "0x23260C8", Offset = "0x23260C8", VA = "0x23260C8", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x6000594")]
		[Address(RVA = "0x232612C", Offset = "0x232612C", VA = "0x232612C", Slot = "43")]
		public override void WriteValue(int? value)
		{
		}

		[Token(Token = "0x6000595")]
		[Address(RVA = "0x23261E0", Offset = "0x23261E0", VA = "0x23261E0", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x6000596")]
		[Address(RVA = "0x2326244", Offset = "0x2326244", VA = "0x2326244", Slot = "45")]
		public override void WriteValue(long? value)
		{
		}

		[Token(Token = "0x6000597")]
		[Address(RVA = "0x2326304", Offset = "0x2326304", VA = "0x2326304", Slot = "62")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A46C", Offset = "0x18A46C")]
		public override void WriteValue(object value)
		{
		}

		[Token(Token = "0x6000598")]
		[Address(RVA = "0x232640C", Offset = "0x232640C", VA = "0x232640C", Slot = "37")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000599")]
		[Address(RVA = "0x2326470", Offset = "0x2326470", VA = "0x2326470", Slot = "54")]
		public override void WriteValue(sbyte? value)
		{
		}

		[Token(Token = "0x600059A")]
		[Address(RVA = "0x2326528", Offset = "0x2326528", VA = "0x2326528", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x600059B")]
		[Address(RVA = "0x232658C", Offset = "0x232658C", VA = "0x232658C", Slot = "50")]
		public override void WriteValue(short? value)
		{
		}

		[Token(Token = "0x600059C")]
		[Address(RVA = "0x2326648", Offset = "0x2326648", VA = "0x2326648", Slot = "25")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A480", Offset = "0x18A480")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x600059D")]
		[Address(RVA = "0x23266AC", Offset = "0x23266AC", VA = "0x23266AC", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x600059E")]
		[Address(RVA = "0x2326710", Offset = "0x2326710", VA = "0x2326710", Slot = "59")]
		public override void WriteValue(TimeSpan? value)
		{
		}

		[Token(Token = "0x600059F")]
		[Address(RVA = "0x23267D0", Offset = "0x23267D0", VA = "0x23267D0", Slot = "27")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x60005A0")]
		[Address(RVA = "0x2326834", Offset = "0x2326834", VA = "0x2326834", Slot = "44")]
		public override void WriteValue(uint? value)
		{
		}

		[Token(Token = "0x60005A1")]
		[Address(RVA = "0x23268E8", Offset = "0x23268E8", VA = "0x23268E8", Slot = "29")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x60005A2")]
		[Address(RVA = "0x232694C", Offset = "0x232694C", VA = "0x232694C", Slot = "46")]
		public override void WriteValue(ulong? value)
		{
		}

		[Token(Token = "0x60005A3")]
		[Address(RVA = "0x2326A0C", Offset = "0x2326A0C", VA = "0x2326A0C", Slot = "61")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A494", Offset = "0x18A494")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x60005A4")]
		[Address(RVA = "0x2326AE8", Offset = "0x2326AE8", VA = "0x2326AE8", Slot = "34")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x60005A5")]
		[Address(RVA = "0x2326B4C", Offset = "0x2326B4C", VA = "0x2326B4C", Slot = "51")]
		public override void WriteValue(ushort? value)
		{
		}

		[Token(Token = "0x60005A6")]
		[Address(RVA = "0x2326C08", Offset = "0x2326C08", VA = "0x2326C08", Slot = "63")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A4A8", Offset = "0x18A4A8")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x60005A7")]
		[Address(RVA = "0x2326C6C", Offset = "0x2326C6C", VA = "0x2326C6C", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x60005A8")]
		[Address(RVA = "0x2326CBC", Offset = "0x2326CBC", VA = "0x2326CBC", Slot = "10")]
		public override void WriteEndArray()
		{
		}

		[Token(Token = "0x60005A9")]
		[Address(RVA = "0x2326D0C", Offset = "0x2326D0C", VA = "0x2326D0C", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x60005AA")]
		[Address(RVA = "0x2326D68", Offset = "0x2326D68", VA = "0x2326D68", Slot = "12")]
		public override void WriteEndConstructor()
		{
		}

		[Token(Token = "0x60005AB")]
		[Address(RVA = "0x2326DB8", Offset = "0x2326DB8", VA = "0x2326DB8", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x60005AC")]
		[Address(RVA = "0x2326E1C", Offset = "0x2326E1C", VA = "0x2326E1C", Slot = "14")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x60005AD")]
		[Address(RVA = "0x2326E90", Offset = "0x2326E90", VA = "0x2326E90", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x60005AE")]
		[Address(RVA = "0x2326EE0", Offset = "0x2326EE0", VA = "0x2326EE0", Slot = "8")]
		public override void WriteEndObject()
		{
		}

		[Token(Token = "0x60005AF")]
		[Address(RVA = "0x2326F30", Offset = "0x2326F30", VA = "0x2326F30", Slot = "24")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A4BC", Offset = "0x18A4BC")]
		public override void WriteRawValue(string json)
		{
		}

		[Token(Token = "0x60005B0")]
		[Address(RVA = "0x2326F94", Offset = "0x2326F94", VA = "0x2326F94", Slot = "23")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A4D0", Offset = "0x18A4D0")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x60005B1")]
		[Address(RVA = "0x2326FF8", Offset = "0x2326FF8", VA = "0x2326FF8", Slot = "6")]
		public override void Close()
		{
		}
	}
}
