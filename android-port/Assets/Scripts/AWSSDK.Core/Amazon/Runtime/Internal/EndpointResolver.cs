using System;
using System.Threading.Tasks;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal
{
	[Token(Token = "0x2000187")]
	public class EndpointResolver : PipelineHandler
	{
		[Token(Token = "0x6000C37")]
		[Address(RVA = "0x11FE1F8", Offset = "0x11FE1F8", VA = "0x11FE1F8", Slot = "14")]
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C38")]
		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		[Token(Token = "0x6000C39")]
		[Address(RVA = "0x11FE228", Offset = "0x11FE228", VA = "0x11FE228")]
		protected void PreInvoke(IExecutionContext executionContext)
		{
		}

		[Token(Token = "0x6000C3A")]
		[Address(RVA = "0x11FE5CC", Offset = "0x11FE5CC", VA = "0x11FE5CC", Slot = "16")]
		public virtual Uri DetermineEndpoint(IRequestContext requestContext)
		{
			return null;
		}

		[Token(Token = "0x6000C3B")]
		[Address(RVA = "0x11FE704", Offset = "0x11FE704", VA = "0x11FE704")]
		public static Uri DetermineEndpoint(IClientConfig config, IRequest request)
		{
			return null;
		}

		[Token(Token = "0x6000C3C")]
		[Address(RVA = "0x11FEAA4", Offset = "0x11FEAA4", VA = "0x11FEAA4")]
		private static Uri InjectHostPrefix(IClientConfig config, IRequest request, Uri endpoint)
		{
			return null;
		}

		[Token(Token = "0x6000C3D")]
		[Address(RVA = "0x11FECD4", Offset = "0x11FECD4", VA = "0x11FECD4")]
		public EndpointResolver()
		{
		}
	}
}
