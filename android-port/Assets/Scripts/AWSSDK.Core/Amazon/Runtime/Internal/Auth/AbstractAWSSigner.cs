using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
	public abstract class AbstractAWSSigner
	{
		private AWS4Signer _aws4Signer;

		private AWS4Signer AWS4SignerInstance => null;

		public abstract ClientProtocol Protocol { get; }

		protected static string ComputeHash(string data, string secretkey, SigningAlgorithm algorithm)
		{
			return null;
		}

		protected static string ComputeHash(byte[] data, string secretkey, SigningAlgorithm algorithm)
		{
			return null;
		}

		public abstract void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey);

		protected static bool UseV4Signing(bool useSigV4Setting, IRequest request, IClientConfig config)
		{
			return false;
		}

		protected AbstractAWSSigner SelectSigner(IRequest request, IClientConfig config)
		{
			return null;
		}

		protected AbstractAWSSigner SelectSigner(AbstractAWSSigner defaultSigner, bool useSigV4Setting, IRequest request, IClientConfig config)
		{
			return null;
		}
	}
}
