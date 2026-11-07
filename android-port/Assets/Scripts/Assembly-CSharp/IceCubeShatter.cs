using Audio;
using UnityEngine;

public class IceCubeShatter : MonoBehaviour
{
	private ObjectShatter shatter;

	private ParticleSystem shatterParticles;

	[SerializeField]
	private int ParticlesOnBreak;

	[SerializeField]
	private float ShatterForce;

	[SerializeField]
	private AudioEventAsset sfxOnShatter;

	private void Awake()
	{
	}

	public void Shatter()
	{
	}
}
