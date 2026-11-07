using Menu.QuickMenu;
using UnityEngine;
using UnityEngine.AddressableAssets;

public class MissingSvgImage : MissingComponent<SVGImage>
{
	[SerializeField]
	private AssetReferenceT<Sprite> img;

	protected override bool NullCheck()
	{
		return false;
	}

	protected override void Replace()
	{
	}
}
