using System;
using UnityEngine;

public class OnDestroyCallback : MonoBehaviour
{
	public Action<GameObject> OnWillDestroy;

	private void OnDestroy()
	{
		OnWillDestroy?.Invoke(gameObject);
	}

	private void OnDisable()
	{
		OnWillDestroy?.Invoke(gameObject);
	}
}
