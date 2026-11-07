using UnityEngine;

public class StopParticlesOnTriggerEnter : MonoBehaviour
{
	public ParticleSystem particles;

	public bool onlyTriggerOnPlayerTag;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
