using System.Collections.Generic;
using Audio;
using Core;
using UnityEngine;

public class BilliardGolf : MonoBehaviour
{
	public List<GameObject> Balls;

	public GolfBallController PlayerBall;

	public GolfGoal Goal;

	public RandomAudioClips BallToHoleClips;

	private void OnTriggerEnter(Collider other)
	{
	}

	public void HoleHit(Collider other, bool destroy = true)
	{
	}

	private void CheckBall(Collider other, bool destroy)
	{
	}

	public void CheckIfPlayer(GameObject go)
	{
	}
}
