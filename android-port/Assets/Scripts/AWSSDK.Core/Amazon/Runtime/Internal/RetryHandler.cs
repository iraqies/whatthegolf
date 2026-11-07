using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200019B")]
	public class RetryHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200019C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E20", Offset = "0x25E20")]
		private struct _003CInvokeAsync_003Ed__10<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x4000627")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4000628")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x4000629")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x400062A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public RetryHandler _003C_003E4__this;

			[Token(Token = "0x400062B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private IRequestContext _003CrequestContext_003E5__2;

			[Token(Token = "0x400062C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private bool _003CshouldRetry_003E5__3;

			[Token(Token = "0x400062D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x400062E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ExceptionDispatchInfo _003CcapturedException_003E5__4;

			[Token(Token = "0x400062F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x4000630")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__3;

			[Token(Token = "0x4000631")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private TimingEvent _003C_003E7__wrap4;

			[Token(Token = "0x6000CB8")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000CB9")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4000625")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private ILogger _logger;

		[Token(Token = "0x4000626")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x274D8", Offset = "0x274D8")]
		private RetryPolicy RetryPolicy__BackingField;

		[Token(Token = "0x17000346")]
		public override ILogger Logger
		{
			[Token(Token = "0x6000CAD")]
			[Address(RVA = "0x12604CC", Offset = "0x12604CC", VA = "0x12604CC", Slot = "12")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CAE")]
			[Address(RVA = "0x12604D4", Offset = "0x12604D4", VA = "0x12604D4", Slot = "13")]
			set
			{
			}
		}

		[Token(Token = "0x17000347")]
		public RetryPolicy RetryPolicy
		{
			[Token(Token = "0x6000CAF")]
			[Address(RVA = "0x12604F4", Offset = "0x12604F4", VA = "0x12604F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AB7C", Offset = "0x2AB7C")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CB0")]
			[Address(RVA = "0x12604FC", Offset = "0x12604FC", VA = "0x12604FC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AB8C", Offset = "0x2AB8C")]
			private set
			{
			}
		}

		[Token(Token = "0x6000CB1")]
		[Address(RVA = "0x1260504", Offset = "0x1260504", VA = "0x1260504")]
		public RetryHandler(RetryPolicy retryPolicy)
		{
		}

		[Token(Token = "0x6000CB2")]
		[Address(RVA = "0x1260530", Offset = "0x1260530", VA = "0x1260530", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CB3")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000CB4")]
		[Address(RVA = "0x126166C", Offset = "0x126166C", VA = "0x126166C")]
		internal static void PrepareForRetry(IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6000CB5")]
		[Address(RVA = "0x1261200", Offset = "0x1261200", VA = "0x1261200")]
		private void LogForRetry(IRequestContext requestContext, Exception exception)
		{
		}

		[Token(Token = "0x6000CB6")]
		[Address(RVA = "0x1260DCC", Offset = "0x1260DCC", VA = "0x1260DCC")]
		private void LogForError(IRequestContext requestContext, Exception exception)
		{
		}

		[Token(Token = "0x6000CB7")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AB9C", Offset = "0x2AB9C")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
