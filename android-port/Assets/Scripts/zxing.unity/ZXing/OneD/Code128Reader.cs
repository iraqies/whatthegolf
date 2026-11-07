using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x200003A")]
	public sealed class Code128Reader : OneDReader
	{
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x0")]
		internal static int[][] CODE_PATTERNS;

		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int MAX_AVG_VARIANCE;

		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int MAX_INDIVIDUAL_VARIANCE;
	}
}
