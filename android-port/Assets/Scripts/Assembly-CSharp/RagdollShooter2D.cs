using System.Collections.Generic;
using Core;
using UnityEngine;

public class RagdollShooter2D : GolfBall2DShooterBase
{
	public float Force;

	public Vector2 RandomRange;

	public Rigidbody2D[] rigidbodies;

	public List<Rigidbody2D> blacklistRigidbodies;

	protected override void Awake()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
	}
}
