using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ActionOnce : MonoBehaviour
{
	[SerializeField]
	private float delay;

	[SerializeField]
	private bool startOnEnable;

	[SerializeField]
	private UnityEvent m_Event;

	[SerializeField]
	private bool hasHappened;

	private void OnEnable()
	{
		if (startOnEnable && !hasHappened)
		{
			StartCoroutine(Do());
		}
	}

	public void DoAction()
	{
		if (!hasHappened)
		{
			StartCoroutine(Do());
		}
	}

	private IEnumerator Do()
	{
		hasHappened = true;
		yield return new WaitForSeconds(delay);
		m_Event?.Invoke();
	}
}
