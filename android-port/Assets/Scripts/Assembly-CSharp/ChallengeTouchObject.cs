using System;
using UnityEngine;

public class ChallengeTouchObject : MonoBehaviour
{
	public Action<ChallengeTouchObject> onToughTarget;

	private GameObject _toughTarget;

	public void SetTouchTarget(GameObject target)
	{
		_toughTarget = target;
	}

	private void OnCollisionEnter(Collision other)
	{
		if (other != null && other.gameObject == _toughTarget)
		{
			onToughTarget?.Invoke(this);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.gameObject == _toughTarget)
		{
			onToughTarget?.Invoke(this);
		}
	}
}
