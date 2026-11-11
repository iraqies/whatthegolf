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
		ExitLevelOnComplete = false;
		controllers = Object.FindObjectsOfType<GolfBallController>().ToList();
		ObjectDestroyTrigger objectDestroyTrigger = Object.FindObjectOfType<ObjectDestroyTrigger>();
		if (objectDestroyTrigger != null)
		{
			objectDestroyTrigger.onDestroyObject += OnObjectDestroyed;
		}
		if (controllers[0] != null)
		{
			controllers[0].OnShoot += OnShoot;
		}
		LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(ScoreToBeat, StrokeCounter.CounterTypes.CardsDisappearing, useExternalCountActivator: true);
	}

	private void OnObjectDestroyed(GameObject obj)
	{
		GolfBallController component = obj.GetComponent<GolfBallController>();
		if (component != null)
		{
			if (controllers[0] == component)
			{
				component.OnShoot -= OnShoot;
				controllers.Remove(component);
				if (controllers.Count >= 1)
				{
					controllers[0].OnShoot += OnShoot;
				}
			}
			else
			{
				controllers.Remove(component);
			}
		}
		if (controllers.Count == 0)
		{
			Fail();
		}
	}

	public override string GetDescription()
	{
		if (string.IsNullOrEmpty(DescriptionLocalizationId))
		{
			DescriptionLocalizationId = "ID_CHALLENGE_PAR_DESCRIPTION";
		}
		return string.Format(Localization.Instance.GetString(DescriptionLocalizationId), ScoreToBeat);
	}

	private void OnShoot(Vector3 vector3)
	{
		strokeCount++;
		LevelManager.Instance.InGameMenu.CountStroke(controllers[0], strokeCount);
		if (controllers[0].NumberOfStrokes + 1 > ScoreToBeat)
		{
			Fail();
		}
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
		if (completedState.Strokes > ScoreToBeat)
		{
			Fail();
			return;
		}
		completedState.Message = "ID_EMPTY_STRING";
		completedState.Delay = 2f;
		completedState.LeaveLevel = true;
		Complete();
	}
}
