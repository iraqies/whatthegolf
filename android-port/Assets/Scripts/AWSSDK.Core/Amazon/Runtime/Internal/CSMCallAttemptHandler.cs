using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x20001A0")]
	public class CSMCallAttemptHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x20001A1")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E40", Offset = "0x25E40")]
		private struct _003CInvokeAsync_003Ed__1<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x400063E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400063F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x4000640")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CSMCallAttemptHandler _003C_003E4__this;

			[Token(Token = "0x4000641")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x4000642")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000CF3")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000CF4")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000CEB")]
		[Address(RVA = "0x11D6AC0", Offset = "0x11D6AC0", VA = "0x11D6AC0", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CEC")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000CED")]
		[Address(RVA = "0x11D71B0", Offset = "0x11D71B0", VA = "0x11D71B0")]
		protected static void CSMCallAttemptMetricsCapture(IRequestContext requestContext, IResponseContext responseContext)
		{
		}

		[Token(Token = "0x6000CEE")]
		[Address(RVA = "0x11D8C1C", Offset = "0x11D8C1C", VA = "0x11D8C1C", Slot = "16")]
		protected virtual void PreInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CEF")]
		[Address(RVA = "0x11D7080", Offset = "0x11D7080", VA = "0x11D7080")]
		private static void CaptureSDKExceptionMessage(MonitoringAPICallAttempt monitoringAPICallAttempt, Exception e)
		{
		}

		[Token(Token = "0x6000CF0")]
		[Address(RVA = "0x11D6F54", Offset = "0x11D6F54", VA = "0x11D6F54")]
		private static void CaptureAmazonException(MonitoringAPICallAttempt monitoringAPICallAttempt, AmazonServiceException e)
		{
		}

		[Token(Token = "0x6000CF1")]
		[Address(RVA = "0x11D8EF0", Offset = "0x11D8EF0", VA = "0x11D8EF0")]
		public CSMCallAttemptHandler()
		{
		}

		[Token(Token = "0x6000CF2")]
		[DebuggerHidden]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AC94", Offset = "0x2AC94")]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
