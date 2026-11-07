using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Amazon.Runtime.Internal.Util
{
	[Token(Token = "0x20001F5")]
	public abstract class EncryptionWrapper : IEncryptionWrapper
	{
		[Token(Token = "0x4000779")]
		[FieldOffset(Offset = "0x10")]
		private SymmetricAlgorithm algorithm;

		[Token(Token = "0x400077A")]
		[FieldOffset(Offset = "0x18")]
		private ICryptoTransform encryptor;

		[Token(Token = "0x400077B")]
		private const int encryptionKeySize = 256;

		[Token(Token = "0x6000F75")]
		[Address(RVA = "0x11FB538", Offset = "0x11FB538", VA = "0x11FB538")]
		protected EncryptionWrapper()
		{
		}

		[Token(Token = "0x6000F76")]
		protected abstract SymmetricAlgorithm CreateAlgorithm();

		[Token(Token = "0x6000F77")]
		[Address(RVA = "0x11FB570", Offset = "0x11FB570", VA = "0x11FB570", Slot = "5")]
		public int AppendBlock(byte[] buffer, int offset, int count, byte[] target, int targetOffset)
		{
			return default;
		}

		[Token(Token = "0x6000F78")]
		[Address(RVA = "0x11FB668", Offset = "0x11FB668", VA = "0x11FB668", Slot = "6")]
		public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
		{
			return null;
		}

		[Token(Token = "0x6000F79")]
		[Address(RVA = "0x11FB748", Offset = "0x11FB748", VA = "0x11FB748", Slot = "8")]
		public void CreateEncryptor()
		{
		}

		[Token(Token = "0x6000F7A")]
		[Address(RVA = "0x11FB784", Offset = "0x11FB784", VA = "0x11FB784", Slot = "7")]
		public void SetEncryptionData(byte[] key, byte[] IV)
		{
		}

		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x11FB838", Offset = "0x11FB838", VA = "0x11FB838", Slot = "4")]
		public void Reset()
		{
		}
	}
}
