using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000EA")]
	public interface IAsyncExecutionContext
	{
		[Token(Token = "0x17000233")]
		IAsyncResponseContext ResponseContext
		{
			[Token(Token = "0x600081C")]
			get;
		}

		[Token(Token = "0x17000234")]
		IAsyncRequestContext RequestContext
		{
			[Token(Token = "0x600081D")]
			get;
		}

		[Token(Token = "0x17000235")]
		object RuntimeState
		{
			[Token(Token = "0x600081E")]
			get;
			[Token(Token = "0x600081F")]
			set;
		}
	}
}
