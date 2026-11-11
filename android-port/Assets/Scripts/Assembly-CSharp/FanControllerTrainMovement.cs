using System.Collections.Generic;
using Core;
using UnityEngine;

public class FanControllerTrainMovement : MonoBehaviour
{
	public Transform Train;

	public List<MoveObjectAlongPoints> Movers;

	public Transform WaypointContainer;

	public Fan Fan;

	private GolfBallController controller;

	private float startupTimeTarget;

	private float startupTimer;

	private void Awake()
	{
		controller = GetComponent<GolfBallController>();
		controller.OnAimStart += Controller_OnAimStart;
		controller.OnShoot += delegate
		{
			startupTimeTarget = 0f;
		};
		controller.OnCancel += OnCancel;
	}

	private void OnCancel()
	{
		startupTimeTarget = 0f;
	}

	private void Controller_OnAimStart()
	{
		startupTimeTarget = 1f;
	}

	private void Update()
	{
		startupTimer = Mathf.MoveTowards(startupTimer, Fan.IsOn ? startupTimeTarget : 0f, Time.deltaTime * 0.5f);
		Vector3 forward = Train.transform.forward;
		Vector3 right = base.transform.right;
		float num = Mathf.Lerp(0f, 1f, startupTimer) * Vector3.Dot(forward, right);
		foreach (MoveObjectAlongPoints mover in Movers)
		{
			mover.SpeedMod = num * (float)mover.GetDirection();
		}
	}
}
