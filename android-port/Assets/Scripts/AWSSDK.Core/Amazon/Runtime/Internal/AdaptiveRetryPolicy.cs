using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000198")]
	public class AdaptiveRetryPolicy : StandardRetryPolicy
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000199")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x25E10", Offset = "0x25E10")]
		private struct _003CObtainSendTokenAsync_003Ed__11 : IAsyncStateMachine
		{
			[Token(Token = "0x400061B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x400061C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400061D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public AdaptiveRetryPolicy _003C_003E4__this;

			[Token(Token = "0x400061E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public IExecutionContext executionContext;

			[Token(Token = "0x400061F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public Exception exception;

			[Token(Token = "0x4000620")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _003C_003Eu__1;

			[Token(Token = "0x6000C95")]
			[Address(RVA = "0x12867E0", Offset = "0x12867E0", VA = "0x12867E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x6000C96")]
			[Address(RVA = "0x1286E70", Offset = "0x1286E70", VA = "0x1286E70", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x400061A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x274B8", Offset = "0x274B8")]
		private TokenBucket TokenBucket__BackingField;

		[Token(Token = "0x17000344")]
		protected TokenBucket TokenBucket
		{
			[Token(Token = "0x6000C8B")]
			[Address(RVA = "0x11C8AFC", Offset = "0x11C8AFC", VA = "0x11C8AFC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AA84", Offset = "0x2AA84")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000C8C")]
			[Address(RVA = "0x11C8B04", Offset = "0x11C8B04", VA = "0x11C8B04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AA94", Offset = "0x2AA94")]
			set
			{
			}
		}

		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x11C8B0C", Offset = "0x11C8B0C", VA = "0x11C8B0C")]
		public AdaptiveRetryPolicy(int maxRetries)
		{
		}

		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x11C8BB4", Offset = "0x11C8BB4", VA = "0x11C8BB4")]
		public AdaptiveRetryPolicy(IClientConfig config)
		{
		}

		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x11C8C5C", Offset = "0x11C8C5C", VA = "0x11C8C5C", Slot = "13")]
		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return default;
		}

		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x11C8CB8", Offset = "0x11C8CB8", VA = "0x11C8CB8", Slot = "14")]
		public override void ObtainSendToken(IExecutionContext executionContext, Exception exception)
		{
		}

		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x11C903C", Offset = "0x11C903C", VA = "0x11C903C", Slot = "10")]
		public override void NotifySuccess(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x11C9080", Offset = "0x11C9080", VA = "0x11C9080", Slot = "19")]
		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		[Token(Token = "0x6000C93")]
		[Address(RVA = "0x11C9130", Offset = "0x11C9130", VA = "0x11C9130", Slot = "20")]
		public override Task WaitBeforeRetryAsync(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C94")]
		[Address(RVA = "0x11C93E0", Offset = "0x11C93E0", VA = "0x11C93E0", Slot = "18")]
		public override Task ObtainSendTokenAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}
	}
}
