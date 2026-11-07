using System.Threading;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public interface IRequestContext
	{
		AmazonWebServiceRequest OriginalRequest { get; }

		string RequestName { get; }

		IMarshaller<IRequest, AmazonWebServiceRequest> Marshaller { get; }

		ResponseUnmarshaller Unmarshaller { get; }

		InvokeOptionsBase Options { get; }

		RequestMetrics Metrics { get; }

		AbstractAWSSigner Signer { get; }

		IClientConfig ClientConfig { get; }

		ImmutableCredentials ImmutableCredentials { get; set; }

		IRequest Request { get; set; }

		bool IsSigned { get; set; }

		bool IsAsync { get; }

		int Retries { get; set; }

		CapacityManager.CapacityType LastCapacityType { get; set; }

		int EndpointDiscoveryRetries { get; set; }

		CancellationToken CancellationToken { get; }

		MonitoringAPICallAttempt CSMCallAttempt { get; set; }

		MonitoringAPICallEvent CSMCallEvent { get; set; }

		IServiceMetadata ServiceMetaData { get; }

		bool CSMEnabled { get; }

		bool IsLastExceptionRetryable { get; set; }
	}
}
