using System.Collections;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleSwitchOnStay : PuzzleSwitchBase
	{
		public bool continuousTrigger;

		public float velocityDamp;

		private const float time = 0.2f;

		private void OnCollisionEnter2D(Collision2D collision)
		{
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
		}

		private void OnTriggerStay2D(Collider2D collision)
		{
		}

		private void OnCollisionStay2D(Collision2D collision)
		{
		}

		private void OnCollisionExit2D(Collision2D collision)
		{
		}

		private void OnTriggerExit2D(Collider2D other)
		{
		}

		private void OnObjectAnyTrigger(GameObject go, bool active)
		{
		}

		private IEnumerator DampenVelocity(Rigidbody2D rb)
		{
			return null;
		}
	}
}
