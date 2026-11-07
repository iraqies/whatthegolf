using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000E9")]
	public interface IExecutionContext
	{
		[Token(Token = "0x17000231")]
		IResponseContext ResponseContext
		{
			[Token(Token = "0x600081A")]
			get;
		}

		[Token(Token = "0x17000232")]
		IRequestContext RequestContext
		{
			[Token(Token = "0x600081B")]
			get;
		}
	}
}
