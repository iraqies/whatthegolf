using System;
using System.Collections.Generic;
using System.Globalization;
using Il2CppDummyDll;
using Newtonsoft.Json.Serialization;

namespace Newtonsoft.Json
{
	[Token(Token = "0x2000020")]
	[AttributeAttribute(Name = "NullableAttribute", RVA = "0x1828F4", Offset = "0x1828F4")]
	[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1828F4", Offset = "0x1828F4")]
	public abstract class JsonReader : IDisposable
	{
		[Token(Token = "0x2000021")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x182934", Offset = "0x182934")]
		protected internal enum State
		{
			[Token(Token = "0x400006B")]
			Start = 0,
			[Token(Token = "0x400006C")]
			Complete = 1,
			[Token(Token = "0x400006D")]
			Property = 2,
			[Token(Token = "0x400006E")]
			ObjectStart = 3,
			[Token(Token = "0x400006F")]
			Object = 4,
			[Token(Token = "0x4000070")]
			ArrayStart = 5,
			[Token(Token = "0x4000071")]
			Array = 6,
			[Token(Token = "0x4000072")]
			Closed = 7,
			[Token(Token = "0x4000073")]
			PostValue = 8,
			[Token(Token = "0x4000074")]
			ConstructorStart = 9,
			[Token(Token = "0x4000075")]
			Constructor = 10,
			[Token(Token = "0x4000076")]
			Error = 11,
			[Token(Token = "0x4000077")]
			Finished = 12
		}

		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x10")]
		private JsonToken _tokenType;

		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x18")]
		private object _value;

		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x20")]
		internal char _quoteChar;

		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x24")]
		internal State _currentState;

		[Token(Token = "0x400005F")]
		[FieldOffset(Offset = "0x28")]
		private JsonPosition _currentPosition;

		[Token(Token = "0x4000060")]
		[FieldOffset(Offset = "0x40")]
		private CultureInfo _culture;

		[Token(Token = "0x4000061")]
		[FieldOffset(Offset = "0x48")]
		private DateTimeZoneHandling _dateTimeZoneHandling;

		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x4C")]
		private int? _maxDepth;

		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x54")]
		private bool _hasExceededMaxDepth;

		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x58")]
		internal DateParseHandling _dateParseHandling;

		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x5C")]
		internal FloatParseHandling _floatParseHandling;

		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x60")]
		private string _dateFormatString;

		[Token(Token = "0x4000067")]
		[FieldOffset(Offset = "0x68")]
		private List<JsonPosition> _stack;

		[Token(Token = "0x4000068")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18522C", Offset = "0x18522C")]
		private bool CloseInput__BackingField;

		[Token(Token = "0x4000069")]
		[FieldOffset(Offset = "0x71")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x18523C", Offset = "0x18523C")]
		private bool SupportMultipleContent__BackingField;

		[Token(Token = "0x17000016")]
		protected State CurrentState
		{
			[Token(Token = "0x6000046")]
			[Address(RVA = "0x22EC3E4", Offset = "0x22EC3E4", VA = "0x22EC3E4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000017")]
		public bool CloseInput
		{
			[Token(Token = "0x6000047")]
			[Address(RVA = "0x22EC3EC", Offset = "0x22EC3EC", VA = "0x22EC3EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188840", Offset = "0x188840")]
			set
			{
			}
		}

		[Token(Token = "0x17000018")]
		public bool SupportMultipleContent
		{
			[Token(Token = "0x6000048")]
			[Address(RVA = "0x22EC3F4", Offset = "0x22EC3F4", VA = "0x22EC3F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188850", Offset = "0x188850")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x22EC3FC", Offset = "0x22EC3FC", VA = "0x22EC3FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x188860", Offset = "0x188860")]
			set
			{
			}
		}

		[Token(Token = "0x17000019")]
		public DateTimeZoneHandling DateTimeZoneHandling
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x22EC404", Offset = "0x22EC404", VA = "0x22EC404")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x22EC40C", Offset = "0x22EC40C", VA = "0x22EC40C")]
			set
			{
			}
		}

		[Token(Token = "0x1700001A")]
		public DateParseHandling DateParseHandling
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x22EC470", Offset = "0x22EC470", VA = "0x22EC470")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x22EC478", Offset = "0x22EC478", VA = "0x22EC478")]
			set
			{
			}
		}

		[Token(Token = "0x1700001B")]
		public FloatParseHandling FloatParseHandling
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x22EC4DC", Offset = "0x22EC4DC", VA = "0x22EC4DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600004F")]
			[Address(RVA = "0x22EC4E4", Offset = "0x22EC4E4", VA = "0x22EC4E4")]
			set
			{
			}
		}

		[Token(Token = "0x1700001C")]
		public string DateFormatString
		{
			[Token(Token = "0x6000050")]
			[Address(RVA = "0x22EC548", Offset = "0x22EC548", VA = "0x22EC548")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000051")]
			[Address(RVA = "0x22EC550", Offset = "0x22EC550", VA = "0x22EC550")]
			set
			{
			}
		}

		[Token(Token = "0x1700001D")]
		public int? MaxDepth
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x22EC558", Offset = "0x22EC558", VA = "0x22EC558")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x22EC560", Offset = "0x22EC560", VA = "0x22EC560")]
			set
			{
			}
		}

		[Token(Token = "0x1700001E")]
		public virtual JsonToken TokenType
		{
			[Token(Token = "0x6000054")]
			[Address(RVA = "0x22EC620", Offset = "0x22EC620", VA = "0x22EC620", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700001F")]
		public virtual object Value
		{
			[Token(Token = "0x6000055")]
			[Address(RVA = "0x22EC628", Offset = "0x22EC628", VA = "0x22EC628", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000020")]
		public virtual Type ValueType
		{
			[Token(Token = "0x6000056")]
			[Address(RVA = "0x22EC630", Offset = "0x22EC630", VA = "0x22EC630", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000021")]
		public virtual int Depth
		{
			[Token(Token = "0x6000057")]
			[Address(RVA = "0x22EC644", Offset = "0x22EC644", VA = "0x22EC644", Slot = "8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000022")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E9E8", Offset = "0x18E9E8")]
		public virtual string Path
		{
			[Token(Token = "0x6000058")]
			[Address(RVA = "0x22EC6C0", Offset = "0x22EC6C0", VA = "0x22EC6C0", Slot = "9")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188870", Offset = "0x188870")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000023")]
		[AttributeAttribute(Name = "NullableAttribute", RVA = "0x18E9FC", Offset = "0x18E9FC")]
		public CultureInfo Culture
		{
			[Token(Token = "0x6000059")]
			[Address(RVA = "0x22EC7E0", Offset = "0x22EC7E0", VA = "0x22EC7E0")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188884", Offset = "0x188884")]
			get
			{
				return null;
			}
			[Token(Token = "0x600005A")]
			[Address(RVA = "0x22EC854", Offset = "0x22EC854", VA = "0x22EC854")]
			[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x188898", Offset = "0x188898")]
			set
			{
			}
		}

		[Token(Token = "0x600005B")]
		[Address(RVA = "0x22EC85C", Offset = "0x22EC85C", VA = "0x22EC85C")]
		internal JsonPosition GetPosition(int depth)
		{
			return default;
		}

		[Token(Token = "0x600005C")]
		[Address(RVA = "0x22EC8FC", Offset = "0x22EC8FC", VA = "0x22EC8FC")]
		protected JsonReader()
		{
		}

		[Token(Token = "0x600005D")]
		[Address(RVA = "0x22EC990", Offset = "0x22EC990", VA = "0x22EC990")]
		private void Push(JsonContainerType value)
		{
		}

		[Token(Token = "0x600005E")]
		[Address(RVA = "0x22ECCE4", Offset = "0x22ECCE4", VA = "0x22ECCE4")]
		private JsonContainerType Pop()
		{
			return default;
		}

		[Token(Token = "0x600005F")]
		[Address(RVA = "0x22ECDF0", Offset = "0x22ECDF0", VA = "0x22ECDF0")]
		private JsonContainerType Peek()
		{
			return default;
		}

		[Token(Token = "0x6000060")]
		public abstract bool Read();

		[Token(Token = "0x6000061")]
		[Address(RVA = "0x22ECDF8", Offset = "0x22ECDF8", VA = "0x22ECDF8", Slot = "11")]
		public virtual int? ReadAsInt32()
		{
			return null;
		}

		[Token(Token = "0x6000062")]
		[Address(RVA = "0x22ED5E8", Offset = "0x22ED5E8", VA = "0x22ED5E8")]
		internal int? ReadInt32String(string s)
		{
			return null;
		}

		[Token(Token = "0x6000063")]
		[Address(RVA = "0x22ED84C", Offset = "0x22ED84C", VA = "0x22ED84C", Slot = "12")]
		public virtual string ReadAsString()
		{
			return null;
		}

		[Token(Token = "0x6000064")]
		[Address(RVA = "0x22EDBD8", Offset = "0x22EDBD8", VA = "0x22EDBD8", Slot = "13")]
		public virtual byte[] ReadAsBytes()
		{
			return null;
		}

		[Token(Token = "0x6000065")]
		[Address(RVA = "0x22EE3A4", Offset = "0x22EE3A4", VA = "0x22EE3A4")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1888AC", Offset = "0x1888AC")]
		internal byte[] ReadArrayIntoByteArray()
		{
			return null;
		}

		[Token(Token = "0x6000066")]
		[Address(RVA = "0x22EE500", Offset = "0x22EE500", VA = "0x22EE500")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1888C0", Offset = "0x1888C0")]
		private bool ReadArrayElementIntoByteArrayReportDone(List<byte> buffer)
		{
			return default;
		}

		[Token(Token = "0x6000067")]
		[Address(RVA = "0x22EE6F8", Offset = "0x22EE6F8", VA = "0x22EE6F8", Slot = "14")]
		public virtual double? ReadAsDouble()
		{
			return null;
		}

		[Token(Token = "0x6000068")]
		[Address(RVA = "0x22EEB4C", Offset = "0x22EEB4C", VA = "0x22EEB4C")]
		internal double? ReadDoubleString(string s)
		{
			return null;
		}

		[Token(Token = "0x6000069")]
		[Address(RVA = "0x22EEDD0", Offset = "0x22EEDD0", VA = "0x22EEDD0", Slot = "15")]
		public virtual bool? ReadAsBoolean()
		{
			return null;
		}

		[Token(Token = "0x600006A")]
		[Address(RVA = "0x22EF268", Offset = "0x22EF268", VA = "0x22EF268")]
		internal bool? ReadBooleanString(string s)
		{
			return null;
		}

		[Token(Token = "0x600006B")]
		[Address(RVA = "0x22EF48C", Offset = "0x22EF48C", VA = "0x22EF48C", Slot = "16")]
		public virtual decimal? ReadAsDecimal()
		{
			return null;
		}

		[Token(Token = "0x600006C")]
		[Address(RVA = "0x22EFA14", Offset = "0x22EFA14", VA = "0x22EFA14")]
		internal decimal? ReadDecimalString(string s)
		{
			return null;
		}

		[Token(Token = "0x600006D")]
		[Address(RVA = "0x22EFD14", Offset = "0x22EFD14", VA = "0x22EFD14", Slot = "17")]
		public virtual DateTime? ReadAsDateTime()
		{
			return null;
		}

		[Token(Token = "0x600006E")]
		[Address(RVA = "0x22F003C", Offset = "0x22F003C", VA = "0x22F003C")]
		internal DateTime? ReadDateTimeString(string s)
		{
			return null;
		}

		[Token(Token = "0x600006F")]
		[Address(RVA = "0x22F03EC", Offset = "0x22F03EC", VA = "0x22F03EC", Slot = "18")]
		public virtual DateTimeOffset? ReadAsDateTimeOffset()
		{
			return null;
		}

		[Token(Token = "0x6000070")]
		[Address(RVA = "0x22F071C", Offset = "0x22F071C", VA = "0x22F071C")]
		internal DateTimeOffset? ReadDateTimeOffsetString(string s)
		{
			return null;
		}

		[Token(Token = "0x6000071")]
		[Address(RVA = "0x22EE354", Offset = "0x22EE354", VA = "0x22EE354")]
		internal void ReaderReadAndAssert()
		{
		}

		[Token(Token = "0x6000072")]
		[Address(RVA = "0x22F0A68", Offset = "0x22F0A68", VA = "0x22F0A68")]
		[AttributeAttribute(Name = "NullableContextAttribute", RVA = "0x1888D4", Offset = "0x1888D4")]
		internal JsonReaderException CreateUnexpectedEndException()
		{
			return null;
		}

		[Token(Token = "0x6000073")]
		[Address(RVA = "0x22EE118", Offset = "0x22EE118", VA = "0x22EE118")]
		internal void ReadIntoWrappedTypeObject()
		{
		}

		[Token(Token = "0x6000074")]
		[Address(RVA = "0x22F0B14", Offset = "0x22F0B14", VA = "0x22F0B14")]
		public void Skip()
		{
		}

		[Token(Token = "0x6000075")]
		[Address(RVA = "0x22EE4F4", Offset = "0x22EE4F4", VA = "0x22EE4F4")]
		protected void SetToken(JsonToken newToken)
		{
		}

		[Token(Token = "0x6000076")]
		[Address(RVA = "0x22F0BB0", Offset = "0x22F0BB0", VA = "0x22F0BB0")]
		protected void SetToken(JsonToken newToken, object value)
		{
		}

		[Token(Token = "0x6000077")]
		[Address(RVA = "0x22ED44C", Offset = "0x22ED44C", VA = "0x22ED44C")]
		protected void SetToken(JsonToken newToken, object value, bool updateIndex)
		{
		}

		[Token(Token = "0x6000078")]
		[Address(RVA = "0x22F0CF0", Offset = "0x22F0CF0", VA = "0x22F0CF0")]
		internal void SetPostValueState(bool updateIndex)
		{
		}

		[Token(Token = "0x6000079")]
		[Address(RVA = "0x22ECC44", Offset = "0x22ECC44", VA = "0x22ECC44")]
		private void UpdateScopeWithFinishedValue()
		{
		}

		[Token(Token = "0x600007A")]
		[Address(RVA = "0x22F0BB8", Offset = "0x22F0BB8", VA = "0x22F0BB8")]
		private void ValidateEnd(JsonToken endToken)
		{
		}

		[Token(Token = "0x600007B")]
		[Address(RVA = "0x22F0E68", Offset = "0x22F0E68", VA = "0x22F0E68")]
		protected void SetStateBasedOnCurrent()
		{
		}

		[Token(Token = "0x600007C")]
		[Address(RVA = "0x22F0D48", Offset = "0x22F0D48", VA = "0x22F0D48")]
		private void SetFinished()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x22F0D70", Offset = "0x22F0D70", VA = "0x22F0D70")]
		private JsonContainerType GetTypeForCloseToken(JsonToken token)
		{
			return default;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x22F0F98", Offset = "0x22F0F98", VA = "0x22F0F98", Slot = "4")]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x22F101C", Offset = "0x22F101C", VA = "0x22F101C", Slot = "19")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x22F1040", Offset = "0x22F1040", VA = "0x22F1040", Slot = "20")]
		public virtual void Close()
		{
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x22F1054", Offset = "0x22F1054", VA = "0x22F1054")]
		internal void ReadAndAssert()
		{
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x22F1138", Offset = "0x22F1138", VA = "0x22F1138")]
		internal void ReadForTypeAndAssert(JsonContract contract, bool hasConverter)
		{
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x22F1190", Offset = "0x22F1190", VA = "0x22F1190")]
		internal bool ReadForType(JsonContract contract, bool hasConverter)
		{
			return default;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x22F1528", Offset = "0x22F1528", VA = "0x22F1528")]
		internal bool ReadAndMoveToContent()
		{
			return default;
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x22F158C", Offset = "0x22F158C", VA = "0x22F158C")]
		internal bool MoveToContent()
		{
			return default;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x22ED344", Offset = "0x22ED344", VA = "0x22ED344")]
		private JsonToken GetContentToken()
		{
			return default;
		}
	}
}
