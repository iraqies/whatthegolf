using System.Collections.Generic;
using Core;
using UnityEngine;

public class MoonLanderPad : MonoBehaviour
{
	public int RequiredHitsForCompletion = 1;

	private GolfGoal golfGoal;

	private List<GolfBallController> hits = new List<GolfBallController>();

	private void Awake()
	{
		golfGoal = GetComponent<GolfGoal>();
	}

	public void Landed(GolfBallController controller)
	{
		if (hits == null || hits.Contains(controller))
			return;
		hits.Add(controller);
		if (hits.Count < RequiredHitsForCompletion)
		{
			if (controller != null && golfGoal != null)
				golfGoal.GoalProgress(controller.playerIndex);
		}
		else if (golfGoal != null)
		{
			golfGoal.Complete();
		}
	}
}
