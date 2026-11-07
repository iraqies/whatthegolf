using System.Collections;
using System.Collections.Generic;

public class ShowToAFriend : BasePackStarter
{
	private ContentPack _pack;

	private List<LevelDataAndChallenge> _levels;

	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		return false;
	}

	private IEnumerator StartPackCR(ContentPack pack)
	{
		return null;
	}

	public void StartShowToAFriend(bool allowMenuButtons)
	{
	}

	private IEnumerator PlayShowToAFriendLevels(bool allowMenuButtons)
	{
		return null;
	}

	private void GoToHub()
	{
	}
}
