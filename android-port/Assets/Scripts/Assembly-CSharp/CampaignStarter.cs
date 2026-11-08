using System;
using System.Collections;
using Core;
using UnityEngine;

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

		bool needOnboarding = !SaveGame.IsOnboardingComplete && pack.campaignType == ECampaignType.Main;
		if (!needOnboarding && section != null)
		{
			SaveGame.SavePosition = section.saveSpotId;
			SaveGame.SavePositionShape = section.ballShape;
		}

		SaveGame.IncrementContentPackPlayCount(pack.contentPackID);

		var effect = def != null ? def.transition : Transition.TransitionEffect.Random;

		if (needOnboarding)
		{
			if (LevelManager.Exists)
				yield return StartCoroutine(LevelManager.Instance.StartTransition(Color.black, null, true, false, false, effect, null));
			if (overworldCaller != null)
				overworldCaller.ChangeStateToInLevel();
			var onboarding = FindObjectOfType<Onboarding>();
			if (onboarding != null)
			{
				onboarding.StartOnBoarding(pack, true, LevelAborted, BackFromOnboarding);
				yield break;
			}
		}

		if (LevelManager.Exists)
			yield return StartCoroutine(LevelManager.Instance.StartTransition(Color.black, null, false, false, false, effect, null));
		SaveThrobber.HideThrobber();
		OverworldSceneLoader.LoadOverworld(pack, false);
		StartCoroutine(WaitAfterLevelLoaded());
	}

	private void LevelAborted() => OnPackDone?.Invoke(false);
	private void BackFromOnboarding(bool isComplete) => OnPackDone?.Invoke(isComplete);

	private IEnumerator WaitAfterLevelLoaded()
	{
		yield return null;
		OnPackDone?.Invoke(true);
	}
}
