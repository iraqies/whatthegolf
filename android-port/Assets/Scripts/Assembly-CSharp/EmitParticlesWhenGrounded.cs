using UnityEngine;

public class EmitParticlesWhenGrounded : MonoBehaviour
{
	public Transform positionOfEmitter;

	public float checkDistance = 0.25f;

	private ParticleSystem.EmissionModule emissionModule;

	private void Start()
	{
		ParticleSystem ps = GetComponent<ParticleSystem>();
		if (ps != null)
			emissionModule = ps.emission;
	}

	private void Update()
	{
		if (positionOfEmitter != null)
			transform.position = positionOfEmitter.position;
		emissionModule.enabled = Physics.Raycast(transform.position, Vector3.down, checkDistance, ~2048);
	}
}
