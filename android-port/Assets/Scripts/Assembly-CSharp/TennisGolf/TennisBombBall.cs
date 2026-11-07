using Audio;
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

		public float explosionRange;

		public void Start()
		{
		}

		public override void CheckCollision(string collidingTag, GameObject hit)
		{
		}

		public void CheckPlayerDistance(Vector3 explosionPosition)
		{
		}
	}
}
