using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x20001A2")]
	public class CSMCallEventHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001A3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E50", Offset = "0x25E50")]
		private struct _003CInvokeAsync_003Ed__2<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x4000644")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000645")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x4000646")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CSMCallEventHandler _003C_003E4__this;

			[Token(Token = "0x4000647")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x4000648")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000CFC")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000CFD")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000643")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private Stopwatch stopWatch;

		[Token(Token = "0x6000CF5")]
		[Address(RVA = "0x11D8EF8", Offset = "0x11D8EF8", VA = "0x11D8EF8", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CF6")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000CF7")]
		[Address(RVA = "0x11D97B0", Offset = "0x11D97B0", VA = "0x11D97B0")]
		private void CSMCallEventMetricsCapture(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CF8")]
		[Address(RVA = "0x11D927C", Offset = "0x11D927C", VA = "0x11D927C")]
		private static void CaptureCSMCallEventExceptionData(IRequestContext requestContext, Exception exception)
		{
		}

		[Token(Token = "0x6000CF9")]
		[Address(RVA = "0x11D920C", Offset = "0x11D920C", VA = "0x11D920C")]
		protected void PreInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CFA")]
		[Address(RVA = "0x11DA64C", Offset = "0x11DA64C", VA = "0x11DA64C")]
		public CSMCallEventHandler()
		{
		}

		[Token(Token = "0x6000CFB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ACDC", Offset = "0x2ACDC")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
