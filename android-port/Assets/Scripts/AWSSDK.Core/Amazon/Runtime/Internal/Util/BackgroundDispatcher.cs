using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001BC")]
	internal class BackgroundDispatcher<T> : IDisposable
	{
		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x0")]
		private bool isDisposed;

		[Token(Token = "0x40006CF")]
		[FieldOffset(Offset = "0x0")]
		private Action<T> action;

		[Token(Token = "0x40006D0")]
		[FieldOffset(Offset = "0x0")]
		private Queue<T> queue;

		[Token(Token = "0x40006D1")]
		[FieldOffset(Offset = "0x0")]
		private Thread backgroundThread;

		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x0")]
		private AutoResetEvent resetEvent;

		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0x0")]
		private bool shouldStop;

		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27858", Offset = "0x27858")]
		private bool IsRunning__BackingField;

		[Token(Token = "0x40006D5")]
		private const int MAX_QUEUE_SIZE = 100;

		[Token(Token = "0x1700038A")]
		public bool IsRunning
		{
			[Token(Token = "0x6000DC3")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B47C", Offset = "0x2B47C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000DC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2B48C", Offset = "0x2B48C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000DC5")]
		public BackgroundDispatcher(Action<T> action)
		{
		}

		[Token(Token = "0x6000DC6")]
		~BackgroundDispatcher()
		{
		}

		[Token(Token = "0x6000DC7")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000DC8")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000DC9")]
		public void Dispatch(T data)
		{
		}

		[Token(Token = "0x6000DCA")]
		public void Stop()
		{
		}

		[Token(Token = "0x6000DCB")]
		private void Run()
		{
		}

		[Token(Token = "0x6000DCC")]
		private void HandleInvoked()
		{
		}
	}
}
