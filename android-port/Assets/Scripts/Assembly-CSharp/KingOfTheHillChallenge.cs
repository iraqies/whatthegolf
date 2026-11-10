using System.Collections.Generic;
using Core;

public class KingOfTheHillChallenge : Challenge
{
	public List<ChallengeAIRoller> enemies;

	protected override void Activate()
	{
		if (enemies != null)
		{
			foreach (var e in enemies)
			{
				if (e == null || e.gameObject == null) continue;
				var trig = e.gameObject.AddComponent<OutOfBoundsTrigger>();
				trig.OnOutOfBounds += OnOnOutOfBounds;
			}
			if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null)
			{
				LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(enemies.Count, StrokeCounter.CounterTypes.CardsAppearing, true);
			}
		}
	}

	private void OnOnOutOfBounds(OutOfBoundsTrigger obj)
	{
		if (obj == null) return;
		var roller = obj.GetComponent<ChallengeAIRoller>();
		if (enemies != null)
		{
			enemies.Remove(roller);
		}
		Destroy(obj.gameObject);
		if (LevelManager.Exists && LevelManager.Instance != null && LevelManager.Instance.InGameMenu != null && enemies != null)
		{
			LevelManager.Instance.InGameMenu.SetStrokeCounterSettings(enemies.Count, StrokeCounter.CounterTypes.CardsAppearing, true);
		}
		if (enemies != null && enemies.Count <= 0)
		{
			Complete();
		}
	}
}
