using System.Collections;
using System.Threading.Tasks;
using UnityEngine;

public class GeneralCampaignStarter : BasePackStarter
{
	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		return false;
	}

	private IEnumerator StartPack(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		return null;
	}

	public Task StartCampaign(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		return null;
	}

	private IEnumerator StartCampaignCR(ContentPack pack, string level = null, Transmogrif.BALLSHAPES shape = Transmogrif.BALLSHAPES.ball)
	{
		return null;
	}

	private IEnumerator GoToComputerCR(string notificationId)
	{
		return null;
	}

	private IEnumerator AwaitLevelLoadCR(float delay)
	{
		return null;
	}

	private IEnumerator GoToLevelCR(string level, Transmogrif.BALLSHAPES shape, float delay = 0f)
	{
		return null;
	}

	private IEnumerator GoToPosition(Vector2 position)
	{
		return null;
	}

	private bool CheckDoors(string level)
	{
		return false;
	}
}
