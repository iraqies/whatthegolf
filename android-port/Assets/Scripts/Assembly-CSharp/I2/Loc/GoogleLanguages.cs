using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x20012E6")]
	public static class GoogleLanguages
	{
		[Token(Token = "0x20012E7")]
		public struct LanguageCodeDef
		{
			[Token(Token = "0x40065BC")]
			[FieldOffset(Offset = "0x0")]
			public string Code;

			[Token(Token = "0x40065BD")]
			[FieldOffset(Offset = "0x8")]
			public string GoogleCode;

			[Token(Token = "0x40065BE")]
			[FieldOffset(Offset = "0x10")]
			public bool HasJoinedWords;

			[Token(Token = "0x40065BF")]
			[FieldOffset(Offset = "0x14")]
			public int PluralRule;
		}

		[Token(Token = "0x40065BB")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, LanguageCodeDef> mLanguageDef;

		[Token(Token = "0x60057AB")]
		[Address(RVA = "0x14A6C00", Offset = "0x14A6C00", VA = "0x14A6C00")]
		public static string GetLanguageCode(string Filter, bool ShowWarnings = false)
		{
			return null;
		}

		[Token(Token = "0x60057AC")]
		[Address(RVA = "0x14A6EE4", Offset = "0x14A6EE4", VA = "0x14A6EE4")]
		private static bool LanguageMatchesFilter(string Language, string[] Filters)
		{
			return default;
		}

		[Token(Token = "0x60057AD")]
		[Address(RVA = "0x14A7030", Offset = "0x14A7030", VA = "0x14A7030")]
		public static void UnPackCodeFromLanguageName(string CodedLanguage, out string Language, out string code)
		{
		}

		[Token(Token = "0x60057AE")]
		[Address(RVA = "0x14A7184", Offset = "0x14A7184", VA = "0x14A7184")]
		public static bool LanguageCode_HasJoinedWord(string languageCode)
		{
			return default;
		}

		[Token(Token = "0x60057AF")]
		[Address(RVA = "0x14A736C", Offset = "0x14A736C", VA = "0x14A736C")]
		private static int GetPluralRule(string langCode)
		{
			return default;
		}

		[Token(Token = "0x60057B0")]
		[Address(RVA = "0x14A7574", Offset = "0x14A7574", VA = "0x14A7574")]
		public static ePluralType GetPluralType(string langCode, int n)
		{
			return default;
		}

		[Token(Token = "0x60057B1")]
		[Address(RVA = "0x14A7C00", Offset = "0x14A7C00", VA = "0x14A7C00")]
		private static bool inRange(int amount, int min, int max)
		{
			return default;
		}
	}
}
