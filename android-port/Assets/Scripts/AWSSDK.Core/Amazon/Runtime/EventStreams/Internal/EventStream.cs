using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.EventStreams.Internal
{
	public abstract class EventStream<T, TE> : IEventStream<T, TE>, IDisposable where T : IEventStreamEvent where TE : EventStreamException, new()
	{
		protected const string UnknownEventKey = "===UNKNOWN===";

		private const string HeaderMessageType = ":message-type";

		private const string HeaderEventType = ":event-type";

		private const string HeaderExceptionType = ":exception-type";

		private const string HeaderErrorCode = ":error-code";

		private const string HeaderErrorMessage = ":error-message";

		private const string EventHeaderMessageTypeValue = "event";

		private const string ExceptionHeaderMessageTypeValue = "exception";

		private const string ErrorHeaderMessageTypeValue = "error";

		private const string WrappedErrorMessage = "Error.";

		[CompilerGenerated]
		private EventHandler<EventStreamEventReceivedArgs<T>> m_EventReceived;

		[CompilerGenerated]
		private EventHandler<EventStreamExceptionReceivedArgs<TE>> m_ExceptionReceived;

		private bool _disposed;

		public int BufferSize { get; set; }

		protected Stream NetworkStream { get; }

		protected IEventStreamDecoder Decoder { get; }

		protected abstract IDictionary<string, Func<IEventStreamMessage, T>> EventMapping { get; }

		protected abstract IDictionary<string, Func<IEventStreamMessage, TE>> ExceptionMapping { get; }

		protected abstract bool IsProcessing { get; set; }

		public virtual event EventHandler<EventStreamEventReceivedArgs<T>> EventReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public virtual event EventHandler<EventStreamExceptionReceivedArgs<TE>> ExceptionReceived
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected EventStream(Stream stream)
		{
		}

		protected EventStream(Stream stream, IEventStreamDecoder eventStreamDecoder)
		{
		}

		protected T ConvertMessageToEvent(EventStreamMessage eventStreamMessage)
		{
			return default;
		}

		protected void Process()
		{
		}

		private void ProcessLoop()
		{
		}

		private void ProcessLoop(object state)
		{
		}

		protected void ReadFromStream(byte[] buffer)
		{
		}

		protected TE WrapException(Exception ex)
		{
			return null;
		}

		public virtual void StartProcessing()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
