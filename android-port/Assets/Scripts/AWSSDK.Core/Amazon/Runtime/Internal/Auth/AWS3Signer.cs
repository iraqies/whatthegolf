using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
	public class AWS3Signer : AbstractAWSSigner
	{
		private const string HTTP_SCHEME = "AWS3";

		private const string HTTPS_SCHEME = "AWS3-HTTPS";

		private const string Slash = "/";

		private bool UseAws3Https { get; set; }

		public override ClientProtocol Protocol => ClientProtocol.QueryStringProtocol;

		public AWS3Signer(bool useAws3Https)
		{
		}

		public AWS3Signer()
		{
		}

		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		private static void SignHttps(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		private static void SignHttp(IRequest request, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		private static string GetCanonicalizedResourcePath(IRequest request)
		{
			return null;
		}

		private static bool IsHttpsRequest(IRequest request)
		{
			return false;
		}

		private static string GetCanonicalizedQueryString(IDictionary<string, string> parameters)
		{
			return null;
		}

		private static string GetRequestPayload(IRequest request)
		{
			return null;
		}

		private static string GetSignedHeadersComponent(IRequest request)
		{
			return null;
		}

		private static List<string> GetHeadersForStringToSign(IRequest request)
		{
			return null;
		}

		private static string GetCanonicalizedHeadersForStringToSign(IRequest request)
		{
			return null;
		}
	}
}
