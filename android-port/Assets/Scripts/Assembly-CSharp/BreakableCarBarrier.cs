using Audio;
using UnityEngine;

public class BreakableCarBarrier : MonoBehaviour
{
	public Rigidbody[] toEnable;

	public Rigidbody[] toDisable;

	public float breakThreshold;

	public float breakExplosionRadius;

	public float breakExplosionForceFactor;

	public bool didBreak;

	public ClipSettingsCollection breakSFX;

	public ClipSettingsCollection impactSFX;

	private void OnCollisionEnter(Collision collision)
	{
	}
}
