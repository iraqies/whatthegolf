using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Amazon.Runtime.EventStreams.Internal
{
	public abstract class EnumerableEventStream<T, TE> : EventStream<T, TE>, IEnumerableEventStream<T, TE>, IEventStream<T, TE>, IDisposable, IEnumerable<T>, IEnumerable where T : IEventStreamEvent where TE : EventStreamException, new()
	{
		private const string MutuallyExclusiveExceptionMessage = "Stream has already begun processing. Event-driven and Enumerable traversals of the stream are mutually exclusive. You can either use the event driven or enumerable interface, but not both.";

		protected bool IsEnumerated { get; set; }

		protected EnumerableEventStream(Stream stream)
			: base((Stream)null)
		{
		}

		protected EnumerableEventStream(Stream stream, IEventStreamDecoder eventStreamDecoder)
			: base((Stream)null)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public override void StartProcessing()
		{
		}
	}
}
