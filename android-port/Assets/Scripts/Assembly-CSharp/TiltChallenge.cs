using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class TiltChallenge : Challenge
{
	public List<GameObject> ObjectsToTilt;

	private TiltChallengeSFX SFX;

	private int count;

	private GolfBallController controller;

	public GameObject[] boundsList;

	public bool disableBoundsOnWin;

	protected override void Activate()
	{
	}

	private void OnTip(GameObject go)
	{
	}

	public override string GetDescription()
	{
		return null;
	}

	public override string GetWinMessageID()
	{
		return null;
	}
}
