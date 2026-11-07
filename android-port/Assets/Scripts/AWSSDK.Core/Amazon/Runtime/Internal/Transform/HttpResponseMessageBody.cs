using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Transform
{
	[Token(Token = "0x200023A")]
	public class HttpResponseMessageBody : IHttpResponseBody, IDisposable
	{
		[Token(Token = "0x40007FA")]
		[FieldOffset(Offset = "0x10")]
		private HttpClient _httpClient;

		[Token(Token = "0x40007FB")]
		[FieldOffset(Offset = "0x18")]
		private HttpResponseMessage _response;

		[Token(Token = "0x40007FC")]
		[FieldOffset(Offset = "0x20")]
		private bool _disposeClient;

		[Token(Token = "0x40007FD")]
		[FieldOffset(Offset = "0x21")]
		private bool _disposed;

		[Token(Token = "0x60010FB")]
		[Address(RVA = "0x120EB40", Offset = "0x120EB40", VA = "0x120EB40")]
		public HttpResponseMessageBody(HttpResponseMessage response, HttpClient httpClient, bool disposeClient)
		{
		}

		[Token(Token = "0x60010FC")]
		[Address(RVA = "0x1211E3C", Offset = "0x1211E3C", VA = "0x1211E3C", Slot = "4")]
		public Stream OpenResponse()
		{
			return null;
		}

		[Token(Token = "0x60010FD")]
		[Address(RVA = "0x1211EF8", Offset = "0x1211EF8", VA = "0x1211EF8", Slot = "5")]
		public Task<Stream> OpenResponseAsync()
		{
			return null;
		}

		[Token(Token = "0x60010FE")]
		[Address(RVA = "0x1211F7C", Offset = "0x1211F7C", VA = "0x1211F7C", Slot = "6")]
		public void Dispose()
		{
		}

		[Token(Token = "0x60010FF")]
		[Address(RVA = "0x1211FFC", Offset = "0x1211FFC", VA = "0x1211FFC", Slot = "7")]
		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
