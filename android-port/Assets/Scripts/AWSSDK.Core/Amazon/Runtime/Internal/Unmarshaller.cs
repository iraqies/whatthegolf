using System.Threading.Tasks;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime.Internal
{
	public class Unmarshaller : PipelineHandler
	{
		private bool _supportsResponseLogging;

		public Unmarshaller(bool supportsResponseLogging)
		{
		}

		public override void InvokeSync(IExecutionContext executionContext)
		{
		}

		public override Task<T> InvokeAsync<T>(IExecutionContext executionContext)
		{
			return null;
		}

		private void Unmarshall(IExecutionContext executionContext)
		{
		}

		private Task UnmarshallAsync(IExecutionContext executionContext)
		{
			return null;
		}

		private AmazonWebServiceResponse UnmarshallResponse(UnmarshallerContext context, IRequestContext requestContext)
		{
			return null;
		}

		private static bool ShouldLogResponseBody(bool supportsResponseLogging, IRequestContext requestContext)
		{
			return false;
		}
	}
}
