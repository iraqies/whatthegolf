using System.Collections.Generic;
using UnityEngine;

public class ComputerCameraBlender : GolfBehaviour
{
	public List<OverworldMainDoorRobot> robots;

	public OverworldCameraSettings robotSettings;

	private Coroutine current;

	public override void OnPrePlayOrPreCompile()
	{
		base.OnPrePlayOrPreCompile();
		FindObjectsInOverworld.Find(robots);
	}

	private void Start()
	{
		foreach (OverworldMainDoorRobot robot in robots)
		{
			robot.OnBallExitedAndIsExploding += Robot_OnBallExitedAndIsExploding;
		}
	}

	private void Robot_OnBallExitedAndIsExploding(OverworldMainDoorRobot obj)
	{
		if (current != null)
		{
			StopCoroutine(current);
		}
		robotSettings.SetValue(1f);
		current = StartCoroutine(pTween.To(0.3f, delegate(float t)
		{
			robotSettings.SetValue(TweenFunctions.EaseIn(t));
		}));
	}
}
