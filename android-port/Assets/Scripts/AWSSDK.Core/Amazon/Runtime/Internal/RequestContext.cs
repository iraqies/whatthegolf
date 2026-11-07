using System.Threading;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal
{
	public class RequestContext : IRequestContext
	{
		private IServiceMetadata _serviceMetadata;

		private AbstractAWSSigner clientSigner;

		public IRequest Request { get; set; }

		public RequestMetrics Metrics { get; private set; }

		public IClientConfig ClientConfig { get; set; }

		public int Retries { get; set; }

		public CapacityManager.CapacityType LastCapacityType { get; set; }

		public int EndpointDiscoveryRetries { get; set; }

		public bool IsSigned { get; set; }

		public bool IsAsync { get; set; }

		public AmazonWebServiceRequest OriginalRequest { get; set; }

		public IMarshaller<IRequest, AmazonWebServiceRequest> Marshaller { get; set; }

		public ResponseUnmarshaller Unmarshaller { get; set; }

		public InvokeOptionsBase Options { get; set; }

		public ImmutableCredentials ImmutableCredentials { get; set; }

		public AbstractAWSSigner Signer => null;

		public CancellationToken CancellationToken { get; set; }

		public string RequestName => null;

		public MonitoringAPICallAttempt CSMCallAttempt { get; set; }

		public MonitoringAPICallEvent CSMCallEvent { get; set; }

		public IServiceMetadata ServiceMetaData
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public bool CSMEnabled { get; private set; }

		public bool IsLastExceptionRetryable { get; set; }

		public RequestContext(bool enableMetrics, AbstractAWSSigner clientSigner)
		{
		}
	}
}
