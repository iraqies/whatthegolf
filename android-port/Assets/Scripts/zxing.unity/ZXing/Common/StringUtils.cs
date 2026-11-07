using System.Text;
using Il2CppDummyDll;

namespace ZXing.Common
{
	[Token(Token = "0x200006F")]
	public static class StringUtils
	{
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string PLATFORM_DEFAULT_ENCODING;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x8")]
		public static readonly Encoding PLATFORM_DEFAULT_ENCODING_T;

		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Encoding SHIFT_JIS_ENCODING;

		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Encoding GB2312_ENCODING;

		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Encoding EUC_JP_ENCODING;

		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x28")]
		public static readonly Encoding ISO88591_ENCODING;

		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x30")]
		private static readonly bool ASSUME_SHIFT_JIS;

		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x31")]
		public static readonly bool JIS_IS_SUPPORTED;

		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x32")]
		public static readonly bool EUC_JP_IS_SUPPORTED;

		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x2ED4274", Offset = "0x2ED4274", VA = "0x2ED4274")]
		static StringUtils()
		{
		}
	}
}
