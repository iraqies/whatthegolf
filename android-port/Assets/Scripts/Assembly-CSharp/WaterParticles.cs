using UnityEngine;

public class WaterParticles : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other == null) return;
		Bounds b = other.bounds;
		float size = b.size.x * b.size.z;
		if (size < 1.2f)
		{
			Effects.EmitWaterSplash(other.transform.position, 25);
			return;
		}
		int count = (int)Mathf.Min(100f, size * 20f);
		for (int i = 0; i < count; i++)
		{
			Vector3 pos = other.transform.position + new Vector3(
				Random.Range(-b.extents.x, b.extents.x),
				0f,
				Random.Range(-b.extents.z, b.extents.z));
			Effects.EmitWaterSplash(pos, 1);
		}
	}
}
