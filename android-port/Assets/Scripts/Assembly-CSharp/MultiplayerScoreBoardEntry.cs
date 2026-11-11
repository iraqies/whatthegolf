using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MultiplayerScoreBoardEntry : MonoBehaviour
{
	public TextMeshProUGUI PlayerName;

	public TextMeshProUGUI TotalScore;

	public TextMeshProUGUI ScoreTemplate;

	public List<TextMeshProUGUI> Scores = new List<TextMeshProUGUI>();

	public void AddNewScore(int score)
	{
		if (ScoreTemplate == null)
		{
			return;
		}
		TextMeshProUGUI textObj = Object.Instantiate(ScoreTemplate, ScoreTemplate.transform.parent);
		textObj.text = score == int.MinValue ? "-" : score.ToString();
		textObj.gameObject.SetActive(true);
		if (Scores == null)
		{
			Scores = new List<TextMeshProUGUI>();
		}
		Scores.Add(textObj);
	}

	public void ResetAll()
	{
		if (Scores != null)
		{
			for (int i = 0; i < Scores.Count; i++)
			{
				if (Scores[i] != null)
				{
					Object.Destroy(Scores[i].gameObject);
				}
			}
			Scores.Clear();
		}
		if (TotalScore != null)
		{
			TotalScore.text = "0";
		}
	}
}
