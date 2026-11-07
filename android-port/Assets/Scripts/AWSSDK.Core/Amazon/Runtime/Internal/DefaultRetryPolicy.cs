using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200019A")]
	public class DefaultRetryPolicy : RetryPolicy
	{
		[Token(Token = "0x4000621")]
		private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;

		[Token(Token = "0x4000622")]
		[FieldOffset(Offset = "0x0")]
		private static readonly CapacityManager _capacityManagerInstance;

		[Token(Token = "0x4000623")]
		[FieldOffset(Offset = "0x8")]
		private static readonly HashSet<string> _netStandardRetryErrorMessages;

		[Token(Token = "0x4000624")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x274C8", Offset = "0x274C8")]
		private int MaxBackoffInMilliseconds__BackingField;

		[Token(Token = "0x17000345")]
		public int MaxBackoffInMilliseconds
		{
			[Token(Token = "0x6000C97")]
			[Address(RVA = "0x11EFD1C", Offset = "0x11EFD1C", VA = "0x11EFD1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AAB4", Offset = "0x2AAB4")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000C98")]
			[Address(RVA = "0x11EFD24", Offset = "0x11EFD24", VA = "0x11EFD24")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AAC4", Offset = "0x2AAC4")]
			set
			{
			}
		}

		[Token(Token = "0x6000C99")]
		[Address(RVA = "0x11EFD2C", Offset = "0x11EFD2C", VA = "0x11EFD2C")]
		public DefaultRetryPolicy(int maxRetries)
		{
		}

		[Token(Token = "0x6000C9A")]
		[Address(RVA = "0x11EFDAC", Offset = "0x11EFDAC", VA = "0x11EFDAC")]
		public DefaultRetryPolicy(IClientConfig config)
		{
		}

		[Token(Token = "0x6000C9B")]
		[Address(RVA = "0x11F0020", Offset = "0x11F0020", VA = "0x11F0020", Slot = "6")]
		public override bool CanRetry(IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000C9C")]
		[Address(RVA = "0x11F01DC", Offset = "0x11F01DC", VA = "0x11F01DC", Slot = "7")]
		public override bool RetryForException(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000C9D")]
		[Address(RVA = "0x11F0388", Offset = "0x11F0388", VA = "0x11F0388", Slot = "11")]
		public override bool OnRetry(IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000C9E")]
		[Address(RVA = "0x11F03A0", Offset = "0x11F03A0", VA = "0x11F03A0", Slot = "12")]
		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
		{
			return default;
		}

		[Token(Token = "0x6000C9F")]
		[Address(RVA = "0x11F03B4", Offset = "0x11F03B4", VA = "0x11F03B4", Slot = "13")]
		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return default;
		}

		[Token(Token = "0x6000CA0")]
		[Address(RVA = "0x11F06D8", Offset = "0x11F06D8", VA = "0x11F06D8", Slot = "10")]
		public override void NotifySuccess(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CA1")]
		[Address(RVA = "0x11F09F4", Offset = "0x11F09F4", VA = "0x11F09F4")]
		private bool RetryForExceptionSync(Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000CA2")]
		[Address(RVA = "0x11F01EC", Offset = "0x11F01EC", VA = "0x11F01EC")]
		private bool RetryForExceptionSync(Exception exception, IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000CA3")]
		[Address(RVA = "0x11F09FC", Offset = "0x11F09FC", VA = "0x11F09FC", Slot = "8")]
		public override bool RetryLimitReached(IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000CA4")]
		[Address(RVA = "0x11F0B50", Offset = "0x11F0B50", VA = "0x11F0B50", Slot = "9")]
		public override void WaitBeforeRetry(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CA5")]
		[Address(RVA = "0x11F0CD8", Offset = "0x11F0CD8", VA = "0x11F0CD8")]
		public static void WaitBeforeRetry(int retries, int maxBackoffInMilliseconds)
		{
		}

		[Token(Token = "0x6000CA6")]
		[Address(RVA = "0x11F0DA0", Offset = "0x11F0DA0", VA = "0x11F0DA0")]
		private static int CalculateRetryDelay(int retries, int maxBackoffInMilliseconds)
		{
			return default;
		}

		[Token(Token = "0x6000CA7")]
		[Address(RVA = "0x11F0E90", Offset = "0x11F0E90", VA = "0x11F0E90")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2AAD4", Offset = "0x2AAD4")]
		protected static bool ContainErrorMessage(Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000CA8")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2AB0C", Offset = "0x2AB0C")]
		protected static bool IsInnerException<T>(Exception exception) where T : Exception
		{
			return default;
		}

		[Token(Token = "0x6000CA9")]
		[AttributeAttribute(Name = "ObsoleteAttribute", RVA = "0x2AB44", Offset = "0x2AB44")]
		protected static bool IsInnerException<T>(Exception exception, out T inner) where T : Exception
		{
			return default;
		}

		[Token(Token = "0x6000CAA")]
		[Address(RVA = "0x11F0F3C", Offset = "0x11F0F3C", VA = "0x11F0F3C", Slot = "19")]
		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		[Token(Token = "0x6000CAB")]
		[Address(RVA = "0x11F0FE8", Offset = "0x11F0FE8", VA = "0x11F0FE8", Slot = "20")]
		public override Task WaitBeforeRetryAsync(IExecutionContext executionContext)
		{
			return null;
		}
	}
}
