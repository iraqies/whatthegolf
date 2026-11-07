using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000040")]
	public sealed class Code39Reader : OneDReader
	{
		[Token(Token = "0x400010C")]
		[FieldOffset(Offset = "0x0")]
		internal static string ALPHABET_STRING;

		[Token(Token = "0x400010D")]
		[FieldOffset(Offset = "0x8")]
		internal static int[] CHARACTER_ENCODINGS;

		[Token(Token = "0x400010E")]
		[FieldOffset(Offset = "0x10")]
		internal static readonly int ASTERISK_ENCODING;
	}
}
