using Audio;
using Core;
using UnityEngine;

namespace TennisGolf
{
	public class TennisBombBall : TennisBall
	{
		public GameObject explosionPrefab;

		private ParticleSystem _explosion;

		public TennisOpponent tennisOpponent;

		public TennisPlayer tennisPlayer;

		public AudioEventAsset explosionSFX;

		public float explosionRange = 8f;

		public void Start()
		{
			if (explosionPrefab != null)
			{
				GameObject gameObject = Object.Instantiate(explosionPrefab);
				if (gameObject != null)
				{
					_explosion = gameObject.GetComponent<ParticleSystem>();
				}
			}
		}

		public override void CheckCollision(string collidingTag, GameObject hit)
		{
			if (hit == null || (tennisOpponent != null && hit == tennisOpponent.gameObject) || hit.transform.GetComponent<TennisBombBall>() != null)
			{
				return;
			}
			if (_explosion != null)
			{
				_explosion.transform.position = base.transform.position;
				_explosion.Play();
			}
			if (explosionSFX != null)
			{
				explosionSFX.Play(base.transform.position);
			}
			CheckPlayerDistance(base.transform.position);
			OnPlayerWon?.Invoke();
		}

		public void CheckPlayerDistance(Vector3 explosionPosition)
		{
			if (tennisPlayer != null && Vector3.Distance(tennisPlayer.transform.position, explosionPosition) < explosionRange && Level.Instance != null)
			{
				Level.Instance.Fail(true, true, null, 0f, true, "");
			}
		}
	}
}
