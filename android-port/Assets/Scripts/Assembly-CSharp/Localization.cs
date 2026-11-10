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
	private Dictionary<string, string> _englishLookup;

	public static Localization Instance => instance ?? (instance = new Localization());

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
		_ = Instance;
	}

	private void EnsureLoaded()
	{
		if (_englishLookup != null) return;
		_englishLookup = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
		try
		{
			var asset = Resources.Load<LanguageSourceAsset>("I2Languages");
			if (asset != null && asset.mSource != null && asset.mSource.mTerms != null)
			{
				foreach (var term in asset.mSource.mTerms)
				{
					if (term != null && !string.IsNullOrEmpty(term.Term) && term.Languages != null && term.Languages.Length > 0)
					{
						string val = term.Languages[0];
						if (!string.IsNullOrEmpty(val))
							_englishLookup[term.Term] = val.Trim() == "---" ? string.Empty : val;
					}
				}
			}
		}
		catch
		{
		}
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

	public bool HasTerm(string id)
	{
		if (string.IsNullOrEmpty(id)) return false;
		EnsureLoaded();
		return _englishLookup != null && _englishLookup.ContainsKey(id);
	}

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
		if (id.Trim() == "---") return string.Empty;
		EnsureLoaded();
		if (_englishLookup != null && _englishLookup.TryGetValue(id, out string translated))
		{
			if (string.IsNullOrEmpty(translated) || translated.Trim() == "---")
				return string.Empty;
			return translated;
		}
		if (id.StartsWith("ID_"))
		{
			if (id.EndsWith("__COMPLETION", StringComparison.OrdinalIgnoreCase) && id.Contains("TRANSITIONTOOVERWORLD"))
				return string.Empty;
			int doubleIdx = id.LastIndexOf("__", StringComparison.Ordinal);
			if (doubleIdx >= 0 && doubleIdx + 2 < id.Length)
				return id.Substring(doubleIdx + 2).Replace("_", " ");
			return id.Substring(3).Replace("__", ": ").Replace("_", " ");
		}
		return id;
	}

	public LocalizationFont GetFont(LocalizationFontStyle style) => null;
	private void RegisterForLanguageChanges() { }
	private void OnLanguageChanged() => OnLanguageChangedEvent?.Invoke();
	private void LoadFontCollection(string fontCollectionName) { }
}
