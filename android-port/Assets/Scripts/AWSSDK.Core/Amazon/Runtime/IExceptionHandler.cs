using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000EB")]
	public interface IExceptionHandler
	{
		[Token(Token = "0x6000820")]
		bool Handle(IExecutionContext executionContext, Exception exception);
	}
	[Token(Token = "0x20000EC")]
	public interface IExceptionHandler<T> : IExceptionHandler where T : Exception
	{
		[Token(Token = "0x6000821")]
		bool HandleException(IExecutionContext executionContext, T exception);
	}
}
