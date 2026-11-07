using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuLeaderboards : MonoBehaviour
{
	public CompletionLeaderboard Leaderboard;

	public HighscoreList Highscore;

	public RectTransform Rect;

	public List<RectTransform> Selectables;

	public ScrollRect HighscoreScrollRect;

	private LeaderboardBoard leaderboardType;

	private bool waitForInputReset;

	private int handTarget;

	private Action closeAction;

	public IEnumerator Show(Action closeAction)
	{
		return null;
	}

	private void Update()
	{
	}

	public void Close()
	{
	}

	public void ShowAnyPercentLeaderboards()
	{
	}

	public void Show50PercentLeaderboards()
	{
	}

	public void Show75PercentLeaderboards()
	{
	}

	public void Show100PercentLeaderboards()
	{
	}

	private IEnumerator ChangeLeaderboard(LeaderboardBoard newBoard)
	{
		return null;
	}

	public void Hide()
	{
	}

	public IEnumerator HideRoutine()
	{
		return null;
	}
}
