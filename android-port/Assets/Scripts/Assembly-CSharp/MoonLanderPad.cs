using System.Collections.Generic;
using Core;
using UnityEngine;

public class MoonLanderPad : MonoBehaviour
{
	public int RequiredHitsForCompletion;

	private GolfGoal golfGoal;

	private List<GolfBallController> hits;

	private void Awake()
	{
	}

	public void Landed(GolfBallController controller)
	{
	}
}
