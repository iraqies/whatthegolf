using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000E6")]
	public interface IResponseContext
	{
		[Token(Token = "0x1700022D")]
		AmazonWebServiceResponse Response
		{
			[Token(Token = "0x6000814")]
			get;
			[Token(Token = "0x6000815")]
			set;
		}

		[Token(Token = "0x1700022E")]
		IWebResponseData HttpResponse
		{
			[Token(Token = "0x6000816")]
			get;
			[Token(Token = "0x6000817")]
			set;
		}
	}
}
