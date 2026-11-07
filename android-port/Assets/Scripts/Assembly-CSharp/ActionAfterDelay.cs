using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ActionAfterDelay : MonoBehaviour
{
	[SerializeField]
	private float delay;

	[SerializeField]
	private bool startOnEnable;

	[SerializeField]
	private UnityEvent m_Event;

	private void OnEnable()
	{
	}

	public void DoAction()
	{
	}

	private IEnumerator Do()
	{
		return null;
	}
}
