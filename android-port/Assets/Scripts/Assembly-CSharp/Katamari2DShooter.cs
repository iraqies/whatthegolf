using Core;
using UnityEngine;

public class Katamari2DShooter : GolfBall2DShooterBase
{
	[SerializeField]
	public float minShootVelocity = 5f;

	[SerializeField]
	public float fullShootVelocity = 25f;

	[SerializeField]
	public float directionalSpin = 10f;

	public override void OnActivate()
	{
		base.OnActivate();
		if (rigidbodyC != null)
			rigidbodyC.isKinematic = false;
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
		StandardShoot(boost, 0f, minShootVelocity, fullShootVelocity, directionalSpin);
	}
}
