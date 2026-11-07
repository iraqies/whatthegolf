using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000194")]
	public class HttpHandler<TRequestContent> : PipelineHandler, IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000195")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25DF0", Offset = "0x25DF0")]
		private struct _003CInvokeAsync_003Ed__9<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x4000607")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000608")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x4000609")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x400060A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public HttpHandler<TRequestContent> _003C_003E4__this;

			[Token(Token = "0x400060B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IHttpRequest<TRequestContent> _003ChttpRequest_003E5__2;

			[Token(Token = "0x400060C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TimingEvent _003C_003E7__wrap2;

			[Token(Token = "0x400060D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ExceptionDispatchInfo _003Cedi_003E5__4;

			[Token(Token = "0x400060E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<TRequestContent>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x400060F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x4000610")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<IWebResponseData>.ConfiguredTaskAwaiter _003C_003Eu__3;

			[Token(Token = "0x6000C7D")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C7E")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000196")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E00", Offset = "0x25E00")]
		private struct _003CCompleteFailedRequest_003Ed__10 : IAsyncStateMachine
		{
			[Token(Token = "0x4000611")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000612")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4000613")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IHttpRequest<TRequestContent> httpRequest;

			[Token(Token = "0x4000614")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x4000615")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IWebResponseData _003Ciwrd_003E5__2;

			[Token(Token = "0x4000616")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<IWebResponseData>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C7F")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C80")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000604")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private bool _disposed;

		[Token(Token = "0x4000605")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private IHttpRequestFactory<TRequestContent> _requestFactory;

		[Token(Token = "0x4000606")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27478", Offset = "0x27478")]
		private object CallbackSender__BackingField;

		[Token(Token = "0x17000340")]
		public object CallbackSender
		{
			[Token(Token = "0x6000C70")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A9E4", Offset = "0x2A9E4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C71")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A9F4", Offset = "0x2A9F4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000C72")]
		public HttpHandler(IHttpRequestFactory<TRequestContent> requestFactory, object callbackSender)
		{
		}

		[Token(Token = "0x6000C73")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C74")]
		private static void CompleteFailedRequest(IHttpRequest<TRequestContent> httpRequest)
		{
		}

		[Token(Token = "0x6000C75")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C76")]
		private static Task CompleteFailedRequest(IExecutionContext executionContext, IHttpRequest<TRequestContent> httpRequest)
		{
			return null;
		}

		[Token(Token = "0x6000C77")]
		private static void SetMetrics(IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6000C78")]
		private void WriteContentToRequestBody(TRequestContent requestContent, IHttpRequest<TRequestContent> httpRequest, IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6000C79")]
		protected virtual IHttpRequest<TRequestContent> CreateWebRequest(IRequestContext requestContext)
		{
			return null;
		}

		[Token(Token = "0x6000C7A")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000C7B")]
		protected virtual void Dispose(bool disposing)
		{
		}

		[Token(Token = "0x6000C7C")]
		private static Stream GetInputStream(IRequestContext requestContext, Stream originalStream, IRequest wrappedRequest)
		{
			return null;
		}
	}
}
