using Core;
using GolfCourse;
using UnityEngine;

public class RaceChallenge : Challenge
{
	[SerializeField]
	private GameObject[] playerObjects;

	[SerializeField]
	private GameObject[] enemyObjects;

	[SerializeField]
	private GolfCoursePinGoal pinGoal;

	private RigidbodyCollisionInfo collisionInfo;

	protected override void Activate()
	{
	}

	private void OnFlagCollision(HitInfo hitInfo)
	{
	}

	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}
}
