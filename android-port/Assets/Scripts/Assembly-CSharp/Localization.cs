using System;
using System.Collections.Generic;
using UnityEngine;

public class Localization
{
	private Dictionary<string, LocalizationFont> fonts;

	private const string TAG = "Localization";

	private static readonly pLogger dbg;

	private static readonly pLogger dbg_details;

	public static Action OnLanguageChangedEvent;

	private static Localization instance;

	public static Localization Instance => null;

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	static Localization()
	{
	}

	public void ChangeLanguage(string languageId)
	{
	}

	public string GetCurrentLanguage()
	{
		return null;
	}

	public bool IsEnglish()
	{
		return false;
	}

	public string ReverseCustomTextIfNecessary(string text)
	{
		return null;
	}

	public string GetNextLanguage()
	{
		return null;
	}

	public bool HasTerm(string id)
	{
		return false;
	}

	public string GetStringWithFormat(string id, params object[] values)
	{
		return null;
	}

	public string GetEnglishString(string id)
	{
		return null;
	}

	public string GetString(string id, bool suppressWarnings = false, string overrideLanguage = null)
	{
		return null;
	}

	public LocalizationFont GetFont(LocalizationFontStyle style)
	{
		return null;
	}

	private void RegisterForLanguageChanges()
	{
	}

	private void OnLanguageChanged()
	{
	}

	private void LoadFontCollection(string fontCollectionName)
	{
	}
}
