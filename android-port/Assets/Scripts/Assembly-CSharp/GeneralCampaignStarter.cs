using System.Collections;
using System.Linq;
using System.Threading.Tasks;
using Core;
using UnityEngine;

public class GeneralCampaignStarter : BasePackStarter
{
	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		if (pack == null) return false;
		string level = null;
		if (additionalContext != null && additionalContext.Length > 0)
			level = additionalContext[0] as string;
		StartCoroutine(StartPack(pack, level, Transmogrif.BALLSHAPES.ball));
		return true;
	}

	private IEnumerator StartPack(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		yield return StartCoroutine(StartCampaignCR(pack, level, shape));
		OnPackDone?.Invoke(true);
	}

	public async Task StartCampaign(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		if (pack == null) return;
		SaveGame.SetOverworld(pack.campaignType);
		SaveGame.IncrementContentPackPlayCount(pack.contentPackID);
		SaveGame.LastPlayedCampaignType = pack.campaignType;
		await OverworldSceneLoader.TryLoadOverworld(pack, false);
		OnPackDone?.Invoke(true);
	}

	private IEnumerator StartCampaignCR(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		if (pack == null)
		{
			OnPackDone?.Invoke(false);
			yield break;
		}

		if (Loading.IsCreated && !Loading.IsReady)
		{
			yield return new WaitUntil(() => Loading.IsReady);
		}

		var def = CampaignDef.GetDef(pack.campaignType);
		ECampaignType cType = def != null ? def.type : pack.campaignType;
		Transition.TransitionEffect effect = def != null ? def.transition : Transition.TransitionEffect.Default;

		if (LevelManager.Instance != null)
		{
			bool isMain = cType == ECampaignType.Main;
			yield return StartCoroutine(LevelManager.Instance.SwapTranstion(null, null, isMain, isMain, isMain, effect));
		}

		yield return new WaitForSeconds(0.1f);
		SaveThrobber.HideThrobber();

		if (ProcessDeepLink.Instance != null)
		{
			var ab = ProcessDeepLink.Instance.AbandonLevelIfAny();
			if (ab != null)
				yield return StartCoroutine(ab);
		}

		SaveGame.SetOverworld(cType);
		SaveGame.IncrementContentPackPlayCount(pack.contentPackID);
		SaveGame.LastPlayedCampaignType = cType;
		OverworldSceneLoader.LoadOverworld(pack, false);

		if (!string.IsNullOrEmpty(level))
		{
			if (level.Contains("Computer"))
			{
				yield return StartCoroutine(GoToComputerCR(level));
			}
			else if (!SaveGame.GetIsLevelCompleted(level, null))
			{
				yield return StartCoroutine(GoToLevelCR(level, shape, 0f));
			}
		}
	}

	private IEnumerator GoToComputerCR(string notificationId)
	{
		yield return StartCoroutine(AwaitLevelLoadCR(0f));
		var robots = FindObjectsOfType<OverworldMainDoorRobot>();
		var target = robots != null ? robots.FirstOrDefault(r => r != null && r.name != null && r.name.Contains(notificationId)) : null;
		if (target != null)
		{
			Vector3 pos = target.transform.position;
			yield return StartCoroutine(GoToPosition(new Vector2(pos.x, pos.y - 1f)));
		}
		else if (LevelManager.Instance != null)
		{
			yield return StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
		}
	}

	private IEnumerator AwaitLevelLoadCR(float delay)
	{
		if (delay > 0f)
			yield return new WaitForSecondsRealtime(delay);
		while (OverworldManager2d.Instance == null || !OverworldManager2d.Instance.IsOverworldPlaying)
			yield return null;
		yield return new WaitForFixedUpdate();
	}

	private IEnumerator GoToLevelCR(string level, Transmogrif.BALLSHAPES shape, float delay = 0f)
	{
		yield return StartCoroutine(AwaitLevelLoadCR(delay));
		var goals = FindObjectsOfType<OverworldGoal>();
		var found = goals != null ? goals.FirstOrDefault(g => g != null && g.levelData != null && (g.levelData.ID == level || g.levelData.name == level)) : null;
		if (found != null)
		{
			if (CheckDoors(level))
			{
				if (OverworldBallManager.Instance != null)
					OverworldBallManager.Instance.Load(shape);
				Vector3 p = found.transform.position;
				yield return StartCoroutine(GoToPosition(new Vector2(p.x, p.y)));
			}
			if (LevelManager.Instance != null)
				yield return StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
		}
		else
		{
			Debug.LogWarning("Could not find level goal: " + level);
			if (LevelManager.Instance != null)
				yield return StartCoroutine(LevelManager.Instance.EndTransition(false, 0f));
		}
	}

	private IEnumerator GoToPosition(Vector2 position)
	{
		yield return new WaitUntil(() => OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null);
		if (OverworldBallManager.Instance != null && OverworldBallManager.Instance.Ball != null)
		{
			OverworldBallManager.Instance.Ball.SetEnableFlagsAndDoors();
			OverworldBallManager.Instance.Ball.transform.position = new Vector3(position.x, position.y, 0f);
		}
	}

	private bool CheckDoors(string level)
	{
		var doors = FindObjectsOfType<OverworldButton2D>();
		if (doors == null) return true;
		bool allOpen = true;
		foreach (var d in doors)
		{
			if (d != null && d.requireGoals != null && d.requireGoals.Any(g => g != null && g.levelData != null && (g.levelData.ID == level || g.levelData.name == level)))
			{
				if (!d.openOrOpening)
					allOpen = false;
			}
		}
		return allOpen;
	}
}
