using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BCB")]
public class ChangeColor : MonoBehaviour
{
	[Token(Token = "0x40041A9")]
	[FieldOffset(Offset = "0x18")]
	public Renderer RendererToChange;

	[Token(Token = "0x40041AA")]
	[FieldOffset(Offset = "0x20")]
	public Color Color;

	[Token(Token = "0x40041AB")]
	[FieldOffset(Offset = "0x30")]
	public Material mat;

	[Token(Token = "0x40041AC")]
	[FieldOffset(Offset = "0x38")]
	public bool useMaterial;

	[Token(Token = "0x60038C5")]
	[Address(RVA = "0x1896654", Offset = "0x1896654", VA = "0x1896654")]
	public void Change()
	{
	}

	[Token(Token = "0x60038C6")]
	[Address(RVA = "0x18966B8", Offset = "0x18966B8", VA = "0x18966B8")]
	public ChangeColor()
	{
	}
}
