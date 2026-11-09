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
		if (SaveSlotCreatedObject != null)
			SaveSlotCreatedObject.SetActive(created);
		if (SaveSlotNotCreatedObject != null)
			SaveSlotNotCreatedObject.SetActive(!created);
	}

	public void Toggle(bool state)
	{
		if (Container != null)
			Container.SetActive(state);
	}
}
