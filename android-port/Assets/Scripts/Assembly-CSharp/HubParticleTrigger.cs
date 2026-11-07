using UnityEngine;

public class HubParticleTrigger : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _particleSystem;

	private static bool _hasBeenLoadedBefore;

	private void OnTriggerEnter2D(Collider2D other)
	{
	}
}
