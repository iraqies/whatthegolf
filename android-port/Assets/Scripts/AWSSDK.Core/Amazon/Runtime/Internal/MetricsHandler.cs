using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class MetricsHandler : PipelineHandler
	{
		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}
	}
}
