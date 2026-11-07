using System;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000E7")]
	public interface IAsyncRequestContext : IRequestContext
	{
		[Token(Token = "0x1700022F")]
		AsyncCallback Callback
		{
			[Token(Token = "0x6000818")]
			get;
		}

		[Token(Token = "0x17000230")]
		object State
		{
			[Token(Token = "0x6000819")]
			get;
		}
	}
}
