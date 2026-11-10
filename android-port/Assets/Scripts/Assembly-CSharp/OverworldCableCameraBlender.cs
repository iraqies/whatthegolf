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
		base.OnPrePlayOrPreCompile();
		cables = new List<OverworldMainButton>(FindObjectsOfType<OverworldMainButton>());
	}

	private void Start()
	{
		if (cables == null || cables.Count == 0)
			cables = new List<OverworldMainButton>(FindObjectsOfType<OverworldMainButton>());
		for (int i = 0; i < cables.Count; i++)
		{
			if (cables[i] != null)
			{
				cables[i].OnEnteredCable -= Cable_OnEnteredCable1;
				cables[i].OnEnteredCable += Cable_OnEnteredCable1;
			}
		}
	}

	private void Cable_OnEnteredCable1(OverworldMainButton cable)
	{
		if (cable != null && cable.doorplate != null && cable.doorplate.computer != null)
		{
			cable.doorplate.computer.OnExitedCable -= Cable_OnExitedCable;
			cable.doorplate.computer.OnExitedCable += Cable_OnExitedCable;
		}
		if (inCable == null) return;
		if (current != null) StopCoroutine(current);
		current = StartCoroutine(pTween.To(0.6f, t =>
		{
			if (inCable != null)
				inCable.SetValue(TweenFunctions.EaseIn(t));
		}));
	}

	private void Cable_OnExitedCable(OverworldMainDoorRobot cable)
	{
		if (cable != null)
			cable.OnExitedCable -= Cable_OnExitedCable;
		if (inCable == null) return;
		if (current != null) StopCoroutine(current);
		current = StartCoroutine(EndCamera());
	}

	private IEnumerator EndCamera()
	{
		yield return StartCoroutine(pTween.To(0.6f, 1f, 0f, t =>
		{
			if (inCable != null)
				inCable.SetValue(TweenFunctions.EaseIn(Mathf.Clamp01(t)));
		}));
	}
}
