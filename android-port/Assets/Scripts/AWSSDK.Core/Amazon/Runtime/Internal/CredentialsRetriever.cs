using System.Threading.Tasks;

namespace Amazon.Runtime.Internal
{
	public class CredentialsRetriever : PipelineHandler
	{
		protected AWSCredentials Credentials { get; private set; }

		public CredentialsRetriever(AWSCredentials credentials)
		{
		}

		protected virtual void PreInvoke(IExecutionContext executionContext)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}
	}
}
