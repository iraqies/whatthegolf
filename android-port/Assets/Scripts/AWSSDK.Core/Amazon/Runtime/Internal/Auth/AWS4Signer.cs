using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Runtime.Internal.Auth
{
	public class AWS4Signer : AbstractAWSSigner
	{
		public const string Scheme = "AWS4";

		public const string Algorithm = "HMAC-SHA256";

		public const string AWS4AlgorithmTag = "AWS4-HMAC-SHA256";

		public const string Terminator = "aws4_request";

		public static readonly byte[] TerminatorBytes;

		public const string Credential = "Credential";

		public const string SignedHeaders = "SignedHeaders";

		public const string Signature = "Signature";

		public const string EmptyBodySha256 = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";

		public const string StreamingBodySha256 = "STREAMING-AWS4-HMAC-SHA256-PAYLOAD";

		public const string AWSChunkedEncoding = "aws-chunked";

		public const string UnsignedPayload = "UNSIGNED-PAYLOAD";

		private const SigningAlgorithm SignerAlgorithm = SigningAlgorithm.HmacSHA256;

		private static IEnumerable<string> _headersToIgnoreWhenSigning;

		public bool SignPayload { get; private set; }

		public override ClientProtocol Protocol => ClientProtocol.QueryStringProtocol;

		public AWS4Signer()
		{
		}

		public AWS4Signer(bool signPayload)
		{
		}

		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		public AWS4SigningResult SignRequest(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
			return null;
		}

		public static DateTime InitializeHeaders(IDictionary<string, string> headers, Uri requestEndpoint)
		{
			return default;
		}

		public static DateTime InitializeHeaders(IDictionary<string, string> headers, Uri requestEndpoint, DateTime requestDateTime)
		{
			return default;
		}

		private static void CleanHeaders(IDictionary<string, string> headers)
		{
		}

		public static AWS4SigningResult ComputeSignature(ImmutableCredentials credentials, string region, DateTime signedAt, string service, string signedHeaders, string canonicalRequest)
		{
			return null;
		}

		public static AWS4SigningResult ComputeSignature(string awsAccessKey, string awsSecretAccessKey, string region, DateTime signedAt, string service, string signedHeaders, string canonicalRequest)
		{
			return null;
		}

		public static AWS4SigningResult ComputeSignature(string awsAccessKey, string awsSecretAccessKey, string region, DateTime signedAt, string service, string signedHeaders, string canonicalRequest, RequestMetrics metrics)
		{
			return null;
		}

		public static string FormatDateTime(DateTime dt, string formatString)
		{
			return null;
		}

		public static byte[] ComposeSigningKey(string awsSecretAccessKey, string region, string date, string service)
		{
			return null;
		}

		public static string SetRequestBodyHash(IRequest request)
		{
			return null;
		}

		public static string SetRequestBodyHash(IRequest request, bool signPayload)
		{
			return null;
		}

		public static byte[] SignBlob(byte[] key, string data)
		{
			return null;
		}

		public static byte[] SignBlob(byte[] key, byte[] data)
		{
			return null;
		}

		public static byte[] ComputeKeyedHash(SigningAlgorithm algorithm, byte[] key, string data)
		{
			return null;
		}

		public static byte[] ComputeKeyedHash(SigningAlgorithm algorithm, byte[] key, byte[] data)
		{
			return null;
		}

		public static byte[] ComputeHash(string data)
		{
			return null;
		}

		public static byte[] ComputeHash(byte[] data)
		{
			return null;
		}

		private static string SetPayloadSignatureHeader(IRequest request, string payloadHash)
		{
			return null;
		}

		public static string DetermineSigningRegion(IClientConfig clientConfig, string serviceName, RegionEndpoint alternateEndpoint, IRequest request)
		{
			return null;
		}

		internal static string DetermineService(IClientConfig clientConfig)
		{
			return null;
		}

		protected static string CanonicalizeRequest(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash)
		{
			return null;
		}

		protected static string CanonicalizeRequest(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash, IDictionary<string, string> pathResources, int marshallerVersion)
		{
			return null;
		}

		protected static string CanonicalizeRequest(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash, IDictionary<string, string> pathResources, int marshallerVersion, string service)
		{
			return null;
		}

		private static string CanonicalizeRequestHelper(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash, IDictionary<string, string> pathResources, int marshallerVersion, bool detectPreEncode)
		{
			return null;
		}

		protected static IDictionary<string, string> SortAndPruneHeaders(IEnumerable<KeyValuePair<string, string>> requestHeaders)
		{
			return null;
		}

		protected static string CanonicalizeHeaders(IEnumerable<KeyValuePair<string, string>> sortedHeaders)
		{
			return null;
		}

		protected static string CanonicalizeHeaderNames(IEnumerable<KeyValuePair<string, string>> sortedHeaders)
		{
			return null;
		}

		protected static List<KeyValuePair<string, string>> GetParametersToCanonicalize(IRequest request)
		{
			return null;
		}

		protected static string CanonicalizeQueryParameters(string queryString)
		{
			return null;
		}

		protected static string CanonicalizeQueryParameters(string queryString, bool uriEncodeParameters)
		{
			return null;
		}

		protected static string CanonicalizeQueryParameters(IEnumerable<KeyValuePair<string, string>> parameters)
		{
			return null;
		}

		protected static string CanonicalizeQueryParameters(IEnumerable<KeyValuePair<string, string>> parameters, bool uriEncodeParameters)
		{
			return null;
		}

		private static byte[] GetRequestPayloadBytes(IRequest request)
		{
			return null;
		}
	}
}
