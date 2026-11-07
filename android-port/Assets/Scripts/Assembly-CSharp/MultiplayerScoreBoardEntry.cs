using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MultiplayerScoreBoardEntry : MonoBehaviour
{
	public TextMeshProUGUI PlayerName;

	public TextMeshProUGUI TotalScore;

	public TextMeshProUGUI ScoreTemplate;

	public List<TextMeshProUGUI> Scores;

	public void AddNewScore(int score)
	{
	}

	public void ResetAll()
	{
	}
}
