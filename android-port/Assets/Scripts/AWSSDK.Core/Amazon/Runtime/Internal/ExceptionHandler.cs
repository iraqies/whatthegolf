using System;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200017F")]
	public abstract class ExceptionHandler<T> : IExceptionHandler<T>, IExceptionHandler where T : Exception
	{
		[Token(Token = "0x40005CA")]
		[FieldOffset(Offset = "0x0")]
		private ILogger _logger;

		[Token(Token = "0x1700033A")]
		protected ILogger Logger
		{
			[Token(Token = "0x6000C0D")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C0E")]
		protected ExceptionHandler(ILogger logger)
		{
		}

		[Token(Token = "0x6000C0F")]
		public bool Handle(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000C10")]
		public abstract bool HandleException(IExecutionContext executionContext, T exception);
	}
}
