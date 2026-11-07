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
	}

	private void OnDisable()
	{
	}

	private void Controller_OnShoot(Vector3 obj)
	{
	}
}
