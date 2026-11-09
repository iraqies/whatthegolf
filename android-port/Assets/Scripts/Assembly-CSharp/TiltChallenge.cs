using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class TiltChallenge : Challenge
{
	public List<GameObject> ObjectsToTilt;

	private TiltChallengeSFX SFX;

	private int count;

	private GolfBallController controller;

	public GameObject[] boundsList;

	public bool disableBoundsOnWin;

	protected override void Activate()
	{
		controller = FindObjectOfType<GolfBallController>();
		if (ObjectsToTilt != null)
		{
			foreach (var go in ObjectsToTilt)
			{
				if (go == null) continue;
				var tip2d = go.GetComponent<TipObject2D>();
				if (tip2d != null)
				{
					tip2d.OnTip += OnTip;
				}
				else
				{
					var tip = go.GetComponent<TipObject>() ?? go.AddComponent<TipObject>();
					tip.OnTip += OnTip;
				}
			}
		}
		SFX = GetComponentInChildren<TiltChallengeSFX>();
		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null && ObjectsToTilt != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(ObjectsToTilt.Count, StrokeCounter.CounterTypes.CardsAppearing, true);
		}
	}

	private void OnTip(GameObject go)
	{
		if (ObjectsToTilt == null) return;
		ObjectsToTilt.Remove(go);
		count++;
		if (SFX != null)
			SFX.Play();
		if (ObjectsToTilt.Count == 0)
		{
			if (disableBoundsOnWin && boundsList != null)
			{
				for (int i = 0; i < boundsList.Length; i++)
				{
					if (boundsList[i] != null)
						boundsList[i].SetActive(false);
				}
			}
			Complete(0.25f);
		}
		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			LevelManager.Instance.InGameMenu.CountStroke(controller, count);
	}

	public override string GetDescription()
	{
		string key = !string.IsNullOrEmpty(DescriptionLocalizationId) ? DescriptionLocalizationId : "ID_CHALLENGE_DESC_TILT";
		string fmt = Localization.Instance != null ? Localization.Instance.GetString(key) : key;
		try
		{
			return string.Format(fmt, ObjectsToTilt != null ? ObjectsToTilt.Count : 0);
		}
		catch
		{
			return fmt;
		}
	}

	public override string GetWinMessageID()
	{
		return !string.IsNullOrEmpty(WinMessageLocalizationId) ? WinMessageLocalizationId : "ID_WIN_MESSAGE_CHALLENGE";
	}
}
