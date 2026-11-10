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
		leaderboardType = LeaderboardBoard.Finished;
		handTarget = 0;
		this.closeAction = closeAction;
		base.gameObject.SetActive(value: true);
		if (Highscore != null)
		{
			Highscore.board = LeaderboardBoard.Finished;
			Highscore.Reset();
			Highscore.StartRefreshLeaderboard(0f);
		}
		StartCoroutine(pTween.To(0.2f, delegate(float t)
		{
			float num = Mathf.Clamp01(Mathf.SmoothStep(0f, 1f, t));
			if (Rect != null)
			{
				Rect.anchoredPosition = Vector2.Lerp(Vector3.zero, new Vector2(0f, -77f), num);
			}
		}));
		if (Leaderboard != null)
		{
			yield return StartCoroutine(Leaderboard.TransitionIn());
		}
	}

	private void Update()
	{
		int allPlayerAxisRoundedHorizontal = InputHelper.GetAllPlayerAxisRoundedHorizontal();
		if (allPlayerAxisRoundedHorizontal != 0)
		{
			if (!waitForInputReset)
			{
				waitForInputReset = true;
				handTarget = Mathf.Clamp(handTarget + allPlayerAxisRoundedHorizontal, 0, Selectables.Count - 1);
				Button component = Selectables[handTarget].gameObject.GetComponent<Button>();
				if (component != null)
				{
					component.onClick.Invoke();
				}
			}
		}
		else if (waitForInputReset)
		{
			waitForInputReset = false;
		}
		if (InputHelper.GetAllPlayerButtonCancel())
		{
			closeAction?.Invoke();
		}
		if (Highscore != null)
		{
			Highscore.UpdateInput(Time.deltaTime);
		}
	}

	public void Close()
	{
		closeAction?.Invoke();
	}

	public void ShowAnyPercentLeaderboards()
	{
		StartCoroutine(ChangeLeaderboard(LeaderboardBoard.Finished));
	}

	public void Show50PercentLeaderboards()
	{
		StartCoroutine(ChangeLeaderboard(LeaderboardBoard.Completed50));
	}

	public void Show75PercentLeaderboards()
	{
		StartCoroutine(ChangeLeaderboard(LeaderboardBoard.Completed75));
	}

	public void Show100PercentLeaderboards()
	{
		StartCoroutine(ChangeLeaderboard(LeaderboardBoard.Completed100));
	}

	private IEnumerator ChangeLeaderboard(LeaderboardBoard newBoard)
	{
		if (leaderboardType != newBoard)
		{
			leaderboardType = newBoard;
			if (Highscore != null)
			{
				Highscore.board = newBoard;
				Highscore.Reset();
				Highscore.StartRefreshLeaderboard(0f);
			}
		}
		yield return null;
	}

	public void Hide()
	{
		StartCoroutine(HideRoutine());
	}

	public IEnumerator HideRoutine()
	{
		float waitTime = 0.5f;
		if (Leaderboard != null)
		{
			StartCoroutine(Leaderboard.CoTransOutAndDisable());
			waitTime = Leaderboard.transitionTime;
		}
		yield return StartCoroutine(pTween.To(0.2f, delegate(float t)
		{
			float num = Mathf.Clamp01(Mathf.SmoothStep(0f, 1f, t));
			if (Rect != null)
			{
				Rect.anchoredPosition = new Vector2(0f, num * 77f - 77f);
			}
		}));
		yield return new WaitForSecondsRealtime(waitTime - 0.2f);
		base.gameObject.SetActive(value: false);
	}
}
