using UnityEngine;

public class ParticlesOnHit : MonoBehaviour
{
	public int particleCount = 15;

	public GameObject prefab;

	private ParticleSystem particles;

	private void Start()
	{
		if (prefab != null)
		{
			GameObject go = Instantiate(prefab, transform.position, Quaternion.identity);
			if (go != null)
				particles = go.GetComponent<ParticleSystem>();
		}
	}

	public void Hit(Vector3 position, Vector3 normal)
	{
		if (particles != null)
		{
			particles.transform.position = position;
			particles.transform.up = normal;
			particles.Emit(particleCount);
		}
	}
}
