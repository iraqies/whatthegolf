using UnityEngine;

public class DeathTriggerOverworld : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		if (other == null) return;
		var ball = other.GetComponentInParent<OverworldBall2D>();
		if (ball != null)
			ball.SendMessage("Death", SendMessageOptions.DontRequireReceiver);
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision == null || collision.collider == null) return;
		var ball = collision.collider.GetComponentInParent<OverworldBall2D>();
		if (ball != null)
			ball.SendMessage("Death", SendMessageOptions.DontRequireReceiver);
	}
}
