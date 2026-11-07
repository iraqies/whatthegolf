using System.Collections.Generic;
using UnityEngine;

public static class LanguageDetector
{
	private class LanguageCode
	{
		public string code;

		public string languageName;

		public SystemLanguage unityCode;
	}

	private static readonly List<LanguageCode> languageCodes;

	public static string GetDefaultLanguage()
	{
		return null;
	}

	private static string GetLanguageFromCode(string code)
	{
		return null;
	}
}
