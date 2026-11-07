using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
	public class AWS4PreSignedUrlSigner : AWS4Signer
	{
		public const long MaxAWS4PreSignedUrlExpiry = 604800L;

		internal const string XAmzSignature = "X-Amz-Signature";

		internal const string XAmzAlgorithm = "X-Amz-Algorithm";

		internal const string XAmzCredential = "X-Amz-Credential";

		internal const string XAmzExpires = "X-Amz-Expires";

		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		public new AWS4SigningResult SignRequest(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
			return null;
		}

		public static AWS4SigningResult SignRequest(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey, string service, string overrideSigningRegion)
		{
			return null;
		}
	}
}
