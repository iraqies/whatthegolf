using System;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;

namespace Rewired.Utils
{
	[Token(Token = "0x2000342")]
	public static class StringTools
	{
		[Token(Token = "0x400109F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static string urTiAGpyTdYIpEfryRFChszmVFAG;

		[Token(Token = "0x6001903")]
		[Address(RVA = "0x241AE78", Offset = "0x241AE78", VA = "0x241AE78")]
		public static string ToString(int[] inArray)
		{
			return null;
		}

		[Token(Token = "0x6001904")]
		[Address(RVA = "0x241AF70", Offset = "0x241AF70", VA = "0x241AF70")]
		static StringTools()
		{
		}

		[Token(Token = "0x6001905")]
		[Address(RVA = "0x241B040", Offset = "0x241B040", VA = "0x241B040")]
		public static string StripTrailingNumbers(string name, out int number)
		{
			return null;
		}

		[Token(Token = "0x6001906")]
		[Address(RVA = "0x241B1BC", Offset = "0x241B1BC", VA = "0x241B1BC")]
		public static string IterateName(string name, [Optional][DefaultParameterValue(-1)] int indexInNameList, [Optional] string[] names)
		{
			return null;
		}

		[Token(Token = "0x6001907")]
		[Address(RVA = "0x241B35C", Offset = "0x241B35C", VA = "0x241B35C")]
		public static Guid ToGuid(string guid)
		{
			return default;
		}

		[Token(Token = "0x6001908")]
		[Address(RVA = "0x241B454", Offset = "0x241B454", VA = "0x241B454")]
		public static string SanitizeDeviceString(string text)
		{
			return null;
		}

		[Token(Token = "0x6001909")]
		[Address(RVA = "0x241B5A8", Offset = "0x241B5A8", VA = "0x241B5A8")]
		public static string AddSpacesToSentence(string text, bool preserveAcronyms)
		{
			return null;
		}

		[Token(Token = "0x600190A")]
		[Address(RVA = "0x241B840", Offset = "0x241B840", VA = "0x241B840")]
		public static void WriteVar(StringBuilder sb, string name, object value)
		{
		}

		[Token(Token = "0x600190B")]
		[Address(RVA = "0x241B8E4", Offset = "0x241B8E4", VA = "0x241B8E4")]
		public static void WriteVar(StringBuilder sb, string name, object value, char delimiter)
		{
		}

		[Token(Token = "0x600190C")]
		[Address(RVA = "0x241B9F8", Offset = "0x241B9F8", VA = "0x241B9F8")]
		public static string Trim(string str)
		{
			return null;
		}

		[Token(Token = "0x600190D")]
		[Address(RVA = "0x241BA40", Offset = "0x241BA40", VA = "0x241BA40")]
		public static string VariableNameToDisplayName(string fieldName)
		{
			return null;
		}
	}
}
