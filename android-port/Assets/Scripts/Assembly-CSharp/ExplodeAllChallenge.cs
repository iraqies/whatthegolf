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
	}

	private void B_OnExplode(Collider2D obj)
	{
	}

	private void OnExplode3D(Collider arg1, ExplosionBarrel arg2)
	{
	}

	private void CheckCompletion()
	{
	}
}
