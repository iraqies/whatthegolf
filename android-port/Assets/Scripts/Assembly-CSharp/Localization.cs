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
		if (fonts == null || fonts.Count == 0)
		{
			LoadFontCollection("Western");
		}
	}

	public void ChangeLanguage(string languageId)
	{
		if (!string.IsNullOrEmpty(languageId))
		{
			_currentLang = languageId;
			OnLanguageChanged();
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

	public LocalizationFont GetFont(LocalizationFontStyle style)
	{
		if (style == null) return null;
		EnsureLoaded();
		if (fonts == null || fonts.Count == 0)
			LoadFontCollection("Western");
		if (fonts != null && fonts.TryGetValue(style.name, out LocalizationFont font))
			return font;
		return null;
	}

	private void RegisterForLanguageChanges() { }

	private void OnLanguageChanged()
	{
		string fontCollectionName = GetString("ID_SYSTEM_FONT_COLLECTION", true);
		if (string.IsNullOrEmpty(fontCollectionName) || fontCollectionName == "ID_SYSTEM_FONT_COLLECTION" || fontCollectionName == "SYSTEM FONT COLLECTION")
			fontCollectionName = "Western";
		LoadFontCollection(fontCollectionName);
		foreach (var tmp in UnityEngine.Object.FindObjectsOfType<TextMeshProLocalized>())
		{
			if (tmp != null && tmp.gameObject != null && tmp.gameObject.scene.IsValid())
				tmp.NotifyLanguageChanged();
		}
		OnLanguageChangedEvent?.Invoke();
	}

	private void LoadFontCollection(string fontCollectionName)
	{
		if (string.IsNullOrEmpty(fontCollectionName))
			fontCollectionName = "Western";
		var col = Resources.Load<LocalizationFontCollection>("FontCollections/" + fontCollectionName)
			?? Resources.Load<LocalizationFontCollection>("FontCollections/Western");
		fonts = new Dictionary<string, LocalizationFont>(StringComparer.OrdinalIgnoreCase);
		if (col != null && col.Fonts != null)
		{
			for (int i = 0; i < col.Fonts.Length; i++)
			{
				var lf = col.Fonts[i];
				if (lf != null && lf.Style != null)
				{
					if (lf.MaterialUGUI == null)
						lf.MaterialUGUI = lf.Material;
					fonts[lf.Style.name] = lf;
				}
			}
		}
	}
}
