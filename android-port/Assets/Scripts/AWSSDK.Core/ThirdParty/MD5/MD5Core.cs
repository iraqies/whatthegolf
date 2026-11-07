using System.Text;
using Il2CppDummyDll;

namespace ThirdParty.MD5
{
	[Token(Token = "0x2000014")]
	internal sealed class MD5Core
	{
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x123B8F8", Offset = "0x123B8F8", VA = "0x123B8F8")]
		private MD5Core()
		{
		}

		[Token(Token = "0x600007D")]
		[Address(RVA = "0x123B900", Offset = "0x123B900", VA = "0x123B900")]
		public static byte[] GetHash(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x600007E")]
		[Address(RVA = "0x123BAC4", Offset = "0x123BAC4", VA = "0x123BAC4")]
		public static byte[] GetHash(string input)
		{
			return null;
		}

		[Token(Token = "0x600007F")]
		[Address(RVA = "0x123BB2C", Offset = "0x123BB2C", VA = "0x123BB2C")]
		public static string GetHashString(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x6000080")]
		[Address(RVA = "0x123BC44", Offset = "0x123BC44", VA = "0x123BC44")]
		public static string GetHashString(string input, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000081")]
		[Address(RVA = "0x123BD0C", Offset = "0x123BD0C", VA = "0x123BD0C")]
		public static string GetHashString(string input)
		{
			return null;
		}

		[Token(Token = "0x6000082")]
		[Address(RVA = "0x123B9C8", Offset = "0x123B9C8", VA = "0x123B9C8")]
		public static byte[] GetHash(byte[] input)
		{
			return null;
		}

		[Token(Token = "0x6000083")]
		[Address(RVA = "0x123C7FC", Offset = "0x123C7FC", VA = "0x123C7FC")]
		internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ABCDStruct ABCD, long len)
		{
			return null;
		}

		[Token(Token = "0x6000084")]
		[Address(RVA = "0x123BD74", Offset = "0x123BD74", VA = "0x123BD74")]
		internal static void GetHashBlock(byte[] input, ref ABCDStruct ABCDValue, int ibStart)
		{
		}

		[Token(Token = "0x6000085")]
		[Address(RVA = "0x123CB8C", Offset = "0x123CB8C", VA = "0x123CB8C")]
		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default;
		}

		[Token(Token = "0x6000086")]
		[Address(RVA = "0x123CBB4", Offset = "0x123CBB4", VA = "0x123CBB4")]
		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default;
		}

		[Token(Token = "0x6000087")]
		[Address(RVA = "0x123CBDC", Offset = "0x123CBDC", VA = "0x123CBDC")]
		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default;
		}

		[Token(Token = "0x6000088")]
		[Address(RVA = "0x123CC00", Offset = "0x123CC00", VA = "0x123CC00")]
		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return default;
		}

		[Token(Token = "0x6000089")]
		[Address(RVA = "0x123CC24", Offset = "0x123CC24", VA = "0x123CC24")]
		private static uint LSR(uint i, int s)
		{
			return default;
		}

		[Token(Token = "0x600008A")]
		[Address(RVA = "0x123CA20", Offset = "0x123CA20", VA = "0x123CA20")]
		private static uint[] Converter(byte[] input, int ibStart)
		{
			return null;
		}
	}
}
