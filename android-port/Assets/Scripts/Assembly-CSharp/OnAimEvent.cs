using Core;
using UnityEngine;
using UnityEngine.Events;

public class OnAimEvent : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private UnityEvent _event;

	private void Start()
	{
	}

	private void TriggerEvent()
	{
	}

	private void OnDestroy()
	{
	}
}
