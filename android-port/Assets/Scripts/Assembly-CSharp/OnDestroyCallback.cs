using System;
using UnityEngine;

public class OnDestroyCallback : MonoBehaviour
{
	public Action<GameObject> OnWillDestroy;

	private void OnDestroy()
	{
	}

	private void OnDisable()
	{
	}
}
