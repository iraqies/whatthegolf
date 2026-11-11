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
		CheckBall(other, true);
	}

	public void HoleHit(Collider other, bool destroy = true)
	{
		CheckBall(other, destroy);
	}

	private void CheckBall(Collider other, bool destroy)
	{
		if (Balls.Contains(other.gameObject))
		{
			BallToHoleClips.PlayRandomClip(other.transform.position, 0f, 0f);
			Balls.Remove(other.gameObject);
			if (destroy)
			{
				Object.Destroy(other.gameObject);
			}
			if (Balls.Count <= 0)
			{
				Goal.Complete();
			}
		}
		CheckIfPlayer(other.gameObject);
	}

	public void CheckIfPlayer(GameObject go)
	{
		if (go == PlayerBall.gameObject)
		{
			BallToHoleClips.PlayRandomClip(go.transform.position, 1f, 1f);
			PlayerBall.Reset(0f);
		}
	}
}
