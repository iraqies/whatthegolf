using UnityEngine;

public class EmitParticles : MonoBehaviour
{
	public int particleCount;

	public int totalEmitCount;

	private ParticleSystem particles;

	private int currentCount;

	private void Start()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}
}
