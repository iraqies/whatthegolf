using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SaveSlotInfo : MonoBehaviour
{
	public TextMeshProUGUI timePlayedText;

	public TextMeshProUGUI lastPlayedText;

	public TextMeshProUGUI progressText;

	public Transform flagVisualContainer;

	public UnityAction ResetEvent;

	public Button ResetButton;

	private int currentSelectedSave;

	public void InstantiateFlagVisual(GameObject flagObject)
	{
		if (flagVisualContainer == null)
			return;
		for (int i = flagVisualContainer.childCount - 1; i >= 0; i--)
		{
			var child = flagVisualContainer.GetChild(i);
			if (child != null)
				Destroy(child.gameObject);
		}
		if (flagObject != null)
		{
			var go = Instantiate(flagObject, flagVisualContainer, false);
			if (go != null)
				go.transform.localPosition = Vector3.zero;
		}
	}

	public void Show(int slotIndex)
	{
		currentSelectedSave = slotIndex;
		gameObject.SetActive(true);
		ResetValues();
		if (ResetButton != null)
		{
			ResetButton.onClick.RemoveAllListeners();
			ResetButton.interactable = CanBeReset();
			ResetButton.onClick.AddListener(() =>
			{
				ResetEvent?.Invoke();
				ResetValues();
			});
		}
	}

	private void ResetValues()
	{
		if (timePlayedText != null)
			timePlayedText.text = TimePlayed();
		if (lastPlayedText != null)
			lastPlayedText.text = LastTimePlayed();
		if (progressText != null)
			progressText.text = TotalPercentageComplete(currentSelectedSave);
		if (ResetButton != null)
			ResetButton.interactable = CanBeReset();
	}

	private string LastTimePlayed()
	{
		DateTime lastPlayed = SaveGame.GetLastTimePlayed(currentSelectedSave);
		TimeSpan elapsed = DateTime.UtcNow - lastPlayed;
		if (elapsed.TotalDays > 3584.0)
			return "-";
		string daysAgo = I2.Loc.LocalizationManager.GetTranslation("ID_MENU_UI_DAYS_AGO") ?? "{0} days ago";
		string hoursAgo = I2.Loc.LocalizationManager.GetTranslation("ID_MENU_UI_HOURS_AGO") ?? "{0} hours ago";
		string minsAgo = I2.Loc.LocalizationManager.GetTranslation("ID_MENU_UI_MINUTES_AGO") ?? "{0} minutes ago";
		if (elapsed.TotalMinutes < 60.0)
		{
			int m = Mathf.Max(0, (int)elapsed.TotalMinutes);
			return minsAgo.Contains("{0}") ? string.Format(minsAgo, m) : (m + " " + minsAgo);
		}
		if (elapsed.TotalHours < 24.0)
		{
			int h = Mathf.Max(0, (int)elapsed.TotalHours);
			return hoursAgo.Contains("{0}") ? string.Format(hoursAgo, h) : (h + " " + hoursAgo);
		}
		int d = Mathf.Max(0, (int)elapsed.TotalDays);
		return daysAgo.Contains("{0}") ? string.Format(daysAgo, d) : (d + " " + daysAgo);
	}

	private bool CanBeReset()
	{
		return true;
	}

	private string TimePlayed()
	{
		int sec = SaveGame.GetTotalPlayTime(currentSelectedSave);
		TimeSpan ts = TimeSpan.FromSeconds(Mathf.Max(0, sec));
		int hours = Mathf.FloorToInt((float)ts.TotalHours);
		int mins = Mathf.FloorToInt((float)ts.TotalMinutes);
		string hShort = I2.Loc.LocalizationManager.GetTranslation("ID_MENU_UI_HOURS_SHORT") ?? "h";
		string mShort = I2.Loc.LocalizationManager.GetTranslation("ID_MENU_UI_MINUTES_SHORT") ?? "m";
		if (hours > 0)
			return hours + hShort;
		return mins + mShort;
	}

	public static string TotalPercentageComplete(int s)
	{
		int pct = SaveGame.GetCompletedPercentage(ECampaignType.Main, s, true);
		return pct + "%";
	}
}
