using System;
using UnityEngine;

public class ChallengeHoleAbsorber : MonoBehaviour
{
	public Action<GameObject> onStoneSwallow;

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && other.gameObject != null && other.gameObject.CompareTag("Obstacle"))
		{
			onStoneSwallow?.Invoke(other.gameObject);
		}
	}
}
