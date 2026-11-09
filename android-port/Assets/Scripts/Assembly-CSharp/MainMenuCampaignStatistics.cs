using System;
using TMPro;
using UnityEngine;

public class MainMenuCampaignStatistics : MonoBehaviour
{
	public TextMeshProUGUI CompletePercentage;

	public TextMeshProUGUI PlayTime;

	public TextMeshProUGUI Strokes;

	public ECampaignType campaignType;

	private void Awake()
	{
		SaveGame.OnSaveSlotChanged -= OnSaveSlotChanged;
		SaveGame.OnSaveSlotChanged += OnSaveSlotChanged;
	}

	private void OnSaveSlotChanged(int slot)
	{
		SetStatistics();
	}

	private void OnEnable()
	{
		SetStatistics();
	}

	private void OnDestroy()
	{
		SaveGame.OnSaveSlotChanged -= OnSaveSlotChanged;
	}

	public void SetStatistics()
	{
		var data = SaveGame.GetOverworldData(campaignType);
		if (CompletePercentage != null)
		{
			var lvls = SaveGame.CompletedLevelsInOverworld(data);
			int count = lvls != null ? lvls.Count : 0;
			int pct = Mathf.Clamp(Mathf.RoundToInt(count / 1.5f), 0, 100);
			if (count > 0 && pct == 0) pct = 1;
			CompletePercentage.text = pct + "%";
		}
		if (PlayTime != null && data != null)
		{
			TimeSpan ts = TimeSpan.FromSeconds(Mathf.Max(0, data.TimePlayed));
			PlayTime.text = string.Format("{0:00}:{1:00}:{2:00}", (int)ts.TotalHours, ts.Minutes, ts.Seconds);
		}
		if (Strokes != null && data != null)
		{
			Strokes.text = data.OverworldStrokes.ToString();
		}
	}
}
