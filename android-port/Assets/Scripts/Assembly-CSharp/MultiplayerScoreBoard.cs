using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;

public class MultiplayerScoreBoard : MonoBehaviour
{
	public MultiplayerScoreBoardEntry EntryTemplate;

	public Canvas Canvas;

	private MultiplayerScoreBoardEntry[] entries;

	private const int MAXPLAYERS = 4;

	private Dictionary<int, int> totalScores;

	private Dictionary<int, int> scoresThisLevel;

	public bool LastLevelCompleted;

	private void Start()
	{
	}

	private void OnLastLevelCompleted()
	{
	}

	private void OnReturnToMainMenuExit()
	{
	}

	private void OnLevelWillUnload()
	{
	}

	private void OnLevelLoaded(LevelData levelData)
	{
	}

	private void OnGoal(Level.CompletedState s)
	{
	}

	private void OnGoalProgress(int playerIndex, string s)
	{
	}

	private IEnumerator ShowScores()
	{
		return null;
	}
}
