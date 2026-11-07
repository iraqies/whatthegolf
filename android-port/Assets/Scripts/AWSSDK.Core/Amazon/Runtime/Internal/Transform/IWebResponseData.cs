using System.Net;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000218")]
	public interface IWebResponseData
	{
		[Token(Token = "0x17000406")]
		long ContentLength
		{
			[Token(Token = "0x6001017")]
			get;
		}

		[Token(Token = "0x17000407")]
		string ContentType
		{
			[Token(Token = "0x6001018")]
			get;
		}

		[Token(Token = "0x17000408")]
		HttpStatusCode StatusCode
		{
			[Token(Token = "0x6001019")]
			get;
		}

		[Token(Token = "0x17000409")]
		bool IsSuccessStatusCode
		{
			[Token(Token = "0x600101A")]
			get;
		}

		[Token(Token = "0x1700040A")]
		IHttpResponseBody ResponseBody
		{
			[Token(Token = "0x600101E")]
			get;
		}

		[Token(Token = "0x600101B")]
		string[] GetHeaderNames();

		[Token(Token = "0x600101C")]
		bool IsHeaderPresent(string headerName);

		[Token(Token = "0x600101D")]
		string GetHeaderValue(string headerName);
	}
}
