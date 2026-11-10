using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WinSceneUI : MonoBehaviour
{
	[SerializeField]
	private PrizeController prizeController;

	[SerializeField]
	private DailyChallengeQuickMenu dailyQuickMenu;

	[SerializeField]
	private TextMeshProLocalized HighscoreTitle;

	[SerializeField]
	private TextMeshProUGUI HighscoreTimeLeft;

	[SerializeField]
	private List<AnimateRectTransform> ActiveOnLeaderboardShow;

	[SerializeField]
	private List<AnimateRectTransform> DeactiveOnLeaderboardShow;

	[SerializeField]
	private HighscoreList HighscoreList;

	[SerializeField]
	private List<AnimateRectTransform> UIToDeactivateOnUsingController;

	[SerializeField]
	private List<AnimateRectTransform> UIToActivateOnUsingController;

	private bool HasSentAnalytics;

	public bool isShowingLeaderboards;

	private bool p_usingController;

	[SerializeField]
	private AnimateRectTransform UnlockButton;

	private bool hasUnlocked;

	private DailyPrize prizeToUnlock;

	public void LockUI(DailyPrize prizeToUnlock)
	{
		this.prizeToUnlock = prizeToUnlock;
		hasUnlocked = false;
		if (UnlockButton != null)
		{
			UnlockButton.SetShow(false, true);
			UnlockButton.Show();
		}
		if (UIToDeactivateOnUsingController != null)
			UIToDeactivateOnUsingController.ForEach(x => { if (x != null) x.SetShow(false, true); });
		if (UIToActivateOnUsingController != null)
			UIToActivateOnUsingController.ForEach(x => { if (x != null) x.SetShow(false, true); });
		if (prizeController != null)
			prizeController.SetControllerActive(false);
	}

	public void Unlock()
	{
		if (hasUnlocked) return;
		if (UnlockButton != null)
		{
			var btn = UnlockButton.GetComponent<Button>();
			if (btn != null && btn.onClick != null)
				btn.onClick.RemoveAllListeners();
			UnlockButton.Hide();
		}
		if (prizeToUnlock != null)
			prizeToUnlock.StartUnlockAnimation();
		hasUnlocked = true;
		StartCoroutine(UnlockPrizeAfter());
		p_usingController = InputHelper.IsNavigatingWithController();
		SetUI(false, p_usingController);
	}

	private IEnumerator UnlockPrizeAfter()
	{
		yield return new WaitForSeconds(0.5f);
		if (prizeToUnlock != null)
			prizeToUnlock.UnWrap();
		if (prizeController != null)
			prizeController.SetControllerActive(true);
	}

	public void InitUI()
	{
		p_usingController = InputHelper.IsNavigatingWithController();
		SetUI(false, p_usingController);
	}

	private void SetUI(bool leaderboards, bool usingController)
	{
		if (UIToDeactivateOnUsingController != null)
		{
			UIToDeactivateOnUsingController.ForEach(x =>
			{
				if (x == null) return;
				if (!usingController && !leaderboards) x.Show();
				else x.Hide();
			});
		}
		if (UIToActivateOnUsingController != null)
		{
			UIToActivateOnUsingController.ForEach(x =>
			{
				if (x == null) return;
				if (usingController && !leaderboards) x.Show();
				else x.Hide();
			});
		}
		if (ActiveOnLeaderboardShow != null)
		{
			ActiveOnLeaderboardShow.ForEach(x =>
			{
				if (x == null) return;
				if (leaderboards) x.Show();
				else x.Hide();
			});
		}
		if (DeactiveOnLeaderboardShow != null)
		{
			DeactiveOnLeaderboardShow.ForEach(x =>
			{
				if (x == null) return;
				if (!leaderboards) x.Show();
				else x.Hide();
			});
		}
	}

	private void SetHighscoreTitle(bool isSpecial)
	{
		if (DailyChallenges.Instance == null) return;
		var pack = isSpecial ? DailyChallenges.GetSpecialPack() : DailyChallenges.GetNormalPack();
		if (pack != null && HighscoreTitle != null)
		{
			HighscoreTitle.ChangeText(pack.GetMenuID());
		}
	}

	public void Init(bool isSpecial)
	{
		if (UIToDeactivateOnUsingController != null)
			UIToDeactivateOnUsingController.ForEach(x => { if (x != null) x.SetShow(false, true); });
		if (UIToActivateOnUsingController != null)
			UIToActivateOnUsingController.ForEach(x => { if (x != null) x.SetShow(false, true); });
		if (ActiveOnLeaderboardShow != null)
			ActiveOnLeaderboardShow.ForEach(x => { if (x != null) x.SetShow(false, true); });
		if (DeactiveOnLeaderboardShow != null)
			DeactiveOnLeaderboardShow.ForEach(x => { if (x != null) x.SetShow(false, true); });

		if (hasUnlocked)
		{
			SetUI(false, InputHelper.IsNavigatingWithController());
		}

		if (HighscoreList != null)
		{
			HighscoreList.Reset();
			HighscoreList.StartRefreshLeaderboard(0.5f);
		}
		SetHighscoreTitle(isSpecial);
	}

	private void Update()
	{
		if (!hasUnlocked && InputHelper.GetAllPlayerButtonConfirm())
		{
			Unlock();
			return;
		}
		if (hasUnlocked)
		{
			bool nav = InputHelper.IsNavigatingWithController();
			if (nav != p_usingController)
			{
				p_usingController = nav;
				SetUI(isShowingLeaderboards, nav);
			}
			if (isShowingLeaderboards && (InputHelper.GetAllPlayerButtonGoBack() || InputHelper.GetAllPlayerButtonCancel()))
			{
				HideLeaderBoards();
			}
			if (isShowingLeaderboards && HighscoreList != null)
			{
				HighscoreList.UpdateInput(Time.deltaTime);
			}
		}
	}

	public void ToggleLeaderboards()
	{
		if (isShowingLeaderboards)
			HideLeaderBoards();
		else
			ShowLeaderboards();
	}

	private void ShowLeaderboards()
	{
		if (HighscoreList != null)
			HighscoreList.StartRefreshLeaderboard(0f);
		SetLeaderBoardBtn(true);
		RefreshNextChallangeText();
		if (!HasSentAnalytics)
		{
			GameAnalytics.OnMenuButtonPressed("Leaderboard");
		}
		HasSentAnalytics = true;
		isShowingLeaderboards = true;
		if (prizeController != null)
			prizeController.SetControllerActive(false);
		if (dailyQuickMenu != null)
			dailyQuickMenu.BlockInput = false;
	}

	private void HideLeaderBoards()
	{
		SetLeaderBoardBtn(false);
		isShowingLeaderboards = false;
		if (prizeController != null)
			prizeController.SetControllerActive(true);
		if (dailyQuickMenu != null)
			dailyQuickMenu.BlockInput = true;
	}

	private void SetLeaderBoardBtn(bool open)
	{
		SetUI(open, InputHelper.IsNavigatingWithController());
	}

	protected void RefreshNextChallangeText()
	{
		if (HighscoreTimeLeft == null) return;
		DateTime today = DailyChallenges.GetToday();
		DateTime endOfDay = new DateTime(today.Year, today.Month, today.Day, 23, 59, 59);
		TimeSpan remaining = endOfDay - today;
		if (remaining.Hours > 0)
		{
			HighscoreTimeLeft.SetLocalizedText(remaining.Hours + "h");
		}
		else
		{
			HighscoreTimeLeft.SetLocalizedText(Mathf.Max(1, remaining.Minutes) + "m");
		}
	}
}
