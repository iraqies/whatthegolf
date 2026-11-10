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

	private List<GameObject> m_currentlyActivated = new List<GameObject>();

	public void AddToCounter(GameObject sender)
	{
		if (m_currentlyActivated == null)
			m_currentlyActivated = new List<GameObject>();

		if (!m_currentlyActivated.Contains(sender))
		{
			m_currentlyActivated.Add(sender);
		}
		if (m_currentlyActivated.Count >= m_counterNeeded)
		{
			OnCounterComplete?.Invoke();
		}
	}

	public void RemoveFromCounter(GameObject sender)
	{
		if (m_currentlyActivated == null)
			m_currentlyActivated = new List<GameObject>();

		if (m_currentlyActivated.Contains(sender))
		{
			m_currentlyActivated.Remove(sender);
		}
		if (m_currentlyActivated.Count == 0)
		{
			OnCounterZero?.Invoke();
		}
	}

	private void CallAction()
	{
		OnCounterComplete?.Invoke();
	}
}
