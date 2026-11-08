using System.Collections;

public class CampaignStarter : BasePackStarter
{
	private OverworldManager2d overworldCaller;

	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		if (pack == null) return false;
		_ = PackStarterManager.StartPack(pack, false, additionalContext);
		return true;
	}

	private IEnumerator StartCampaignCR(ContentPack pack, OverworldLevelSection section)
	{
		var task = PackStarterManager.StartPack(pack, false, section);
		while (!task.IsCompleted) yield return null;
		OnPackDone?.Invoke(task.Result);
	}

	private void LevelAborted() => OnPackDone?.Invoke(false);
	private void BackFromOnboarding(bool isComplete) => OnPackDone?.Invoke(isComplete);
	private IEnumerator WaitAfterLevelLoaded() { yield break; }
}
