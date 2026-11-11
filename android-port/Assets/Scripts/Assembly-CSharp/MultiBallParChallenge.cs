using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class MultiBallParChallenge : Challenge
{
	public int ScoreToBeat;

	private List<GolfBallController> controllers;

	private int strokeCount;

	protected override void Activate()
	{
		CompleteOnHoleComplete = false;
		controllers = Object.FindObjectsOfType<GolfBallController>().ToList();
		OutOfBoundsDestroyer destroyer = Object.FindObjectOfType<OutOfBoundsDestroyer>();
		if (destroyer != null)
		{
			destroyer.OnObjectDestroyed += OnObjectDestroyed;
		}
		if (controllers != null && controllers.Count > 0 && controllers[0] != null)
		{
			controllers[0].OnShoot += OnShoot;
		}
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(ScoreToBeat, true, true, false);
		}
	}

	private void OnObjectDestroyed(GameObject obj)
	{
		if (obj == null)
		{
			return;
		}
		GolfBallController gbc = obj.GetComponent<GolfBallController>();
		if (gbc != null && controllers != null)
		{
			if (controllers.Count > 0 && controllers[0] == gbc)
			{
				gbc.OnShoot -= OnShoot;
				controllers.Remove(gbc);
				if (controllers.Count >= 1 && controllers[0] != null)
				{
					controllers[0].OnShoot += OnShoot;
				}
			}
			else
			{
				controllers.Remove(gbc);
			}
		}
		if (controllers != null && controllers.Count == 0)
		{
			Fail();
		}
	}

	public override string GetDescription()
	{
		if (string.IsNullOrEmpty(DescriptionLocalizationID))
		{
			DescriptionLocalizationID = "CHALLENGE_PAR";
		}
		if (Localization.Instance != null)
		{
			return string.Format(Localization.Instance.GetString(DescriptionLocalizationID), ScoreToBeat);
		}
		return string.Format(DescriptionLocalizationID, ScoreToBeat);
	}

	private void OnShoot(Vector3 vector3)
	{
		strokeCount++;
		if (LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null && controllers != null && controllers.Count > 0)
		{
			LevelManager.Instance.InGameMenu.CountStroke(controllers[0], strokeCount);
		}
		if (controllers != null && controllers.Count > 0 && controllers[0] != null)
		{
			if (controllers[0].NumberOfStrokes + 1 > ScoreToBeat)
			{
				Fail();
			}
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (completedState == null)
		{
			return;
		}
		if (completedState.NumberOfStrokes > ScoreToBeat)
		{
			Fail();
		}
		else
		{
			completedState.VictoryMessage = "CROWN!";
			completedState.VictoryDuration = 2f;
			completedState.IsChallengeCompleted = true;
			Complete();
		}
	}
}
