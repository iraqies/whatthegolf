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
		if (!string.IsNullOrEmpty(_textId))
			ChangeText(Localization.Instance.GetString(_textId));
	}

	public void ChangeText(string text)
	{
		CheckForComponent();
		if (_tmp != null && !string.IsNullOrEmpty(text))
		{
			_tmp.text = text;
			onTextChanged?.Invoke();
		}
	}

	private void CheckForComponent()
	{
		if (_tmp == null) _tmp = GetComponent<TMP_Text>();
	}

	private static bool TryTranslate(string textOrTerm, out string translated)
	{
		translated = Localization.Instance.GetString(textOrTerm);
		return !string.IsNullOrEmpty(translated);
	}

	public void ClearText()
	{
		CheckForComponent();
		if (_tmp != null) _tmp.text = string.Empty;
	}

	public virtual void ChangeTextAfterTranslation(string textOrTerm) => ChangeText(Localization.Instance.GetString(textOrTerm));
	public void UpdateAlignment() { }
	public void UpdateFont() { }
	private bool IsUGUI() => _tmp is TextMeshProUGUI;
	private static TextAlignmentOptions GetOppositeAlignment(TextAlignmentOptions a) => a;
}
