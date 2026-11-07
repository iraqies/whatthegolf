using System;
using System.IO;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x2000219")]
	public interface IHttpResponseBody : IDisposable
	{
		[Token(Token = "0x600101F")]
		Stream OpenResponse();

		[Token(Token = "0x6001020")]
		Task<Stream> OpenResponseAsync();
	}
}
