using TMPro;
using UnityEngine;

public class IngameSpeechBubble : MonoBehaviour
{
	public TextMeshProUGUI speechText;
	private Canvas canvas;

	private void Awake()
	{
		canvas = GetComponent<Canvas>() ?? GetComponentInChildren<Canvas>(true);
		if (canvas != null)
			canvas.enabled = false;
	}

	public void ShowText(string text)
	{
		if (canvas == null)
			canvas = GetComponent<Canvas>() ?? GetComponentInChildren<Canvas>(true);
		if (canvas != null)
			canvas.enabled = true;
		if (speechText != null)
			speechText.text = Localization.Instance != null ? Localization.Instance.GetString(text) : text;
	}

	public void Hide()
	{
		if (canvas != null)
			canvas.enabled = false;
	}
}
