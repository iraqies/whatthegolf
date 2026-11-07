using System.Collections.Generic;
using Core;
using UnityEngine;

public class GolfManyThingsShooter : GolfBallShooterExperimental
{
	public List<Rigidbody> AdditionalThings;

	public Vector2 RandomForceMod;

	public override void OnShoot(Vector3 boost)
	{
	}
}
