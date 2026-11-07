using System.Text;

namespace ZXing.Common
{
	public static class StringUtils
	{
		public static readonly string PLATFORM_DEFAULT_ENCODING;

		public static readonly Encoding PLATFORM_DEFAULT_ENCODING_T;

		public static readonly Encoding SHIFT_JIS_ENCODING;

		public static readonly Encoding GB2312_ENCODING;

		public static readonly Encoding EUC_JP_ENCODING;

		public static readonly Encoding ISO88591_ENCODING;

		private static readonly bool ASSUME_SHIFT_JIS;

		public static readonly bool JIS_IS_SUPPORTED;

		public static readonly bool EUC_JP_IS_SUPPORTED;

		static StringUtils()
		{
		}
	}
}
