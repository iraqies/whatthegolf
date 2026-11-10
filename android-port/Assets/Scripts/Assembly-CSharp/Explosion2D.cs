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
		if (explosionContainer != null)
		{
			explosionContainer.localScale = Vector3.one * Mathf.Max(0.25f, magnitude);
		}
		if (animator != null)
		{
			animator.SetTrigger("Explode");
		}
		if (fireballsSystem != null)
		{
			fireballsSystem.Play();
		}
		FireRingParticles();
		StartAftersmoke();
	}

	public void FireRingParticles()
	{
		if (smokeRingSystem != null)
		{
			smokeRingSystem.Play();
		}
	}

	public void StartAftersmoke()
	{
		if (aftersmokeSystem != null)
		{
			aftersmokeSystem.Play();
		}
	}
}
