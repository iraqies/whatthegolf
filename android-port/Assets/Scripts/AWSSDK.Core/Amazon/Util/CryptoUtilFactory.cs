using System;
using System.IO;
using System.Security.Cryptography;
using Amazon.Runtime;
using Il2CppDummyDll;

namespace Amazon.Util
{
	[Token(Token = "0x200005A")]
	public static class CryptoUtilFactory
	{
		[Token(Token = "0x200005B")]
		private class CryptoUtil : ICryptoUtil
		{
			[Token(Token = "0x40001BA")]
			[ThreadStatic]
			private static HashAlgorithm _hashAlgorithm;

			[Token(Token = "0x170000AD")]
			private static HashAlgorithm SHA256HashAlgorithmInstance
			{
				[Token(Token = "0x6000356")]
				[Address(RVA = "0x1289FF0", Offset = "0x1289FF0", VA = "0x1289FF0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600034D")]
			[Address(RVA = "0x1289B80", Offset = "0x1289B80", VA = "0x1289B80")]
			internal CryptoUtil()
			{
			}

			[Token(Token = "0x600034E")]
			[Address(RVA = "0x1289B88", Offset = "0x1289B88", VA = "0x1289B88", Slot = "4")]
			public string HMACSign(string data, string key, SigningAlgorithm algorithmName)
			{
				return null;
			}

			[Token(Token = "0x600034F")]
			[Address(RVA = "0x1289BEC", Offset = "0x1289BEC", VA = "0x1289BEC", Slot = "5")]
			public string HMACSign(byte[] data, string key, SigningAlgorithm algorithmName)
			{
				return null;
			}

			[Token(Token = "0x6000350")]
			[Address(RVA = "0x1289F78", Offset = "0x1289F78", VA = "0x1289F78", Slot = "6")]
			public byte[] ComputeSHA256Hash(byte[] data)
			{
				return null;
			}

			[Token(Token = "0x6000351")]
			[Address(RVA = "0x128A0AC", Offset = "0x128A0AC", VA = "0x128A0AC", Slot = "7")]
			public byte[] ComputeSHA256Hash(Stream steam)
			{
				return null;
			}

			[Token(Token = "0x6000352")]
			[Address(RVA = "0x128A124", Offset = "0x128A124", VA = "0x128A124", Slot = "8")]
			public byte[] ComputeMD5Hash(byte[] data)
			{
				return null;
			}

			[Token(Token = "0x6000353")]
			[Address(RVA = "0x128A198", Offset = "0x128A198", VA = "0x128A198", Slot = "9")]
			public byte[] ComputeMD5Hash(Stream steam)
			{
				return null;
			}

			[Token(Token = "0x6000354")]
			[Address(RVA = "0x128A20C", Offset = "0x128A20C", VA = "0x128A20C", Slot = "10")]
			public byte[] HMACSignBinary(byte[] data, byte[] key, SigningAlgorithm algorithmName)
			{
				return null;
			}

			[Token(Token = "0x6000355")]
			[Address(RVA = "0x1289E44", Offset = "0x1289E44", VA = "0x1289E44")]
			private KeyedHashAlgorithm CreateKeyedHashAlgorithm(SigningAlgorithm algorithmName)
			{
				return null;
			}
		}

		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x0")]
		private static CryptoUtil util;

		[Token(Token = "0x170000AC")]
		public static ICryptoUtil CryptoInstance
		{
			[Token(Token = "0x600034B")]
			[Address(RVA = "0x11EC66C", Offset = "0x11EC66C", VA = "0x11EC66C")]
			get
			{
				return null;
			}
		}
	}
}
