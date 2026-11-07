using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000018")]
[ExecuteInEditMode]
public class SpriteMaskController : MonoBehaviour
{
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x18")]
	private SpriteRenderer m_spriteRenderer;

	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x20")]
	private Vector4 m_uvs;

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x16DA1F0", Offset = "0x16DA1F0", VA = "0x16DA1F0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x16DA2A4", Offset = "0x16DA2A4", VA = "0x16DA2A4")]
	public SpriteMaskController()
	{
	}
}
