using System;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace I2.Loc
{
	[Token(Token = "0x2001323")]
	public static class I2Utils
	{
		[Serializable]
		[Token(Token = "0x2001324")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48BA0", Offset = "0x48BA0")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4006698")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4006699")]
			[FieldOffset(Offset = "0x8")]
			public static Func<char, bool> _003C_003E9__6_0;

			[Token(Token = "0x600595C")]
			[Address(RVA = "0x17C1748", Offset = "0x17C1748", VA = "0x17C1748")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x600595D")]
			[Address(RVA = "0x17C1750", Offset = "0x17C1750", VA = "0x17C1750")]
			internal bool _003CSplitLine_003Eb__6_0(char c)
			{
				return default;
			}
		}

		[Token(Token = "0x6005953")]
		[Address(RVA = "0x14E0848", Offset = "0x14E0848", VA = "0x14E0848")]
		public static string ReverseText(string source)
		{
			return null;
		}

		[Token(Token = "0x6005954")]
		[Address(RVA = "0x14E0918", Offset = "0x14E0918", VA = "0x14E0918")]
		public static string RemoveNonASCII(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6005955")]
		[Address(RVA = "0x14E0B58", Offset = "0x14E0B58", VA = "0x14E0B58")]
		public static string GetValidTermName(string text, bool allowCategory = false)
		{
			return null;
		}

		[Token(Token = "0x6005956")]
		[Address(RVA = "0x14E0CC4", Offset = "0x14E0CC4", VA = "0x14E0CC4")]
		public static string SplitLine(string line, int maxCharacters)
		{
			return null;
		}

		[Token(Token = "0x6005957")]
		[Address(RVA = "0x14E0FC8", Offset = "0x14E0FC8", VA = "0x14E0FC8")]
		public static bool FindNextTag(string line, int iStart, out int tagStart, out int tagEnd)
		{
			return default;
		}

		[Token(Token = "0x6005958")]
		[Address(RVA = "0x14E0C18", Offset = "0x14E0C18", VA = "0x14E0C18")]
		public static string RemoveTags(string text)
		{
			return null;
		}

		[Token(Token = "0x6005959")]
		[Address(RVA = "0x14E1128", Offset = "0x14E1128", VA = "0x14E1128")]
		public static bool IsPlaying()
		{
			return default;
		}

		[Token(Token = "0x600595A")]
		[Address(RVA = "0x14E1130", Offset = "0x14E1130", VA = "0x14E1130")]
		public static void SendWebRequest(UnityWebRequest www)
		{
		}
	}
}
