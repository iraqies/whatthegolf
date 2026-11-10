using System.Collections;
using Core;
using UnityEngine;

public class LeaderboardLoader : MonoBehaviour
{
	[SerializeField]
	private MainMenuLeaderboards _leaderboardsMenu;

	private bool interactionDisabled;

	private bool wantsToEnableInteraction;

	private bool InteractionDisabled => interactionDisabled;

	private void EnableInteraction()
	{
		wantsToEnableInteraction = true;
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.EnableInteraction();
		}
	}

	private void DisableInteraction()
	{
		interactionDisabled = true;
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.DisableInteraction(hide: true);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		ShowLeaderboards();
	}

	public void ShowLeaderboards()
	{
		if (!interactionDisabled)
		{
			interactionDisabled = true;
			if (OverworldManager2d.Instance != null)
			{
				OverworldManager2d.Instance.DisableInteraction(hide: true);
			}
			GameAnalytics.OnMenuButtonPressed("Leaderboard");
			StartCoroutine(ShowLeaderboardsCR());
		}
	}

	private IEnumerator ShowLeaderboardsCR()
	{
		if (RuntimeStoreData.instance != null && RuntimeStoreData.instance.onlineLeaderboardType != PlatformSettings.OnlineLeaderboardType.None && _leaderboardsMenu != null)
		{
			_leaderboardsMenu.gameObject.SetActive(value: true);
			yield return _leaderboardsMenu.Show(HideLeaderboards);
		}
		else
		{
			yield return new WaitForSecondsRealtime(0.1f);
			EnableInteraction();
		}
	}

	private void HideLeaderboards()
	{
		if (_leaderboardsMenu != null)
		{
			_leaderboardsMenu.gameObject.SetActive(value: false);
		}
		wantsToEnableInteraction = true;
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.EnableInteraction();
		}
	}

	private void OnTriggerExit2D(Collider2D collision)
	{
		if (wantsToEnableInteraction)
		{
			interactionDisabled = false;
			wantsToEnableInteraction = false;
		}
	}

	public void ZoneEnter()
	{
	}

	public void ZoneExit()
	{
	}
}
