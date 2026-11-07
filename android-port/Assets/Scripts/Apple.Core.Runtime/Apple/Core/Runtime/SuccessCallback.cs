using Il2CppDummyDll;

namespace Apple.Core.Runtime
{
	[Token(Token = "0x2000002")]
	public delegate void SuccessCallback();
	[Token(Token = "0x2000003")]
	public delegate void SuccessCallback<TResponse>(TResponse response);
}
