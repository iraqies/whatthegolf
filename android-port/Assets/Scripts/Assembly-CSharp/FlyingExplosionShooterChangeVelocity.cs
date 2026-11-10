using Core;
using UnityEngine;

public class FlyingExplosionShooterChangeVelocity : MonoBehaviour
{
	public float newMaxVelocity;

	private FlyingExplosionShooter explosionShooterScript;

	private void Start()
	{
		explosionShooterScript = GetComponent<FlyingExplosionShooter>();
	}

	public void ChangeVelocity()
	{
		if (explosionShooterScript != null)
		{
			explosionShooterScript.fullShootVelocity = newMaxVelocity;
		}
	}
}
