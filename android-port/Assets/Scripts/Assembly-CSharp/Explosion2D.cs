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
			explosionContainer.localScale = new Vector3(magnitude, magnitude, magnitude);
		}
		if (animator != null)
		{
			animator.SetTrigger("Explode");
		}
		if (fireballsSystem != null)
		{
			fireballsSystem.Emit(5);
		}
	}

	public void FireRingParticles()
	{
		if (smokeRingSystem != null)
		{
			smokeRingSystem.Emit(50);
		}
		if (fireballsSystem != null)
		{
			fireballsSystem.Emit(5);
		}
	}

	public void StartAftersmoke()
	{
		if (aftersmokeSystem != null)
		{
			aftersmokeSystem.Play();
			var main = aftersmokeSystem.main;
			main.stopAction = ParticleSystemStopAction.Destroy;
		}
	}
}
