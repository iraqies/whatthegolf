using System;
using Core;
using Malee;
using UnityEngine;

public class LevelChallenges : MonoBehaviour
{
	public enum gameVersion
	{
		Base = 0,
		OL = 1
	}

	[Serializable]
	public class ChallengeList : ReorderableArray<Challenge>
	{
	}

	[SerializeField]
	public ChallengeList Challenges;

	private bool hasFailedLevel;

	public gameVersion failMessages;

	private string[] olFailMessages = new string[]
	{
		"ID_FAIL_CHALLENGE_OL_0",
		"ID_FAIL_CHALLENGE_OL_1",
		"ID_FAIL_CHALLENGE_OL_2",
		"ID_FAIL_CHALLENGE_OL_3"
	};

	private static System.Random random = new System.Random();

	private void Awake()
	{
		if (LevelManager.Exists && LevelManager.Instance != null)
		{
			LevelManager.Instance.ChallengeSelected -= OnChallengeSelected;
			LevelManager.Instance.ChallengeSelected += OnChallengeSelected;
		}
		if (Challenges != null)
		{
			foreach (var ch in Challenges)
			{
				if (ch != null)
					ch.Disable();
			}
		}
	}

	private void OnDisable()
	{
		if (LevelManager.Exists && LevelManager.Instance != null)
		{
			LevelManager.Instance.ChallengeSelected -= OnChallengeSelected;
		}
	}

	private void OnChallengeSelected(string id)
	{
		if (Challenges != null)
		{
			for (int i = 0; i < Challenges.Count; i++)
			{
				var ch = Challenges[i];
				if (ch == null) continue;
				if (ch.ID == id)
				{
					ch.Activate(Complete, Fail);
				}
				else
				{
					ch.Disable();
				}
			}
		}
		if (!string.IsNullOrEmpty(id))
		{
			hasFailedLevel = false;
			if (Level.HasInstance && Level.Instance != null)
			{
				Level.Instance.OnFail += (c, s, s2) => hasFailedLevel = true;
			}
		}
	}

	private void Complete(Challenge challenge)
	{
		if (hasFailedLevel || challenge == null)
			return;
		if (LevelManager.Exists && LevelManager.Instance != null)
		{
			var curData = LevelManager.Instance.GetCurrentLevelData();
			if (curData != null && curData.CompletedChallenges != null)
			{
				if (!curData.CompletedChallenges.Contains(challenge.ID))
					curData.CompletedChallenges.Add(challenge.ID);
				SaveGame.AddCompletedChallenges(curData.CompletedChallenges);
			}
		}
		var tc = FindObjectOfType<TimeControl>();
		if (tc != null)
			tc.TogglePause(true);
		string winMsg = challenge.GetWinMessageID();
		if (Level.HasInstance && Level.Instance != null)
			Level.Instance.Complete(winMsg, 2f, null, false);
	}

	private void Fail(Challenge challenge)
	{
		var tc = FindObjectOfType<TimeControl>();
		if (tc != null)
			tc.TogglePause(true);
		string msg = "ID_FAIL_CHALLENGE";
		if (failMessages == gameVersion.OL && olFailMessages != null && olFailMessages.Length > 0)
			msg = olFailMessages[UnityEngine.Random.Range(0, olFailMessages.Length)];
		if (Level.HasInstance && Level.Instance != null)
			Level.Instance.Fail(true, true, null, 0.5f, false, msg);
	}

	public string GenerateId(int length)
	{
		const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
		char[] buffer = new char[length];
		for (int i = 0; i < length; i++)
			buffer[i] = chars[random.Next(chars.Length)];
		return new string(buffer);
	}
}
