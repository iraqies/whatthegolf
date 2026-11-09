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
		if (inCable == null) return;
		if (current != null) StopCoroutine(current);
		current = StartCoroutine(pTween.To(0.25f, 0f, 1f, t =>
		{
			if (inCable != null)
				inCable.SetValue(t * t);
		}));
	}

	private void Cable_OnExitedCable(OverworldMainDoorRobot cable)
	{
		if (inCable == null) return;
		if (current != null) StopCoroutine(current);
		current = StartCoroutine(EndCamera());
	}

	private IEnumerator EndCamera()
	{
		yield return StartCoroutine(pTween.To(0.25f, 1f, 0f, t =>
		{
			if (inCable != null)
				inCable.SetValue(t * t);
		}));
	}
}
