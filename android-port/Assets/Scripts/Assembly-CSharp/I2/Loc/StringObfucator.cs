using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x2001332")]
	public class StringObfucator
	{
		[Token(Token = "0x40066AB")]
		[FieldOffset(Offset = "0x0")]
		public static char[] StringObfuscatorPassword;

		[Token(Token = "0x6005988")]
		[Address(RVA = "0x16E31F0", Offset = "0x16E31F0", VA = "0x16E31F0")]
		public static string Encode(string NormalString)
		{
			return null;
		}

		[Token(Token = "0x6005989")]
		[Address(RVA = "0x16E3558", Offset = "0x16E3558", VA = "0x16E3558")]
		public static string Decode(string ObfucatedString)
		{
			return null;
		}

		[Token(Token = "0x600598A")]
		[Address(RVA = "0x16E34C8", Offset = "0x16E34C8", VA = "0x16E34C8")]
		private static string ToBase64(string regularString)
		{
			return null;
		}

		[Token(Token = "0x600598B")]
		[Address(RVA = "0x16E3648", Offset = "0x16E3648", VA = "0x16E3648")]
		private static string FromBase64(string base64string)
		{
			return null;
		}

		[Token(Token = "0x600598C")]
		[Address(RVA = "0x16E32E0", Offset = "0x16E32E0", VA = "0x16E32E0")]
		private static string XoREncode(string NormalString)
		{
			return null;
		}
	}
}
