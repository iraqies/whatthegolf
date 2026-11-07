using Core;
using UnityEngine;

public class FPGHideCursor : MonoBehaviour
{
	public bool ShowWhenAiming;

	private bool cursorState;

	private GolfBallController controller;

	private bool origState;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Instance_OnComplete(Level.CompletedState obj)
	{
	}

	private void ControllerOnAimUpdate(Vector3 vector3, bool b)
	{
	}

	private void ControllerOnAimStart()
	{
	}

	private void ControllerOnCancel()
	{
	}

	private void ControllerOnShoot(Vector3 vector3)
	{
	}

	private void Update()
	{
	}
}
