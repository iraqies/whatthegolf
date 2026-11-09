using UnityEngine;

public class PoolWaterParticles : MonoBehaviour
{
	public ParticleSystem splashEffect;

	public Transform topPoolPlane;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || splashEffect == null || topPoolPlane == null) return;
		Bounds b = other.bounds;
		int count = (int)Mathf.Min(100f, b.size.x * b.size.z * 20f);
		for (int i = 0; i < count; i++)
		{
			Vector3 pos = new Vector3(
				other.transform.position.x + Random.Range(-b.extents.x, b.extents.x),
				topPoolPlane.position.y,
				other.transform.position.z + Random.Range(-b.extents.z, b.extents.z));
			splashEffect.transform.position = pos;
			splashEffect.Emit(1);
		}
	}
}
