using Il2CppDummyDll;
using Menu.QuickMenu;
using UnityEngine;
using UnityEngine.AddressableAssets;

[Token(Token = "0x20008EE")]
public class MissingSvgImage : MissingComponent<SVGImage>
{
	[Token(Token = "0x40030CC")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private AssetReferenceT<Sprite> img;

	[Token(Token = "0x6002942")]
	[Address(RVA = "0x1568EB8", Offset = "0x1568EB8", VA = "0x1568EB8", Slot = "4")]
	protected override bool NullCheck()
	{
		return default;
	}

	[Token(Token = "0x6002943")]
	[Address(RVA = "0x1568F38", Offset = "0x1568F38", VA = "0x1568F38", Slot = "5")]
	protected override void Replace()
	{
	}

	[Token(Token = "0x6002944")]
	[Address(RVA = "0x156900C", Offset = "0x156900C", VA = "0x156900C")]
	public MissingSvgImage()
	{
	}
}
