using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000038")]
	public sealed class CodaBarReader : OneDReader
	{
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MAX_ACCEPTABLE;

		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int PADDING;

		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly char[] ALPHABET;

		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x10")]
		internal static int[] CHARACTER_ENCODINGS;

		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x18")]
		private static readonly char[] STARTEND_ENCODING;

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x2EA9868", Offset = "0x2EA9868", VA = "0x2EA9868")]
		internal static bool arrayContains(char[] array, char key)
		{
			return default;
		}
	}
}
