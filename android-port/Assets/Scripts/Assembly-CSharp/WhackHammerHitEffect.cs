using Audio;
using UnityEngine;

public class WhackHammerHitEffect : MonoBehaviour
{
	public Transform HitPosition;

	public float HitRadius;

	public WhackHammerController Controller;

	public ClipSettingsCollection MissClip;

	public ClipSettingsCollection HitClip;

	public float Duration;

	public float Speed;

	public float Magnitude;

	public ParticleSystem DustParticles;

	public ParticleSystem HoleParticles;

	public ParticleSystem CrackParticles;

	public ParticleSystem DirtParticles;

	public void Hit()
	{
	}
}
