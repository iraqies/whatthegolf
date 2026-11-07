using System;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Il2CppDummyDll;

namespace Amazon.SecurityToken
{
	[Token(Token = "0x2000009")]
	public class SecurityTokenServiceStandardRetryPolicy : StandardRetryPolicy
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x12D2258", Offset = "0x12D2258", VA = "0x12D2258")]
		public SecurityTokenServiceStandardRetryPolicy(IClientConfig config)
		{
		}

		[Token(Token = "0x6000050")]
		[Address(RVA = "0x12E6478", Offset = "0x12E6478", VA = "0x12E6478", Slot = "7")]
		public override bool RetryForException(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x6000051")]
		[Address(RVA = "0x12E66B0", Offset = "0x12E66B0", VA = "0x12E66B0", Slot = "19")]
		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}
	}
}
