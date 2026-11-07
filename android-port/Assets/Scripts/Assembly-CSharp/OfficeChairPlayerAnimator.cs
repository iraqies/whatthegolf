using UnityEngine;

public class OfficeChairPlayerAnimator : MonoBehaviour
{
	public Animator Animator;

	public SuperGolfShooter Controller;

	public float HardThrowThreshold;

	private void Start()
	{
	}

	private void OnWeaponPickUp(SuperGolfGun obj)
	{
	}

	public void OnDeath(SuperGolfShooter obj)
	{
	}

	private void OnPlayerShot(SuperGolfGun gun, Vector3 boost)
	{
	}
}
