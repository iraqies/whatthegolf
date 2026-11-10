using Core;
using UnityEngine;

namespace GolfGames.Pinball
{
	public class Pinball : MonoBehaviour
	{
		public Transform StartPosition;

		public bool BallInStarterPosition;

		public Rigidbody2D Rigidbody;

		private void OnCollisionEnter2D(Collision2D collision)
		{
			if (collision == null || collision.transform == null)
				return;

			GolfGoal goal = collision.transform.GetComponent<GolfGoal>();
			if (goal != null)
			{
				goal.Complete();
			}
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
			if (collision != null && collision.gameObject.CompareTag("OutOfBounds") && Level.HasInstance)
			{
				Level.Instance.Fail(true, true, null, 0f, true, "ID_FAIL_PINBALL");
			}
		}
	}
}
