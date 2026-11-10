using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DailyCountdown : MonoBehaviour
{
	private TextMeshPro text;

	private TextMeshProUGUI textGUI;

	private DateTime EOD;

	private float time;

	private bool usingUGUI;

	public bool debug;

	[SerializeField]
	private string appendString;

	[SerializeField]
	private bool showHours = true;

	[SerializeField]
	private bool showMinutes = true;

	[SerializeField]
	private bool showSeconds = true;

	[SerializeField]
	private string stringOnReachZero;

	public Action OnCountdownZero;

	[SerializeField]
	private TextMeshPro ToEnable;

	[SerializeField]
	private List<TextMeshPro> ToDisable;

	private bool end;

	private void Start()
	{
		DateTime today = DailyChallenges.GetToday();
		text = GetComponent<TextMeshPro>();
		textGUI = GetComponent<TextMeshProUGUI>();
		usingUGUI = textGUI != null;
		EOD = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59);
	}

	private void UpdateTimer()
	{
		if (end)
			return;

		DateTime today = DailyChallenges.GetToday();
		TimeSpan diff = EOD - today;
		if (diff.Ticks <= 0 || debug)
		{
			string nextTitle;
			if (string.IsNullOrEmpty(stringOnReachZero))
			{
				var nextPack = DailyChallenges.GetNormalPack(DailyChallenges.GetToday().AddMinutes(1.0));
				string key = nextPack != null ? ("DAILY_TITLE_" + nextPack.PackName) : "";
				nextTitle = Localization.Instance != null ? Localization.Instance.GetString(key, false, null) : key;
			}
			else
			{
				nextTitle = Localization.Instance != null ? Localization.Instance.GetString(stringOnReachZero, false, null) : stringOnReachZero;
			}

			string readyStr = Localization.Instance != null ? Localization.Instance.GetString("DAILY_NEXT_READY", false, null) : "NEXT READY";
			string fullText = readyStr + "\n" + nextTitle;

			if (ToEnable != null)
			{
				ToEnable.gameObject.SetActive(true);
				var tmp = ToEnable.GetComponent<TextMeshPro>();
				if (tmp != null && fullText != null)
					tmp.text = fullText.ToUpper();
			}

			if (ToDisable != null)
			{
				ToDisable.ForEach(t =>
				{
					if (t != null)
						t.gameObject.SetActive(false);
				});
			}

			end = true;
			OnCountdownZero?.Invoke();
			Destroy(this);
			return;
		}

		string timerStr = "";
		if (showHours)
		{
			timerStr += diff.Hours.ToString();
		}
		if (showMinutes)
		{
			timerStr = timerStr + ":" + diff.Minutes.ToString().PadLeft(2, '0');
		}
		if (showSeconds)
		{
			timerStr = timerStr + ":" + diff.Seconds.ToString().PadLeft(2, '0');
		}
		timerStr += appendString;

		if (usingUGUI)
		{
			if (textGUI != null)
				textGUI.text = timerStr;
		}
		else
		{
			if (text != null)
				text.text = timerStr;
		}
	}

	private void Update()
	{
		time += Time.deltaTime;
		if (time >= 1f)
		{
			time = 0f;
			UpdateTimer();
		}
	}
}
