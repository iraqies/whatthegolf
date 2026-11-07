using System;
using Audio;
using UnityEngine;

public class PoloRing : MonoBehaviour
{
	public Animator FlagAnimator;

	public ParticleSystem Particles;

	public Joint Joint;

	public ClipSettingsCollection HitClip;

	public Action<PoloRing> OnRingHit;

	private bool hasBeenHit;

	private void OnTriggerEnter(Collider other)
	{
	}
}
