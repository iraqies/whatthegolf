using Core;
using UnityEngine;
using UnityEngine.Events;

public class OnShootTriggerDetection : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private UnityEvent action;

	private bool isInTrigger;

	private void OnEnable()
	{
		if (controller != null)
		{
			controller.OnShoot += Controller_OnShoot;
		}
	}

	private void OnDisable()
	{
		if (controller != null)
		{
			controller.OnShoot -= Controller_OnShoot;
		}
	}

	private void Controller_OnShoot(Vector3 obj)
	{
		if (isInTrigger)
		{
			action?.Invoke();
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other != null && other.CompareTag("Player"))
		{
			isInTrigger = true;
		}
	}

	private void OnTriggerExit(Collider other)
	{
		if (other != null && other.CompareTag("Player"))
		{
			isInTrigger = false;
		}
	}
}
