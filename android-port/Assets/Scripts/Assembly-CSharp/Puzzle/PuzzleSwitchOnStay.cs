using System.Collections;
using UnityEngine;

namespace Puzzle
{
	public class PuzzleSwitchOnStay : PuzzleSwitchBase
	{
		public bool continuousTrigger;

		public float velocityDamp = 0.5f;

		private const float time = 0.2f;

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision != null)
			{
				OnObjectAnyTrigger(collision.gameObject, true);
			}
		}

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other == null)
			{
				return;
			}
			OnObjectAnyTrigger(other.gameObject, true);
			Rigidbody2D component = other.GetComponent<Rigidbody2D>();
			if (component != null && component.GetComponent<OverworldBall2D>() != null && velocityDamp > 0f)
			{
				StartCoroutine(DampenVelocity(component));
			}
		}

		private void OnTriggerStay2D(Collider2D collision)
		{
			if (continuousTrigger && collision != null)
			{
				OnObjectAnyTrigger(collision.gameObject, true);
			}
		}

		private void OnCollisionStay2D(UnityEngine.Collision2D collision)
		{
			if (continuousTrigger && collision != null)
			{
				OnObjectAnyTrigger(collision.gameObject, true);
			}
		}

		private void OnCollisionExit2D(Collision2D collision)
		{
			if (collision != null)
			{
				OnObjectAnyTrigger(collision.gameObject, false);
			}
		}

		private void OnTriggerExit2D(Collider2D other)
		{
			if (other != null)
			{
				OnObjectAnyTrigger(other.gameObject, false);
			}
		}

		private void OnObjectAnyTrigger(GameObject go, bool active)
		{
			if (go != null && (go.GetComponent<OverworldBall2D>() != null || go.GetComponent<OverworldPuzzleCollider>() != null))
			{
				TriggerObjects(active);
			}
		}

		private IEnumerator DampenVelocity(Rigidbody2D rb)
		{
			float t = 0.2f;
			while (t > 0f)
			{
				t -= Time.deltaTime;
				if (rb != null)
				{
					rb.velocity *= velocityDamp;
				}
				yield return null;
			}
		}
	}
}
