using System.Collections.Generic;
using Audio;
using UnityEngine;

public class PoleVaultFailOnCollision : MonoBehaviour
{
	public ImpactUser impactSfx;

	public List<Joint> JointsToDestroy;

	public LayerMask CollisionLayer;

	public float FailLevelDelay;

	public ClipSettingsCollection FailClip;

	public bool AddExplosiveForce;

	public float ExplosionForce;

	public float ExplosionRadius;

	public float Upwards;

	private bool hasFailed;

	private void OnCollisionEnter(Collision other)
	{
	}
}
