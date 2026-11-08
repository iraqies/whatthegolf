using TMPro;
using UnityEngine;

public class TransitionSubtitles : MonoBehaviour
{
	[SerializeField] private TMP_Text text;
	[SerializeField] private RectTransform textRectTransform;
	[SerializeField] private RectTransform bgRectTransform;

	private void Awake()
	{
		Hide();
	}

	public void Show(string key, bool onTheSide)
	{
		if (string.IsNullOrEmpty(key))
		{
			Hide();
			return;
		}
		if (text != null) text.text = key;
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		if (gameObject != null)
			gameObject.SetActive(false);
	}
}
