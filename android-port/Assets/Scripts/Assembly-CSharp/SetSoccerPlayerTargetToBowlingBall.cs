using System.Collections.Generic;
using UnityEngine;

public class SetSoccerPlayerTargetToBowlingBall : MonoBehaviour
{
	public BowlingShooter Shooter;

	public List<SoccerPlayer> SoccerPlayers;

	private void Start()
	{
		if (Shooter != null)
		{
			Shooter.OnBallShot += BallShot;
		}
	}

	private void BallShot(Rigidbody bowlingBall)
	{
		if (SoccerPlayers == null)
		{
			return;
		}
		foreach (SoccerPlayer soccerPlayer in SoccerPlayers)
		{
			if (soccerPlayer != null)
			{
				soccerPlayer.AddBallTarget(bowlingBall);
			}
		}
	}
}
