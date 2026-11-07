using System;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Utilities;

namespace Newtonsoft.Json
{
	[Token(Token = "0x200002B")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x182AFC", Offset = "0x182AFC")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182AFC", Offset = "0x182AFC")]
	public abstract class JsonWriter : IDisposable
	{
		[Token(Token = "0x200002C")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182B3C", Offset = "0x182B3C")]
		internal enum State
		{
			[Token(Token = "0x4000101")]
			Start = 0,
			[Token(Token = "0x4000102")]
			Property = 1,
			[Token(Token = "0x4000103")]
			ObjectStart = 2,
			[Token(Token = "0x4000104")]
			Object = 3,
			[Token(Token = "0x4000105")]
			ArrayStart = 4,
			[Token(Token = "0x4000106")]
			Array = 5,
			[Token(Token = "0x4000107")]
			ConstructorStart = 6,
			[Token(Token = "0x4000108")]
			Constructor = 7,
			[Token(Token = "0x4000109")]
			Closed = 8,
			[Token(Token = "0x400010A")]
			Error = 9
		}

		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x0")]
		private static readonly State[][] StateArray;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly State[][] StateArrayTemplate;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1855D0", Offset = "0x1855D0")]
		private List<JsonPosition> _stack;

		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x18")]
		private JsonPosition _currentPosition;

		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x30")]
		private State _currentState;

		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x34")]
		private Formatting _formatting;

		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1855E4", Offset = "0x1855E4")]
		private bool CloseOutput__BackingField;

		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x39")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1855F4", Offset = "0x1855F4")]
		private bool AutoCompleteOnClose__BackingField;

		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x3C")]
		private DateFormatHandling _dateFormatHandling;

		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x40")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x44")]
		private StringEscapeHandling _stringEscapeHandling;

		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0x48")]
		private FloatFormatHandling _floatFormatHandling;

		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185604", Offset = "0x185604")]
		private string _dateFormatString;

		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x185618", Offset = "0x185618")]
		private CultureInfo _culture;

		[Token(Token = "0x1700004B")]
		public bool CloseOutput
		{
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x2315C68", Offset = "0x2315C68", VA = "0x2315C68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188BD0", Offset = "0x188BD0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x2315C70", Offset = "0x2315C70", VA = "0x2315C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188BE0", Offset = "0x188BE0")]
			set
			{
			}
		}

		[Token(Token = "0x1700004C")]
		public bool AutoCompleteOnClose
		{
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x2315C78", Offset = "0x2315C78", VA = "0x2315C78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188BF0", Offset = "0x188BF0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000149")]
			[Address(RVA = "0x2315C80", Offset = "0x2315C80", VA = "0x2315C80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188C00", Offset = "0x188C00")]
			set
			{
			}
		}

		[Token(Token = "0x1700004D")]
		protected internal int Top
		{
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x2311380", Offset = "0x2311380", VA = "0x2311380")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004E")]
		public WriteState WriteState
		{
			[Token(Token = "0x600014B")]
			[Address(RVA = "0x2315C90", Offset = "0x2315C90", VA = "0x2315C90")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700004F")]
		internal string ContainerPath
		{
			[Token(Token = "0x600014C")]
			[Address(RVA = "0x2315DC8", Offset = "0x2315DC8", VA = "0x2315DC8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000050")]
		public string Path
		{
			[Token(Token = "0x600014D")]
			[Address(RVA = "0x2315E80", Offset = "0x2315E80", VA = "0x2315E80")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000051")]
		public Formatting Formatting
		{
			[Token(Token = "0x600014E")]
			[Address(RVA = "0x2315FAC", Offset = "0x2315FAC", VA = "0x2315FAC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600014F")]
			[Address(RVA = "0x2315FB4", Offset = "0x2315FB4", VA = "0x2315FB4")]
			set
			{
			}
		}

		[Token(Token = "0x17000052")]
		public DateFormatHandling DateFormatHandling
		{
			[Token(Token = "0x6000150")]
			[Address(RVA = "0x2316018", Offset = "0x2316018", VA = "0x2316018")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000151")]
			[Address(RVA = "0x2316020", Offset = "0x2316020", VA = "0x2316020")]
			set
			{
			}
		}

		[Token(Token = "0x17000053")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x6000152")]
			[Address(RVA = "0x2316084", Offset = "0x2316084", VA = "0x2316084")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000153")]
			[Address(RVA = "0x231608C", Offset = "0x231608C", VA = "0x231608C")]
			set
			{
			}
		}

		[Token(Token = "0x17000054")]
		public StringEscapeHandling StringEscapeHandling
		{
			[Token(Token = "0x6000154")]
			[Address(RVA = "0x23160F0", Offset = "0x23160F0", VA = "0x23160F0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000155")]
			[Address(RVA = "0x23160F8", Offset = "0x23160F8", VA = "0x23160F8")]
			set
			{
			}
		}

		[Token(Token = "0x17000055")]
		public FloatFormatHandling FloatFormatHandling
		{
			[Token(Token = "0x6000157")]
			[Address(RVA = "0x2316168", Offset = "0x2316168", VA = "0x2316168")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000158")]
			[Address(RVA = "0x2316170", Offset = "0x2316170", VA = "0x2316170")]
			set
			{
			}
		}

		[Token(Token = "0x17000056")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18EAE4", Offset = "0x18EAE4")]
		public string DateFormatString
		{
			[Token(Token = "0x6000159")]
			[Address(RVA = "0x23161D4", Offset = "0x23161D4", VA = "0x23161D4")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188C10", Offset = "0x188C10")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015A")]
			[Address(RVA = "0x23161DC", Offset = "0x23161DC", VA = "0x23161DC")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188C24", Offset = "0x188C24")]
			set
			{
			}
		}

		[Token(Token = "0x17000057")]
		public CultureInfo Culture
		{
			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2312820", Offset = "0x2312820", VA = "0x2312820")]
			get
			{
				return null;
			}
			[Token(Token = "0x600015C")]
			[Address(RVA = "0x23161E4", Offset = "0x23161E4", VA = "0x23161E4")]
			set
			{
			}
		}

		[Token(Token = "0x6000144")]
		[Address(RVA = "0x23156DC", Offset = "0x23156DC", VA = "0x23156DC")]
		internal static State[][] BuildStateArray()
		{
			return null;
		}

		[Token(Token = "0x6000145")]
		[Address(RVA = "0x2315904", Offset = "0x2315904", VA = "0x2315904")]
		static JsonWriter()
		{
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2316164", Offset = "0x2316164", VA = "0x2316164", Slot = "5")]
		internal virtual void OnStringEscapeHandlingChanged()
		{
		}

		[Token(Token = "0x600015D")]
		[Address(RVA = "0x23108E0", Offset = "0x23108E0", VA = "0x23108E0")]
		protected JsonWriter()
		{
		}

		[Token(Token = "0x600015E")]
		[Address(RVA = "0x23161EC", Offset = "0x23161EC", VA = "0x23161EC")]
		internal void UpdateScopeWithFinishedValue()
		{
		}

		[Token(Token = "0x600015F")]
		[Address(RVA = "0x2316208", Offset = "0x2316208", VA = "0x2316208")]
		private void Push(JsonContainerType value)
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x2316304", Offset = "0x2316304", VA = "0x2316304")]
		private JsonContainerType Pop()
		{
			return default;
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2315C88", Offset = "0x2315C88", VA = "0x2315C88")]
		private JsonContainerType Peek()
		{
			return default;
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x2310A7C", Offset = "0x2310A7C", VA = "0x2310A7C", Slot = "6")]
		public virtual void Close()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x231645C", Offset = "0x231645C", VA = "0x231645C", Slot = "7")]
		public virtual void WriteStartObject()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x23164A4", Offset = "0x23164A4", VA = "0x23164A4", Slot = "8")]
		public virtual void WriteEndObject()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x23164B0", Offset = "0x23164B0", VA = "0x23164B0", Slot = "9")]
		public virtual void WriteStartArray()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x23164F8", Offset = "0x23164F8", VA = "0x23164F8", Slot = "10")]
		public virtual void WriteEndArray()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x2316500", Offset = "0x2316500", VA = "0x2316500", Slot = "11")]
		public virtual void WriteStartConstructor(string name)
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x2316548", Offset = "0x2316548", VA = "0x2316548", Slot = "12")]
		public virtual void WriteEndConstructor()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x2316550", Offset = "0x2316550", VA = "0x2316550", Slot = "13")]
		public virtual void WritePropertyName(string name)
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x231655C", Offset = "0x231655C", VA = "0x231655C", Slot = "14")]
		public virtual void WritePropertyName(string name, bool escape)
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x231656C", Offset = "0x231656C", VA = "0x231656C", Slot = "15")]
		public virtual void WriteEnd()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x231667C", Offset = "0x231667C", VA = "0x231667C")]
		public void WriteToken(JsonReader reader)
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x23166FC", Offset = "0x23166FC", VA = "0x23166FC")]
		public void WriteToken(JsonReader reader, bool writeChildren)
		{
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2316788", Offset = "0x2316788", VA = "0x2316788")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188C38", Offset = "0x188C38")]
		public void WriteToken(JsonToken token, object value)
		{
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2316FE8", Offset = "0x2316FE8", VA = "0x2316FE8", Slot = "16")]
		internal virtual void WriteToken(JsonReader reader, bool writeChildren, bool writeDateConstructorAsDate, bool writeComments)
		{
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2317390", Offset = "0x2317390", VA = "0x2317390")]
		private bool IsWriteTokenIncomplete(JsonReader reader, bool writeChildren, int initialDepth)
		{
			return default;
		}

		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2317264", Offset = "0x2317264", VA = "0x2317264")]
		private int CalculateWriteTokenInitialDepth(JsonReader reader)
		{
			return default;
		}

		[Token(Token = "0x6000172")]
		[Address(RVA = "0x231743C", Offset = "0x231743C", VA = "0x231743C")]
		private int CalculateWriteTokenFinalDepth(JsonReader reader)
		{
			return default;
		}

		[Token(Token = "0x6000173")]
		[Address(RVA = "0x23172C0", Offset = "0x23172C0", VA = "0x23172C0")]
		private void WriteConstructorDate(JsonReader reader)
		{
		}

		[Token(Token = "0x6000174")]
		[Address(RVA = "0x2316574", Offset = "0x2316574", VA = "0x2316574")]
		private void WriteEnd(JsonContainerType type)
		{
		}

		[Token(Token = "0x6000175")]
		[Address(RVA = "0x23163D4", Offset = "0x23163D4", VA = "0x23163D4")]
		private void AutoCompleteAll()
		{
		}

		[Token(Token = "0x6000176")]
		[Address(RVA = "0x231749C", Offset = "0x231749C", VA = "0x231749C")]
		private JsonToken GetCloseTokenForType(JsonContainerType type)
		{
			return default;
		}

		[Token(Token = "0x6000177")]
		[Address(RVA = "0x231758C", Offset = "0x231758C", VA = "0x231758C")]
		private void AutoCompleteClose(JsonContainerType type)
		{
		}

		[Token(Token = "0x6000178")]
		[Address(RVA = "0x2317658", Offset = "0x2317658", VA = "0x2317658")]
		private int CalculateLevelsToComplete(JsonContainerType type)
		{
			return default;
		}

		[Token(Token = "0x6000179")]
		[Address(RVA = "0x231779C", Offset = "0x231779C", VA = "0x231779C")]
		private void UpdateCurrentState()
		{
		}

		[Token(Token = "0x600017A")]
		[Address(RVA = "0x23178A4", Offset = "0x23178A4", VA = "0x23178A4", Slot = "17")]
		protected virtual void WriteEnd(JsonToken token)
		{
		}

		[Token(Token = "0x600017B")]
		[Address(RVA = "0x23178A8", Offset = "0x23178A8", VA = "0x23178A8", Slot = "18")]
		protected virtual void WriteIndent()
		{
		}

		[Token(Token = "0x600017C")]
		[Address(RVA = "0x23178AC", Offset = "0x23178AC", VA = "0x23178AC", Slot = "19")]
		protected virtual void WriteValueDelimiter()
		{
		}

		[Token(Token = "0x600017D")]
		[Address(RVA = "0x23178B0", Offset = "0x23178B0", VA = "0x23178B0", Slot = "20")]
		protected virtual void WriteIndentSpace()
		{
		}

		[Token(Token = "0x600017E")]
		[Address(RVA = "0x23178B4", Offset = "0x23178B4", VA = "0x23178B4")]
		internal void AutoComplete(JsonToken tokenBeingWritten)
		{
		}

		[Token(Token = "0x600017F")]
		[Address(RVA = "0x2317B34", Offset = "0x2317B34", VA = "0x2317B34", Slot = "21")]
		public virtual void WriteNull()
		{
		}

		[Token(Token = "0x6000180")]
		[Address(RVA = "0x2317B54", Offset = "0x2317B54", VA = "0x2317B54", Slot = "22")]
		public virtual void WriteUndefined()
		{
		}

		[Token(Token = "0x6000181")]
		[Address(RVA = "0x2317B74", Offset = "0x2317B74", VA = "0x2317B74", Slot = "23")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188C4C", Offset = "0x188C4C")]
		public virtual void WriteRaw(string json)
		{
		}

		[Token(Token = "0x6000182")]
		[Address(RVA = "0x2317B78", Offset = "0x2317B78", VA = "0x2317B78", Slot = "24")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188C60", Offset = "0x188C60")]
		public virtual void WriteRawValue(string json)
		{
		}

		[Token(Token = "0x6000183")]
		[Address(RVA = "0x2317BD0", Offset = "0x2317BD0", VA = "0x2317BD0", Slot = "25")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188C74", Offset = "0x188C74")]
		public virtual void WriteValue(string value)
		{
		}

		[Token(Token = "0x6000184")]
		[Address(RVA = "0x2317BF0", Offset = "0x2317BF0", VA = "0x2317BF0", Slot = "26")]
		public virtual void WriteValue(int value)
		{
		}

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x2317C10", Offset = "0x2317C10", VA = "0x2317C10", Slot = "27")]
		public virtual void WriteValue(uint value)
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x2317C30", Offset = "0x2317C30", VA = "0x2317C30", Slot = "28")]
		public virtual void WriteValue(long value)
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x2317C50", Offset = "0x2317C50", VA = "0x2317C50", Slot = "29")]
		public virtual void WriteValue(ulong value)
		{
		}

		[Token(Token = "0x6000188")]
		[Address(RVA = "0x2317C70", Offset = "0x2317C70", VA = "0x2317C70", Slot = "30")]
		public virtual void WriteValue(float value)
		{
		}

		[Token(Token = "0x6000189")]
		[Address(RVA = "0x2317C90", Offset = "0x2317C90", VA = "0x2317C90", Slot = "31")]
		public virtual void WriteValue(double value)
		{
		}

		[Token(Token = "0x600018A")]
		[Address(RVA = "0x2317CB0", Offset = "0x2317CB0", VA = "0x2317CB0", Slot = "32")]
		public virtual void WriteValue(bool value)
		{
		}

		[Token(Token = "0x600018B")]
		[Address(RVA = "0x2317CD0", Offset = "0x2317CD0", VA = "0x2317CD0", Slot = "33")]
		public virtual void WriteValue(short value)
		{
		}

		[Token(Token = "0x600018C")]
		[Address(RVA = "0x2317CF0", Offset = "0x2317CF0", VA = "0x2317CF0", Slot = "34")]
		public virtual void WriteValue(ushort value)
		{
		}

		[Token(Token = "0x600018D")]
		[Address(RVA = "0x2317D10", Offset = "0x2317D10", VA = "0x2317D10", Slot = "35")]
		public virtual void WriteValue(char value)
		{
		}

		[Token(Token = "0x600018E")]
		[Address(RVA = "0x2317D30", Offset = "0x2317D30", VA = "0x2317D30", Slot = "36")]
		public virtual void WriteValue(byte value)
		{
		}

		[Token(Token = "0x600018F")]
		[Address(RVA = "0x2317D50", Offset = "0x2317D50", VA = "0x2317D50", Slot = "37")]
		public virtual void WriteValue(sbyte value)
		{
		}

		[Token(Token = "0x6000190")]
		[Address(RVA = "0x2317D70", Offset = "0x2317D70", VA = "0x2317D70", Slot = "38")]
		public virtual void WriteValue(decimal value)
		{
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x2317D90", Offset = "0x2317D90", VA = "0x2317D90", Slot = "39")]
		public virtual void WriteValue(DateTime value)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x2317DB0", Offset = "0x2317DB0", VA = "0x2317DB0", Slot = "40")]
		public virtual void WriteValue(DateTimeOffset value)
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x2317DD0", Offset = "0x2317DD0", VA = "0x2317DD0", Slot = "41")]
		public virtual void WriteValue(Guid value)
		{
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x2317DF0", Offset = "0x2317DF0", VA = "0x2317DF0", Slot = "42")]
		public virtual void WriteValue(TimeSpan value)
		{
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x2317E10", Offset = "0x2317E10", VA = "0x2317E10", Slot = "43")]
		public virtual void WriteValue(int? value)
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x2317E98", Offset = "0x2317E98", VA = "0x2317E98", Slot = "44")]
		public virtual void WriteValue(uint? value)
		{
		}

		[Token(Token = "0x6000197")]
		[Address(RVA = "0x2317F20", Offset = "0x2317F20", VA = "0x2317F20", Slot = "45")]
		public virtual void WriteValue(long? value)
		{
		}

		[Token(Token = "0x6000198")]
		[Address(RVA = "0x2317FAC", Offset = "0x2317FAC", VA = "0x2317FAC", Slot = "46")]
		public virtual void WriteValue(ulong? value)
		{
		}

		[Token(Token = "0x6000199")]
		[Address(RVA = "0x2318038", Offset = "0x2318038", VA = "0x2318038", Slot = "47")]
		public virtual void WriteValue(float? value)
		{
		}

		[Token(Token = "0x600019A")]
		[Address(RVA = "0x23180C0", Offset = "0x23180C0", VA = "0x23180C0", Slot = "48")]
		public virtual void WriteValue(double? value)
		{
		}

		[Token(Token = "0x600019B")]
		[Address(RVA = "0x231814C", Offset = "0x231814C", VA = "0x231814C", Slot = "49")]
		public virtual void WriteValue(bool? value)
		{
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x23181D8", Offset = "0x23181D8", VA = "0x23181D8", Slot = "50")]
		public virtual void WriteValue(short? value)
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x2318260", Offset = "0x2318260", VA = "0x2318260", Slot = "51")]
		public virtual void WriteValue(ushort? value)
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x23182E8", Offset = "0x23182E8", VA = "0x23182E8", Slot = "52")]
		public virtual void WriteValue(char? value)
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x2318370", Offset = "0x2318370", VA = "0x2318370", Slot = "53")]
		public virtual void WriteValue(byte? value)
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x23183F8", Offset = "0x23183F8", VA = "0x23183F8", Slot = "54")]
		public virtual void WriteValue(sbyte? value)
		{
		}

		[Token(Token = "0x60001A1")]
		[Address(RVA = "0x2318480", Offset = "0x2318480", VA = "0x2318480", Slot = "55")]
		public virtual void WriteValue(decimal? value)
		{
		}

		[Token(Token = "0x60001A2")]
		[Address(RVA = "0x2318510", Offset = "0x2318510", VA = "0x2318510", Slot = "56")]
		public virtual void WriteValue(DateTime? value)
		{
		}

		[Token(Token = "0x60001A3")]
		[Address(RVA = "0x231859C", Offset = "0x231859C", VA = "0x231859C", Slot = "57")]
		public virtual void WriteValue(DateTimeOffset? value)
		{
		}

		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x231862C", Offset = "0x231862C", VA = "0x231862C", Slot = "58")]
		public virtual void WriteValue(Guid? value)
		{
		}

		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x23186BC", Offset = "0x23186BC", VA = "0x23186BC", Slot = "59")]
		public virtual void WriteValue(TimeSpan? value)
		{
		}

		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x2318748", Offset = "0x2318748", VA = "0x2318748", Slot = "60")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188C88", Offset = "0x188C88")]
		public virtual void WriteValue(byte[] value)
		{
		}

		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x231877C", Offset = "0x231877C", VA = "0x231877C", Slot = "61")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188C9C", Offset = "0x188C9C")]
		public virtual void WriteValue(Uri value)
		{
		}

		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x2311690", Offset = "0x2311690", VA = "0x2311690", Slot = "62")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188CB0", Offset = "0x188CB0")]
		public virtual void WriteValue(object value)
		{
		}

		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x2319A0C", Offset = "0x2319A0C", VA = "0x2319A0C", Slot = "63")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188CC4", Offset = "0x188CC4")]
		public virtual void WriteComment(string text)
		{
		}

		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x2319A14", Offset = "0x2319A14", VA = "0x2319A14", Slot = "4")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x2319A98", Offset = "0x2319A98", VA = "0x2319A98", Slot = "64")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x23188F4", Offset = "0x23188F4", VA = "0x23188F4")]
		internal static void WriteValue(JsonWriter writer, PrimitiveTypeCode typeCode, object value)
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2319AB8", Offset = "0x2319AB8", VA = "0x2319AB8")]
		private static void ResolveConvertibleValue(IConvertible convertible, out PrimitiveTypeCode typeCode, out object value)
		{
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2318838", Offset = "0x2318838", VA = "0x2318838")]
		private static JsonWriterException CreateUnsupportedTypeException(JsonWriter writer, object value)
		{
			return null;
		}

		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x2319C8C", Offset = "0x2319C8C", VA = "0x2319C8C")]
		protected void SetWriteState(JsonToken token, object value)
		{
		}

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x23164AC", Offset = "0x23164AC", VA = "0x23164AC")]
		internal void InternalWriteEnd(JsonContainerType container)
		{
		}

		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x2310FBC", Offset = "0x2310FBC", VA = "0x2310FBC")]
		internal void InternalWritePropertyName(string name)
		{
		}

		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x2311968", Offset = "0x2311968", VA = "0x2311968")]
		internal void InternalWriteRaw()
		{
		}

		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x2310BD4", Offset = "0x2310BD4", VA = "0x2310BD4")]
		internal void InternalWriteStart(JsonToken token, JsonContainerType container)
		{
		}

		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x2311674", Offset = "0x2311674", VA = "0x2311674")]
		internal void InternalWriteValue(JsonToken token)
		{
		}

		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x23130E0", Offset = "0x23130E0", VA = "0x23130E0")]
		internal void InternalWriteComment()
		{
		}
	}
}
