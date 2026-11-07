using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x2000075")]
	public class AWSHttpClient : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2595C", Offset = "0x2595C")]
		private struct _003CGetResponseHeadersAsync_003Ed__17 : IAsyncStateMachine
		{
			[Token(Token = "0x400024F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000250")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<List<Tuple<string, IEnumerable<string>, HttpStatusCode>>> _003C_003Et__builder;

			[Token(Token = "0x4000251")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string httpMethodValue;

			[Token(Token = "0x4000252")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string url;

			[Token(Token = "0x4000253")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public AWSHttpClient _003C_003E4__this;

			[Token(Token = "0x4000254")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private List<Tuple<string, IEnumerable<string>, HttpStatusCode>> _003Cheaders_003E5__2;

			[Token(Token = "0x4000255")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000461")]
			[Address(RVA = "0x1284C88", Offset = "0x1284C88", VA = "0x1284C88", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000462")]
			[Address(RVA = "0x12852C4", Offset = "0x12852C4", VA = "0x12852C4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400024D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private HttpClient _httpClient;

		[Token(Token = "0x400024E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private bool disposed;

		[Token(Token = "0x170000FF")]
		public Uri BaseAddress
		{
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x11C10EC", Offset = "0x11C10EC", VA = "0x11C10EC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000456")]
			[Address(RVA = "0x11C1108", Offset = "0x11C1108", VA = "0x11C1108")]
			set
			{
			}
		}

		[Token(Token = "0x17000100")]
		public TimeSpan Timeout
		{
			[Token(Token = "0x6000457")]
			[Address(RVA = "0x11C1124", Offset = "0x11C1124", VA = "0x11C1124")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000458")]
			[Address(RVA = "0x11C1140", Offset = "0x11C1140", VA = "0x11C1140")]
			set
			{
			}
		}

		[Token(Token = "0x17000101")]
		public long MaxResponseContentBufferSize
		{
			[Token(Token = "0x6000459")]
			[Address(RVA = "0x11C115C", Offset = "0x11C115C", VA = "0x11C115C")]
			get
			{
				return default;
			}
			[Token(Token = "0x600045A")]
			[Address(RVA = "0x11C1178", Offset = "0x11C1178", VA = "0x11C1178")]
			set
			{
			}
		}

		[Token(Token = "0x6000451")]
		[Address(RVA = "0x11C0EA8", Offset = "0x11C0EA8", VA = "0x11C0EA8")]
		public AWSHttpClient()
		{
		}

		[Token(Token = "0x6000452")]
		[Address(RVA = "0x11C0F18", Offset = "0x11C0F18", VA = "0x11C0F18")]
		internal AWSHttpClient(IWebProxy proxy, bool useProxy)
		{
		}

		[Token(Token = "0x6000453")]
		[Address(RVA = "0x11C0FEC", Offset = "0x11C0FEC", VA = "0x11C0FEC")]
		internal AWSHttpClient(HttpMessageHandler handler)
		{
		}

		[Token(Token = "0x6000454")]
		[Address(RVA = "0x11C1064", Offset = "0x11C1064", VA = "0x11C1064")]
		internal AWSHttpClient(HttpMessageHandler handler, bool disposeHandler)
		{
		}

		[Token(Token = "0x600045B")]
		[Address(RVA = "0x11C1194", Offset = "0x11C1194", VA = "0x11C1194")]
		public Task<Stream> GetStreamAsync(string requestUri)
		{
			return null;
		}

		[Token(Token = "0x600045C")]
		[Address(RVA = "0x11C11B0", Offset = "0x11C11B0", VA = "0x11C11B0")]
		public Task PutRequestUriAsync(string requestUri, AWSStreamContent content, IDictionary<string, string> requestHeaders)
		{
			return null;
		}

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x11C15B4", Offset = "0x11C15B4", VA = "0x11C15B4")]
		public Task<List<Tuple<string, IEnumerable<string>, HttpStatusCode>>> GetResponseHeadersAsync(string httpMethodValue, string url)
		{
			return null;
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x11C16D8", Offset = "0x11C16D8", VA = "0x11C16D8", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600045F")]
		[Address(RVA = "0x11C1758", Offset = "0x11C1758", VA = "0x11C1758", Slot = "5")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000460")]
		[Address(RVA = "0x11C17A0", Offset = "0x11C17A0", VA = "0x11C17A0")]
		public static bool IsHttpInnerException(Exception exception)
		{
			return default;
		}
	}
}
