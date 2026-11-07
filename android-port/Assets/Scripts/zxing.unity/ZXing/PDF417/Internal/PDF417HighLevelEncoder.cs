using System.Text;
using ZXing.Common;

namespace ZXing.PDF417.Internal
{
	internal static class PDF417HighLevelEncoder
	{
		private class NoECIInput : ECIInput
		{
			private string input;

			public int Length => 0;

			public NoECIInput(string input)
			{
			}

			public char charAt(int index)
			{
				return '\0';
			}

			public bool isECI(int index)
			{
				return false;
			}

			public int getECIValue(int index)
			{
				return 0;
			}

			public string subSequence(int start, int end)
			{
				return null;
			}
		}

		private static readonly sbyte[] TEXT_MIXED_RAW;

		private static readonly sbyte[] TEXT_PUNCTUATION_RAW;

		private static readonly sbyte[] MIXED;

		private static readonly sbyte[] PUNCTUATION;

		internal static string DEFAULT_ENCODING_NAME;

		private static Encoding DEFAULT_ENCODING;

		static PDF417HighLevelEncoder()
		{
		}

		internal static string encodeHighLevel(string msg, Compaction compaction, Encoding encoding, bool disableEci, bool autoECI)
		{
			return null;
		}

		internal static Encoding getEncoder(Encoding encoding)
		{
			return null;
		}

		private static byte[] toBytes(string msg, Encoding encoding)
		{
			return null;
		}

		internal static void checkCharset(string input, int max, string errorMessage)
		{
		}

		private static int encodeText(ECIInput input, int startpos, int count, StringBuilder sb, int initialSubmode)
		{
			return 0;
		}

		private static void encodeMultiECIBinary(ECIInput input, int startpos, int count, int startmode, StringBuilder sb)
		{
		}

		private static byte[] subBytes(ECIInput input, int start, int end)
		{
			return null;
		}

		private static void encodeBinary(byte[] bytes, int startpos, int count, int startmode, StringBuilder sb)
		{
		}

		private static void encodeNumeric(ECIInput input, int startpos, int count, StringBuilder sb)
		{
		}

		private static bool isDigit(char ch)
		{
			return false;
		}

		private static bool isAlphaUpper(char ch)
		{
			return false;
		}

		private static bool isAlphaLower(char ch)
		{
			return false;
		}

		private static bool isMixed(char ch)
		{
			return false;
		}

		private static bool isPunctuation(char ch)
		{
			return false;
		}

		private static bool isText(char ch)
		{
			return false;
		}

		private static int determineConsecutiveDigitCount(ECIInput input, int startpos)
		{
			return 0;
		}

		private static int determineConsecutiveTextCount(ECIInput input, int startpos)
		{
			return 0;
		}

		private static int determineConsecutiveBinaryCount(ECIInput input, int startpos, Encoding encoding)
		{
			return 0;
		}

		private static void encodingECI(int eci, StringBuilder sb)
		{
		}
	}
}
