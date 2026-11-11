using UnityEngine;

namespace Puzzle
{
	public class PuzzleBallModifier : MonoBehaviour
	{
		public float speedChange = 5f;

		public SpriteRenderer shadowSprite;

		public Transform iconParent;

		private Collider2D col;

		private PuzzleBall puzzleBall;

		private bool hasInitializedBall;

		private bool hit;

		private void Awake()
		{
			col = GetComponent<Collider2D>();
			if (col != null)
			{
				col.isTrigger = true;
			}
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision == null)
			{
				return;
			}
			PuzzleBall ball = collision.GetComponent<PuzzleBall>();
			if (ball == null)
			{
				return;
			}
			if (!hasInitializedBall)
			{
				puzzleBall = ball;
				SubscribeToBall(ball);
				hasInitializedBall = true;
			}
			if (!hit)
			{
				HandlePower(ball);
				hit = true;
				if (iconParent != null)
				{
					iconParent.gameObject.SetActive(false);
				}
				if (shadowSprite != null)
				{
					shadowSprite.enabled = false;
				}
			}
		}

		private void HandlePower(PuzzleBall ball)
		{
			if (ball != null)
			{
				ball.AddSpeed(speedChange);
			}
		}

		private void SubscribeToBall(PuzzleBall ball)
		{
			if (ball != null)
			{
				puzzleBall = ball;
				ball.OnBallReset += ResetPowerup;
			}
		}

		private void ResetPowerup()
		{
			if (iconParent != null)
			{
				iconParent.gameObject.SetActive(true);
			}
			if (shadowSprite != null)
			{
				shadowSprite.enabled = true;
			}
			hit = false;
		}
	}
}
