using System;
using System.Collections.Generic;
using System.Threading;

namespace Amazon.Runtime.Internal.Util
{
	internal class BackgroundDispatcher<T> : IDisposable
	{
		private bool isDisposed;

		private Action<T> action;

		private Queue<T> queue;

		private Thread backgroundThread;

		private AutoResetEvent resetEvent;

		private bool shouldStop;

		private const int MAX_QUEUE_SIZE = 100;

		public bool IsRunning { get; private set; }

		public BackgroundDispatcher(Action<T> action)
		{
		}

		~BackgroundDispatcher()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public void Dispose()
		{
		}

		public void Dispatch(T data)
		{
		}

		public void Stop()
		{
		}

		private void Run()
		{
		}

		private void HandleInvoked()
		{
		}
	}
}
