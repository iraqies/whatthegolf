using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
	public class S3Signer : AbstractAWSSigner
	{
		public delegate void RegionDetectionUpdater(IRequest request);

		private readonly bool _useSigV4;

		private readonly RegionDetectionUpdater _regionDetector;

		private static readonly HashSet<string> SignableParameters;

		private static readonly HashSet<string> SubResourcesSigningExclusion;

		public override ClientProtocol Protocol => ClientProtocol.QueryStringProtocol;

		public S3Signer()
		{
		}

		public S3Signer(bool useSigV4, RegionDetectionUpdater regionDetector)
		{
		}

		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		public static void SignRequest(IRequest request, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		private static string BuildStringToSign(IRequest request)
		{
			return null;
		}

		private static string BuildCanonicalizedHeaders(IDictionary<string, string> headers)
		{
			return null;
		}

		private static string BuildCanonicalizedResource(IRequest request)
		{
			return null;
		}
	}
}
