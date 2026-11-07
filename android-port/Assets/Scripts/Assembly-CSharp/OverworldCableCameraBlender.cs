using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldCableCameraBlender : GolfBehaviour
{
	public OverworldCameraSettings inCable;

	private Coroutine current;

	[SerializeField]
	private List<OverworldMainButton> cables;

	public override void OnPrePlayOrPreCompile()
	{
	}

	private void Start()
	{
	}

	private void Cable_OnEnteredCable1(OverworldMainButton cable)
	{
	}

	private void Cable_OnExitedCable(OverworldMainDoorRobot cable)
	{
	}

	private IEnumerator EndCamera()
	{
		return null;
	}
}
