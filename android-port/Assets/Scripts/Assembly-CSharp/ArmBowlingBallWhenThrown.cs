using System;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class ArmBowlingBallWhenThrown : MonoBehaviour, IAudioEvent
{
	public ParticleSystem Explosion;

	public float Timer;

	public float Range;

	public float RangeMobile;

	public float Power;

	public float UpFactor = 0.3f;

	public List<AudioClip> Clips;

	public float Volume = 0.35f;

	public float VolumeDeviance = 0.07f;

	public AudioSource FuseSource;

	public ParticleSystem FuseParticles;

	public int AffectedPinsStandalone = 500;

	public int AffectedPinsMobile = 100;

	public List<string> ExplodeWhenHittingTags;

	private Rigidbody rigid;

	private bool armed;

	private float timer;

	private List<Rigidbody> affectedRigidbodies;

	private Collider[] collider;

	public Action<Vector3> OnAudioEvent { get; set; }

	private void Awake()
	{
		rigid = GetComponent<Rigidbody>();
		collider = new Collider[PlatformSettings.IsMobile ? AffectedPinsMobile : AffectedPinsStandalone];
		affectedRigidbodies = new List<Rigidbody>(collider.Length);
	}

	private void Update()
	{
		if (!rigid.isKinematic)
		{
			if (!FuseSource.isPlaying)
			{
				FuseParticles.Play();
				FuseSource.Play();
			}
			timer += Time.deltaTime;
			if (timer >= Timer)
			{
				Explode();
			}
		}
	}

	private void Explode()
	{
		OnAudioEvent?.Invoke(base.transform.position);
		Explosion.transform.SetParent(null);
		Explosion.Play();
		Physics.OverlapSphereNonAlloc(base.transform.position, Range, collider);
		for (int i = 0; i < collider.Length; i++)
		{
			Collider collider = this.collider[i];
			if (collider != null && collider.attachedRigidbody != null && !collider.attachedRigidbody.isKinematic && !affectedRigidbodies.Contains(collider.attachedRigidbody))
			{
				collider.attachedRigidbody.AddExplosionForce(Power, base.transform.position, Range, UpFactor);
				affectedRigidbodies.Add(collider.attachedRigidbody);
			}
		}
		AudioManager.Instance.shortEffects.Play(Clips, delegate(AudioSource s)
		{
			s.transform.position = base.transform.position;
			s.volume = UnityEngine.Random.Range(Volume - VolumeDeviance, Volume + VolumeDeviance);
			s.pitch = UnityEngine.Random.Range(0.9f, 1.1f);
		});
		CameraManager.Instance.Shake(0.5f, 20f, 2f);
		timer = float.NegativeInfinity;
		UnityEngine.Object.Destroy(base.gameObject);
		this.collider = null;
		affectedRigidbodies.Clear();
	}

	private void OnCollisionEnter(Collision other)
	{
		if (ExplodeWhenHittingTags.Contains(other.gameObject.tag))
		{
			Explode();
		}
	}

	private void OnDrawGizmosSelected()
	{
		Gizmos.DrawWireSphere(base.transform.position, PlatformSettings.IsMobile ? RangeMobile : Range);
	}
}
