using System.Collections;
using UnityEngine;

public class ConfettiTrigger : MonoBehaviour
{
	public ConfettiSpawner confetti;

	public Transform spotleft;

	public Transform spotRight;

	public float OfflineTime;

	private float nextConfetti;

	private void OnTriggerEnter2D(Collider2D collision)
	{
	}

	private IEnumerator MakeConfetti()
	{
		return null;
	}
}
