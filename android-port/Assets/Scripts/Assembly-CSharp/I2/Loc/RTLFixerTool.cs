using System.Collections.Generic;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x200132C")]
	internal class RTLFixerTool
	{
		[Token(Token = "0x40066A4")]
		[FieldOffset(Offset = "0x0")]
		internal static bool showTashkeel;

		[Token(Token = "0x40066A5")]
		[FieldOffset(Offset = "0x1")]
		internal static bool useHinduNumbers;

		[Token(Token = "0x600596C")]
		[Address(RVA = "0x1637A74", Offset = "0x1637A74", VA = "0x1637A74")]
		internal static string RemoveTashkeel(string str, out List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600596D")]
		[Address(RVA = "0x1637FF8", Offset = "0x1637FF8", VA = "0x1637FF8")]
		internal static char[] ReturnTashkeel(char[] letters, List<TashkeelLocation> tashkeelLocation)
		{
			return null;
		}

		[Token(Token = "0x600596E")]
		[Address(RVA = "0x1636D00", Offset = "0x1636D00", VA = "0x1636D00")]
		internal static string FixLine(string str)
		{
			return null;
		}

		[Token(Token = "0x600596F")]
		[Address(RVA = "0x163824C", Offset = "0x163824C", VA = "0x163824C")]
		internal static bool IsIgnoredCharacter(char ch)
		{
			return default;
		}

		[Token(Token = "0x6005970")]
		[Address(RVA = "0x1638AE4", Offset = "0x1638AE4", VA = "0x1638AE4")]
		internal static bool IsLeadingLetter(char[] letters, int index)
		{
			return default;
		}

		[Token(Token = "0x6005971")]
		[Address(RVA = "0x16388CC", Offset = "0x16388CC", VA = "0x16388CC")]
		internal static bool IsFinishingLetter(char[] letters, int index)
		{
			return default;
		}

		[Token(Token = "0x6005972")]
		[Address(RVA = "0x16383D8", Offset = "0x16383D8", VA = "0x16383D8")]
		internal static bool IsMiddleLetter(char[] letters, int index)
		{
			return default;
		}
	}
}
