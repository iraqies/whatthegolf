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
		_tmp = GetComponent<TMP_Text>();
		if (_tmp != null)
			_originalAlignment = _tmp.alignment;
		if (!string.IsNullOrEmpty(_textId))
		{
			CheckForComponent();
			TryTranslate(_textId, out string translated);
			ChangeTextAfterTranslation(translated);
		}
	}

	public void NotifyLanguageChanged()
	{
		if (!string.IsNullOrEmpty(_textId) && Localization.Instance != null && Localization.Instance.HasTerm(_textId))
		{
			CheckForComponent();
			TryTranslate(_textId, out string translated);
			ChangeTextAfterTranslation(translated);
		}
	}

	private void Retranslate()
	{
		CheckForComponent();
		TryTranslate(_textId, out string translated);
		ChangeTextAfterTranslation(translated);
	}

	public void ChangeText(string text)
	{
		_textId = text;
		CheckForComponent();
		TryTranslate(_textId, out string translated);
		ChangeTextAfterTranslation(translated);
	}

	private void CheckForComponent()
	{
		if (_tmp == null)
			_tmp = GetComponent<TMP_Text>();
	}

	private static bool TryTranslate(string textOrTerm, out string translated)
	{
		translated = textOrTerm;
		if (string.IsNullOrEmpty(textOrTerm))
			return false;
		if (Localization.Instance != null && Localization.Instance.HasTerm(textOrTerm))
		{
			translated = Localization.Instance.GetString(textOrTerm);
			return true;
		}
		return false;
	}

	public void ClearText()
	{
		if (_tmp != null)
			_tmp.text = string.Empty;
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

	public void UpdateAlignment()
	{
		if (_tmp == null) return;
		_tmp.isRightToLeftText = false;
		if (HorizontalAlignment == HorizontalTextAlignment.FontBased)
		{
			_tmp.alignment = _tmp.isRightToLeftText ? GetOppositeAlignment(_originalAlignment) : _originalAlignment;
		}
	}

	public void UpdateFont()
	{
		if (style == null || Localization.Instance == null) return;
		var lf = Localization.Instance.GetFont(style);
		if (lf == null || _tmp == null) return;
		if (lf.Font != null)
			_tmp.font = lf.Font;
		if (IsUGUI() && lf.MaterialUGUI != null)
			_tmp.fontSharedMaterial = lf.MaterialUGUI;
		else if (lf.Material != null)
			_tmp.fontSharedMaterial = lf.Material;
	}

	private bool IsUGUI() => GetComponent<TextMeshProUGUI>() != null;

	private static TextAlignmentOptions GetOppositeAlignment(TextAlignmentOptions a)
	{
		switch (a)
		{
			case TextAlignmentOptions.TopLeft: return TextAlignmentOptions.TopRight;
			case TextAlignmentOptions.TopRight: return TextAlignmentOptions.TopLeft;
			case TextAlignmentOptions.Left: return TextAlignmentOptions.Right;
			case TextAlignmentOptions.Right: return TextAlignmentOptions.Left;
			case TextAlignmentOptions.BottomLeft: return TextAlignmentOptions.BottomRight;
			case TextAlignmentOptions.BottomRight: return TextAlignmentOptions.BottomLeft;
			case TextAlignmentOptions.BaselineLeft: return TextAlignmentOptions.BaselineRight;
			case TextAlignmentOptions.BaselineRight: return TextAlignmentOptions.BaselineLeft;
			case TextAlignmentOptions.MidlineLeft: return TextAlignmentOptions.MidlineRight;
			case TextAlignmentOptions.MidlineRight: return TextAlignmentOptions.MidlineLeft;
			case TextAlignmentOptions.CaplineLeft: return TextAlignmentOptions.CaplineRight;
			case TextAlignmentOptions.CaplineRight: return TextAlignmentOptions.CaplineLeft;
			default: return a;
		}
	}
}
