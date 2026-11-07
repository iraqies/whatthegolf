using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x200024E")]
	public class AWS4PreSignedUrlSigner : AWS4Signer
	{
		[Token(Token = "0x4000868")]
		public const long MaxAWS4PreSignedUrlExpiry = 604800L;

		[Token(Token = "0x4000869")]
		internal const string XAmzSignature = "X-Amz-Signature";

		[Token(Token = "0x400086A")]
		internal const string XAmzAlgorithm = "X-Amz-Algorithm";

		[Token(Token = "0x400086B")]
		internal const string XAmzCredential = "X-Amz-Credential";

		[Token(Token = "0x400086C")]
		internal const string XAmzExpires = "X-Amz-Expires";

		[Token(Token = "0x6001188")]
		[Address(RVA = "0x11B3044", Offset = "0x11B3044", VA = "0x11B3044", Slot = "4")]
		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6001189")]
		[Address(RVA = "0x11B3098", Offset = "0x11B3098", VA = "0x11B3098")]
		public new AWS4SigningResult SignRequest(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
			return null;
		}

		[Token(Token = "0x600118A")]
		[Address(RVA = "0x11B3120", Offset = "0x11B3120", VA = "0x11B3120")]
		public static AWS4SigningResult SignRequest(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey, string service, string overrideSigningRegion)
		{
			return null;
		}

		[Token(Token = "0x600118B")]
		[Address(RVA = "0x11B6194", Offset = "0x11B6194", VA = "0x11B6194")]
		public AWS4PreSignedUrlSigner()
		{
		}
	}
}
