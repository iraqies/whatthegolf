using UnityEngine;

public class HubParticleTrigger : MonoBehaviour
{
	[SerializeField]
	private ParticleSystem _particleSystem;

	private static bool _hasBeenLoadedBefore;

	private void OnTriggerEnter2D(Collider2D other)
	{
		if (!_hasBeenLoadedBefore && other != null && (other.CompareTag("Ball") || other.CompareTag("Player") || other.GetComponentInParent<OverworldBall2D>() != null))
		{
			_hasBeenLoadedBefore = true;
			if (_particleSystem != null)
			{
				_particleSystem.Play();
			}
		}
	}
}
