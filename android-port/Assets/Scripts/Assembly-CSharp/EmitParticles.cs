using UnityEngine;

public class EmitParticles : MonoBehaviour
{
	public ParticleSystem particles;

	public int amount = 5;

	public void Emit()
	{
		if (particles == null)
			particles = GetComponent<ParticleSystem>();
		if (particles != null)
			particles.Emit(amount);
	}
}
