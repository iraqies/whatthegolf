using System;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams
{
	[Token(Token = "0x2000118")]
	public class EventStreamHeader : IEventStreamHeader
	{
		[Token(Token = "0x4000441")]
		[FieldOffset(Offset = "0x0")]
		private static readonly DateTime _unixEpoch;

		[Token(Token = "0x4000442")]
		private const int _sizeOfByte = 1;

		[Token(Token = "0x4000443")]
		private const int _sizeOfInt16 = 2;

		[Token(Token = "0x4000444")]
		private const int _sizeOfInt32 = 4;

		[Token(Token = "0x4000445")]
		private const int _sizeOfInt64 = 8;

		[Token(Token = "0x4000446")]
		private const int _sizeOfGuid = 16;

		[Token(Token = "0x4000447")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26DA8", Offset = "0x26DA8")]
		private readonly string Name__BackingField;

		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26DB8", Offset = "0x26DB8")]
		private EventStreamHeaderType HeaderType__BackingField;

		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26DC8", Offset = "0x26DC8")]
		private object HeaderValue__BackingField;

		[Token(Token = "0x1700026C")]
		public string Name
		{
			[Token(Token = "0x6000921")]
			[Address(RVA = "0x1203D60", Offset = "0x1203D60", VA = "0x1203D60", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2988C", Offset = "0x2988C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700026D")]
		public EventStreamHeaderType HeaderType
		{
			[Token(Token = "0x6000922")]
			[Address(RVA = "0x1203D68", Offset = "0x1203D68", VA = "0x1203D68", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2989C", Offset = "0x2989C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000923")]
			[Address(RVA = "0x1203D70", Offset = "0x1203D70", VA = "0x1203D70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x298AC", Offset = "0x298AC")]
			set
			{
			}
		}

		[Token(Token = "0x1700026E")]
		private object HeaderValue
		{
			[Token(Token = "0x6000924")]
			[Address(RVA = "0x1203D78", Offset = "0x1203D78", VA = "0x1203D78")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x298BC", Offset = "0x298BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000925")]
			[Address(RVA = "0x1203D80", Offset = "0x1203D80", VA = "0x1203D80")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x298CC", Offset = "0x298CC")]
			set
			{
			}
		}

		[Token(Token = "0x6000926")]
		[Address(RVA = "0x1203D88", Offset = "0x1203D88", VA = "0x1203D88")]
		public EventStreamHeader(string name)
		{
		}

		[Token(Token = "0x6000927")]
		[Address(RVA = "0x1203DB4", Offset = "0x1203DB4", VA = "0x1203DB4")]
		public static EventStreamHeader FromBuffer(byte[] buffer, int offset, ref int newOffset)
		{
			return null;
		}

		[Token(Token = "0x6000928")]
		[Address(RVA = "0x120443C", Offset = "0x120443C", VA = "0x120443C", Slot = "7")]
		public int WriteToBuffer(byte[] buffer, int offset)
		{
			return default;
		}

		[Token(Token = "0x6000929")]
		[Address(RVA = "0x1204ABC", Offset = "0x1204ABC", VA = "0x1204ABC", Slot = "6")]
		public int GetWireSize()
		{
			return default;
		}

		[Token(Token = "0x600092A")]
		[Address(RVA = "0x1204CEC", Offset = "0x1204CEC", VA = "0x1204CEC", Slot = "8")]
		public bool AsBool()
		{
			return default;
		}

		[Token(Token = "0x600092B")]
		[Address(RVA = "0x1204CFC", Offset = "0x1204CFC", VA = "0x1204CFC", Slot = "9")]
		public void SetBool(bool value)
		{
		}

		[Token(Token = "0x600092C")]
		[Address(RVA = "0x1204D78", Offset = "0x1204D78", VA = "0x1204D78", Slot = "10")]
		public byte AsByte()
		{
			return default;
		}

		[Token(Token = "0x600092D")]
		[Address(RVA = "0x1204DEC", Offset = "0x1204DEC", VA = "0x1204DEC", Slot = "11")]
		public void SetByte(byte value)
		{
		}

		[Token(Token = "0x600092E")]
		[Address(RVA = "0x1204E60", Offset = "0x1204E60", VA = "0x1204E60", Slot = "12")]
		public short AsInt16()
		{
			return default;
		}

		[Token(Token = "0x600092F")]
		[Address(RVA = "0x1204ED4", Offset = "0x1204ED4", VA = "0x1204ED4", Slot = "13")]
		public void SetInt16(short value)
		{
		}

		[Token(Token = "0x6000930")]
		[Address(RVA = "0x1204F48", Offset = "0x1204F48", VA = "0x1204F48", Slot = "14")]
		public int AsInt32()
		{
			return default;
		}

		[Token(Token = "0x6000931")]
		[Address(RVA = "0x1204FBC", Offset = "0x1204FBC", VA = "0x1204FBC", Slot = "15")]
		public void SetInt32(int value)
		{
		}

		[Token(Token = "0x6000932")]
		[Address(RVA = "0x1205030", Offset = "0x1205030", VA = "0x1205030", Slot = "16")]
		public long AsInt64()
		{
			return default;
		}

		[Token(Token = "0x6000933")]
		[Address(RVA = "0x12050A4", Offset = "0x12050A4", VA = "0x12050A4", Slot = "17")]
		public void SetInt64(long value)
		{
		}

		[Token(Token = "0x6000934")]
		[Address(RVA = "0x1205118", Offset = "0x1205118", VA = "0x1205118", Slot = "18")]
		public byte[] AsByteBuf()
		{
			return null;
		}

		[Token(Token = "0x6000935")]
		[Address(RVA = "0x120516C", Offset = "0x120516C", VA = "0x120516C", Slot = "19")]
		public void SetByteBuf(byte[] value)
		{
		}

		[Token(Token = "0x6000936")]
		[Address(RVA = "0x120517C", Offset = "0x120517C", VA = "0x120517C", Slot = "20")]
		public string AsString()
		{
			return null;
		}

		[Token(Token = "0x6000937")]
		[Address(RVA = "0x12051E0", Offset = "0x12051E0", VA = "0x12051E0", Slot = "21")]
		public void SetString(string value)
		{
		}

		[Token(Token = "0x6000938")]
		[Address(RVA = "0x12051F0", Offset = "0x12051F0", VA = "0x12051F0", Slot = "22")]
		public DateTime AsTimestamp()
		{
			return default;
		}

		[Token(Token = "0x6000939")]
		[Address(RVA = "0x1205264", Offset = "0x1205264", VA = "0x1205264", Slot = "23")]
		public void SetTimestamp(DateTime value)
		{
		}

		[Token(Token = "0x600093A")]
		[Address(RVA = "0x12052D8", Offset = "0x12052D8", VA = "0x12052D8", Slot = "24")]
		public Guid AsUUID()
		{
			return default;
		}

		[Token(Token = "0x600093B")]
		[Address(RVA = "0x1205350", Offset = "0x1205350", VA = "0x1205350", Slot = "25")]
		public void SetUUID(Guid value)
		{
		}
	}
}
