using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class DoEventOnIntervals : MonoBehaviour
{
	public bool canFire = true;

	public float minInterval;

	public float maxInterval;

	public UnityEvent eventToCall;

	private void Update()
	{
		if (canFire)
		{
			StartCoroutine(DoEvent());
		}
	}

	private IEnumerator DoEvent()
	{
		canFire = false;
		yield return new WaitForSeconds(Random.Range(minInterval, maxInterval));
		eventToCall.Invoke();
		canFire = true;
	}

	public void SetBoolTrue()
	{
		canFire = true;
	}

	public void SetBoolFalse()
	{
		canFire = false;
	}
}
