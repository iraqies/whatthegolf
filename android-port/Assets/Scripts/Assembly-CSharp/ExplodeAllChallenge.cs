using System.Collections.Generic;
using Core;
using UnityEngine;

public class ExplodeAllChallenge : Challenge
{
	public List<ExplosionBarrel> explosionBarrels;

	public List<ExplosionBarrel2D> explosionBarrel2Ds;

	private int maxCount;

	private int explodedCount;

	private GolfBallController controller;

	protected override void Activate()
	{
		foreach (ExplosionBarrel explosionBarrel in explosionBarrels)
		{
			explosionBarrel.OnExplode += OnExplode3D;
			maxCount++;
		}
		foreach (ExplosionBarrel2D explosionBarrel2D in explosionBarrel2Ds)
		{
			explosionBarrel2D.OnExplode += B_OnExplode;
			maxCount++;
		}
		controller = Object.FindObjectOfType<GolfBallController>();
		AddressableSingleton<LevelManager>.Instance.InGameMenu.SetStrokeCounterSettings(maxCount, StrokeCounter.CounterTypes.ReverseCounting, true);
	}

	private void B_OnExplode(Collider2D obj)
	{
		CheckCompletion();
	}

	private void OnExplode3D(Collider arg1, ExplosionBarrel arg2)
	{
		CheckCompletion();
	}

	private void CheckCompletion()
	{
		explodedCount++;
		AddressableSingleton<LevelManager>.Instance.InGameMenu.CountStroke(controller, explodedCount);
		if (explodedCount >= maxCount)
		{
			Complete();
		}
	}
}
