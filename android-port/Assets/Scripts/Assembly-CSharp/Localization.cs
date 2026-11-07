using System;
using System.Collections.Generic;
using I2.Loc;
using UnityEngine;

public class Localization
{
	private Dictionary<string, LocalizationFont> fonts = new Dictionary<string, LocalizationFont>();
	private const string TAG = "Localization";
	public static Action OnLanguageChangedEvent;
	private static Localization instance;
	private string _currentLang = "English";

	public static Localization Instance => instance ?? (instance = new Localization());

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		_ = Instance;
	}

	public void ChangeLanguage(string languageId)
	{
		if (!string.IsNullOrEmpty(languageId))
		{
			_currentLang = languageId;
			OnLanguageChangedEvent?.Invoke();
		}
	}

	public string GetCurrentLanguage() => _currentLang;
	public bool IsEnglish() => string.IsNullOrEmpty(_currentLang) || _currentLang.StartsWith("en", StringComparison.OrdinalIgnoreCase);
	public string ReverseCustomTextIfNecessary(string text) => text ?? string.Empty;
	public string GetNextLanguage() => _currentLang;
	public bool HasTerm(string id) => !string.IsNullOrEmpty(id);

	public string GetStringWithFormat(string id, params object[] values)
	{
		string raw = GetString(id);
		try { return values != null && values.Length > 0 ? string.Format(raw, values) : raw; }
		catch { return raw; }
	}

	public string GetEnglishString(string id) => GetString(id);

	public string GetString(string id, bool suppressWarnings = false, string overrideLanguage = null)
	{
		if (string.IsNullOrEmpty(id)) return string.Empty;
		if (id.StartsWith("ID_"))
			return id.Substring(3).Replace("__", ": ").Replace("_", " ");
		return id;
	}

	public LocalizationFont GetFont(LocalizationFontStyle style) => null;
	private void RegisterForLanguageChanges() { }
	private void OnLanguageChanged() => OnLanguageChangedEvent?.Invoke();
	private void LoadFontCollection(string fontCollectionName) { }
}
