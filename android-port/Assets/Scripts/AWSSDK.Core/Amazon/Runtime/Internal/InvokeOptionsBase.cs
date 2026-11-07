using Amazon.Runtime.Internal.Transform;

namespace Amazon.Runtime.Internal
{
	public abstract class InvokeOptionsBase
	{
		private IMarshaller<IRequest, AmazonWebServiceRequest> _requestMarshaller;

		private ResponseUnmarshaller _responseUnmarshaller;

		private IMarshaller<EndpointDiscoveryDataBase, AmazonWebServiceRequest> _endpointDiscoveryMarshaller;

		private EndpointOperationDelegate _endpointOperation;

		public virtual IMarshaller<IRequest, AmazonWebServiceRequest> RequestMarshaller
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual ResponseUnmarshaller ResponseUnmarshaller
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual IMarshaller<EndpointDiscoveryDataBase, AmazonWebServiceRequest> EndpointDiscoveryMarshaller
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual EndpointOperationDelegate EndpointOperation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}
	}
}
