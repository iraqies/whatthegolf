using System;
using System.Collections.Generic;
using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x200024C")]
	public class AWS4Signer : AbstractAWSSigner
	{
		[Serializable]
		[Token(Token = "0x200024D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x26050", Offset = "0x26050")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000865")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000866")]
			[FieldOffset(Offset = "0x8")]
			public static Func<KeyValuePair<string, string>, bool> _003C_003E9__50_0;

			[Token(Token = "0x4000867")]
			[FieldOffset(Offset = "0x10")]
			public static Func<KeyValuePair<string, string>, string> _003C_003E9__54_0;

			[Token(Token = "0x6001185")]
			[Address(RVA = "0x1284BFC", Offset = "0x1284BFC", VA = "0x1284BFC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6001186")]
			[Address(RVA = "0x1284C04", Offset = "0x1284C04", VA = "0x1284C04")]
			internal bool _003CGetParametersToCanonicalize_003Eb__50_0(KeyValuePair<string, string> queryParameter)
			{
				return default;
			}

			[Token(Token = "0x6001187")]
			[Address(RVA = "0x1284C48", Offset = "0x1284C48", VA = "0x1284C48")]
			internal string _003CCanonicalizeQueryParameters_003Eb__54_0(KeyValuePair<string, string> kvp)
			{
				return null;
			}
		}

		[Token(Token = "0x4000856")]
		public const string Scheme = "AWS4";

		[Token(Token = "0x4000857")]
		public const string Algorithm = "HMAC-SHA256";

		[Token(Token = "0x4000858")]
		public const string AWS4AlgorithmTag = "AWS4-HMAC-SHA256";

		[Token(Token = "0x4000859")]
		public const string Terminator = "aws4_request";

		[Token(Token = "0x400085A")]
		[FieldOffset(Offset = "0x0")]
		public static readonly byte[] TerminatorBytes;

		[Token(Token = "0x400085B")]
		public const string Credential = "Credential";

		[Token(Token = "0x400085C")]
		public const string SignedHeaders = "SignedHeaders";

		[Token(Token = "0x400085D")]
		public const string Signature = "Signature";

		[Token(Token = "0x400085E")]
		public const string EmptyBodySha256 = "e3b0c44298fc1c149afbf4c8996fb92427ae41e4649b934ca495991b7852b855";

		[Token(Token = "0x400085F")]
		public const string StreamingBodySha256 = "STREAMING-AWS4-HMAC-SHA256-PAYLOAD";

		[Token(Token = "0x4000860")]
		public const string AWSChunkedEncoding = "aws-chunked";

		[Token(Token = "0x4000861")]
		public const string UnsignedPayload = "UNSIGNED-PAYLOAD";

		[Token(Token = "0x4000862")]
		private const SigningAlgorithm SignerAlgorithm = SigningAlgorithm.HmacSHA256;

		[Token(Token = "0x4000863")]
		[FieldOffset(Offset = "0x8")]
		private static IEnumerable<string> _headersToIgnoreWhenSigning;

		[Token(Token = "0x4000864")]
		[FieldOffset(Offset = "0x18")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x27CD8", Offset = "0x27CD8")]
		private bool SignPayload__BackingField;

		[Token(Token = "0x17000451")]
		public bool SignPayload
		{
			[Token(Token = "0x600115E")]
			[Address(RVA = "0x11B6264", Offset = "0x11B6264", VA = "0x11B6264")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2BFF0", Offset = "0x2BFF0")]
			get
			{
				return default;
			}
			[Token(Token = "0x600115F")]
			[Address(RVA = "0x11B626C", Offset = "0x11B626C", VA = "0x11B626C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x2C000", Offset = "0x2C000")]
			private set
			{
			}
		}

		[Token(Token = "0x17000452")]
		public override ClientProtocol Protocol
		{
			[Token(Token = "0x6001160")]
			[Address(RVA = "0x11B6274", Offset = "0x11B6274", VA = "0x11B6274", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600115C")]
		[Address(RVA = "0x11B620C", Offset = "0x11B620C", VA = "0x11B620C")]
		public AWS4Signer()
		{
		}

		[Token(Token = "0x600115D")]
		[Address(RVA = "0x11B6238", Offset = "0x11B6238", VA = "0x11B6238")]
		public AWS4Signer(bool signPayload)
		{
		}

		[Token(Token = "0x6001161")]
		[Address(RVA = "0x11B627C", Offset = "0x11B627C", VA = "0x11B627C", Slot = "4")]
		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6001162")]
		[Address(RVA = "0x11B6438", Offset = "0x11B6438", VA = "0x11B6438")]
		public AWS4SigningResult SignRequest(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
			return null;
		}

		[Token(Token = "0x6001163")]
		[Address(RVA = "0x11B6D24", Offset = "0x11B6D24", VA = "0x11B6D24")]
		public static DateTime InitializeHeaders(IDictionary<string, string> headers, Uri requestEndpoint)
		{
			return default;
		}

		[Token(Token = "0x6001164")]
		[Address(RVA = "0x11B7D94", Offset = "0x11B7D94", VA = "0x11B7D94")]
		public static DateTime InitializeHeaders(IDictionary<string, string> headers, Uri requestEndpoint, DateTime requestDateTime)
		{
			return default;
		}

		[Token(Token = "0x6001165")]
		[Address(RVA = "0x11B80B4", Offset = "0x11B80B4", VA = "0x11B80B4")]
		private static void CleanHeaders(IDictionary<string, string> headers)
		{
		}

		[Token(Token = "0x6001166")]
		[Address(RVA = "0x11B8428", Offset = "0x11B8428", VA = "0x11B8428")]
		public static AWS4SigningResult ComputeSignature(ImmutableCredentials credentials, string region, DateTime signedAt, string service, string signedHeaders, string canonicalRequest)
		{
			return null;
		}

		[Token(Token = "0x6001167")]
		[Address(RVA = "0x11B8528", Offset = "0x11B8528", VA = "0x11B8528")]
		public static AWS4SigningResult ComputeSignature(string awsAccessKey, string awsSecretAccessKey, string region, DateTime signedAt, string service, string signedHeaders, string canonicalRequest)
		{
			return null;
		}

		[Token(Token = "0x6001168")]
		[Address(RVA = "0x11B5CEC", Offset = "0x11B5CEC", VA = "0x11B5CEC")]
		public static AWS4SigningResult ComputeSignature(string awsAccessKey, string awsSecretAccessKey, string region, DateTime signedAt, string service, string signedHeaders, string canonicalRequest, RequestMetrics metrics)
		{
			return null;
		}

		[Token(Token = "0x6001169")]
		[Address(RVA = "0x11B5AD4", Offset = "0x11B5AD4", VA = "0x11B5AD4")]
		public static string FormatDateTime(DateTime dt, string formatString)
		{
			return null;
		}

		[Token(Token = "0x600116A")]
		[Address(RVA = "0x11B8814", Offset = "0x11B8814", VA = "0x11B8814")]
		public static byte[] ComposeSigningKey(string awsSecretAccessKey, string region, string date, string service)
		{
			return null;
		}

		[Token(Token = "0x600116B")]
		[Address(RVA = "0x11B8CE8", Offset = "0x11B8CE8", VA = "0x11B8CE8")]
		public static string SetRequestBodyHash(IRequest request)
		{
			return null;
		}

		[Token(Token = "0x600116C")]
		[Address(RVA = "0x11B6FC4", Offset = "0x11B6FC4", VA = "0x11B6FC4")]
		public static string SetRequestBodyHash(IRequest request, bool signPayload)
		{
			return null;
		}

		[Token(Token = "0x600116D")]
		[Address(RVA = "0x11B9298", Offset = "0x11B9298", VA = "0x11B9298")]
		public static byte[] SignBlob(byte[] key, string data)
		{
			return null;
		}

		[Token(Token = "0x600116E")]
		[Address(RVA = "0x11B9330", Offset = "0x11B9330", VA = "0x11B9330")]
		public static byte[] SignBlob(byte[] key, byte[] data)
		{
			return null;
		}

		[Token(Token = "0x600116F")]
		[Address(RVA = "0x11B8AA0", Offset = "0x11B8AA0", VA = "0x11B8AA0")]
		public static byte[] ComputeKeyedHash(SigningAlgorithm algorithm, byte[] key, string data)
		{
			return null;
		}

		[Token(Token = "0x6001170")]
		[Address(RVA = "0x11B8BA0", Offset = "0x11B8BA0", VA = "0x11B8BA0")]
		public static byte[] ComputeKeyedHash(SigningAlgorithm algorithm, byte[] key, byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6001171")]
		[Address(RVA = "0x11B8628", Offset = "0x11B8628", VA = "0x11B8628")]
		public static byte[] ComputeHash(string data)
		{
			return null;
		}

		[Token(Token = "0x6001172")]
		[Address(RVA = "0x11B946C", Offset = "0x11B946C", VA = "0x11B946C")]
		public static byte[] ComputeHash(byte[] data)
		{
			return null;
		}

		[Token(Token = "0x6001173")]
		[Address(RVA = "0x11B8D64", Offset = "0x11B8D64", VA = "0x11B8D64")]
		private static string SetPayloadSignatureHeader(IRequest request, string payloadHash)
		{
			return null;
		}

		[Token(Token = "0x6001174")]
		[Address(RVA = "0x11B41E8", Offset = "0x11B41E8", VA = "0x11B41E8")]
		public static string DetermineSigningRegion(IClientConfig clientConfig, string serviceName, RegionEndpoint alternateEndpoint, IRequest request)
		{
			return null;
		}

		[Token(Token = "0x6001175")]
		[Address(RVA = "0x11B6DF4", Offset = "0x11B6DF4", VA = "0x11B6DF4")]
		internal static string DetermineService(IClientConfig clientConfig)
		{
			return null;
		}

		[Token(Token = "0x6001176")]
		[Address(RVA = "0x11B9A90", Offset = "0x11B9A90", VA = "0x11B9A90")]
		protected static string CanonicalizeRequest(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash)
		{
			return null;
		}

		[Token(Token = "0x6001177")]
		[Address(RVA = "0x11B9B84", Offset = "0x11B9B84", VA = "0x11B9B84")]
		protected static string CanonicalizeRequest(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash, IDictionary<string, string> pathResources, int marshallerVersion)
		{
			return null;
		}

		[Token(Token = "0x6001178")]
		[Address(RVA = "0x11B5BF0", Offset = "0x11B5BF0", VA = "0x11B5BF0")]
		protected static string CanonicalizeRequest(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash, IDictionary<string, string> pathResources, int marshallerVersion, string service)
		{
			return null;
		}

		[Token(Token = "0x6001179")]
		[Address(RVA = "0x11B9C98", Offset = "0x11B9C98", VA = "0x11B9C98")]
		private static string CanonicalizeRequestHelper(Uri endpoint, string resourcePath, string httpMethod, IDictionary<string, string> sortedHeaders, string canonicalQueryString, string precomputedBodyHash, IDictionary<string, string> pathResources, int marshallerVersion, bool detectPreEncode)
		{
			return null;
		}

		[Token(Token = "0x600117A")]
		[Address(RVA = "0x11B473C", Offset = "0x11B473C", VA = "0x11B473C")]
		protected static IDictionary<string, string> SortAndPruneHeaders(IEnumerable<KeyValuePair<string, string>> requestHeaders)
		{
			return null;
		}

		[Token(Token = "0x600117B")]
		[Address(RVA = "0x11BA748", Offset = "0x11BA748", VA = "0x11BA748")]
		protected static string CanonicalizeHeaders(IEnumerable<KeyValuePair<string, string>> sortedHeaders)
		{
			return null;
		}

		[Token(Token = "0x600117C")]
		[Address(RVA = "0x11B4B9C", Offset = "0x11B4B9C", VA = "0x11B4B9C")]
		protected static string CanonicalizeHeaderNames(IEnumerable<KeyValuePair<string, string>> sortedHeaders)
		{
			return null;
		}

		[Token(Token = "0x600117D")]
		[Address(RVA = "0x11B4F4C", Offset = "0x11B4F4C", VA = "0x11B4F4C")]
		protected static List<KeyValuePair<string, string>> GetParametersToCanonicalize(IRequest request)
		{
			return null;
		}

		[Token(Token = "0x600117E")]
		[Address(RVA = "0x11BAD40", Offset = "0x11BAD40", VA = "0x11BAD40")]
		protected static string CanonicalizeQueryParameters(string queryString)
		{
			return null;
		}

		[Token(Token = "0x600117F")]
		[Address(RVA = "0x11BADBC", Offset = "0x11BADBC", VA = "0x11BADBC")]
		protected static string CanonicalizeQueryParameters(string queryString, bool uriEncodeParameters)
		{
			return null;
		}

		[Token(Token = "0x6001180")]
		[Address(RVA = "0x11B5B74", Offset = "0x11B5B74", VA = "0x11B5B74")]
		protected static string CanonicalizeQueryParameters(IEnumerable<KeyValuePair<string, string>> parameters)
		{
			return null;
		}

		[Token(Token = "0x6001181")]
		[Address(RVA = "0x11BB15C", Offset = "0x11BB15C", VA = "0x11BB15C")]
		protected static string CanonicalizeQueryParameters(IEnumerable<KeyValuePair<string, string>> parameters, bool uriEncodeParameters)
		{
			return null;
		}

		[Token(Token = "0x6001182")]
		[Address(RVA = "0x11B908C", Offset = "0x11B908C", VA = "0x11B908C")]
		private static byte[] GetRequestPayloadBytes(IRequest request)
		{
			return null;
		}
	}
}
