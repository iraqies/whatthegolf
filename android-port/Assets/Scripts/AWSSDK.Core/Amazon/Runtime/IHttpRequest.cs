using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000EE")]
	public interface IHttpRequest<TRequestContent> : IDisposable
	{
		[Token(Token = "0x17000236")]
		string Method
		{
			[Token(Token = "0x6000823")]
			get;
			[Token(Token = "0x6000824")]
			set;
		}

		[Token(Token = "0x17000237")]
		Uri RequestUri
		{
			[Token(Token = "0x6000825")]
			get;
		}

		[Token(Token = "0x6000826")]
		void ConfigureRequest(IRequestContext requestContext);

		[Token(Token = "0x6000827")]
		void SetRequestHeaders(IDictionary<string, string> headers);

		[Token(Token = "0x6000828")]
		TRequestContent GetRequestContent();

		[Token(Token = "0x6000829")]
		IWebResponseData GetResponse();

		[Token(Token = "0x600082A")]
		void WriteToRequestBody(TRequestContent requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext);

		[Token(Token = "0x600082B")]
		void WriteToRequestBody(TRequestContent requestContent, byte[] content, IDictionary<string, string> contentHeaders);

		[Token(Token = "0x600082C")]
		Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback);

		[Token(Token = "0x600082D")]
		void Abort();

		[Token(Token = "0x600082E")]
		Task<TRequestContent> GetRequestContentAsync();

		[Token(Token = "0x600082F")]
		Task<IWebResponseData> GetResponseAsync(CancellationToken cancellationToken);
	}
}
