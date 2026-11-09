using System.Collections.Generic;
using Core;
using UnityEngine;

public class GolfManyThingsShooter : GolfBallShooterExperimental
{
	public List<Rigidbody> AdditionalThings;

	public Vector2 RandomForceMod = new Vector2(0.8f, 1.2f);

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		if (AdditionalThings != null)
		{
			for (int i = 0; i < AdditionalThings.Count; i++)
			{
				var rb = AdditionalThings[i];
				if (rb == null) continue;
				rb.isKinematic = false;
				float rand = RandomForceMod.sqrMagnitude > 0.001f ? Random.Range(RandomForceMod.x, RandomForceMod.y) : 1f;
				float speed = Mathf.Lerp(minShootVelocity, fullShootVelocity, boost.magnitude) * rand;
				Vector3 dir = boost.normalized;
				Vector3 axis = Vector3.Cross(boost, Vector3.up);
				if (axis.sqrMagnitude > 1e-6f)
					dir = (Quaternion.AngleAxis(pitch, axis) * boost).normalized;
				rb.velocity = dir * speed;
			}
		}
	}
}
