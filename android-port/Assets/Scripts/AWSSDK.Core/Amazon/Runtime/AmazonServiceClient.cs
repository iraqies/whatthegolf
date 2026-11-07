using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime
{
	public abstract class AmazonServiceClient : IDisposable
	{
		private bool _disposed;

		private Logger _logger;

		private PreRequestEventHandler mBeforeMarshallingEvent;

		private RequestEventHandler mBeforeRequestEvent;

		private ResponseEventHandler mAfterResponseEvent;

		private ExceptionEventHandler mExceptionEvent;

		protected EndpointDiscoveryResolverBase EndpointDiscoveryResolver { get; private set; }

		protected RuntimePipeline RuntimePipeline { get; set; }

		protected internal AWSCredentials Credentials { get; private set; }

		public IClientConfig Config { get; private set; }

		protected virtual IServiceMetadata ServiceMetadata { get; }

		protected virtual bool SupportResponseLogging => false;

		protected AbstractAWSSigner Signer { get; private set; }

		internal event PreRequestEventHandler BeforeMarshallingEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event RequestEventHandler BeforeRequestEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ResponseEventHandler AfterResponseEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public event ExceptionEventHandler ExceptionEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		protected AmazonServiceClient(AWSCredentials credentials, ClientConfig config)
		{
		}

		protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, ClientConfig config)
		{
		}

		protected AmazonServiceClient(string awsAccessKeyId, string awsSecretAccessKey, ClientConfig config)
		{
		}

		protected virtual void Initialize()
		{
		}

		[Obsolete]
		protected TResponse Invoke<TRequest, TResponse>(TRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller) where TRequest : AmazonWebServiceRequest where TResponse : AmazonWebServiceResponse
		{
			return null;
		}

		protected TResponse Invoke<TResponse>(AmazonWebServiceRequest request, InvokeOptionsBase options) where TResponse : AmazonWebServiceResponse
		{
			return null;
		}

		[Obsolete]
		protected Task<TResponse> InvokeAsync<TRequest, TResponse>(TRequest request, IMarshaller<IRequest, AmazonWebServiceRequest> marshaller, ResponseUnmarshaller unmarshaller, CancellationToken cancellationToken) where TRequest : AmazonWebServiceRequest where TResponse : AmazonWebServiceResponse, new()
		{
			return null;
		}

		protected Task<TResponse> InvokeAsync<TResponse>(AmazonWebServiceRequest request, InvokeOptionsBase options, CancellationToken cancellationToken) where TResponse : AmazonWebServiceResponse, new()
		{
			return null;
		}

		protected virtual IEnumerable<DiscoveryEndpointBase> EndpointOperation(EndpointOperationContextBase context)
		{
			return null;
		}

		protected void ProcessPreRequestHandlers(IExecutionContext executionContext)
		{
		}

		protected void ProcessRequestHandlers(IExecutionContext executionContext)
		{
		}

		protected void ProcessResponseHandlers(IExecutionContext executionContext)
		{
		}

		protected virtual void ProcessExceptionHandlers(IExecutionContext executionContext, Exception exception)
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		private void ThrowIfDisposed()
		{
		}

		protected abstract AbstractAWSSigner CreateSigner();

		protected virtual void CustomizeRuntimePipeline(RuntimePipeline pipeline)
		{
		}

		private void BuildRuntimePipeline()
		{
		}

		public static Uri ComposeUrl(IRequest iRequest)
		{
			return null;
		}

		private static void DontUnescapePathDotsAndSlashes(Uri uri)
		{
		}

		internal C CloneConfig<C>() where C : ClientConfig, new()
		{
			return null;
		}

		internal void CloneConfig(ClientConfig newConfig)
		{
		}

		private static void SetupCSMHandler(IRequestContext requestContext)
		{
		}
	}
}
