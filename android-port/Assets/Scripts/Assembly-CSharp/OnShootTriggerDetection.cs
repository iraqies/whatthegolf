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
	}

	private void OnDisable()
	{
	}

	private void Controller_OnShoot(Vector3 obj)
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}
}
