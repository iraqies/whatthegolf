using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;

namespace UnityEngine.AddressableAssets.Initialization
{
	[Token(Token = "0x2000055")]
	public static class AddressablesRuntimeProperties
	{
		[Token(Token = "0x4000119")]
		[FieldOffset(Offset = "0x0")]
		private static Stack<string> s_TokenStack;

		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x8")]
		private static Stack<int> s_TokenStartStack;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x10")]
		private static bool s_StaticStacksAreInUse;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x18")]
		private static Dictionary<string, string> s_CachedValues;

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2A26EE0", Offset = "0x2A26EE0", VA = "0x2A26EE0")]
		private static Assembly[] GetAssemblies()
		{
			return null;
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2A26F04", Offset = "0x2A26F04", VA = "0x2A26F04")]
		internal static int GetCachedValueCount()
		{
			return default;
		}

		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2A26F88", Offset = "0x2A26F88", VA = "0x2A26F88")]
		public static void SetPropertyValue(string name, string val)
		{
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x2A27024", Offset = "0x2A27024", VA = "0x2A27024")]
		public static void ClearCachedPropertyValues()
		{
		}

		[Token(Token = "0x600025E")]
		[Address(RVA = "0x2A270A8", Offset = "0x2A270A8", VA = "0x2A270A8")]
		public static string EvaluateProperty(string name)
		{
			return null;
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x2A1F630", Offset = "0x2A1F630", VA = "0x2A1F630")]
		public static string EvaluateString(string input)
		{
			return null;
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x2A27564", Offset = "0x2A27564", VA = "0x2A27564")]
		public static string EvaluateString(string inputString, char startDelimiter, char endDelimiter, Func<string, string> varFunc)
		{
			return null;
		}
	}
}
