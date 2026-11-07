using System;
using System.IO;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000029")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182ABC", Offset = "0x182ABC")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182ABC", Offset = "0x182ABC")]
	public class JsonTextWriter : JsonWriter
	{
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x60")]
		private readonly bool _safeAsync;

		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0x68")]
		private readonly TextWriter _writer;

		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18556C", Offset = "0x18556C")]
		private Base64Encoder _base64Encoder;

		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x78")]
		private char _indentChar;

		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x7C")]
		private int _indentation;

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x80")]
		private char _quoteChar;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x82")]
		private bool _quoteName;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x88")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185580", Offset = "0x185580")]
		private bool[] _charEscapeFlags;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x90")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185594", Offset = "0x185594")]
		private char[] _writeBuffer;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x98")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1855A8", Offset = "0x1855A8")]
		private IArrayPool<char> _arrayPool;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0xA0")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1855BC", Offset = "0x1855BC")]
		private char[] _indentChars;

		[Token(Token = "0x17000049")]
		private Base64Encoder Base64Encoder
		{
			[Token(Token = "0x600010D")]
			[Address(RVA = "0x2310680", Offset = "0x2310680", VA = "0x2310680")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700004A")]
		public char QuoteChar
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x23106F8", Offset = "0x23106F8", VA = "0x23106F8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2310700", Offset = "0x2310700", VA = "0x2310700")]
		public JsonTextWriter(TextWriter textWriter)
		{
		}

		[Token(Token = "0x6000110")]
		[Address(RVA = "0x23109A4", Offset = "0x23109A4", VA = "0x23109A4", Slot = "6")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2310B10", Offset = "0x2310B10", VA = "0x2310B10")]
		private void CloseBufferAndWriter()
		{
		}

		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2310B6C", Offset = "0x2310B6C", VA = "0x2310B6C", Slot = "7")]
		public override void WriteStartObject()
		{
		}

		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2310C1C", Offset = "0x2310C1C", VA = "0x2310C1C", Slot = "9")]
		public override void WriteStartArray()
		{
		}

		[Token(Token = "0x6000114")]
		[Address(RVA = "0x2310C84", Offset = "0x2310C84", VA = "0x2310C84", Slot = "11")]
		public override void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000115")]
		[Address(RVA = "0x2310D58", Offset = "0x2310D58", VA = "0x2310D58", Slot = "17")]
		protected override void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x6000116")]
		[Address(RVA = "0x2310F64", Offset = "0x2310F64", VA = "0x2310F64", Slot = "13")]
		public override void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x6000117")]
		[Address(RVA = "0x23110C0", Offset = "0x23110C0", VA = "0x23110C0", Slot = "14")]
		public override void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x6000118")]
		[Address(RVA = "0x2311190", Offset = "0x2311190", VA = "0x2311190", Slot = "5")]
		internal override void OnStringEscapeHandlingChanged()
		{
		}

		[Token(Token = "0x6000119")]
		[Address(RVA = "0x2310918", Offset = "0x2310918", VA = "0x2310918")]
		private void UpdateCharEscapeFlags()
		{
		}

		[Token(Token = "0x600011A")]
		[Address(RVA = "0x231121C", Offset = "0x231121C", VA = "0x231121C", Slot = "18")]
		protected override void WriteIndent()
		{
		}

		[Token(Token = "0x600011B")]
		[Address(RVA = "0x23113D4", Offset = "0x23113D4", VA = "0x23113D4")]
		private int SetIndentChars()
		{
			return default;
		}

		[Token(Token = "0x600011C")]
		[Address(RVA = "0x23114C4", Offset = "0x23114C4", VA = "0x23114C4", Slot = "19")]
		protected override void WriteValueDelimiter()
		{
		}

		[Token(Token = "0x600011D")]
		[Address(RVA = "0x23114EC", Offset = "0x23114EC", VA = "0x23114EC", Slot = "20")]
		protected override void WriteIndentSpace()
		{
		}

		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2311514", Offset = "0x2311514", VA = "0x2311514")]
		private void WriteValueInternal(string value, JsonToken token)
		{
		}

		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2311538", Offset = "0x2311538", VA = "0x2311538", Slot = "62")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188B58", Offset = "0x188B58")]
		public override void WriteValue(object value)
		{
		}

		[Token(Token = "0x6000120")]
		[Address(RVA = "0x23117FC", Offset = "0x23117FC", VA = "0x23117FC", Slot = "21")]
		public override void WriteNull()
		{
		}

		[Token(Token = "0x6000121")]
		[Address(RVA = "0x23118A0", Offset = "0x23118A0", VA = "0x23118A0", Slot = "22")]
		public override void WriteUndefined()
		{
		}

		[Token(Token = "0x6000122")]
		[Address(RVA = "0x2311944", Offset = "0x2311944", VA = "0x2311944", Slot = "23")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188B6C", Offset = "0x188B6C")]
		public override void WriteRaw(string json)
		{
		}

		[Token(Token = "0x6000123")]
		[Address(RVA = "0x231196C", Offset = "0x231196C", VA = "0x231196C", Slot = "25")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188B80", Offset = "0x188B80")]
		public override void WriteValue(string value)
		{
		}

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x2310FC8", Offset = "0x2310FC8", VA = "0x2310FC8")]
		private void WriteEscapedString(string value, bool quote)
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x2311A7C", Offset = "0x2311A7C", VA = "0x2311A7C", Slot = "26")]
		public override void WriteValue(int value)
		{
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x2311B6C", Offset = "0x2311B6C", VA = "0x2311B6C", Slot = "27")]
		public override void WriteValue(uint value)
		{
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x2311C5C", Offset = "0x2311C5C", VA = "0x2311C5C", Slot = "28")]
		public override void WriteValue(long value)
		{
		}

		[Token(Token = "0x6000128")]
		[Address(RVA = "0x2311CA8", Offset = "0x2311CA8", VA = "0x2311CA8", Slot = "29")]
		public override void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x6000129")]
		[Address(RVA = "0x2311DCC", Offset = "0x2311DCC", VA = "0x2311DCC", Slot = "30")]
		public override void WriteValue(float value)
		{
		}

		[Token(Token = "0x600012A")]
		[Address(RVA = "0x2311EA8", Offset = "0x2311EA8", VA = "0x2311EA8", Slot = "47")]
		public override void WriteValue(float? value)
		{
		}

		[Token(Token = "0x600012B")]
		[Address(RVA = "0x2311FC8", Offset = "0x2311FC8", VA = "0x2311FC8", Slot = "31")]
		public override void WriteValue(double value)
		{
		}

		[Token(Token = "0x600012C")]
		[Address(RVA = "0x23120A4", Offset = "0x23120A4", VA = "0x23120A4", Slot = "48")]
		public override void WriteValue(double? value)
		{
		}

		[Token(Token = "0x600012D")]
		[Address(RVA = "0x23121C8", Offset = "0x23121C8", VA = "0x23121C8", Slot = "32")]
		public override void WriteValue(bool value)
		{
		}

		[Token(Token = "0x600012E")]
		[Address(RVA = "0x231227C", Offset = "0x231227C", VA = "0x231227C", Slot = "33")]
		public override void WriteValue(short value)
		{
		}

		[Token(Token = "0x600012F")]
		[Address(RVA = "0x23122C8", Offset = "0x23122C8", VA = "0x23122C8", Slot = "34")]
		public override void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x6000130")]
		[Address(RVA = "0x2312314", Offset = "0x2312314", VA = "0x2312314", Slot = "35")]
		public override void WriteValue(char value)
		{
		}

		[Token(Token = "0x6000131")]
		[Address(RVA = "0x23123C8", Offset = "0x23123C8", VA = "0x23123C8", Slot = "36")]
		public override void WriteValue(byte value)
		{
		}

		[Token(Token = "0x6000132")]
		[Address(RVA = "0x2312414", Offset = "0x2312414", VA = "0x2312414", Slot = "37")]
		public override void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000133")]
		[Address(RVA = "0x2312460", Offset = "0x2312460", VA = "0x2312460", Slot = "38")]
		public override void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x6000134")]
		[Address(RVA = "0x231251C", Offset = "0x231251C", VA = "0x231251C", Slot = "39")]
		public override void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000135")]
		[Address(RVA = "0x23126EC", Offset = "0x23126EC", VA = "0x23126EC")]
		private int WriteValueToBuffer(DateTime value)
		{
			return default;
		}

		[Token(Token = "0x6000136")]
		[Address(RVA = "0x2312894", Offset = "0x2312894", VA = "0x2312894", Slot = "60")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188B94", Offset = "0x188B94")]
		public override void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x6000137")]
		[Address(RVA = "0x2312A38", Offset = "0x2312A38", VA = "0x2312A38", Slot = "40")]
		public override void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x6000138")]
		[Address(RVA = "0x2312BA0", Offset = "0x2312BA0", VA = "0x2312BA0")]
		private int WriteValueToBuffer(DateTimeOffset value)
		{
			return default;
		}

		[Token(Token = "0x6000139")]
		[Address(RVA = "0x2312D18", Offset = "0x2312D18", VA = "0x2312D18", Slot = "41")]
		public override void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x600013A")]
		[Address(RVA = "0x2312E38", Offset = "0x2312E38", VA = "0x2312E38", Slot = "42")]
		public override void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x600013B")]
		[Address(RVA = "0x2312F3C", Offset = "0x2312F3C", VA = "0x2312F3C", Slot = "61")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188BA8", Offset = "0x188BA8")]
		public override void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x600013C")]
		[Address(RVA = "0x231301C", Offset = "0x231301C", VA = "0x231301C", Slot = "63")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188BBC", Offset = "0x188BBC")]
		public override void WriteComment(string text)
		{
		}

		[Token(Token = "0x600013D")]
		[Address(RVA = "0x2311A3C", Offset = "0x2311A3C", VA = "0x2311A3C")]
		private void EnsureWriteBuffer()
		{
		}

		[Token(Token = "0x600013E")]
		[Address(RVA = "0x2311BB8", Offset = "0x2311BB8", VA = "0x2311BB8")]
		private void WriteIntegerValue(long value)
		{
		}

		[Token(Token = "0x600013F")]
		[Address(RVA = "0x2311D50", Offset = "0x2311D50", VA = "0x2311D50")]
		private void WriteIntegerValue(ulong value, bool negative)
		{
		}

		[Token(Token = "0x6000140")]
		[Address(RVA = "0x23130E8", Offset = "0x23130E8", VA = "0x23130E8")]
		private int WriteNumberToBuffer(ulong value, bool negative)
		{
			return default;
		}

		[Token(Token = "0x6000141")]
		[Address(RVA = "0x2311AC8", Offset = "0x2311AC8", VA = "0x2311AC8")]
		private void WriteIntegerValue(int value)
		{
		}

		[Token(Token = "0x6000142")]
		[Address(RVA = "0x2313638", Offset = "0x2313638", VA = "0x2313638")]
		private void WriteIntegerValue(uint value, bool negative)
		{
		}

		[Token(Token = "0x6000143")]
		[Address(RVA = "0x23132F0", Offset = "0x23132F0", VA = "0x23132F0")]
		private int WriteNumberToBuffer(uint value, bool negative)
		{
			return default;
		}
	}
}
