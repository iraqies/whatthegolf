using TMPro;

public static class TMPLocalizationExtensions
{
	public static void SetLocalizedText(this TMP_Text tmp, string textOrTerm)
	{
		if (tmp == null)
			return;
		var loc = tmp.GetComponent<TextMeshProLocalized>();
		if (loc == null)
			loc = tmp.gameObject.AddComponent<TextMeshProLocalized>();
		if (loc != null)
			loc.ChangeText(textOrTerm);
	}

	public static void SetLocalizedTextWithFormat(this TMP_Text tmp, string term, params object[] values)
	{
		if (Localization.Instance != null)
		{
			string formatted = Localization.Instance.GetStringWithFormat(term, values);
			tmp.SetLocalizedText(formatted);
		}
		else
		{
			tmp.SetLocalizedText(term);
		}
	}
}
