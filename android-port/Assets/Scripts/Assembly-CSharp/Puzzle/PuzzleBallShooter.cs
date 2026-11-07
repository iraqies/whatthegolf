using UnityEngine;

namespace Puzzle
{
	public class PuzzleBallShooter : MonoBehaviour
	{
		public PuzzleBall ball;

		public Transform shootPoint;

		private float lastShootTime;

		private OverworldBall2D overworldBall;

		private bool ignoringCollision;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void TryShoot()
		{
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}
	}
}
