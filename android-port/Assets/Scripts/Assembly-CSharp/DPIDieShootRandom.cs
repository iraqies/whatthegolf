using UnityEngine;

public class DPIDieShootRandom : BaseDailyPrizeInteractions
{
	public Rigidbody dieRb;

	public float forceMultiplier = 1f;

	private Vector3 randomVector;

	public override void OnShootNotWrapped(Vector3 b)
	{
		if (dieRb == null)
			return;

		if (dieRb.transform.localPosition.y > 4.5f)
			return;

		randomVector = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
		float mag = b.magnitude;
		dieRb.AddForce(b * 10f + Vector3.up * (mag * 50f * forceMultiplier), ForceMode.VelocityChange);
		dieRb.AddTorque(randomVector * mag, ForceMode.VelocityChange);
	}
}
