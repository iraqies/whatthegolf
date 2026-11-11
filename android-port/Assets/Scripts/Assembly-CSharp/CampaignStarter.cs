using System;
using System.Collections;
using System.Linq;
using Core;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CampaignStarter : BasePackStarter
{
	private OverworldManager2d overworldCaller;

	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		if (pack == null) return false;
		OverworldLevelSection section = null;
		if (additionalContext != null && additionalContext.Length > 0)
			section = additionalContext[0] as OverworldLevelSection;
		StartCoroutine(StartCampaignCR(pack, section));
		return true;
	}

	private IEnumerator StartCampaignCR(ContentPack pack, OverworldLevelSection section)
	{
		overworldCaller = OverworldManager2d.Instance;
		var def = CampaignDef.GetDef(pack.campaignType);
		ECampaignType cType = def != null ? def.type : pack.campaignType;
		SaveGame.SetOverworld(cType);
		if (pack.campaignType != ECampaignType.None)
			SaveGame.LastPlayedCampaignType = cType;

		bool needOnboarding = !SaveGame.IsOnboardingComplete && pack.campaignType != ECampaignType.Hub;
		if (!needOnboarding && section != null)
		{
			SaveGame.SavePosition = section.saveSpotId;
			SaveGame.SavePositionShape = section.ballShape;
		}

		GameAnalytics.OnCampaignStarted(pack, false);

		var effect = def != null ? def.transition : Transition.TransitionEffect.Random;

		if (needOnboarding)
		{
			var onboardings = GetComponentsInChildren<Onboarding>(true);
			var onboarding = onboardings != null ? onboardings.FirstOrDefault(o => o != null && o.CampaignType == pack.campaignType) : null;
			if (onboarding == null)
			{
				var allOnboardings = FindObjectsOfType<Onboarding>();
				onboarding = allOnboardings.FirstOrDefault(o => o != null && o.CampaignType == pack.campaignType) ?? allOnboardings.FirstOrDefault();
			}
			if (onboarding != null)
			{
				if (LevelManager.Exists)
					yield return StartCoroutine(LevelManager.Instance.StartTransition(Color.black, null, true, false, false, effect, null));
				if (overworldCaller != null)
					overworldCaller.ChangeStateToInLevel();
				onboarding.StartOnBoarding(pack, true, LevelAborted, completed =>
				{
					BackFromOnboarding(completed);
					OnPackDone?.Invoke(completed);
				});
				StartCoroutine(WaitAfterLevelLoaded());
				yield break;
			}
		}

		if (overworldCaller != null)
			overworldCaller.DisableInteraction(false);
		if (LevelManager.Exists)
			yield return StartCoroutine(LevelManager.Instance.StartTransition(Color.black, null, false, false, false, effect, null));
		SaveThrobber.HideThrobber();

		var loadTask = OverworldSceneLoader.TryLoadOverworld(pack, false);
		while (loadTask != null && !loadTask.IsCompleted)
			yield return null;
		bool loadedOverworld = loadTask != null && !loadTask.IsFaulted && !loadTask.IsCanceled && loadTask.Result;

		if (!loadedOverworld)
		{
			if (pack.mainContainer != null && LevelManager.Instance != null)
			{
				var allLevels = pack.mainContainer.GetLevelDatasWithChallenges();
				var playableLevels = allLevels != null
					? allLevels.Where(item => item != null && item.level != null && !string.IsNullOrEmpty(item.level.SceneName) && Application.CanStreamedLevelBeLoaded(item.level.SceneName)).ToList()
					: null;
				if (playableLevels != null && playableLevels.Count > 0)
				{
					if (overworldCaller != null)
						overworldCaller.ChangeStateToInLevel();
					bool aborted = false;
					for (int i = 0; i < playableLevels.Count; i++)
					{
						if (aborted) break;
						var item = playableLevels[i];
						string challengeId = string.IsNullOrEmpty(item.challengeID) ? null : item.challengeID;
						if (AudioManager.Instance != null && AudioManager.Instance.music != null)
							AudioManager.Instance.music.SetLevelMusic(item.level.music, false);
						yield return StartCoroutine(LevelManager.Instance.Play(
							item.level,
							onComplete: _ =>
							{
								if (item.level != null)
									item.level.IsCompletedInSaveGame = true;
							},
							onAbort: () => aborted = true,
							skipTransitionIn: i > 0,
							skipTransitionOut: true,
							disableRestartButton: false,
							disableExitButton: false,
							showStrokeCounter: !string.IsNullOrEmpty(challengeId),
							challengeID: challengeId
						));
					}
					if (!aborted)
						SaveGame.Save(false);
					if (HubSceneLoader.Instance != null && !HubSceneLoader.Instance.IsHubLoaded)
					{
						var hubTask = HubSceneLoader.Instance.LoadSceneAsync(LoadSceneMode.Single);
						while (hubTask != null && !hubTask.IsCompleted)
							yield return null;
					}
					else if (overworldCaller != null)
					{
						SaveGame.SetOverworld(overworldCaller.overworldType);
						overworldCaller.DisplayCampaignHub(true);
					}
				}
				else if (overworldCaller != null)
				{
					SaveGame.SetOverworld(overworldCaller.overworldType);
					overworldCaller.EnableInteraction();
				}
			}
			else if (overworldCaller != null)
			{
				SaveGame.SetOverworld(overworldCaller.overworldType);
				overworldCaller.EnableInteraction();
			}
			if (LevelManager.Instance != null)
				yield return StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
			OnPackDone?.Invoke(false);
			yield break;
		}

		StartCoroutine(WaitAfterLevelLoaded());
		OnPackDone?.Invoke(true);
	}

	private void LevelAborted()
	{
		if (OverworldManager2d.Instance != null)
			OverworldManager2d.Instance.EnableInteraction();
		OnPackDone?.Invoke(false);
	}

	private void BackFromOnboarding(bool isComplete)
	{
		if (!isComplete && overworldCaller != null)
		{
			SaveGame.SetOverworld(overworldCaller.overworldType);
			overworldCaller.DisplayCampaignHub(true);
		}
	}

	private IEnumerator WaitAfterLevelLoaded()
	{
		if (LevelManager.Instance != null && !LevelManager.Instance.IsPlayingLevel)
		{
			yield return new WaitUntil(() => LevelManager.Instance != null && LevelManager.Instance.IsPlayingLevel);
		}
		if (overworldCaller != null)
		{
			overworldCaller.DisplayCampaignHub(false);
			overworldCaller.ResetBallPositionToLastSave();
		}
	}
}
