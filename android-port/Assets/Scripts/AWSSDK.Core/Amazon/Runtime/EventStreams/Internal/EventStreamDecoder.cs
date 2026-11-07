using System;
using Il2CppDummyDll;
using ThirdParty.Ionic.Zlib;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x2000129")]
	public class EventStreamDecoder : IEventStreamDecoder, IDisposable
	{
		[Token(Token = "0x200012A")]
		private delegate int ProcessRead(byte[] data, int offset, int length);

		[Token(Token = "0x200012B")]
		private enum DecoderState
		{
			[Token(Token = "0x4000476")]
			Start = 0,
			[Token(Token = "0x4000477")]
			ReadPrelude = 1,
			[Token(Token = "0x4000478")]
			ProcessPrelude = 2,
			[Token(Token = "0x4000479")]
			ReadMessage = 3,
			[Token(Token = "0x400047A")]
			Error = 4
		}

		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x10")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E78", Offset = "0x26E78")]
		private EventHandler<EventStreamMessageReceivedEventArgs> m_MessageReceived;

		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E88", Offset = "0x26E88")]
		private object MessageReceivedContext__BackingField;

		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x20")]
		private ProcessRead[] _stateFns;

		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x28")]
		private DecoderState _state;

		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x2C")]
		private int _currentMessageLength;

		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x30")]
		private int _amountBytesRead;

		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x38")]
		private byte[] _workingMessage;

		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x40")]
		private byte[] _workingBuffer;

		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x48")]
		private CrcCalculatorStream _runningChecksumStream;

		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x50")]
		private bool disposedValue;

		[Token(Token = "0x17000280")]
		public object MessageReceivedContext
		{
			[Token(Token = "0x600098D")]
			[Address(RVA = "0x1202354", Offset = "0x1202354", VA = "0x1202354")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29ADC", Offset = "0x29ADC")]
			get
			{
				return null;
			}
			[Token(Token = "0x600098E")]
			[Address(RVA = "0x120235C", Offset = "0x120235C", VA = "0x120235C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29AEC", Offset = "0x29AEC")]
			set
			{
			}
		}

		[Token(Token = "0x1400000E")]
		public event EventHandler<EventStreamMessageReceivedEventArgs> MessageReceived
		{
			[Token(Token = "0x600098B")]
			[Address(RVA = "0x120220C", Offset = "0x120220C", VA = "0x120220C", Slot = "4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29ABC", Offset = "0x29ABC")]
			add
			{
			}
			[Token(Token = "0x600098C")]
			[Address(RVA = "0x12022B0", Offset = "0x12022B0", VA = "0x12022B0", Slot = "5")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29ACC", Offset = "0x29ACC")]
			remove
			{
			}
		}

		[Token(Token = "0x600098F")]
		[Address(RVA = "0x1202364", Offset = "0x1202364", VA = "0x1202364")]
		public EventStreamDecoder()
		{
		}

		[Token(Token = "0x6000990")]
		[Address(RVA = "0x12025E8", Offset = "0x12025E8", VA = "0x12025E8")]
		private int Start(byte[] data, int offset, int length)
		{
			return default;
		}

		[Token(Token = "0x6000991")]
		[Address(RVA = "0x120269C", Offset = "0x120269C", VA = "0x120269C")]
		private int ReadPrelude(byte[] data, int offset, int length)
		{
			return default;
		}

		[Token(Token = "0x6000992")]
		[Address(RVA = "0x1202780", Offset = "0x1202780", VA = "0x1202780")]
		private int ProcessPrelude(byte[] data, int offset, int length)
		{
			return default;
		}

		[Token(Token = "0x6000993")]
		[Address(RVA = "0x12029F0", Offset = "0x12029F0", VA = "0x12029F0")]
		private int ReadMessage(byte[] data, int offset, int length)
		{
			return default;
		}

		[Token(Token = "0x6000994")]
		[Address(RVA = "0x1202AD4", Offset = "0x1202AD4", VA = "0x1202AD4")]
		private void ProcessMessage()
		{
		}

		[Token(Token = "0x6000995")]
		[Address(RVA = "0x120361C", Offset = "0x120361C", VA = "0x120361C")]
		private int Error(byte[] data, int offset, int length)
		{
			return default;
		}

		[Token(Token = "0x6000996")]
		[Address(RVA = "0x12036F8", Offset = "0x12036F8", VA = "0x12036F8", Slot = "6")]
		public void ProcessData(byte[] data, int offset, int length)
		{
		}

		[Token(Token = "0x6000997")]
		[Address(RVA = "0x1203790", Offset = "0x1203790", VA = "0x1203790", Slot = "8")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000998")]
		[Address(RVA = "0x12037DC", Offset = "0x12037DC", VA = "0x12037DC", Slot = "7")]
		public void Dispose()
		{
		}
	}
}
