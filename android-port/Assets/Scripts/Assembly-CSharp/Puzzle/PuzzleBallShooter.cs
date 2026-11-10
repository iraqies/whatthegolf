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
			if (ball != null && ball.gameObject != null)
			{
				ball.gameObject.SetActive(false);
			}
		}

		private void Update()
		{
			if (ignoringCollision && Time.time > lastShootTime + 0.2f && ball != null)
			{
				Collider2D c1 = GetComponent<Collider2D>();
				Collider2D c2 = ball.GetComponent<Collider2D>();
				if (c1 != null && c2 != null)
				{
					Physics2D.IgnoreCollision(c1, c2, false);
				}
			}
		}

		private void TryShoot()
		{
			if (ball == null || ball.gameObject == null || ball.gameObject.activeSelf)
				return;
			ignoringCollision = true;
			ball.gameObject.SetActive(true);
			Collider2D c1 = GetComponent<Collider2D>();
			Collider2D c2 = ball.GetComponent<Collider2D>();
			if (c1 != null && c2 != null)
			{
				Physics2D.IgnoreCollision(c1, c2, true);
			}
			if (shootPoint != null)
			{
				ball.transform.position = shootPoint.position;
			}
			Vector3 up = transform.up;
			ball.Shoot(new Vector2(up.x, up.y));
			lastShootTime = Time.time;
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision == null || collision.collider == null)
				return;
			overworldBall = collision.collider.GetComponent<OverworldBall2D>();
			if (overworldBall != null)
			{
				TryShoot();
			}
			if (ball != null && collision.gameObject == ball.gameObject)
			{
				ball.gameObject.SetActive(false);
			}
		}
	}
}
