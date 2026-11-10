using System;
using TMPro;
using UnityEngine;

public class CountdownTimer : MonoBehaviour
{
	[SerializeField]
	private TextMeshProLocalized localization;

	[SerializeField]
	private string format = "hh\\:mm\\:ss";

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

	private void Update()
	{
		TMP_Text t = Text;
		if (t == null)
		{
			return;
		}
		TimeSpan rem = DailyChallenges.GetRemainingDayTime();
		string fmt = string.IsNullOrEmpty(format) ? "hh\\:mm\\:ss" : format;
		try
		{
			t.text = rem.ToString(fmt);
		}
		catch
		{
			t.text = $"{Mathf.Max(0, (int)rem.TotalHours):00}:{rem.Minutes:00}:{rem.Seconds:00}";
		}
	}
}
