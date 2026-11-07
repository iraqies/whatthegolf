using TMPro;
using UnityEngine;

[ExecuteAlways]
public class AppleArcadeTextMeshProTextPreprocessor : MonoBehaviour, ITextPreprocessor
{
	private const string StringToReplace = "{0}";

	private const string WordsToReplace = "Apple Arcade";

	[SerializeField]
	private string logoSpriteName;

	[SerializeField]
	private bool tintLogo;

	private TextMeshProUGUI _text;

	private TextMeshProUGUI GetText()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public string GetEditorDescription()
	{
		return null;
	}

	string ITextPreprocessor.PreprocessText(string text)
	{
		return null;
	}

	private string GetSpriteTag()
	{
		return null;
	}
}
