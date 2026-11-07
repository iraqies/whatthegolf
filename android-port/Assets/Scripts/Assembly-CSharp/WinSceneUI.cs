using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

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
	}

	public void Unlock()
	{
	}

	private IEnumerator UnlockPrizeAfter()
	{
		return null;
	}

	public void InitUI()
	{
	}

	private void SetUI(bool leaderboards, bool usingController)
	{
	}

	private void SetHighscoreTitle(bool isSpecial)
	{
	}

	public void Init(bool isSpecial)
	{
	}

	private void Update()
	{
	}

	public void ToggleLeaderboards()
	{
	}

	private void ShowLeaderboards()
	{
	}

	private void HideLeaderBoards()
	{
	}

	private void SetLeaderBoardBtn(bool open)
	{
	}

	protected void RefreshNextChallangeText()
	{
	}
}
