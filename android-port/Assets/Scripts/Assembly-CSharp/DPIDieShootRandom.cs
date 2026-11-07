using UnityEngine;

public class DPIDieShootRandom : BaseDailyPrizeInteractions
{
	public Rigidbody dieRb;

	public float forceMultiplier;

	private Vector3 randomVector;

	public override void OnShootNotWrapped(Vector3 b)
	{
	}
}
