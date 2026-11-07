using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Amazon.Runtime.EventStreams.Internal
{
	[Token(Token = "0x2000125")]
	public abstract class EventStream<T, TE> : IEventStream<T, TE>, IDisposable where T : IEventStreamEvent where TE : EventStreamException, new()
	{
		[Token(Token = "0x4000459")]
		protected const string UnknownEventKey = "===UNKNOWN===";

		[Token(Token = "0x400045A")]
		private const string HeaderMessageType = ":message-type";

		[Token(Token = "0x400045B")]
		private const string HeaderEventType = ":event-type";

		[Token(Token = "0x400045C")]
		private const string HeaderExceptionType = ":exception-type";

		[Token(Token = "0x400045D")]
		private const string HeaderErrorCode = ":error-code";

		[Token(Token = "0x400045E")]
		private const string HeaderErrorMessage = ":error-message";

		[Token(Token = "0x400045F")]
		private const string EventHeaderMessageTypeValue = "event";

		[Token(Token = "0x4000460")]
		private const string ExceptionHeaderMessageTypeValue = "exception";

		[Token(Token = "0x4000461")]
		private const string ErrorHeaderMessageTypeValue = "error";

		[Token(Token = "0x4000462")]
		private const string WrappedErrorMessage = "Error.";

		[Token(Token = "0x4000463")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E08", Offset = "0x26E08")]
		private int BufferSize__BackingField;

		[Token(Token = "0x4000464")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E18", Offset = "0x26E18")]
		private readonly Stream NetworkStream__BackingField;

		[Token(Token = "0x4000465")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E28", Offset = "0x26E28")]
		private readonly IEventStreamDecoder Decoder__BackingField;

		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E38", Offset = "0x26E38")]
		private EventHandler<EventStreamEventReceivedArgs<T>> m_EventReceived;

		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26E48", Offset = "0x26E48")]
		private EventHandler<EventStreamExceptionReceivedArgs<TE>> m_ExceptionReceived;

		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x0")]
		private bool _disposed;

		[Token(Token = "0x17000278")]
		public int BufferSize
		{
			[Token(Token = "0x6000969")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x299CC", Offset = "0x299CC")]
			get
			{
				return default;
			}
			[Token(Token = "0x600096A")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x299DC", Offset = "0x299DC")]
			set
			{
			}
		}

		[Token(Token = "0x17000279")]
		protected Stream NetworkStream
		{
			[Token(Token = "0x600096B")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x299EC", Offset = "0x299EC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027A")]
		protected IEventStreamDecoder Decoder
		{
			[Token(Token = "0x600096C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x299FC", Offset = "0x299FC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700027B")]
		protected abstract IDictionary<string, Func<IEventStreamMessage, T>> EventMapping
		{
			[Token(Token = "0x6000971")]
			get;
		}

		[Token(Token = "0x1700027C")]
		protected abstract IDictionary<string, Func<IEventStreamMessage, TE>> ExceptionMapping
		{
			[Token(Token = "0x6000972")]
			get;
		}

		[Token(Token = "0x1700027D")]
		protected abstract bool IsProcessing
		{
			[Token(Token = "0x6000973")]
			get;
			[Token(Token = "0x6000974")]
			set;
		}

		[Token(Token = "0x1400000B")]
		public virtual event EventHandler<EventStreamEventReceivedArgs<T>> EventReceived
		{
			[Token(Token = "0x600096D")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A0C", Offset = "0x29A0C")]
			add
			{
			}
			[Token(Token = "0x600096E")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A1C", Offset = "0x29A1C")]
			remove
			{
			}
		}

		[Token(Token = "0x1400000C")]
		public virtual event EventHandler<EventStreamExceptionReceivedArgs<TE>> ExceptionReceived
		{
			[Token(Token = "0x600096F")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A2C", Offset = "0x29A2C")]
			add
			{
			}
			[Token(Token = "0x6000970")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A3C", Offset = "0x29A3C")]
			remove
			{
			}
		}

		[Token(Token = "0x6000975")]
		protected EventStream(Stream stream)
		{
		}

		[Token(Token = "0x6000976")]
		protected EventStream(Stream stream, IEventStreamDecoder eventStreamDecoder)
		{
		}

		[Token(Token = "0x6000977")]
		protected T ConvertMessageToEvent(EventStreamMessage eventStreamMessage)
		{
			return (T)null;
		}

		[Token(Token = "0x6000978")]
		protected void Process()
		{
		}

		[Token(Token = "0x6000979")]
		private void ProcessLoop()
		{
		}

		[Token(Token = "0x600097A")]
		private void ProcessLoop(object state)
		{
		}

		[Token(Token = "0x600097B")]
		protected void ReadFromStream(byte[] buffer)
		{
		}

		[Token(Token = "0x600097C")]
		protected TE WrapException(Exception ex)
		{
			return null;
		}

		[Token(Token = "0x600097D")]
		public virtual void StartProcessing()
		{
		}

		[Token(Token = "0x600097E")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600097F")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000980")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x29A4C", Offset = "0x29A4C")]
		private void _003CProcess_003Eb__36_0()
		{
		}
	}
}
