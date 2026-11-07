using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputFieldCharacterCountFeedback : TMP_InputField
{
	[SerializeField]
	private TextMeshProUGUI countRenderer;

	[SerializeField]
	private Graphic inputFieldBackground;

	[SerializeField]
	private Color inputBackgroundColor;

	[SerializeField]
	private Color badInputFeedbackColor;

	[SerializeField]
	private float badInputFadeTime;

	private string lastContent;

	private Coroutine backgroundFeedbackAnimCo;

	private Color originalColor;

	private bool keyPressed;

	private float badInputAnimEndTime;

	private new void Start()
	{
	}

	protected override bool IsValidChar(char c)
	{
		return false;
	}

	private void HandleCharacterLimit()
	{
	}

	private void HandleValueChanged(string content)
	{
	}

	private IEnumerator AnimateImageColor()
	{
		return null;
	}

	private IEnumerator AnimateImageColorV2()
	{
		return null;
	}
}
