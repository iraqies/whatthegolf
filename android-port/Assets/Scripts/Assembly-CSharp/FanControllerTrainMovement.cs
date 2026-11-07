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
	}

	private void OnCancel()
	{
	}

	private void Controller_OnAimStart()
	{
	}

	private void Update()
	{
	}
}
