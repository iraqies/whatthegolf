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
		if (flagObject != null && flagVisualContainer != null)
			Instantiate(flagObject, flagVisualContainer, false);
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
		return DateTime.Now.ToString("yyyy-MM-dd");
	}

	private bool CanBeReset()
	{
		var lvls = SaveGame.CompletedLevelsInOverworld(null, currentSelectedSave);
		return (lvls != null && lvls.Count > 0) || SaveGame.IsOnboardingComplete;
	}

	private string TimePlayed()
	{
		int sec = SaveGame.GetTotalPlayTime(currentSelectedSave);
		TimeSpan ts = TimeSpan.FromSeconds(Mathf.Max(0, sec));
		return string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
	}

	public static string TotalPercentageComplete(int s)
	{
		var lvls = SaveGame.CompletedLevelsInOverworld(null, s);
		int completed = lvls != null ? lvls.Count : 0;
		int pct = Mathf.Clamp(Mathf.RoundToInt(completed / 1.5f), 0, 100);
		if (completed > 0 && pct == 0) pct = 1;
		return pct + "%";
	}
}
