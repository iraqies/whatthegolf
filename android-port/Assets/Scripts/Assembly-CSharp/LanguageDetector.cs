using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20004DC")]
public static class LanguageDetector
{
	[Token(Token = "0x20004DD")]
	private class LanguageCode
	{
		[Token(Token = "0x4001985")]
		[FieldOffset(Offset = "0x10")]
		public string code;

		[Token(Token = "0x4001986")]
		[FieldOffset(Offset = "0x18")]
		public string languageName;

		[Token(Token = "0x4001987")]
		[FieldOffset(Offset = "0x20")]
		public SystemLanguage unityCode;

		[Token(Token = "0x6001675")]
		[Address(RVA = "0x17CD620", Offset = "0x17CD620", VA = "0x17CD620")]
		public LanguageCode()
		{
		}
	}

	[Token(Token = "0x20004DE")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3FF24", Offset = "0x3FF24")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4001988")]
		[FieldOffset(Offset = "0x10")]
		public string code;

		[Token(Token = "0x6001676")]
		[Address(RVA = "0x17CD568", Offset = "0x17CD568", VA = "0x17CD568")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6001677")]
		[Address(RVA = "0x17CD570", Offset = "0x17CD570", VA = "0x17CD570")]
		internal bool _003CGetLanguageFromCode_003Eb__0(LanguageCode x)
		{
			return default;
		}

		[Token(Token = "0x6001678")]
		[Address(RVA = "0x17CD5C8", Offset = "0x17CD5C8", VA = "0x17CD5C8")]
		internal bool _003CGetLanguageFromCode_003Eb__1(LanguageCode x)
		{
			return default;
		}
	}

	[Token(Token = "0x4001984")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<LanguageCode> languageCodes;

	[Token(Token = "0x6001672")]
	[Address(RVA = "0x1502408", Offset = "0x1502408", VA = "0x1502408")]
	public static string GetDefaultLanguage()
	{
		return null;
	}

	[Token(Token = "0x6001673")]
	[Address(RVA = "0x1502518", Offset = "0x1502518", VA = "0x1502518")]
	private static string GetLanguageFromCode(string code)
	{
		return null;
	}
}
