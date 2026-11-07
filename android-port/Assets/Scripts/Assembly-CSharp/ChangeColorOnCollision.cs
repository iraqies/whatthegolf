using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000BCC")]
public class ChangeColorOnCollision : MonoBehaviour
{
	[Token(Token = "0x40041AD")]
	[FieldOffset(Offset = "0x18")]
	public Renderer RendererToChange;

	[Token(Token = "0x40041AE")]
	[FieldOffset(Offset = "0x20")]
	public Color Color;

	[Token(Token = "0x40041AF")]
	[FieldOffset(Offset = "0x30")]
	public LayerMask HitLayer;

	[Token(Token = "0x60038C7")]
	[Address(RVA = "0x189681C", Offset = "0x189681C", VA = "0x189681C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60038C8")]
	[Address(RVA = "0x18968C8", Offset = "0x18968C8", VA = "0x18968C8")]
	public ChangeColorOnCollision()
	{
	}
}
