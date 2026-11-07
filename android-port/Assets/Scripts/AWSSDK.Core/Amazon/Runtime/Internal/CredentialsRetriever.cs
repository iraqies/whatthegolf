using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000183")]
	public class CredentialsRetriever : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000184")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D80", Offset = "0x25D80")]
		private struct _003CInvokeAsync_003Ed__7<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40005D3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005D4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40005D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CredentialsRetriever _003C_003E4__this;

			[Token(Token = "0x40005D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TimingEvent _003C_003E7__wrap1;

			[Token(Token = "0x40005D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<ImmutableCredentials>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x40005D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x6000C29")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C2A")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40005D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x27448", Offset = "0x27448")]
		private AWSCredentials Credentials__BackingField;

		[Token(Token = "0x1700033D")]
		protected AWSCredentials Credentials
		{
			[Token(Token = "0x6000C23")]
			[Address(RVA = "0x11EC268", Offset = "0x11EC268", VA = "0x11EC268")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7C4", Offset = "0x2A7C4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C24")]
			[Address(RVA = "0x11EC270", Offset = "0x11EC270", VA = "0x11EC270")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7D4", Offset = "0x2A7D4")]
			private set
			{
			}
		}

		[Token(Token = "0x6000C22")]
		[Address(RVA = "0x11EC23C", Offset = "0x11EC23C", VA = "0x11EC23C")]
		public CredentialsRetriever(AWSCredentials credentials)
		{
		}

		[Token(Token = "0x6000C25")]
		[Address(RVA = "0x11EC278", Offset = "0x11EC278", VA = "0x11EC278", Slot = "16")]
		protected virtual void PreInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C26")]
		[Address(RVA = "0x11EC630", Offset = "0x11EC630", VA = "0x11EC630", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C27")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C28")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A7E4", Offset = "0x2A7E4")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
