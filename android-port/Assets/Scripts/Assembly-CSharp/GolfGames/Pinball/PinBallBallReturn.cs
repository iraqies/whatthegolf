using UnityEngine;

namespace GolfGames.Pinball
{
	public class PinBallBallReturn : MonoBehaviour
	{
		public Transform StartPosition;

		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other == null)
				return;

			if (other.CompareTag("Ground"))
			{
				Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
				if (rb != null)
				{
					rb.velocity = Vector2.zero;
				}
				if (StartPosition != null)
				{
					other.transform.position = StartPosition.position;
				}
			}
			else if (other.CompareTag("Player"))
			{
				Object.Destroy(other.gameObject);
			}
		}
	}
}
