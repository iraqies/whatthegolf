using System.Security.Cryptography;

namespace ThirdParty.MD5
{
	public class MD5Managed : HashAlgorithm
	{
		private byte[] _data;

		private ABCDStruct _abcd;

		private long _totalLength;

		private int _dataSize;

		public override void Initialize()
		{
		}

		public void TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
		}

		public new byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		protected override void HashCore(byte[] array, int ibStart, int cbSize)
		{
		}

		protected override byte[] HashFinal()
		{
			return null;
		}
	}
}
