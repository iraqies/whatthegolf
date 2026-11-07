using System.Collections;
using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class TouchChallenge : Challenge
{
	public List<GameObject> objectsToDeactivate;

	private TiltChallengeSFX SFX;

	public GameObject touchTarget;

	private ChallengeTouchObject[] _challengeTouchObjects;

	public ObjectDestroyTrigger objectDestroyTrigger;

	private List<ChallengeTouchObject> touchingObjects;

	public bool attachTouchObject;

	protected override void Activate()
	{
	}

	private void OnDestroyObject(GameObject obj)
	{
	}

	private void OnToughTarget(ChallengeTouchObject obj)
	{
	}

	private IEnumerator WaitAndComplete()
	{
		return null;
	}

	private void CheckTouches()
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
