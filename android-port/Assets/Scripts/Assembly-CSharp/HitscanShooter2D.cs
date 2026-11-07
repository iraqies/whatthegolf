using System.Collections.Generic;
using Core;
using UnityEngine;
using Utility;

public class HitscanShooter2D : GolfBall2DShooterBase
{
	public Transform ShootOrigin;

	public GameObject ProjectilePrefab;

	public Transform Torso;

	public List<BottleTarget> bottleTargets;

	public bool winOnAllTargetsHit;

	private ObjectPool<GameObject> projectiles;

	private void Start()
	{
	}

	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	public override void OnAimStart()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}

	private void OnTargetHit(IHitscanTarget obj)
	{
	}
}
