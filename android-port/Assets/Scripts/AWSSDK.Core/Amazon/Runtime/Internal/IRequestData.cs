using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000165")]
	public interface IRequestData
	{
		[Token(Token = "0x17000307")]
		ResponseUnmarshaller Unmarshaller
		{
			[Token(Token = "0x6000B68")]
			get;
		}

		[Token(Token = "0x17000308")]
		RequestMetrics Metrics
		{
			[Token(Token = "0x6000B69")]
			get;
		}

		[Token(Token = "0x17000309")]
		IRequest Request
		{
			[Token(Token = "0x6000B6A")]
			get;
		}

		[Token(Token = "0x1700030A")]
		AbstractAWSSigner Signer
		{
			[Token(Token = "0x6000B6B")]
			get;
		}

		[Token(Token = "0x1700030B")]
		int RetriesAttempt
		{
			[Token(Token = "0x6000B6C")]
			get;
		}
	}
}
