using System;
using System.IO;
using Il2CppDummyDll;

namespace Newtonsoft.Json.Serialization
{
	[Token(Token = "0x20000C7")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x183F84", Offset = "0x183F84")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x183F84", Offset = "0x183F84")]
	internal class TraceJsonReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x40002E4")]
		[FieldOffset(Offset = "0x78")]
		private readonly JsonReader _innerReader;

		[Token(Token = "0x40002E5")]
		[FieldOffset(Offset = "0x80")]
		private readonly JsonTextWriter _textWriter;

		[Token(Token = "0x40002E6")]
		[FieldOffset(Offset = "0x88")]
		private readonly StringWriter _sw;

		[Token(Token = "0x170000F0")]
		public override int Depth
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x2324F88", Offset = "0x2324F88", VA = "0x2324F88", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F1")]
		public override string Path
		{
			[Token(Token = "0x6000574")]
			[Address(RVA = "0x2324FA8", Offset = "0x2324FA8", VA = "0x2324FA8", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F2")]
		public override JsonToken TokenType
		{
			[Token(Token = "0x6000575")]
			[Address(RVA = "0x2324FC8", Offset = "0x2324FC8", VA = "0x2324FC8", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000F3")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F6D8", Offset = "0x18F6D8")]
		public override object Value
		{
			[Token(Token = "0x6000576")]
			[Address(RVA = "0x2324FE8", Offset = "0x2324FE8", VA = "0x2324FE8", Slot = "6")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A430", Offset = "0x18A430")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F4")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18F6EC", Offset = "0x18F6EC")]
		public override Type ValueType
		{
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x2325008", Offset = "0x2325008", VA = "0x2325008", Slot = "7")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A444", Offset = "0x18A444")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000F5")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber
		{
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x232511C", Offset = "0x232511C", VA = "0x232511C", Slot = "22")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber();
			}
		}

		[Token(Token = "0x170000F6")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition
		{
			[Token(Token = "0x600057B")]
			[Address(RVA = "0x23251F0", Offset = "0x23251F0", VA = "0x23251F0", Slot = "23")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition();
			}
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2324A40", Offset = "0x2324A40", VA = "0x2324A40")]
		public TraceJsonReader(JsonReader innerReader)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x2324B8C", Offset = "0x2324B8C", VA = "0x2324B8C")]
		public string GetDeserializedJsonMessage()
		{
			return null;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x2324BAC", Offset = "0x2324BAC", VA = "0x2324BAC", Slot = "10")]
		public override bool Read()
		{
			return default;
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x2324C48", Offset = "0x2324C48", VA = "0x2324C48", Slot = "11")]
		public override int? ReadAsInt32()
		{
			return null;
		}

		[Token(Token = "0x600056B")]
		[Address(RVA = "0x2324CAC", Offset = "0x2324CAC", VA = "0x2324CAC", Slot = "12")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A408", Offset = "0x18A408")]
		public override string ReadAsString()
		{
			return null;
		}

		[Token(Token = "0x600056C")]
		[Address(RVA = "0x2324D10", Offset = "0x2324D10", VA = "0x2324D10", Slot = "13")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x18A41C", Offset = "0x18A41C")]
		public override byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x2324D78", Offset = "0x2324D78", VA = "0x2324D78", Slot = "16")]
		public override decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x2324DD4", Offset = "0x2324DD4", VA = "0x2324DD4", Slot = "14")]
		public override double? ReadAsDouble()
		{
			return null;
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2324E4C", Offset = "0x2324E4C", VA = "0x2324E4C", Slot = "15")]
		public override bool? ReadAsBoolean()
		{
			return null;
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x2324EB4", Offset = "0x2324EB4", VA = "0x2324EB4", Slot = "17")]
		public override DateTime? ReadAsDateTime()
		{
			return null;
		}

		[Token(Token = "0x6000571")]
		[Address(RVA = "0x2324F2C", Offset = "0x2324F2C", VA = "0x2324F2C", Slot = "18")]
		public override DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x2324C10", Offset = "0x2324C10", VA = "0x2324C10")]
		public void WriteCurrentToken()
		{
		}

		[Token(Token = "0x6000578")]
		[Address(RVA = "0x2325028", Offset = "0x2325028", VA = "0x2325028", Slot = "20")]
		public override void Close()
		{
		}

		[Token(Token = "0x6000579")]
		[Address(RVA = "0x232504C", Offset = "0x232504C", VA = "0x232504C", Slot = "21")]
		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return default;
		}

		[Token(Token = "0x600057A")]
		[Address(RVA = "0x232511C", Offset = "0x232511C", VA = "0x232511C", Slot = "22")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber()
		{
			return default;
		}

		[Token(Token = "0x600057B")]
		[Address(RVA = "0x23251F0", Offset = "0x23251F0", VA = "0x23251F0", Slot = "23")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition()
		{
			return default;
		}
	}
}
