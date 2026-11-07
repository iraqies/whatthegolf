using Amazon.Runtime.Internal.Util;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Auth
{
	[Token(Token = "0x2000249")]
	public abstract class AbstractAWSSigner
	{
		[Token(Token = "0x4000851")]
		[FieldOffset(Offset = "0x10")]
		private AWS4Signer _aws4Signer;

		[Token(Token = "0x1700044D")]
		private AWS4Signer AWS4SignerInstance
		{
			[Token(Token = "0x6001143")]
			[Address(RVA = "0x11C8308", Offset = "0x11C8308", VA = "0x11C8308")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700044E")]
		public abstract ClientProtocol Protocol
		{
			[Token(Token = "0x6001147")]
			get;
		}

		[Token(Token = "0x6001144")]
		[Address(RVA = "0x11B0E3C", Offset = "0x11B0E3C", VA = "0x11B0E3C")]
		protected static string ComputeHash(string data, string secretkey, SigningAlgorithm algorithm)
		{
			return null;
		}

		[Token(Token = "0x6001145")]
		[Address(RVA = "0x11B254C", Offset = "0x11B254C", VA = "0x11B254C")]
		protected static string ComputeHash(byte[] data, string secretkey, SigningAlgorithm algorithm)
		{
			return null;
		}

		[Token(Token = "0x6001146")]
		public abstract void Sign(IRequest request, IClientConfig clientConfig, RequestMetrics metrics, string awsAccessKeyId, string awsSecretAccessKey);

		[Token(Token = "0x6001148")]
		[Address(RVA = "0x11C842C", Offset = "0x11C842C", VA = "0x11C842C")]
		protected static bool UseV4Signing(bool useSigV4Setting, IRequest request, IClientConfig config)
		{
			return default;
		}

		[Token(Token = "0x6001149")]
		[Address(RVA = "0x11AF88C", Offset = "0x11AF88C", VA = "0x11AF88C")]
		protected AbstractAWSSigner SelectSigner(IRequest request, IClientConfig config)
		{
			return null;
		}

		[Token(Token = "0x600114A")]
		[Address(RVA = "0x11C8A78", Offset = "0x11C8A78", VA = "0x11C8A78")]
		protected AbstractAWSSigner SelectSigner(AbstractAWSSigner defaultSigner, bool useSigV4Setting, IRequest request, IClientConfig config)
		{
			return null;
		}

		[Token(Token = "0x600114B")]
		[Address(RVA = "0x11AF71C", Offset = "0x11AF71C", VA = "0x11AF71C")]
		protected AbstractAWSSigner()
		{
		}
	}
}
