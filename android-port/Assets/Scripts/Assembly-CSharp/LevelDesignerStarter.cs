using System.Collections;
using UnityEngine;

public class LevelDesignerStarter : BasePackStarter
{
	private static ContentPack _pack;

	[SerializeField]
	private ModalWindow _earlyAccessDialog;

	public override bool StartPack(ContentPack container, params object[] additionalContext)
	{
		return false;
	}

	private IEnumerator LoadDesignerOrCommunityCR(ContentPack pack)
	{
		return null;
	}
}
