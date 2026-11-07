using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200018B")]
	public class MetricsHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200018C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25DB0", Offset = "0x25DB0")]
		private struct _003CInvokeAsync_003Ed__1<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40005E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40005EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public MetricsHandler _003C_003E4__this;

			[Token(Token = "0x40005EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C4F")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C50")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000C4B")]
		[Address(RVA = "0x123E5C0", Offset = "0x123E5C0", VA = "0x123E5C0", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C4C")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C4D")]
		[Address(RVA = "0x123F758", Offset = "0x123F758", VA = "0x123F758")]
		public MetricsHandler()
		{
		}

		[Token(Token = "0x6000C4E")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A8DC", Offset = "0x2A8DC")]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
