using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000210")]
	public interface IErrorResponseUnmarshaller<TUnmarshaller, TUnmarshalleContext> : IUnmarshaller<TUnmarshaller, TUnmarshalleContext>
	{
		[Token(Token = "0x6001009")]
		TUnmarshaller Unmarshall(TUnmarshalleContext input, ErrorResponse errorResponse);
	}
}
