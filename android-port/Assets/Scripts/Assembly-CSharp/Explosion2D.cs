using UnityEngine;

public class Explosion2D : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem smokeRingSystem;

	[SerializeField]
	private ParticleSystem aftersmokeSystem;

	[SerializeField]
	private ParticleSystem fireballsSystem;

	[SerializeField]
	private Transform explosionContainer;

	[SerializeField]
	private Animator animator;

	public void Explode(float magnitude)
	{
	}

	public void FireRingParticles()
	{
	}

	public void StartAftersmoke()
	{
	}
}
