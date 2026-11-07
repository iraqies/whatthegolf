using UnityEngine;

public class PlayerBallHitByCrab : MonoBehaviour
{
	public BeachBallWithAvatarController Owner;

	public FinalLevel FinalLevel;

	public ParticleSystem HitParticles;

	public CrabsController CrabController;

	public Animator playerAnimator;

	private void OnCollisionEnter(Collision other)
	{
	}
}
