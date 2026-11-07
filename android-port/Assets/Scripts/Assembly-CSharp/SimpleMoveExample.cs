using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000015")]
public class SimpleMoveExample : MonoBehaviour
{
	[Token(Token = "0x400004C")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_previous;

	[Token(Token = "0x400004D")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_target;

	[Token(Token = "0x400004E")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_originalPosition;

	[Token(Token = "0x400004F")]
	[FieldOffset(Offset = "0x3C")]
	public Vector3 BoundingVolume;

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x48")]
	public float Speed;

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x16ACEA0", Offset = "0x16ACEA0", VA = "0x16ACEA0")]
	private void Start()
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x16ACF1C", Offset = "0x16ACF1C", VA = "0x16ACF1C")]
	private void Update()
	{
	}

	[Token(Token = "0x6000058")]
	[Address(RVA = "0x16AD0F0", Offset = "0x16AD0F0", VA = "0x16AD0F0")]
	public SimpleMoveExample()
	{
	}
}
