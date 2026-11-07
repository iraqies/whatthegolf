using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SaveSlotElement : MonoBehaviour
{
	public GameObject Container;

	public Image Image;

	public TextMeshProUGUI PercentageCompletedText;

	public TextMeshProLocalized Localizer;

	public Color FlagColor;

	public GameObject SaveSlotCreatedObject;

	public GameObject SaveSlotNotCreatedObject;

	public void SetState(bool created)
	{
	}

	public void Toggle(bool state)
	{
	}
}
