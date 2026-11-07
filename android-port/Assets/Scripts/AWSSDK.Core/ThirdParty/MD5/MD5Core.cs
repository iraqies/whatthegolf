using System.Text;

namespace ThirdParty.MD5
{
	internal sealed class MD5Core
	{
		private MD5Core()
		{
		}

		public static byte[] GetHash(string input, Encoding encoding)
		{
			return null;
		}

		public static byte[] GetHash(string input)
		{
			return null;
		}

		public static string GetHashString(byte[] input)
		{
			return null;
		}

		public static string GetHashString(string input, Encoding encoding)
		{
			return null;
		}

		public static string GetHashString(string input)
		{
			return null;
		}

		public static byte[] GetHash(byte[] input)
		{
			return null;
		}

		internal static byte[] GetHashFinalBlock(byte[] input, int ibStart, int cbSize, ABCDStruct ABCD, long len)
		{
			return null;
		}

		internal static void GetHashBlock(byte[] input, ref ABCDStruct ABCDValue, int ibStart)
		{
		}

		private static uint r1(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return 0u;
		}

		private static uint r2(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return 0u;
		}

		private static uint r3(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return 0u;
		}

		private static uint r4(uint a, uint b, uint c, uint d, uint x, int s, uint t)
		{
			return 0u;
		}

		private static uint LSR(uint i, int s)
		{
			return 0u;
		}

		private static uint[] Converter(byte[] input, int ibStart)
		{
			return null;
		}
	}
}
