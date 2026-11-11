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
		shatter = GetComponentInChildren<ObjectShatter>();
		shatterParticles = GetComponentInChildren<ParticleSystem>();
	}

	public void Shatter()
	{
		if (shatter != null)
		{
			shatter.transform.SetParent(null);
		}
		if (shatterParticles != null)
		{
			shatterParticles.Emit(ParticlesOnBreak);
		}
		if (shatter != null)
		{
			shatter.Shatter(Vector3.zero, ShatterForce, 3f, 1f, ForceMode.Impulse);
		}
		if (sfxOnShatter != null)
		{
			sfxOnShatter.Play(base.transform.position);
		}
		base.gameObject.SetActive(false);
	}
}
