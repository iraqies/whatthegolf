using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class Fan : MonoBehaviour
{
	public float SphereCastRadius;

	public float SphereCastDistance;

	public BoxCollider EffectTrigger;

	public float MaxForce;

	public bool CheckForTimeline;

	public bool OnlyAddTimelines;

	public HashSet<Rigidbody> affectedObjects;

	public HashSet<Timeline> affectedTimelines;

	public ForceMode ForceMode;

	public bool IsOn;

	public bool ForceDependsOnDistance;

	private RotateAxis rotator;

	private float rotatorSpeed;

	private float rotatorSpeedTarget;

	private ParticleSystem particles;

	private AudioSource Source;

	private float baseVolume;

	private float startEmission;

	[SerializeField]
	private bool shouldOverrideForceDirection;

	[SerializeField]
	private Vector3 overrideForceDirection;

	private Vector3 forceDirection => default;

	private void Awake()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void FixedUpdate()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void Toggle()
	{
	}

	public void Toggle(bool state)
	{
	}
}
