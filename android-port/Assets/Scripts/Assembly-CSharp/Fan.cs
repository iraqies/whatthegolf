using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class Fan : MonoBehaviour
{
	public float SphereCastRadius = 1f;

	public float SphereCastDistance = 10f;

	public BoxCollider EffectTrigger;

	public float MaxForce = 100f;

	public bool CheckForTimeline;

	public bool OnlyAddTimelines;

	public HashSet<Rigidbody> affectedObjects = new HashSet<Rigidbody>();

	public HashSet<Timeline> affectedTimelines = new HashSet<Timeline>();

	public ForceMode ForceMode;

	public bool IsOn = true;

	public bool ForceDependsOnDistance = true;

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

	private Vector3 forceDirection => shouldOverrideForceDirection ? overrideForceDirection.normalized : transform.up;

	private void Awake()
	{
		Source = GetComponent<AudioSource>();
		if (Source != null)
			baseVolume = Source.volume;
		rotator = GetComponentInChildren<RotateAxis>();
		if (rotator != null)
		{
			rotatorSpeed = rotator.rotateSpeed;
			rotatorSpeedTarget = rotatorSpeed;
		}
		particles = GetComponentInChildren<ParticleSystem>();
		if (particles != null)
			startEmission = particles.emission.rateOverTime.constant;
		if (EffectTrigger != null)
		{
			EffectTrigger.size = new Vector3(SphereCastRadius * 2f, SphereCastDistance, SphereCastRadius * 2f);
			EffectTrigger.center = new Vector3(0f, SphereCastDistance * 0.5f, 0f);
		}
		Toggle(IsOn);
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other == null)
			return;
		Rigidbody rb = other.attachedRigidbody;
		if (rb != null)
		{
			if (CheckForTimeline)
			{
				Timeline tl = rb.GetComponent<Timeline>();
				if (tl != null)
					affectedTimelines.Add(tl);
				if (OnlyAddTimelines)
					return;
			}
			affectedObjects.Add(rb);
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other == null)
			return;
		Rigidbody rb = other.attachedRigidbody;
		if (rb != null)
		{
			if (CheckForTimeline)
			{
				Timeline tl = rb.GetComponent<Timeline>();
				if (tl != null)
					affectedTimelines.Remove(tl);
			}
			affectedObjects.Remove(rb);
		}
	}

	private void FixedUpdate()
	{
		if (!IsOn)
			return;
		Vector3 dir = forceDirection;
		Vector3 origin = transform.position;
		if (CheckForTimeline && affectedTimelines != null)
		{
			foreach (Timeline tl in affectedTimelines)
			{
				if (tl == null || tl.rigidbody3D == null)
					continue;
				float factor = 1f;
				if (ForceDependsOnDistance && SphereCastDistance > 0.001f)
				{
					float dist = Vector3.Distance(origin, tl.transform.position);
					factor = Mathf.Clamp01(1f - dist / SphereCastDistance);
				}
				tl.rigidbody3D.AddForce(dir * (MaxForce * factor * Time.fixedDeltaTime), ForceMode);
			}
			if (OnlyAddTimelines)
				return;
		}
		if (affectedObjects == null)
			return;
		foreach (Rigidbody rb in affectedObjects)
		{
			if (rb == null)
				continue;
			float factor = 1f;
			if (ForceDependsOnDistance && SphereCastDistance > 0.001f)
			{
				float dist = Vector3.Distance(origin, rb.transform.position);
				factor = Mathf.Clamp01(1f - dist / SphereCastDistance);
			}
			rb.AddForce(dir * (MaxForce * factor * Time.fixedDeltaTime), ForceMode);
		}
	}

	private void Update()
	{
		if (rotator != null)
			rotator.rotateSpeed = Mathf.MoveTowards(rotator.rotateSpeed, IsOn ? rotatorSpeedTarget : 0f, Time.deltaTime * 500f);
		if (Source != null)
			Source.volume = Mathf.MoveTowards(Source.volume, IsOn ? baseVolume : 0f, Time.deltaTime * 2f);
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void Toggle()
	{
		Toggle(!IsOn);
	}

	public void Toggle(bool state)
	{
		IsOn = state;
		if (particles != null)
		{
			var emission = particles.emission;
			emission.rateOverTime = IsOn ? startEmission : 0f;
		}
	}
}
