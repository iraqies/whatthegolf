using System;
using System.IO;
using System.Security.Cryptography;
using Amazon.Runtime;

namespace Amazon.Util
{
	public static class CryptoUtilFactory
	{
		private class CryptoUtil : ICryptoUtil
		{
			[ThreadStatic]
			private static HashAlgorithm _hashAlgorithm;

			private static HashAlgorithm SHA256HashAlgorithmInstance => null;

			internal CryptoUtil()
			{
			}

			public string HMACSign(string data, string key, SigningAlgorithm algorithmName)
			{
				return null;
			}

			public string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName)
			{
				return null;
			}

			public byte[] ComputeSHA256Hash(byte[] data)
			{
				return null;
			}

			public byte[] ComputeSHA256Hash(Stream steam)
			{
				return null;
			}

			public byte[] ComputeMD5Hash(byte[] data)
			{
				return null;
			}

			public byte[] ComputeMD5Hash(Stream steam)
			{
				return null;
			}

			public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
			{
				return null;
			}

			private KeyedHashAlgorithm CreateKeyedHashAlgorithm(SigningAlgorithm algorithmName)
			{
				return null;
			}
		}

		private static CryptoUtil util;

		public static ICryptoUtil CryptoInstance => null;
	}
}
