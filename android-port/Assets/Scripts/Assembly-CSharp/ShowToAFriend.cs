using System;
using System.Collections;
using System.Collections.Generic;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowToAFriend : BasePackStarter
{
	private ContentPack _pack;
	private List<LevelDataAndChallenge> _levels;

	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		_pack = pack;
		StartCoroutine(StartPackCR(pack));
		return true;
	}

	private IEnumerator StartPackCR(ContentPack pack)
	{
		if (pack != null && pack.mainContainer != null)
		{
			_levels = pack.mainContainer.GetLevelDatasWithChallenges();
		}
		if (LevelManager.Instance != null)
		{
			yield return StartCoroutine(LevelManager.Instance.StartTransition());
		}
		StartShowToAFriend(true);
	}

	public void StartShowToAFriend(bool allowMenuButtons)
	{
		StartCoroutine(PlayShowToAFriendLevels(allowMenuButtons));
	}

	private IEnumerator PlayShowToAFriendLevels(bool allowMenuButtons)
	{
		var levelManager = LevelManager.Instance;
		yield return null;
		if (!allowMenuButtons && levelManager != null && levelManager.InGameMenu != null)
		{
			levelManager.InGameMenu.DeactivateMenu();
		}
		GameAnalytics.OnCampaignStarted(_pack, false);

		bool aborted = false;
		if (_levels != null && levelManager != null)
		{
			for (int i = 0; i < _levels.Count; i++)
			{
				if (aborted)
				{
					GoToHub();
					break;
				}
				var item = _levels[i];
				if (item == null || item.level == null) continue;
				string challengeId = string.IsNullOrEmpty(item.challengeID) ? null : item.challengeID;
				if (AudioManager.Instance != null && AudioManager.Instance.music != null)
				{
					AudioManager.Instance.music.SetLevelMusic(item.level.music, false);
				}

				yield return StartCoroutine(levelManager.Play(
					item.level,
					onComplete: _ => { },
					onAbort: () => aborted = true,
					skipTransitionIn: i > 0,
					skipTransitionOut: true,
					disableRestartButton: false,
					disableExitButton: !allowMenuButtons,
					showStrokeCounter: !string.IsNullOrEmpty(challengeId),
					challengeID: challengeId
				));
			}
		}

		GameAnalytics.OnCampaignEnded(!aborted);
		OnPackDone?.Invoke(!aborted);
		if (!aborted)
		{
			if (levelManager != null)
				yield return StartCoroutine(levelManager.EndTransition(false, 0f));
			if (levelManager != null && levelManager.InGameMenu != null)
				levelManager.InGameMenu.ActivateMenu();
		}
	}

	private async void GoToHub()
	{
		if (LevelManager.Instance != null)
		{
			await LevelManager.Instance.StartTransition();
		}
		if (HubSceneLoader.Instance != null)
		{
			await HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
		}
		if (OverworldManager2d.Instance != null)
		{
			OverworldManager2d.Instance.StartMusicWithoutTransition();
		}
	}
}
