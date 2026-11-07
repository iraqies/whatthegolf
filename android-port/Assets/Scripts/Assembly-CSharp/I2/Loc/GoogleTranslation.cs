using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace I2.Loc
{
	[Token(Token = "0x20012E8")]
	public static class GoogleTranslation
	{
		[Token(Token = "0x40065C0")]
		[FieldOffset(Offset = "0x0")]
		private static List<UnityWebRequest> mCurrentTranslations;

		[Token(Token = "0x40065C1")]
		[FieldOffset(Offset = "0x8")]
		private static List<TranslationJob> mTranslationJobs;

		[Token(Token = "0x60057B3")]
		[Address(RVA = "0x14AD920", Offset = "0x14AD920", VA = "0x14AD920")]
		public static string UppercaseFirst(string s)
		{
			return null;
		}

		[Token(Token = "0x60057B4")]
		[Address(RVA = "0x14ADA24", Offset = "0x14ADA24", VA = "0x14ADA24")]
		public static string TitleCase(string s)
		{
			return null;
		}
	}
}
