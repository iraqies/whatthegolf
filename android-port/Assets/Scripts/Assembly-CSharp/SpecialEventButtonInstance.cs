using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SpecialEventButtonInstance : MonoBehaviour
{
	[SerializeField]
	private AnimateRectTransform animator;

	[SerializeField]
	private GameObject bigBanner;

	[SerializeField]
	private GameObject smallBanner;

	[SerializeField]
	private TextMeshProUGUI text;

	[SerializeField]
	private TextMeshProLocalized localizer;

	public Graphic targetGraphics;

	private string title;

	private void Start()
	{
	}

	internal void Init(string title)
	{
	}

	private void ShowBanner(int length)
	{
	}

	private void UpdateBanner(string language)
	{
	}
}
