using Core;
using UnityEngine;

public class ParticlesOnlyWhenGrounded : MonoBehaviour
{
	private ParticleSystem.EmissionModule emissionModule;

	private GolfBallController golfBallController;

	private void Start()
	{
		golfBallController = GetComponentInParent<GolfBallController>();
		ParticleSystem ps = GetComponent<ParticleSystem>();
		if (ps != null)
			emissionModule = ps.emission;
	}

	private void Update()
	{
		if (golfBallController != null)
		{
			emissionModule.enabled = golfBallController.IsGrounded;
		}
	}
}
