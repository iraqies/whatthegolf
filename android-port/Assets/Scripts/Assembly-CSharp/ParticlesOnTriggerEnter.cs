using UnityEngine;

public class ParticlesOnTriggerEnter : MonoBehaviour
{
	public ParticleSystem system;

	public int emitAmount = 50;

	public bool placeInRoot = true;

	private void Start()
	{
		if (placeInRoot && system != null)
		{
			system.transform.parent = null;
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (system != null)
		{
			system.Emit(emitAmount);
		}
	}
}
