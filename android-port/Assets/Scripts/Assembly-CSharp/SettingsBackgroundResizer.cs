using TMPro;
using UnityEngine;

public class SettingsBackgroundResizer : MonoBehaviour
{
	public float TotalPadding = 40f;

	[SerializeField]
	private TextMeshProUGUI Label;

	private RectTransform rectTransform;

	private void Awake()
	{
		rectTransform = GetComponent<RectTransform>();
	}

	private void Update()
	{
		if (rectTransform != null && Label != null)
		{
			Vector2 sd = rectTransform.sizeDelta;
			float targetW = Label.preferredWidth + TotalPadding;
			if (Mathf.Abs(sd.x - targetW) > 0.5f)
			{
				rectTransform.sizeDelta = new Vector2(targetW, sd.y);
			}
		}
	}
}
