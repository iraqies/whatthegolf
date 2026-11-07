using Core;
using UnityEngine;
using UnityEngine.Events;

public class OnAimEventOnce : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private UnityEvent _event;

	private bool hasFired;

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
