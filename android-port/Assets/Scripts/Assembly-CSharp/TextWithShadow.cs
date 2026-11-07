using TMPro;
using UnityEngine;

public class TextWithShadow : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI normalText;

	[SerializeField]
	private TextMeshProUGUI textShadow;

	public string text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Color Color
	{
		get
		{
			return default;
		}
		set
		{
		}
	}

	public void SetActive(bool state)
	{
	}
}
