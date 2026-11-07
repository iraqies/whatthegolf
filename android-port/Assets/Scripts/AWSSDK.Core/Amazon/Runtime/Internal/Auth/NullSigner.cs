using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x2000251")]
	public class NullSigner : AbstractAWSSigner
	{
		[Token(Token = "0x1700045E")]
		public override ClientProtocol Protocol
		{
			[Token(Token = "0x600119B")]
			[Address(RVA = "0x12432F0", Offset = "0x12432F0", VA = "0x12432F0", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600119A")]
		[Address(RVA = "0x12432EC", Offset = "0x12432EC", VA = "0x12432EC", Slot = "4")]
		public override void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		[Token(Token = "0x600119C")]
		[Address(RVA = "0x12432F8", Offset = "0x12432F8", VA = "0x12432F8")]
		public NullSigner()
		{
		}
	}
}
