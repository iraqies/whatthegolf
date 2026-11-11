using UnityEngine;

public class OfficeChairPlayerAnimator : MonoBehaviour
{
	public Animator Animator;

	public SuperGolfShooter Controller;

	public float HardThrowThreshold = 0.5f;

	private void Start()
	{
		if (Controller != null)
		{
			Controller.OnShot += OnPlayerShot;
			Controller.OnWeaponPickUp += OnWeaponPickUp;
			Controller.OnDeath += OnDeath;
		}
	}

	private void OnWeaponPickUp(SuperGolfGun obj)
	{
		if (Animator != null)
		{
			Animator.SetBool("HasGun", true);
		}
	}

	public void OnDeath(SuperGolfShooter obj)
	{
		if (Animator != null)
		{
			Animator.SetTrigger("Death");
		}
	}

	private void OnPlayerShot(SuperGolfGun gun, Vector3 boost)
	{
		if (Animator == null)
		{
			return;
		}
		if (gun == null)
		{
			Animator.SetTrigger(boost.magnitude > HardThrowThreshold ? "ThrowHard" : "ThrowSoft");
		}
		else
		{
			Animator.SetBool("HasGun", false);
		}
	}
}
