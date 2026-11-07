using System;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Il2CppDummyDll;

namespace Amazon.SecurityToken
{
	[Token(Token = "0x2000008")]
	public class SecurityTokenServiceRetryPolicy : DefaultRetryPolicy
	{
		[Token(Token = "0x600004C")]
		[Address(RVA = "0x12D21CC", Offset = "0x12D21CC", VA = "0x12D21CC")]
		public SecurityTokenServiceRetryPolicy(IClientConfig config)
		{
		}

		[Token(Token = "0x600004D")]
		[Address(RVA = "0x12E5FC4", Offset = "0x12E5FC4", VA = "0x12E5FC4", Slot = "7")]
		public override bool RetryForException(IExecutionContext executionContext, Exception exception)
		{
			return default;
		}

		[Token(Token = "0x600004E")]
		[Address(RVA = "0x12E61FC", Offset = "0x12E61FC", VA = "0x12E61FC", Slot = "19")]
		public override Task<bool> RetryForExceptionAsync(IExecutionContext executionContext, Exception exception)
		{
			return null;
		}
	}
}
