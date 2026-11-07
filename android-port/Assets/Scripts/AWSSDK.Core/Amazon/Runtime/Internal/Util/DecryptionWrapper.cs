using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001EF")]
	public abstract class DecryptionWrapper : IDecryptionWrapper
	{
		[Token(Token = "0x400076C")]
		[FieldOffset(Offset = "0x10")]
		private SymmetricAlgorithm algorithm;

		[Token(Token = "0x400076D")]
		[FieldOffset(Offset = "0x18")]
		private ICryptoTransform decryptor;

		[Token(Token = "0x400076E")]
		private const int encryptionKeySize = 256;

		[Token(Token = "0x170003E8")]
		public ICryptoTransform Transformer
		{
			[Token(Token = "0x6000F60")]
			[Address(RVA = "0x11ED548", Offset = "0x11ED548", VA = "0x11ED548", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x11ED510", Offset = "0x11ED510", VA = "0x11ED510")]
		protected DecryptionWrapper()
		{
		}

		[Token(Token = "0x6000F5F")]
		protected abstract SymmetricAlgorithm CreateAlgorithm();

		[Token(Token = "0x6000F61")]
		[Address(RVA = "0x11ED550", Offset = "0x11ED550", VA = "0x11ED550", Slot = "5")]
		public void SetDecryptionData(byte[] key, byte[] IV)
		{
		}

		[Token(Token = "0x6000F62")]
		[Address(RVA = "0x11ED604", Offset = "0x11ED604", VA = "0x11ED604", Slot = "6")]
		public void CreateDecryptor()
		{
		}
	}
}
