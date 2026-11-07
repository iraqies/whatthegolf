using System;
using System.Collections.Generic;
using Audio;
using UnityEngine;

public class ArmBowlingBallWhenThrown : MonoBehaviour, IAudioEvent
{
	public ParticleSystem Explosion;

	public float Timer;

	public float Range;

	public float RangeMobile;

	public float Power;

	public float UpFactor;

	public List<AudioClip> Clips;

	public float Volume;

	public float VolumeDeviance;

	public AudioSource FuseSource;

	public ParticleSystem FuseParticles;

	public int AffectedPinsStandalone;

	public int AffectedPinsMobile;

	public List<string> ExplodeWhenHittingTags;

	private Rigidbody rigid;

	private bool armed;

	private float timer;

	private List<Rigidbody> affectedRigidbodies;

	private Collider[] collider;

	public Action<Vector3> OnAudioEvent { get; set; }

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void Explode()
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
