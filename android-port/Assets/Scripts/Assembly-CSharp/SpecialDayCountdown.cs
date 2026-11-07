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
	}

	public void Tick(SpecialDayStage newStage)
	{
	}
}
