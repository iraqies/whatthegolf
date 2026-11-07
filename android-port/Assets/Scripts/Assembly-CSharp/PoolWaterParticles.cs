using UnityEngine;

public class PoolWaterParticles : MonoBehaviour
{
	public ParticleSystem splashParticles;

	public ParticleSystem ringParticles;

	public MinMax splashSizeRange;

	public MinMax ringSizeRange;

	private ParticleSystem.EmitParams splashParams;

	private ParticleSystem.EmitParams ringParams;

	private Transform root;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	public void DoSplash(Collider other)
	{
	}
}
