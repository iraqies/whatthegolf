using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class Signer : PipelineHandler
	{
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		protected static void PreInvoke(IExecutionContext executionContext)
		{
		}

		private static bool ShouldSign(IRequestContext requestContext)
		{
			return false;
		}

		public static void SignRequest(IRequestContext requestContext)
		{
		}
	}
}
