using Il2CppDummyDll;

namespace Newtonsoft.Json.Linq
{
	[Token(Token = "0x20000DC")]
	[Attribute(Name = "NullableAttribute", RVA = "0x1844A4", Offset = "0x1844A4")]
	[Attribute(Name = "NullableContextAttribute", RVA = "0x1844A4", Offset = "0x1844A4")]
	public class JTokenReader : JsonReader, IJsonLineInfo
	{
		[Token(Token = "0x400031F")]
		[FieldOffset(Offset = "0x78")]
		private readonly JToken _root;

		[Token(Token = "0x4000320")]
		[FieldOffset(Offset = "0x80")]
		[Attribute(Name = "NullableAttribute", RVA = "0x188350", Offset = "0x188350")]
		private string _initialPath;

		[Token(Token = "0x4000321")]
		[FieldOffset(Offset = "0x88")]
		[Attribute(Name = "NullableAttribute", RVA = "0x188364", Offset = "0x188364")]
		private JToken _parent;

		[Token(Token = "0x4000322")]
		[FieldOffset(Offset = "0x90")]
		[Attribute(Name = "NullableAttribute", RVA = "0x188378", Offset = "0x188378")]
		private JToken _current;

		[Token(Token = "0x17000137")]
		[Attribute(Name = "NullableAttribute", RVA = "0x18F838", Offset = "0x18F838")]
		public JToken CurrentToken
		{
			[Token(Token = "0x60006FC")]
			[Address(RVA = "0x22DDC2C", Offset = "0x22DDC2C", VA = "0x22DDC2C")]
			[Attribute(Name = "NullableContextAttribute", RVA = "0x18AB40", Offset = "0x18AB40")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000138")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELineNumber
		{
			[Token(Token = "0x6000707")]
			[Address(RVA = "0x22DE884", Offset = "0x22DE884", VA = "0x22DE884", Slot = "22")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber();
			}
		}

		[Token(Token = "0x17000139")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002ELinePosition
		{
			[Token(Token = "0x6000708")]
			[Address(RVA = "0x22DE950", Offset = "0x22DE950", VA = "0x22DE950", Slot = "23")]
			get
			{
				return Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition();
			}
		}

		[Token(Token = "0x1700013A")]
		public override string Path
		{
			[Token(Token = "0x6000709")]
			[Address(RVA = "0x22DEA1C", Offset = "0x22DEA1C", VA = "0x22DEA1C", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x22DBFF8", Offset = "0x22DBFF8", VA = "0x22DBFF8")]
		public JTokenReader(JToken token)
		{
		}

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x22DDC34", Offset = "0x22DDC34", VA = "0x22DDC34", Slot = "10")]
		public override bool Read()
		{
			return default;
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x22DDDE4", Offset = "0x22DDDE4", VA = "0x22DDDE4")]
		private bool ReadOver(JToken t)
		{
			return default;
		}

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x22DE570", Offset = "0x22DE570", VA = "0x22DE570")]
		private bool ReadToEnd()
		{
			return default;
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x22DE624", Offset = "0x22DE624", VA = "0x22DE624")]
		private JsonToken? GetEndToken(JContainer c)
		{
			return null;
		}

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x22DDD18", Offset = "0x22DDD18", VA = "0x22DDD18")]
		private bool ReadInto(JContainer c)
		{
			return default;
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x22DE594", Offset = "0x22DE594", VA = "0x22DE594")]
		private bool SetEnd(JContainer c)
		{
			return default;
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x22DDEA0", Offset = "0x22DDEA0", VA = "0x22DDEA0")]
		private void SetToken(JToken token)
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x22DE79C", Offset = "0x22DE79C", VA = "0x22DE79C")]
		[Attribute(Name = "NullableContextAttribute", RVA = "0x18AB54", Offset = "0x18AB54")]
		private string SafeToString(object value)
		{
			return null;
		}

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x22DE7BC", Offset = "0x22DE7BC", VA = "0x22DE7BC", Slot = "21")]
		private bool Newtonsoft_002EJson_002EIJsonLineInfo_002EHasLineInfo()
		{
			return default;
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x22DE884", Offset = "0x22DE884", VA = "0x22DE884", Slot = "22")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LineNumber()
		{
			return default;
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x22DE950", Offset = "0x22DE950", VA = "0x22DE950", Slot = "23")]
		private int Newtonsoft_002EJson_002EIJsonLineInfo_002Eget_LinePosition()
		{
			return default;
		}
	}
}
