using Core;
using UnityEngine;

public class StartParticleSystemOnShoot : MonoBehaviour
{
	public GolfBallController controller;

	private ParticleSystem particles;

	private void Start()
	{
		particles = GetComponent<ParticleSystem>();
		if (controller == null)
			controller = GetComponentInParent<GolfBallController>();
		if (controller != null)
			controller.OnShoot += Controller_OnShoot;
	}

	private void Controller_OnShoot(Vector3 obj)
	{
		if (particles != null)
			particles.Play();
		if (controller != null)
			controller.OnShoot -= Controller_OnShoot;
		Destroy(this);
	}
}
