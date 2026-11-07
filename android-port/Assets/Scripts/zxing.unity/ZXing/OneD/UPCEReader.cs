using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x2000050")]
	public sealed class UPCEReader : UPCEANReader
	{
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int[] MIDDLE_END_PATTERN;

		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly int[][] NUMSYS_AND_CHECK_DIGIT_PATTERNS;

		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x2ED6880", Offset = "0x2ED6880", VA = "0x2ED6880")]
		public static string convertUPCEtoUPCA(string upce)
		{
			return null;
		}
	}
}
