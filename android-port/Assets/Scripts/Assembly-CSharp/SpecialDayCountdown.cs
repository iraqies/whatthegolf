using Hub;
using TMPro;
using UnityEngine;

public class SpecialDayCountdown : MonoBehaviour
{
	[SerializeField]
	private TextMeshProLocalized localization;

	[SerializeField]
	private SpecialDayCalendar specialDayCalendar;

	private TMP_Text _text;

	private void Start()
	{
		if (localization != null)
		{
			_text = localization.GetComponent<TMP_Text>();
		}
	}

	public void Tick(SpecialDayStage newStage)
	{
		if (newStage != null && _text != null)
		{
			_text.SetLocalizedText(newStage.GetCountdownText());
		}
	}
}
