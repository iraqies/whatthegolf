using System.Collections.Generic;
using Audio;
using UnityEngine;

public class HammerHitEffect : MonoBehaviour
{
	public Transform HitPosition;

	public float HitRadius;

	public WhackAMoleController Controller;

	public ClipSettingsCollection MissClip;

	public ClipSettingsCollection HitClip;

	public float Duration;

	public float Speed;

	public float Magnitude;

	public ParticleSystem DustParticles;

	public ParticleSystem HoleParticles;

	public ParticleSystem CrackParticles;

	public ParticleSystem DirtParticles;

	private List<HoleToWhack> holes;

	private void Awake()
	{
	}

	public void Hit()
	{
	}
}
