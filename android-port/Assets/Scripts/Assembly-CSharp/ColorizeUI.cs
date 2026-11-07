using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000189")]
public class ColorizeUI : MonoBehaviour
{
	[Token(Token = "0x40006F5")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Graphic[] _images;

	[Token(Token = "0x40006F6")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color _color;

	[Token(Token = "0x60006C2")]
	[Address(RVA = "0x18A909C", Offset = "0x18A909C", VA = "0x18A909C")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006C3")]
	[Address(RVA = "0x18A90A8", Offset = "0x18A90A8", VA = "0x18A90A8")]
	[Attribute(Name = "ContextMenu", RVA = "0x5EE30", Offset = "0x5EE30")]
	public void Colorize()
	{
	}

	[Token(Token = "0x60006C4")]
	[Address(RVA = "0x18A90B4", Offset = "0x18A90B4", VA = "0x18A90B4")]
	public void Colorize(Color c)
	{
	}

	[Token(Token = "0x60006C5")]
	[Address(RVA = "0x18A91D0", Offset = "0x18A91D0", VA = "0x18A91D0")]
	public ColorizeUI()
	{
	}
}
