using System.Collections.Generic;
using UnityEngine;

public class PlayableSoccerAI : MonoBehaviour
{
	public FakeController Controller;

	public Transform GoalTarget;

	public PlayableSoccerBall Ball;

	public List<PlayerSoccerInfo> Players;

	private void Start()
	{
	}

	private void OnBallLost()
	{
	}

	private void OnBallRecieved()
	{
	}
}
