using System;
using UnityEngine;

public class ChallengeTouchObject : MonoBehaviour
{
	public Action<ChallengeTouchObject> onToughTarget;

	private GameObject _toughTarget;

	public void SetTouchTarget(GameObject target)
	{
	}

	private void OnCollisionEnter(Collision other)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}
}
