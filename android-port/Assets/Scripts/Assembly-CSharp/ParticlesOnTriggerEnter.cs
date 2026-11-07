using Audio;
using UnityEngine;

public class ParticlesOnTriggerEnter : MonoBehaviour
{
	public ParticleSystem particles;

	public ClipSettingsCollection sfx;

	public bool onlyTriggerOnPlayerTag;

	private void Start()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
