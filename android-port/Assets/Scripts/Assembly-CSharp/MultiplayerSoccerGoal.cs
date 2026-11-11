using Core;
using GolfCourse;
using UnityEngine;

public class MultiplayerSoccerGoal : MonoBehaviour
{
	public GolfBallController OpponentController;

	public GameObject Football;

	private void OnTriggerEnter(Collider other)
	{
		if (other == null || other.gameObject != Football)
		{
			return;
		}
		GolfCoursePinGoal goal = GetComponent<GolfCoursePinGoal>();
		if (goal != null && OpponentController != null)
		{
			goal.CheckObject(OpponentController.transform, false);
		}
	}
}
