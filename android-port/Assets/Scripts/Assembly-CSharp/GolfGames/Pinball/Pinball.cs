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
		}

		private void OnTriggerEnter2D(Collider2D collision)
		{
		}
	}
}
