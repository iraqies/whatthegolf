using System;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Il2CppDummyDll;

namespace Amazon.SecurityToken
{
	[Token(Token = "0x200000A")]
	public class SecurityTokenServiceAdaptiveRetryPolicy : AdaptiveRetryPolicy
	{
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x12D22E4", Offset = "0x12D22E4", VA = "0x12D22E4")]
		public SecurityTokenServiceAdaptiveRetryPolicy(IClientConfig config)
		{
		}

		[Token(Token = "0x6000053")]
		[Address(RVA = "0x12E5B10", Offset = "0x12E5B10", VA = "0x12E5B10", Slot = "7")]
		public override bool RetryForException(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000054")]
		[Address(RVA = "0x12E5D48", Offset = "0x12E5D48", VA = "0x12E5D48", Slot = "19")]
		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}
	}
}
