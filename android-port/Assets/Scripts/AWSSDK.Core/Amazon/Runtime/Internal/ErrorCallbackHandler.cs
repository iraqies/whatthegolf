using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000188")]
	public class ErrorCallbackHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000189")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25DA0", Offset = "0x25DA0")]
		private struct _003CInvokeAsync_003Ed__5<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40005E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40005E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ErrorCallbackHandler _003C_003E4__this;

			[Token(Token = "0x40005E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C45")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C46")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40005E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27458", Offset = "0x27458")]
		private Action<IExecutionContext, Exception> OnError__BackingField;

		[Token(Token = "0x1700033E")]
		public Action<IExecutionContext, Exception> OnError
		{
			[Token(Token = "0x6000C3E")]
			[Address(RVA = "0x12007B0", Offset = "0x12007B0", VA = "0x12007B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A874", Offset = "0x2A874")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C3F")]
			[Address(RVA = "0x12007B8", Offset = "0x12007B8", VA = "0x12007B8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A884", Offset = "0x2A884")]
			set
			{
			}
		}

		[Token(Token = "0x6000C40")]
		[Address(RVA = "0x12007C0", Offset = "0x12007C0", VA = "0x12007C0", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C41")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C42")]
		[Address(RVA = "0x120088C", Offset = "0x120088C", VA = "0x120088C")]
		protected void HandleException(IExecutionContext executionContext, Exception exception)
		{
		}

		[Token(Token = "0x6000C43")]
		[Address(RVA = "0x12008F8", Offset = "0x12008F8", VA = "0x12008F8")]
		public ErrorCallbackHandler()
		{
		}

		[Token(Token = "0x6000C44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A894", Offset = "0x2A894")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
