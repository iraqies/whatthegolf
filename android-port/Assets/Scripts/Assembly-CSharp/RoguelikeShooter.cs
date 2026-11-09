using System.Collections.Generic;
using Core;
using UnityEngine;

public class RoguelikeShooter : GolfBallShooterExperimental
{
	public List<GameObject> HealthIcons;

	public ParticleSystem HeartBreakParticles;

	public LayerMask HitLayers;

	public float StepSize;

	private void Start()
	{
	}

	public override void OnShoot(Vector3 boost)
	{
		base.OnShoot(boost);
	}

	public void TakeDamage()
	{
	}
}
