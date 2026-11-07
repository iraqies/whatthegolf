using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace Amazon.Runtime.Internal.Transform
{
	public class HttpClientResponseData : IWebResponseData
	{
		private HttpResponseMessageBody _response;

		private string[] _headerNames;

		private Dictionary<string, string> _headers;

		private HashSet<string> _headerNamesSet;

		public HttpStatusCode StatusCode { get; private set; }

		public bool IsSuccessStatusCode { get; private set; }

		public string ContentType { get; private set; }

		public long ContentLength { get; private set; }

		public IHttpResponseBody ResponseBody => null;

		internal HttpClientResponseData(HttpResponseMessage response)
		{
		}

		internal HttpClientResponseData(HttpResponseMessage response, HttpClient httpClient, bool disposeClient)
		{
		}

		public string GetHeaderValue(string headerName)
		{
			return null;
		}

		public bool IsHeaderPresent(string headerName)
		{
			return false;
		}

		public string[] GetHeaderNames()
		{
			return null;
		}

		private void CopyHeaderValues(HttpResponseMessage response)
		{
		}

		private string GetFirstHeaderValue(HttpHeaders headers, string key)
		{
			return null;
		}
	}
}
