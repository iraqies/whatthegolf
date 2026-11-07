using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DoEventOnIntervals : MonoBehaviour
{
	public bool canFire;

	public float minInterval;

	public float maxInterval;

	public UnityEvent eventToCall;

	private void Update()
	{
	}

	private IEnumerator DoEvent()
	{
		return null;
	}

	public void SetBoolTrue()
	{
	}

	public void SetBoolFalse()
	{
	}
}
