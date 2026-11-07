using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class RedirectHandler : PipelineHandler
	{
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		private bool HandleRedirect(IExecutionContext executionContext)
		{
			return false;
		}

		protected virtual void FinalizeForRedirect(IExecutionContext executionContext, string redirectedLocation)
		{
		}
	}
}
