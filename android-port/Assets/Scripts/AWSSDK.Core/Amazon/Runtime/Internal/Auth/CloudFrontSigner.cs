using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x2000250")]
	public class CloudFrontSigner : AbstractAWSSigner
	{
		[Token(Token = "0x1700045D")]
		public override ClientProtocol Protocol
		{
			[Token(Token = "0x6001197")]
			[Address(RVA = "0x11E2208", Offset = "0x11E2208", VA = "0x11E2208", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001198")]
		[Address(RVA = "0x11E2210", Offset = "0x11E2210", VA = "0x11E2210", Slot = "4")]
		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x6001199")]
		[Address(RVA = "0x11E2588", Offset = "0x11E2588", VA = "0x11E2588")]
		public CloudFrontSigner()
		{
		}
	}
}
