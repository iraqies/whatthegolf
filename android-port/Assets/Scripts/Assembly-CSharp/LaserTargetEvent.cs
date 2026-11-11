using UnityEngine;
using UnityEngine.Events;

public class LaserTargetEvent : MonoBehaviour
{
	[SerializeField]
	private UnityEvent _OnLasered;

	private void Start()
	{
		var target = GetComponent<LaserSentryTarget>();
		if (target != null)
		{
			target.OnLasered -= OnLasered;
			target.OnLasered += OnLasered;
		}
	}

	private void OnLasered()
	{
		_OnLasered?.Invoke();
	}
}
