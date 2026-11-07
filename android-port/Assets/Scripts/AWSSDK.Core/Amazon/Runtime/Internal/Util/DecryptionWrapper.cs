using System.Security.Cryptography;

namespace Amazon.Runtime.Internal.Util
{
	public abstract class DecryptionWrapper : IDecryptionWrapper
	{
		private SymmetricAlgorithm algorithm;

		private ICryptoTransform decryptor;

		private const int encryptionKeySize = 256;

		public ICryptoTransform Transformer => null;

		protected abstract SymmetricAlgorithm CreateAlgorithm();

		public void SetDecryptionData(byte[] key, byte[] IV)
		{
		}

		public void CreateDecryptor()
		{
		}
	}
}
