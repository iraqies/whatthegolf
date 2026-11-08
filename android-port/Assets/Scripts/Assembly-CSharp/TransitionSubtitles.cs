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
		if (string.IsNullOrEmpty(key) || Localization.Instance == null)
		{
			Hide();
			return;
		}
		string localized = Localization.Instance.GetString(key, false, null);
		if (string.IsNullOrEmpty(localized))
		{
			Hide();
			return;
		}
		localized = localized.Replace('\n', ' ').Replace('\r', ' ');
		if (text != null)
			text.text = localized;
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		if (gameObject != null)
			gameObject.SetActive(false);
	}
}
