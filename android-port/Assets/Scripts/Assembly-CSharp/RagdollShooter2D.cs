using System.Collections.Generic;
using System.Linq;
using Core;
using UnityEngine;

public class RagdollShooter2D : GolfBall2DShooterBase
{
	public float Force = 25f;

	public Vector2 RandomRange = new Vector2(0.8f, 1.2f);

	public Rigidbody2D[] rigidbodies;

	public List<Rigidbody2D> blacklistRigidbodies;

	protected override void Awake()
	{
		base.Awake();
		var all = GetComponentsInChildren<Rigidbody2D>();
		if (blacklistRigidbodies != null && blacklistRigidbodies.Count > 0)
			rigidbodies = all.Where(r => !blacklistRigidbodies.Contains(r)).ToArray();
		else
			rigidbodies = all;
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (rigidbodies == null || rigidbodies.Length == 0)
			rigidbodies = GetComponentsInChildren<Rigidbody2D>();
		for (int i = 0; i < rigidbodies.Length; i++)
		{
			Rigidbody2D rb = rigidbodies[i];
			if (rb == null) continue;
			rb.isKinematic = false;
			rb.velocity = Vector2.zero;
			rb.angularVelocity = 0f;
			float rand = RandomRange.sqrMagnitude > 0.001f ? Random.Range(RandomRange.x, RandomRange.y) : 1f;
			Vector2 b2 = new Vector2(boost.x, boost.y);
			if (b2.sqrMagnitude < 1e-4f) b2 = new Vector2(boost.x, boost.z);
			rb.AddForce(b2 * rand * (Force > 0f ? Force : 25f), ForceMode2D.Impulse);
		}
	}
}
