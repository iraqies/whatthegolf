using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200017D")]
	public class ErrorHandler : PipelineHandler
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200017E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25D60", Offset = "0x25D60")]
		private struct _003CInvokeAsync_003Ed__5<T> : IAsyncStateMachine where T : AmazonWebServiceResponse, new()
		{
			[Token(Token = "0x40005C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40005C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public AsyncTaskMethodBuilder<T> _003C_003Et__builder;

			[Token(Token = "0x40005C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ErrorHandler _003C_003E4__this;

			[Token(Token = "0x40005C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public IExecutionContext executionContext;

			[Token(Token = "0x40005C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C0B")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C0C")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40005C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IDictionary<Type, IExceptionHandler> _exceptionHandlers;

		[Token(Token = "0x17000339")]
		public IDictionary<Type, IExceptionHandler> ExceptionHandlers
		{
			[Token(Token = "0x6000C04")]
			[Address(RVA = "0x1200900", Offset = "0x1200900", VA = "0x1200900")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000C05")]
		[Address(RVA = "0x1200908", Offset = "0x1200908", VA = "0x1200908")]
		public ErrorHandler(ILogger logger)
		{
		}

		[Token(Token = "0x6000C06")]
		[Address(RVA = "0x1200B10", Offset = "0x1200B10", VA = "0x1200B10", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C07")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C08")]
		[Address(RVA = "0x1200C08", Offset = "0x1200C08", VA = "0x1200C08")]
		private static void DisposeReponse(IResponseContext responseContext)
		{
		}

		[Token(Token = "0x6000C09")]
		[Address(RVA = "0x1200F28", Offset = "0x1200F28", VA = "0x1200F28")]
		private bool ProcessException(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000C0A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2A6F4", Offset = "0x2A6F4")]
		[DebuggerHidden]
		private Task<T> _003C_003En__0<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}
	}
}
