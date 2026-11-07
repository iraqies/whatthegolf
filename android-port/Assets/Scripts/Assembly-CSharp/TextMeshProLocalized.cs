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

	[SerializeField]
	private string _textId;

	public LocalizationFontStyle style;

	public bool isCountdown;

	[SerializeField]
	private HorizontalTextAlignment HorizontalAlignment;

	protected TMP_Text _tmp;

	protected TextAlignmentOptions _originalAlignment;

	public UnityEvent onTextChanged;

	public string TermId => null;

	private void Awake()
	{
	}

	public void NotifyLanguageChanged()
	{
	}

	private void Retranslate()
	{
	}

	public void ChangeText(string text)
	{
	}

	private void CheckForComponent()
	{
	}

	private static bool TryTranslate(string textOrTerm, out string translated)
	{
		translated = null;
		return false;
	}

	public void ClearText()
	{
	}

	public virtual void ChangeTextAfterTranslation(string textOrTerm)
	{
	}

	public void UpdateAlignment()
	{
	}

	public void UpdateFont()
	{
	}

	private bool IsUGUI()
	{
		return false;
	}

	private static TextAlignmentOptions GetOppositeAlignment(TextAlignmentOptions a)
	{
		return (TextAlignmentOptions)0;
	}
}
