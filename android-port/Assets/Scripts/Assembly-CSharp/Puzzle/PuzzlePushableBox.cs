using UnityEngine;

namespace Puzzle
{
	public class PuzzlePushableBox : PuzzleObjectBase
	{
		public float speed;

		public LayerMask layerMask;

		private Rigidbody2D rb;

		private Vector2 newPos;

		private Vector2 resolveTo;

		private bool resolveCollision;

		private void Awake()
		{
		}

		public override void ResetObject()
		{
		}

		private void FixedUpdate()
		{
		}

		private void LateUpdate()
		{
		}

		private bool AnyHit(Vector2 _dir)
		{
			return false;
		}

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}
	}
}
