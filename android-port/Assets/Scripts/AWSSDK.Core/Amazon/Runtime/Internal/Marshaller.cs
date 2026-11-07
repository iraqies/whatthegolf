using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x200018A")]
	public class Marshaller : PipelineHandler
	{
		[Token(Token = "0x6000C47")]
		[Address(RVA = "0x123D20C", Offset = "0x123D20C", VA = "0x123D20C", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C48")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C49")]
		[Address(RVA = "0x123D23C", Offset = "0x123D23C", VA = "0x123D23C")]
		protected static void PreInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C4A")]
		[Address(RVA = "0x123E048", Offset = "0x123E048", VA = "0x123E048")]
		public Marshaller()
		{
		}
	}
}
