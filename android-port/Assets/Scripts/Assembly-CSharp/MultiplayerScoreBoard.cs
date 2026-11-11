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

	private Dictionary<int, int> totalScores = new Dictionary<int, int>();

	private Dictionary<int, int> scoresThisLevel = new Dictionary<int, int>();

	public bool LastLevelCompleted;

	private void Start()
	{
		if (LevelManager.Instance != null)
		{
			LevelManager.Instance.OnLevelLoaded += OnLevelLoaded;
			LevelManager.Instance.OnLevelWillUnload += OnLevelWillUnload;
		}
		entries = new MultiplayerScoreBoardEntry[4];
		totalScores = new Dictionary<int, int>();
		scoresThisLevel = new Dictionary<int, int>();
		if (EntryTemplate != null)
		{
			for (int i = 0; i < 4; i++)
			{
				MultiplayerScoreBoardEntry entry = Object.Instantiate(EntryTemplate, EntryTemplate.transform.parent);
				entries[i] = entry;
				entry.gameObject.SetActive(false);
				if (entry.PlayerName != null)
				{
					entry.PlayerName.text = "Player " + (i + 1);
				}
				totalScores[i] = 0;
				scoresThisLevel[i] = int.MinValue;
			}
		}
	}

	private void OnLastLevelCompleted()
	{
		LastLevelCompleted = true;
	}

	private void OnReturnToMainMenuExit()
	{
		LastLevelCompleted = false;
		if (totalScores != null)
		{
			List<int> keys = new List<int>(totalScores.Keys);
			for (int i = 0; i < keys.Count; i++)
			{
				totalScores[keys[i]] = 0;
			}
		}
		if (entries != null)
		{
			for (int i = 0; i < entries.Length; i++)
			{
				if (entries[i] != null)
				{
					entries[i].ResetAll();
				}
			}
		}
	}

	private void OnLevelWillUnload()
	{
		if (Level.Instance != null)
		{
			if (Level.Instance.Goal != null)
			{
				Level.Instance.Goal.OnGoalProgress -= OnGoalProgress;
			}
			Level.Instance.OnComplete -= OnGoal;
		}
		if (!LastLevelCompleted && entries != null)
		{
			for (int i = 0; i < entries.Length; i++)
			{
				if (entries[i] != null && entries[i].gameObject.activeSelf)
				{
					entries[i].transform.localScale = Vector3.zero;
				}
			}
		}
	}

	private void OnLevelLoaded(LevelData levelData)
	{
		LastLevelCompleted = false;
		GolfBallController[] controllers = Object.FindObjectsOfType<GolfBallController>();
		HashSet<int> playerSet = new HashSet<int>();
		if (controllers != null)
		{
			for (int i = 0; i < controllers.Length; i++)
			{
				if (controllers[i] != null)
				{
					playerSet.Add(controllers[i].PlayerIndex);
				}
			}
		}
		int count = playerSet.Count;
		if (Canvas != null)
		{
			Canvas.gameObject.SetActive(count > 1);
		}
		if (entries != null)
		{
			for (int i = 0; i < entries.Length; i++)
			{
				if (entries[i] != null)
				{
					entries[i].gameObject.SetActive(i < count);
				}
			}
		}
		if (Level.Instance != null)
		{
			if (Level.Instance.Goal != null)
			{
				Level.Instance.Goal.OnGoalProgress += OnGoalProgress;
			}
			Level.Instance.OnComplete += OnGoal;
		}
	}

	private void OnGoal(Level.CompletedState s)
	{
		if (scoresThisLevel != null && entries != null)
		{
			foreach (KeyValuePair<int, int> kvp in scoresThisLevel)
			{
				if (kvp.Key >= 0 && kvp.Key < entries.Length && entries[kvp.Key] != null)
				{
					entries[kvp.Key].AddNewScore(kvp.Value);
				}
			}
		}
		StartCoroutine(ShowScores());
	}

	private void OnGoalProgress(int playerIndex, string s)
	{
		if (totalScores != null && !totalScores.ContainsKey(playerIndex))
		{
			totalScores.Add(playerIndex, 0);
		}
	}

	private IEnumerator ShowScores()
	{
		if (entries == null)
		{
			yield break;
		}
		for (int i = 0; i < entries.Length; i++)
		{
			MultiplayerScoreBoardEntry entry = entries[i];
			if (entry != null && entry.gameObject.activeSelf)
			{
				if (entry.TotalScore != null && totalScores != null && totalScores.TryGetValue(i, out int tot))
				{
					entry.TotalScore.text = tot.ToString();
				}
				StartCoroutine(pTween.To(0.25f, 0f, 1f, t =>
				{
					if (entry != null)
					{
						entry.transform.localScale = Vector3.Lerp(Vector3.zero, Vector3.one, Mathf.SmoothStep(0f, 1f, Mathf.Clamp01(t)));
					}
				}));
			}
		}
		yield return new WaitForSeconds(1.5f);
	}
}
