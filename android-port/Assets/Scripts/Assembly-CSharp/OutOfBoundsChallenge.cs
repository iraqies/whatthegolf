using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class OutOfBoundsChallenge : Challenge
{
	public bool useCustomAmount;

	public int customAmount;

	public List<GameObject> ObjectsToObserve;

	private TiltChallengeSFX sfx;

	private CBFollow _cbFollow;

	private GolfBallController _golfBallController;

	private int knockoutCount;

	private int count;

	protected override void Activate()
	{
	}

	private void OnOnOutOfBounds(OutOfBoundsTrigger outOfBoundsTrigger)
	{
	}
}
