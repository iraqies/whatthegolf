using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000048")]
	public sealed class MSIReader : OneDReader
	{
		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		internal static string ALPHABET_STRING;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly char[] ALPHABET;

		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x10")]
		internal static int[] CHARACTER_ENCODINGS;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x18")]
		private static readonly int[] doubleAndCrossSum;
	}
}
