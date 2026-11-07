using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class ActionAfterDelay : MonoBehaviour
{
	[SerializeField] private float delay = 0.5f;
	[SerializeField] private bool startOnEnable = true;
	[SerializeField] private UnityEvent m_Event = new UnityEvent();

	private void OnEnable()
	{
		if (startOnEnable) DoAction();
	}

	public void DoAction()
	{
		if (gameObject.activeInHierarchy)
			StartCoroutine(Do());
	}

	private IEnumerator Do()
	{
		if (delay > 0f)
			yield return new WaitForSeconds(delay);
		m_Event?.Invoke();
	}
}
