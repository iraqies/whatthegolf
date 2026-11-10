using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class Fan2D : MonoBehaviour, IToggleable
{
	public float SphereCastRadius = 1f;

	public float SphereCastDistance = 10f;

	public BoxCollider2D EffectTrigger;

	public float MaxForce = 100f;

	public bool CheckForTimeline;

	private bool isOn = true;

	private RotateAxis rotator;

	private float rotatorSpeed;

	private float rotatorSpeedTarget;

	private ParticleSystem particles;

	public List<Rigidbody2D> affectedObjects = new List<Rigidbody2D>();

	public List<Timeline> affectedTimelines = new List<Timeline>();

	public bool IsOn
	{
		get => isOn;
		set => Toggle(value);
	}

	private void Start()
	{
		rotator = GetComponentInChildren<RotateAxis>();
		if (rotator != null)
		{
			rotatorSpeed = rotator.rotateSpeed;
			rotatorSpeedTarget = rotatorSpeed;
		}
		particles = GetComponentInChildren<ParticleSystem>();
		if (EffectTrigger != null)
		{
			EffectTrigger.size = new Vector2(SphereCastRadius * 2f, SphereCastDistance);
			EffectTrigger.offset = new Vector2(0f, SphereCastDistance * 0.5f);
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null)
			return;
		Rigidbody2D rb = other.attachedRigidbody;
		if (rb != null)
		{
			if (CheckForTimeline)
			{
				Timeline tl = rb.GetComponent<Timeline>();
				if (tl != null && !affectedTimelines.Contains(tl))
					affectedTimelines.Add(tl);
			}
			if (!affectedObjects.Contains(rb))
				affectedObjects.Add(rb);
		}
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		if (other == null)
			return;
		Rigidbody2D rb = other.attachedRigidbody;
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
		if (!isOn)
			return;
		Vector2 up = transform.up;
		if (CheckForTimeline && affectedTimelines != null)
		{
			for (int i = affectedTimelines.Count - 1; i >= 0; i--)
			{
				Timeline tl = affectedTimelines[i];
				if (tl == null)
				{
					affectedTimelines.RemoveAt(i);
					continue;
				}
				if (tl.rigidbody2D != null)
					tl.rigidbody2D.AddForce(up * MaxForce * Time.fixedDeltaTime, ForceMode2D.Force);
			}
			return;
		}
		if (affectedObjects == null)
			return;
		for (int j = affectedObjects.Count - 1; j >= 0; j--)
		{
			Rigidbody2D rb = affectedObjects[j];
			if (rb == null)
			{
				affectedObjects.RemoveAt(j);
				continue;
			}
			rb.AddForce(up * MaxForce * Time.fixedDeltaTime, ForceMode2D.Force);
		}
	}

	private void Update()
	{
		if (rotator != null)
		{
			rotator.rotateSpeed = Mathf.MoveTowards(rotator.rotateSpeed, isOn ? rotatorSpeedTarget : 0f, Time.deltaTime * 500f);
		}
	}

	private void OnDrawGizmosSelected()
	{
	}

	public void Toggle(bool state)
	{
		isOn = state;
		if (particles != null)
		{
			var emission = particles.emission;
			emission.enabled = isOn;
		}
	}

	public void Toggle()
	{
		Toggle(!isOn);
	}
}
