using Core;
using UnityEngine;
using UnityEngine.Events;

public class OnShootAction : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private bool onlyOnce;

	[SerializeField]
	private UnityEvent action;

	private void OnEnable()
	{
		if (controller == null) return;
		controller.OnShoot += Controller_OnShoot;
	}

	private void OnDisable()
	{
		if (controller == null) return;
		controller.OnShoot -= Controller_OnShoot;
	}

	private void Controller_OnShoot(Vector3 obj)
	{
		action?.Invoke();
		if (onlyOnce)
		{
			enabled = false;
		}
	}
}
