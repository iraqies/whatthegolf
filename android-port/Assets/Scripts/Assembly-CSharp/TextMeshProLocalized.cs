using TMPro;
using UnityEngine;
using UnityEngine.Events;

[DisallowMultipleComponent]
public class TextMeshProLocalized : MonoBehaviour
{
	private enum HorizontalTextAlignment
	{
		Original = 0,
		FontBased = 10
	}

	[SerializeField] private string _textId;
	public LocalizationFontStyle style;
	public bool isCountdown;
	[SerializeField] private HorizontalTextAlignment HorizontalAlignment;
	protected TMP_Text _tmp;
	protected TextAlignmentOptions _originalAlignment;
	public UnityEvent onTextChanged = new UnityEvent();

	public string TermId => _textId;

	private void Awake()
	{
		CheckForComponent();
		Retranslate();
	}

	public void NotifyLanguageChanged() => Retranslate();

	private void Retranslate()
	{
		CheckForComponent();
		if (TryTranslate(_textId, out string translated))
			ChangeTextAfterTranslation(translated);
	}

	public void ChangeText(string text)
	{
		_textId = text;
		CheckForComponent();
		if (TryTranslate(_textId, out string translated))
			ChangeTextAfterTranslation(translated);
		else
			ChangeTextAfterTranslation(_textId);
	}

	private void CheckForComponent()
	{
		if (_tmp == null) _tmp = GetComponent<TMP_Text>();
	}

	private static bool TryTranslate(string textOrTerm, out string translated)
	{
		translated = textOrTerm;
		if (string.IsNullOrEmpty(textOrTerm))
			return false;
		if (Localization.Instance != null && (Localization.Instance.HasTerm(textOrTerm) || textOrTerm.StartsWith("ID_")))
		{
			translated = Localization.Instance.GetString(textOrTerm);
			return !string.IsNullOrEmpty(translated);
		}
		return false;
	}

	public void ClearText()
	{
		CheckForComponent();
		if (_tmp != null) _tmp.text = string.Empty;
	}

	public virtual void ChangeTextAfterTranslation(string textOrTerm)
	{
		CheckForComponent();
		UpdateAlignment();
		UpdateFont();
		if (_tmp != null)
		{
			_tmp.text = textOrTerm ?? string.Empty;
			onTextChanged?.Invoke();
		}
	}
	public void UpdateAlignment() { }
	public void UpdateFont() { }
	private bool IsUGUI() => _tmp is TextMeshProUGUI;
	private static TextAlignmentOptions GetOppositeAlignment(TextAlignmentOptions a) => a;
}
