using Audio;
using UnityEngine;

public class BreakableCarBarrier : MonoBehaviour
{
	public Rigidbody[] toEnable;

	public Rigidbody[] toDisable;

	public float breakThreshold = 15f;

	public float breakExplosionRadius = 5f;

	public float breakExplosionForceFactor = 2f;

	public bool didBreak;

	public ClipSettingsCollection breakSFX;

	public ClipSettingsCollection impactSFX;

	private void OnCollisionEnter(Collision collision)
	{
		if (collision == null || didBreak)
		{
			return;
		}
		float impulseMag = collision.impulse.magnitude;
		if (impulseMag <= breakThreshold)
		{
			return;
		}
		if (breakSFX != null)
		{
			breakSFX.Play(base.transform.position, 1f, 1f);
		}
		if (impactSFX != null)
		{
			impactSFX.Play(base.transform.position, 1f, 1f);
		}
		if (toDisable != null)
		{
			for (int i = 0; i < toDisable.Length; i++)
			{
				if (toDisable[i] != null)
				{
					toDisable[i].gameObject.SetActive(false);
				}
			}
		}
		if (toEnable != null)
		{
			Vector3 contactPt = ((collision.contacts != null && collision.contacts.Length > 0) ? collision.contacts[0].point : base.transform.position);
			for (int j = 0; j < toEnable.Length; j++)
			{
				Rigidbody rb = toEnable[j];
				if (rb != null)
				{
					rb.gameObject.SetActive(true);
					rb.transform.SetParent(base.transform.parent);
					rb.AddExplosionForce(impulseMag * breakExplosionForceFactor, contactPt, breakExplosionRadius);
					rb.AddForce(Vector3.up * 20f, ForceMode.Impulse);
				}
			}
		}
		didBreak = true;
	}
}
