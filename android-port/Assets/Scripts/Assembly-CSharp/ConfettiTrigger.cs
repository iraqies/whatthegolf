using System.Collections;
using UnityEngine;

public class ConfettiTrigger : MonoBehaviour
{
	public ConfettiSpawner confetti;

	public Transform spotleft;

	public Transform spotRight;

	public float OfflineTime = 120f;

	private float nextConfetti;

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (Time.time <= nextConfetti || collision == null)
			return;
		Rigidbody2D rb = collision.attachedRigidbody;
		if (rb == null)
			return;
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null && rb.gameObject == OverworldBallManager.Instance.Ball.gameObject)
		{
			nextConfetti = Time.time + OfflineTime;
			StartCoroutine(MakeConfetti());
		}
	}

	private IEnumerator MakeConfetti()
	{
		if (confetti == null)
			yield break;
		for (int wave = 0; wave < 10; wave++)
		{
			for (int i = 0; i < 5; i++)
			{
				if (spotleft != null)
					confetti.SpawnConfetti(spotleft.position);
				if (spotRight != null)
					confetti.SpawnConfetti(spotRight.position);
			}
			yield return null;
			yield return null;
		}
	}
}
