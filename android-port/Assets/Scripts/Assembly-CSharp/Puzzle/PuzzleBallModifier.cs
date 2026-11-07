using UnityEngine;

namespace Puzzle
{
	public class PuzzleBallModifier : MonoBehaviour
	{
		public float speedChange;

		public SpriteRenderer shadowSprite;

		public Transform iconParent;

		private Collider2D col;

		private PuzzleBall puzzleBall;

		private bool hasInitializedBall;

		private bool hit;

		private void Awake()
		{
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		private void HandlePower(PuzzleBall ball)
		{
		}

		private void SubscribeToBall(PuzzleBall ball)
		{
		}

		private void ResetPowerup()
		{
		}
	}
}
