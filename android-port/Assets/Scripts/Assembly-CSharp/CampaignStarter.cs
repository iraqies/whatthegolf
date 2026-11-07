using System.Collections;

public class CampaignStarter : BasePackStarter
{
	private OverworldManager2d overworldCaller;

	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		return false;
	}

	private IEnumerator StartCampaignCR(ContentPack pack, OverworldLevelSection section)
	{
		return null;
	}

	private void LevelAborted()
	{
	}

	private void BackFromOnboarding(bool isComplete)
	{
	}

	private IEnumerator WaitAfterLevelLoaded()
	{
		return null;
	}
}
