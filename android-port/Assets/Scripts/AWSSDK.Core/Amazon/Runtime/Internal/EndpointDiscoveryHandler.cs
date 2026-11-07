using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000185")]
	public class EndpointDiscoveryHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000186")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D90", Offset = "0x25D90")]
		private struct _003CInvokeAsync_003Ed__2<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40005DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40005DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public EndpointDiscoveryHandler _003C_003E4__this;

			[Token(Token = "0x40005DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IRequestContext _003CrequestContext_003E5__2;

			[Token(Token = "0x40005E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Uri _003CregionalEndpoint_003E5__3;

			[Token(Token = "0x40005E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C35")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C36")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40005DA")]
		private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;

		[Token(Token = "0x6000C2B")]
		[Address(RVA = "0x11FBA88", Offset = "0x11FBA88", VA = "0x11FBA88", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C2C")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C2D")]
		[Address(RVA = "0x11FBD18", Offset = "0x11FBD18", VA = "0x11FBD18")]
		protected static void PreInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C2E")]
		[Address(RVA = "0x11FBE70", Offset = "0x11FBE70", VA = "0x11FBE70")]
		public static void EvictCacheKeyForRequest(IRequestContext requestContext, Uri regionalEndpoint)
		{
		}

		[Token(Token = "0x6000C2F")]
		[Address(RVA = "0x11FBFC4", Offset = "0x11FBFC4", VA = "0x11FBFC4")]
		public static void DiscoverEndpoints(IRequestContext requestContext, bool evictCacheKey)
		{
		}

		[Token(Token = "0x6000C30")]
		[Address(RVA = "0x11FC504", Offset = "0x11FC504", VA = "0x11FC504")]
		private static IEnumerable<DiscoveryEndpointBase> ProcessEndpointDiscovery(IRequestContext requestContext, bool evictCacheKey, Uri evictUri)
		{
			return null;
		}

		[Token(Token = "0x6000C31")]
		[Address(RVA = "0x11FC9A4", Offset = "0x11FC9A4", VA = "0x11FC9A4")]
		private static string OperationNameFromRequestName(string requestName)
		{
			return null;
		}

		[Token(Token = "0x6000C32")]
		[Address(RVA = "0x11FBDD4", Offset = "0x11FBDD4", VA = "0x11FBDD4")]
		private static bool IsInvalidEndpointException(Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000C33")]
		[Address(RVA = "0x11FCDCC", Offset = "0x11FCDCC", VA = "0x11FCDCC")]
		public EndpointDiscoveryHandler()
		{
		}

		[Token(Token = "0x6000C34")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A82C", Offset = "0x2A82C")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
