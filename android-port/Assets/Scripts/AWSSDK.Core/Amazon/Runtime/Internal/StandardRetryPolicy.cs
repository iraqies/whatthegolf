using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200019D")]
	public class StandardRetryPolicy : RetryPolicy
	{
		[Token(Token = "0x4000632")]
		[FieldOffset(Offset = "0x0")]
		private static Random _randomJitter;

		[Token(Token = "0x4000633")]
		private const int INVALID_ENDPOINT_EXCEPTION_STATUSCODE = 421;

		[Token(Token = "0x4000634")]
		[FieldOffset(Offset = "0x8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x274E8", Offset = "0x274E8")]
		private static CapacityManager CapacityManagerInstance__BackingField;

		[Token(Token = "0x4000635")]
		[FieldOffset(Offset = "0x50")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x274F8", Offset = "0x274F8")]
		private int MaxBackoffInMilliseconds__BackingField;

		[Token(Token = "0x17000348")]
		protected static CapacityManager CapacityManagerInstance
		{
			[Token(Token = "0x6000CBA")]
			[Address(RVA = "0x1277EA0", Offset = "0x1277EA0", VA = "0x1277EA0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ABE4", Offset = "0x2ABE4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000CBB")]
			[Address(RVA = "0x1277F04", Offset = "0x1277F04", VA = "0x1277F04")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2ABF4", Offset = "0x2ABF4")]
			set
			{
			}
		}

		[Token(Token = "0x17000349")]
		public int MaxBackoffInMilliseconds
		{
			[Token(Token = "0x6000CBC")]
			[Address(RVA = "0x1277F74", Offset = "0x1277F74", VA = "0x1277F74")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AC04", Offset = "0x2AC04")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000CBD")]
			[Address(RVA = "0x1277F7C", Offset = "0x1277F7C", VA = "0x1277F7C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2AC14", Offset = "0x2AC14")]
			set
			{
			}
		}

		[Token(Token = "0x6000CBE")]
		[Address(RVA = "0x1277F84", Offset = "0x1277F84", VA = "0x1277F84")]
		public StandardRetryPolicy(int maxRetries)
		{
		}

		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x1278000", Offset = "0x1278000", VA = "0x1278000")]
		public StandardRetryPolicy(IClientConfig config)
		{
		}

		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x1278294", Offset = "0x1278294", VA = "0x1278294", Slot = "6")]
		public override bool CanRetry(IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000CC1")]
		[Address(RVA = "0x1278450", Offset = "0x1278450", VA = "0x1278450", Slot = "7")]
		public override bool RetryForException(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000CC2")]
		[Address(RVA = "0x12785FC", Offset = "0x12785FC", VA = "0x12785FC", Slot = "11")]
		public override bool OnRetry(IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000CC3")]
		[Address(RVA = "0x1278614", Offset = "0x1278614", VA = "0x1278614", Slot = "12")]
		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity)
		{
			return default;
		}

		[Token(Token = "0x6000CC4")]
		[Address(RVA = "0x1278628", Offset = "0x1278628", VA = "0x1278628", Slot = "13")]
		public override bool OnRetry(IExecutionContext executionContext, bool bypassAcquireCapacity, bool isThrottlingError)
		{
			return default;
		}

		[Token(Token = "0x6000CC5")]
		[Address(RVA = "0x1278988", Offset = "0x1278988", VA = "0x1278988", Slot = "10")]
		public override void NotifySuccess(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CC6")]
		[Address(RVA = "0x1278CE4", Offset = "0x1278CE4", VA = "0x1278CE4")]
		protected bool RetryForExceptionSync(Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000CC7")]
		[Address(RVA = "0x1278460", Offset = "0x1278460", VA = "0x1278460")]
		protected bool RetryForExceptionSync(Exception exception, IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000CC8")]
		[Address(RVA = "0x1278CEC", Offset = "0x1278CEC", VA = "0x1278CEC", Slot = "8")]
		public override bool RetryLimitReached(IExecutionContext executionContext)
		{
			return default;
		}

		[Token(Token = "0x6000CC9")]
		[Address(RVA = "0x1278E40", Offset = "0x1278E40", VA = "0x1278E40", Slot = "9")]
		public override void WaitBeforeRetry(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000CCA")]
		[Address(RVA = "0x1278FC8", Offset = "0x1278FC8", VA = "0x1278FC8")]
		public static void WaitBeforeRetry(int retries, int maxBackoffInMilliseconds)
		{
		}

		[Token(Token = "0x6000CCB")]
		[Address(RVA = "0x1279090", Offset = "0x1279090", VA = "0x1279090")]
		protected static int CalculateRetryDelay(int retries, int maxBackoffInMilliseconds)
		{
			return default;
		}

		[Token(Token = "0x6000CCC")]
		[Address(RVA = "0x127929C", Offset = "0x127929C", VA = "0x127929C", Slot = "19")]
		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}

		[Token(Token = "0x6000CCD")]
		[Address(RVA = "0x1279348", Offset = "0x1279348", VA = "0x1279348", Slot = "20")]
		public override Task WaitBeforeRetryAsync(IExecutionContext executionContext)
		{
			return null;
		}
	}
}
