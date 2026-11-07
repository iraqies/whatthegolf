using System;
using UnityEngine;

public class ChallengeHoleAbsorber : MonoBehaviour
{
	public Action<GameObject> onStoneSwallow;

	private void OnCollisionEnter(Collision other)
	{
	}
}
