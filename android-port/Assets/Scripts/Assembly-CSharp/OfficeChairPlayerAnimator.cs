using UnityEngine;

public class OfficeChairPlayerAnimator : MonoBehaviour
{
	public Animator Animator;

	public SuperGolfShooter Controller;

	public float HardThrowThreshold = 0.5f;

	private void Start()
	{
		Controller.OnPlayerShot += OnPlayerShot;
		Controller.OnWeaponPickUp += OnWeaponPickUp;
		Controller.OnDeath += OnDeath;
	}

	private void OnWeaponPickUp(SuperGolfGun obj)
	{
		Animator.SetBool("HoldingBall", value: true);
	}

	public void OnDeath(SuperGolfShooter obj)
	{
		Animator.SetTrigger("TakeDamage");
	}

	private void OnPlayerShot(SuperGolfGun gun, Vector3 boost)
	{
		if (gun == null)
		{
			Animator.SetTrigger((boost.magnitude > HardThrowThreshold) ? "ShootHeavy" : "ShootLight");
		}
		else
		{
			Animator.SetBool("HoldingBall", value: false);
		}
	}
}
