using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class GeneralCampaignStarter : BasePackStarter
{
	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		if (pack == null) return false;
		_ = PackStarterManager.StartPack(pack, false, additionalContext);
		return true;
	}

	private IEnumerator StartPack(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		yield return StartCampaignCR(pack, level, shape);
	}

	public Task StartCampaign(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		return PackStarterManager.StartPack(pack, false, level, shape);
	}

	private IEnumerator StartCampaignCR(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		var task = PackStarterManager.StartPack(pack, false, level, shape);
		while (!task.IsCompleted) yield return null;
		OnPackDone?.Invoke(task.Result);
	}

	private IEnumerator GoToComputerCR(string notificationId) { yield break; }
	private IEnumerator AwaitLevelLoadCR(float delay) { yield break; }
	private IEnumerator GoToLevelCR(string level, Transmogrif.BALLSHAPES shape, float delay = 0f) { yield break; }
	private IEnumerator GoToPosition(Vector2 position) { yield break; }
	private bool CheckDoors(string level) => true;
}
