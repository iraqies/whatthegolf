using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public abstract class PipelineHandler : IPipelineHandler
	{
		public virtual ILogger Logger { get; set; }

		public IPipelineHandler InnerHandler { get; set; }

		public IPipelineHandler OuterHandler { get; set; }

		public virtual void InvokeSync(IExecutionContext executionContext)
		{
		}

		public virtual Task<T> InvokeAsync<T>(IExecutionContext executionContext) where T : AmazonWebServiceResponse, new()
		{
			return null;
		}

		protected void LogMetrics(IExecutionContext executionContext)
		{
		}
	}
}
