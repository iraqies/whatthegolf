using Il2CppDummyDll;

namespace ZXing.OneD
{
	[Token(Token = "0x200004E")]
	public abstract class UPCEANReader : OneDReader
	{
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MAX_AVG_VARIANCE;

		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int MAX_INDIVIDUAL_VARIANCE;

		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x8")]
		internal static int[] START_END_PATTERN;

		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x10")]
		internal static int[] MIDDLE_PATTERN;

		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x18")]
		internal static int[] END_PATTERN;

		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x20")]
		internal static int[][] L_PATTERNS;

		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x28")]
		internal static int[][] L_AND_G_PATTERNS;

		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x2ED5EE8", Offset = "0x2ED5EE8", VA = "0x2ED5EE8")]
		static UPCEANReader()
		{
		}

		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x2ED6558", Offset = "0x2ED6558", VA = "0x2ED6558")]
		internal static bool checkStandardUPCEANChecksum(string s)
		{
			return default;
		}

		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x2ED6638", Offset = "0x2ED6638", VA = "0x2ED6638")]
		internal static int? getStandardUPCEANChecksum(string s)
		{
			return null;
		}
	}
}
