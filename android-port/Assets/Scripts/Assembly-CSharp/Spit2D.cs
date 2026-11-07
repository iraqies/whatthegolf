using System;
using Audio;
using UnityEngine;

public class Spit2D : MonoBehaviour
{
	public Collider2D Collider;

	public Rigidbody2D Rigidbody;

	public Action OnHitGoal;

	public Action OnMissGoal;

	public LayerMask HitLayers;

	public Action OnReset;

	public ParticleSystem particleSystem;

	public RandomAudioClips hitclips;

	public Renderer MainSpitRenderer;

	public bool Initialized;

	private bool stuck;

	private void OnEnable()
	{
	}

	private void HitSomething(Collider2D hit)
	{
	}

	private void OnCollisionEnter2D(Collision2D col)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	public void EnteredPortal(PortalPackage package)
	{
	}
}
