using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
	public abstract class EncryptionWrapper : IEncryptionWrapper
	{
		private SymmetricAlgorithm algorithm;

		private ICryptoTransform encryptor;

		private const int encryptionKeySize = 256;

		protected abstract SymmetricAlgorithm CreateAlgorithm();

		public int AppendBlock(byte[] buffer, int offset, int count, byte[] target, int targetOffset)
		{
			return 0;
		}

		public byte[] AppendLastBlock(byte[] buffer, int offset, int count)
		{
			return null;
		}

		public void CreateEncryptor()
		{
		}

		public void SetEncryptionData(byte[] key, byte[] IV)
		{
		}

		public void Reset()
		{
		}
	}
}
