using UnityEngine;

public class Breakable : MonoBehaviour
{
	public Rigidbody[] pieces;

	public float breakThreshold;

	public float breakExplosionRadius;

	public float breakExplosionForceFactor;

	private void OnCollisionEnter(Collision collision)
	{
	}
}
