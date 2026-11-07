using System.Collections.Generic;
using CameraStack;
using UnityEngine;

public class KatamariChallenge : Challenge
{
	public List<GameObject> objectsToDeactivateDEPRICATED;

	private ChallengeKatamariBall _katamariBall;

	public int objectCountToWin;

	private CBFollow[] _cbFollows;

	private float _ballSize;

	protected override void Activate()
	{
	}

	private void OnBallGrow(int objectCount, float size)
	{
	}
}
