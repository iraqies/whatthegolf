using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200018D")]
	public class RedirectHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200018E")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25DC0", Offset = "0x25DC0")]
		private struct _003CInvokeAsync_003Ed__1<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40005ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40005EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RedirectHandler _003C_003E4__this;

			[Token(Token = "0x40005F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C57")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C58")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x6000C51")]
		[Address(RVA = "0x1254BC8", Offset = "0x1254BC8", VA = "0x1254BC8", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C52")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C53")]
		[Address(RVA = "0x1254C04", Offset = "0x1254C04", VA = "0x1254C04")]
		private bool HandleRedirect(IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000C54")]
		[Address(RVA = "0x1255454", Offset = "0x1255454", VA = "0x1255454", Slot = "16")]
		protected virtual void FinalizeForRedirect(IExecutionContext executionContext, string redirectedLocation)
		{
		}

		[Token(Token = "0x6000C55")]
		[Address(RVA = "0x1255960", Offset = "0x1255960", VA = "0x1255960")]
		public RedirectHandler()
		{
		}

		[Token(Token = "0x6000C56")]
		[DebuggerHidden]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A924", Offset = "0x2A924")]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
