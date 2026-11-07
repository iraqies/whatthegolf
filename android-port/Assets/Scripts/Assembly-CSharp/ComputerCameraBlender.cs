using System.Collections.Generic;
using UnityEngine;

public class ComputerCameraBlender : GolfBehaviour
{
	public List<OverworldMainDoorRobot> robots;

	public OverworldCameraSettings robotSettings;

	private Coroutine current;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void Robot_OnBallExitedAndIsExploding(OverworldMainDoorRobot obj)
	{
	}
}
