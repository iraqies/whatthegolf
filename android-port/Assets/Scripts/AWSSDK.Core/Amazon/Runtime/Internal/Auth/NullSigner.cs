using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
	public class NullSigner : AbstractAWSSigner
	{
		public override ClientProtocol Protocol => ClientProtocol.QueryStringProtocol;

		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}
	}
}
