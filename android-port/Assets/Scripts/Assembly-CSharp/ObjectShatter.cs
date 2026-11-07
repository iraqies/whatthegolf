using System;
using Chronos;
using UnityEngine;

public class ObjectShatter : MonoBehaviour
{
	public bool UseTimelines;

	public bool UnparentAllRigidbodies;

	private RigidbodyTimeline3D[] rigidbodiesTimeline;

	private Rigidbody[] rigidbodies;

	private bool hasShattered;

	private void Start()
	{
	}

	private void Toggle(bool isEnabled, Action<RigidbodyTimeline3D> doToRigid = null)
	{
	}

	private void ToggleRagdolls(bool isEnabled, Action<Rigidbody> doToRigid = null)
	{
	}

	public void Shatter(Vector3 impactPoint, float force, float explosionRadius, float upwardsModifier, ForceMode forceMode)
	{
	}
}
