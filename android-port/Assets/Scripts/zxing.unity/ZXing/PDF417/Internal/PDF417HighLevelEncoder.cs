using System.Text;
using Il2CppDummyDll;
using ZXing.Common;

namespace ZXing.PDF417.Internal
{
	[Token(Token = "0x2000035")]
	internal static class PDF417HighLevelEncoder
	{
		[Token(Token = "0x2000036")]
		private class NoECIInput : ECIInput
		{
			[Token(Token = "0x40000DF")]
			[FieldOffset(Offset = "0x10")]
			private string input;

			[Token(Token = "0x17000034")]
			public int Length
			{
				[Token(Token = "0x600015C")]
				[Address(RVA = "0x2EE61D4", Offset = "0x2EE61D4", VA = "0x2EE61D4", Slot = "4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x600015B")]
			[Address(RVA = "0x2EE61A8", Offset = "0x2EE61A8", VA = "0x2EE61A8")]
			public NoECIInput(string input)
			{
			}

			[Token(Token = "0x600015D")]
			[Address(RVA = "0x2EE61F0", Offset = "0x2EE61F0", VA = "0x2EE61F0", Slot = "5")]
			public char charAt(int index)
			{
				return default;
			}

			[Token(Token = "0x600015E")]
			[Address(RVA = "0x2EE620C", Offset = "0x2EE620C", VA = "0x2EE620C", Slot = "7")]
			public bool isECI(int index)
			{
				return default;
			}

			[Token(Token = "0x600015F")]
			[Address(RVA = "0x2EE6214", Offset = "0x2EE6214", VA = "0x2EE6214", Slot = "8")]
			public int getECIValue(int index)
			{
				return default;
			}

			[Token(Token = "0x6000160")]
			[Address(RVA = "0x2EE621C", Offset = "0x2EE621C", VA = "0x2EE621C", Slot = "6")]
			public string subSequence(int start, int end)
			{
				return null;
			}
		}

		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x0")]
		private static readonly sbyte[] TEXT_MIXED_RAW;

		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x8")]
		private static readonly sbyte[] TEXT_PUNCTUATION_RAW;

		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		private static readonly sbyte[] MIXED;

		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		private static readonly sbyte[] PUNCTUATION;

		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		internal static string DEFAULT_ENCODING_NAME;

		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x28")]
		private static Encoding DEFAULT_ENCODING;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x2ECD79C", Offset = "0x2ECD79C", VA = "0x2ECD79C")]
		static PDF417HighLevelEncoder()
		{
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x2ECB388", Offset = "0x2ECB388", VA = "0x2ECB388")]
		internal static string encodeHighLevel(string msg, Compaction compaction, Encoding encoding, bool disableEci, bool autoECI)
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x2ECF998", Offset = "0x2ECF998", VA = "0x2ECF998")]
		internal static Encoding getEncoder(Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x600014A")]
		[Address(RVA = "0x2ECE958", Offset = "0x2ECE958", VA = "0x2ECE958")]
		private static byte[] toBytes(string msg, Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x600014B")]
		[Address(RVA = "0x2ECDA38", Offset = "0x2ECDA38", VA = "0x2ECDA38")]
		internal static void checkCharset(string input, int max, string errorMessage)
		{
		}

		[Token(Token = "0x600014C")]
		[Address(RVA = "0x2ECDE70", Offset = "0x2ECDE70", VA = "0x2ECDE70")]
		private static int encodeText(ECIInput input, int startpos, int count, StringBuilder sb, int initialSubmode)
		{
			return default;
		}

		[Token(Token = "0x600014D")]
		[Address(RVA = "0x2ECE5C4", Offset = "0x2ECE5C4", VA = "0x2ECE5C4")]
		private static void encodeMultiECIBinary(ECIInput input, int startpos, int count, int startmode, StringBuilder sb)
		{
		}

		[Token(Token = "0x600014E")]
		[Address(RVA = "0x2ECFDFC", Offset = "0x2ECFDFC", VA = "0x2ECFDFC")]
		private static byte[] subBytes(ECIInput input, int start, int end)
		{
			return null;
		}

		[Token(Token = "0x600014F")]
		[Address(RVA = "0x2ECE9E0", Offset = "0x2ECE9E0", VA = "0x2ECE9E0")]
		private static void encodeBinary(byte[] bytes, int startpos, int count, int startmode, StringBuilder sb)
		{
		}

		[Token(Token = "0x6000150")]
		[Address(RVA = "0x2ECEC2C", Offset = "0x2ECEC2C", VA = "0x2ECEC2C")]
		private static void encodeNumeric(ECIInput input, int startpos, int count, StringBuilder sb)
		{
		}

		[Token(Token = "0x6000151")]
		[Address(RVA = "0x2ECFF48", Offset = "0x2ECFF48", VA = "0x2ECFF48")]
		private static bool isDigit(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000152")]
		[Address(RVA = "0x2ECFC94", Offset = "0x2ECFC94", VA = "0x2ECFC94")]
		private static bool isAlphaUpper(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000153")]
		[Address(RVA = "0x2ECFCA8", Offset = "0x2ECFCA8", VA = "0x2ECFCA8")]
		private static bool isAlphaLower(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x2ECFCBC", Offset = "0x2ECFCBC", VA = "0x2ECFCBC")]
		private static bool isMixed(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x2ECFD5C", Offset = "0x2ECFD5C", VA = "0x2ECFD5C")]
		private static bool isPunctuation(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x2ECFF58", Offset = "0x2ECFF58", VA = "0x2ECFF58")]
		private static bool isText(char ch)
		{
			return default;
		}

		[Token(Token = "0x6000157")]
		[Address(RVA = "0x2ECEF2C", Offset = "0x2ECEF2C", VA = "0x2ECEF2C")]
		private static int determineConsecutiveDigitCount(ECIInput input, int startpos)
		{
			return default;
		}

		[Token(Token = "0x6000158")]
		[Address(RVA = "0x2ECF14C", Offset = "0x2ECF14C", VA = "0x2ECF14C")]
		private static int determineConsecutiveTextCount(ECIInput input, int startpos)
		{
			return default;
		}

		[Token(Token = "0x6000159")]
		[Address(RVA = "0x2ECF4F0", Offset = "0x2ECF4F0", VA = "0x2ECF4F0")]
		private static int determineConsecutiveBinaryCount(ECIInput input, int startpos, Encoding encoding)
		{
			return default;
		}

		[Token(Token = "0x600015A")]
		[Address(RVA = "0x2ECDD08", Offset = "0x2ECDD08", VA = "0x2ECDD08")]
		private static void encodingECI(int eci, StringBuilder sb)
		{
		}
	}
}
