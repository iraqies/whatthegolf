using System.Collections.Generic;
using Core;
using UnityEngine;

public class PersistentScoreTracker : MonoBehaviour
{
	private Dictionary<int, int> PlayerScores;

	private readonly int MAXPLAYERS;

	private void Start()
	{
	}

	private void OnLevelWillUnload()
	{
	}

	private void OnLevelLoaded(LevelData levelData)
	{
	}

	private void OnGoal(GolfBallController controller, string obj)
	{
	}
}
