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

	private TMP_Text Text
	{
		get
		{
			if (_text == null && localization != null)
			{
				_text = localization.GetComponent<TMP_Text>();
			}
			if (_text == null)
			{
				_text = GetComponent<TMP_Text>();
			}
			return _text;
		}
	}

	private void Start()
	{
		_ = Text;
		if (specialDayCalendar != null)
		{
			SpecialDayStage cur = specialDayCalendar.GetCurrentStage();
			if (cur != null)
			{
				Tick(cur);
			}
		}
	}

	public void Tick(SpecialDayStage newStage)
	{
		if (newStage != null && Text != null)
		{
			Text.SetLocalizedText(newStage.GetCountdownText());
		}
	}
}
