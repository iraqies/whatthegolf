using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200018F")]
	public class Signer : PipelineHandler
	{
		[Token(Token = "0x6000C59")]
		[Address(RVA = "0x1276450", Offset = "0x1276450", VA = "0x1276450", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C5A")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x1276484", Offset = "0x1276484", VA = "0x1276484")]
		protected static void PreInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x12766B0", Offset = "0x12766B0", VA = "0x12766B0")]
		private static bool ShouldSign(IRequestContext requestContext)
		{
			return default;
		}

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x1276868", Offset = "0x1276868", VA = "0x1276868")]
		public static void SignRequest(IRequestContext requestContext)
		{
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x12771A8", Offset = "0x12771A8", VA = "0x12771A8")]
		public Signer()
		{
		}
	}
}
