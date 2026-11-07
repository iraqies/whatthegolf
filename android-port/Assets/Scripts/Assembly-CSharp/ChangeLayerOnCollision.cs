using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000233")]
public class ChangeLayerOnCollision : MonoBehaviour
{
	[Token(Token = "0x4000B45")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask ValidLayers;

	[Token(Token = "0x4000B46")]
	[FieldOffset(Offset = "0x1C")]
	public int NewLayer;

	[Token(Token = "0x60009E6")]
	[Address(RVA = "0x1897528", Offset = "0x1897528", VA = "0x1897528")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x60009E7")]
	[Address(RVA = "0x18975C8", Offset = "0x18975C8", VA = "0x18975C8")]
	public ChangeLayerOnCollision()
	{
	}
}
