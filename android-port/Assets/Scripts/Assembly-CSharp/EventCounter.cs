using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventCounter : MonoBehaviour
{
	public UnityEvent OnCounterComplete;

	public UnityEvent OnCounterZero;

	[SerializeField]
	private float m_delayBetweenActions;

	[SerializeField]
	private int m_counterNeeded;

	private List<GameObject> m_currentlyActivated;

	public void AddToCounter(GameObject sender)
	{
	}

	public void RemoveFromCounter(GameObject sender)
	{
	}

	private void CallAction()
	{
	}
}
