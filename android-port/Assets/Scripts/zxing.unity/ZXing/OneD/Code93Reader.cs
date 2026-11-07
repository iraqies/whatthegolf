using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000042")]
	public sealed class Code93Reader : OneDReader
	{
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x0")]
		private static readonly char[] ALPHABET;

		[Token(Token = "0x4000111")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[] CHARACTER_ENCODINGS;

		[Token(Token = "0x4000112")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int ASTERISK_ENCODING;
	}
}
