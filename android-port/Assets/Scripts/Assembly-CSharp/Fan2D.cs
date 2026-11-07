using System.Collections.Generic;
using Chronos;
using UnityEngine;

public class Fan2D : MonoBehaviour, IToggleable
{
	public float SphereCastRadius;

	public float SphereCastDistance;

	public BoxCollider2D EffectTrigger;

	public float MaxForce;

	public bool CheckForTimeline;

	private bool isOn;

	private RotateAxis rotator;

	private float rotatorSpeed;

	private float rotatorSpeedTarget;

	private ParticleSystem particles;

	public List<Rigidbody2D> affectedObjects;

	public List<Timeline> affectedTimelines;

	public bool IsOn
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
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

	public void Toggle(bool state)
	{
	}

	public void Toggle()
	{
	}
}
