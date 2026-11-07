using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace I2.Loc
{
	[Token(Token = "0x20012E3")]
	public class SpecializationManager : BaseSpecializationManager
	{
		[Token(Token = "0x40065B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static SpecializationManager Singleton;

		[Token(Token = "0x60057A2")]
		[Address(RVA = "0x16CD0DC", Offset = "0x16CD0DC", VA = "0x16CD0DC")]
		private SpecializationManager()
		{
		}

		[Token(Token = "0x60057A3")]
		[Address(RVA = "0x16CD10C", Offset = "0x16CD10C", VA = "0x16CD10C")]
		public static string GetSpecializedText(string text, [Optional] string specialization)
		{
			return null;
		}

		[Token(Token = "0x60057A4")]
		[Address(RVA = "0x16CD314", Offset = "0x16CD314", VA = "0x16CD314")]
		public static string SetSpecializedText(string text, string newText, string specialization)
		{
			return null;
		}

		[Token(Token = "0x60057A5")]
		[Address(RVA = "0x16CD658", Offset = "0x16CD658", VA = "0x16CD658")]
		public static string SetSpecializedText(Dictionary<string, string> specializations)
		{
			return null;
		}

		[Token(Token = "0x60057A6")]
		[Address(RVA = "0x16CD44C", Offset = "0x16CD44C", VA = "0x16CD44C")]
		public static Dictionary<string, string> GetSpecializations(string text, [Optional] Dictionary<string, string> buffer)
		{
			return null;
		}
	}
}
