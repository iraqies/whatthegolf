using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace ZXing.Common
{
	[Token(Token = "0x2000068")]
	public sealed class CharacterSetECI : ECI
	{
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly IDictionary<int, CharacterSetECI> VALUE_TO_ECI;

		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x8")]
		internal static readonly IDictionary<string, CharacterSetECI> NAME_TO_ECI;

		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x18")]
		private readonly string encodingName;

		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2EA7B3C", Offset = "0x2EA7B3C", VA = "0x2EA7B3C")]
		static CharacterSetECI()
		{
		}

		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2EA93C4", Offset = "0x2EA93C4", VA = "0x2EA93C4")]
		private CharacterSetECI(int value, string encodingName)
		{
		}

		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2EA9158", Offset = "0x2EA9158", VA = "0x2EA9158")]
		private static void addCharacterSet(int value, string encodingName)
		{
		}

		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2EA8E84", Offset = "0x2EA8E84", VA = "0x2EA8E84")]
		private static void addCharacterSet(int value, string[] encodingNames)
		{
		}

		[Token(Token = "0x6000271")]
		[Address(RVA = "0x2EA942C", Offset = "0x2EA942C", VA = "0x2EA942C")]
		public static CharacterSetECI getCharacterSetECIByName(string name)
		{
			return null;
		}

		[Token(Token = "0x6000272")]
		[Address(RVA = "0x2EA95E8", Offset = "0x2EA95E8", VA = "0x2EA95E8")]
		public static CharacterSetECI getCharacterSetECI(Encoding encoding)
		{
			return null;
		}

		[Token(Token = "0x6000273")]
		[Address(RVA = "0x2EA97B4", Offset = "0x2EA97B4", VA = "0x2EA97B4")]
		public static Encoding getEncoding(string encodingName)
		{
			return null;
		}
	}
}
