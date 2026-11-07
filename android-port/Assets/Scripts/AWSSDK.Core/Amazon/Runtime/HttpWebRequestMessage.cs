using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;
using Il2CppDummyDll;

namespace Amazon.Runtime
{
	[Token(Token = "0x20000F2")]
	public class HttpWebRequestMessage : IHttpRequest<HttpContent>, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20000F3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25B94", Offset = "0x25B94")]
		private struct _003CGetResponseAsync_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<IWebResponseData> _003C_003Et__builder;

			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public HttpWebRequestMessage _003C_003E4__this;

			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000855")]
			[Address(RVA = "0x128CF5C", Offset = "0x128CF5C", VA = "0x128CF5C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000856")]
			[Address(RVA = "0x128D560", Offset = "0x128D560", VA = "0x128D560", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40003C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static HashSet<string> ContentHeaderNames;

		[Token(Token = "0x40003C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private bool _disposed;

		[Token(Token = "0x40003C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private HttpRequestMessage _request;

		[Token(Token = "0x40003C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private HttpClient _httpClient;

		[Token(Token = "0x40003C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IClientConfig _clientConfig;

		[Token(Token = "0x17000238")]
		public HttpClient HttpClient
		{
			[Token(Token = "0x6000842")]
			[Address(RVA = "0x1212058", Offset = "0x1212058", VA = "0x1212058")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000239")]
		public HttpRequestMessage Request
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x1212060", Offset = "0x1212060", VA = "0x1212060")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700023A")]
		public string Method
		{
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x1212068", Offset = "0x1212068", VA = "0x1212068", Slot = "4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x1212090", Offset = "0x1212090", VA = "0x1212090", Slot = "5")]
			set
			{
			}
		}

		[Token(Token = "0x1700023B")]
		public Uri RequestUri
		{
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x1212110", Offset = "0x1212110", VA = "0x1212110", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000841")]
		[Address(RVA = "0x121161C", Offset = "0x121161C", VA = "0x121161C")]
		public HttpWebRequestMessage(HttpClient httpClient, Uri requestUri, IClientConfig config)
		{
		}

		[Token(Token = "0x6000847")]
		[Address(RVA = "0x121212C", Offset = "0x121212C", VA = "0x121212C", Slot = "7")]
		public void ConfigureRequest(IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6000848")]
		[Address(RVA = "0x12122BC", Offset = "0x12122BC", VA = "0x12122BC", Slot = "8")]
		public void SetRequestHeaders(IDictionary<string, string> headers)
		{
		}

		[Token(Token = "0x6000849")]
		[Address(RVA = "0x12126F8", Offset = "0x12126F8", VA = "0x12126F8", Slot = "9")]
		public HttpContent GetRequestContent()
		{
			return null;
		}

		[Token(Token = "0x600084A")]
		[Address(RVA = "0x12128E8", Offset = "0x12128E8", VA = "0x12128E8", Slot = "10")]
		public IWebResponseData GetResponse()
		{
			return null;
		}

		[Token(Token = "0x600084B")]
		[Address(RVA = "0x1212B3C", Offset = "0x1212B3C", VA = "0x1212B3C", Slot = "14")]
		public void Abort()
		{
		}

		[Token(Token = "0x600084C")]
		[Address(RVA = "0x1212A2C", Offset = "0x1212A2C", VA = "0x1212A2C", Slot = "16")]
		public Task<IWebResponseData> GetResponseAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		[Token(Token = "0x600084D")]
		[Address(RVA = "0x1212B40", Offset = "0x1212B40", VA = "0x1212B40", Slot = "11")]
		public void WriteToRequestBody(HttpContent requestContent, Stream contentStream, IDictionary<string, string> contentHeaders, IRequestContext requestContext)
		{
		}

		[Token(Token = "0x600084E")]
		[Address(RVA = "0x1213618", Offset = "0x1213618", VA = "0x1213618", Slot = "12")]
		public void WriteToRequestBody(HttpContent requestContent, byte[] content, IDictionary<string, string> contentHeaders)
		{
		}

		[Token(Token = "0x600084F")]
		[Address(RVA = "0x1212858", Offset = "0x1212858", VA = "0x1212858", Slot = "15")]
		public Task<HttpContent> GetRequestContentAsync()
		{
			return null;
		}

		[Token(Token = "0x6000850")]
		[Address(RVA = "0x1212DF4", Offset = "0x1212DF4", VA = "0x1212DF4")]
		private void WriteContentHeaders(IDictionary<string, string> contentHeaders)
		{
		}

		[Token(Token = "0x6000851")]
		[Address(RVA = "0x121370C", Offset = "0x121370C", VA = "0x121370C", Slot = "17")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000852")]
		[Address(RVA = "0x1213790", Offset = "0x1213790", VA = "0x1213790", Slot = "18")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000853")]
		[Address(RVA = "0x12137D8", Offset = "0x12137D8", VA = "0x12137D8", Slot = "13")]
		public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
		{
			return null;
		}
	}
}
