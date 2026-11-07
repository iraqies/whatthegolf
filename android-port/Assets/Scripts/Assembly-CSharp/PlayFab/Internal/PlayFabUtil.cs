using System.Globalization;
using Il2CppDummyDll;

namespace PlayFab.Internal
{
	[Token(Token = "0x20011C5")]
	internal static class PlayFabUtil
	{
		[Token(Token = "0x4005F7B")]
		[FieldOffset(Offset = "0x0")]
		private static string _localSettingsFileName;

		[Token(Token = "0x4005F7C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string[] _defaultDateTimeFormats;

		[Token(Token = "0x4005F7D")]
		[FieldOffset(Offset = "0x10")]
		public static DateTimeStyles DateTimeStyles;

		[Token(Token = "0x6005140")]
		[Address(RVA = "0x15F4548", Offset = "0x15F4548", VA = "0x15F4548")]
		static PlayFabUtil()
		{
		}
	}
}
