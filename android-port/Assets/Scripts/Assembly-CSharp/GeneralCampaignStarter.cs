using System.Collections;
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
		yield return StartCampaignCR(pack, level, shape);
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
		SaveThrobber.HideThrobber();
		var def = CampaignDef.GetDef(pack.campaignType);
		ECampaignType cType = def != null ? def.campaignType : pack.campaignType;
		SaveGame.SetOverworld(cType);
		SaveGame.IncrementContentPackPlayCount(pack.contentPackID);
		SaveGame.LastPlayedCampaignType = cType;
		OverworldSceneLoader.LoadOverworld(pack, false);
		yield return null;
		OnPackDone?.Invoke(true);
	}

	private IEnumerator GoToComputerCR(string notificationId) { yield break; }
	private IEnumerator AwaitLevelLoadCR(float delay) { yield break; }
	private IEnumerator GoToLevelCR(string level, Transmogrif.BALLSHAPES shape, float delay = 0f) { yield break; }
	private IEnumerator GoToPosition(Vector2 position) { yield break; }
	private bool CheckDoors(string level) => true;
}
