using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E17")]
public class FreezePos : MonoBehaviour
{
	[Token(Token = "0x4004C8D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Transform m_transform;

	[Token(Token = "0x4004C8E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool freezeX;

	[Token(Token = "0x4004C8F")]
	[FieldOffset(Offset = "0x21")]
	[SerializeField]
	private bool freezeY;

	[Token(Token = "0x4004C90")]
	[FieldOffset(Offset = "0x22")]
	[SerializeField]
	private bool freezeZ;

	[Token(Token = "0x4004C91")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 savedInitialPos;

	[Token(Token = "0x6004230")]
	[Address(RVA = "0x1473014", Offset = "0x1473014", VA = "0x1473014")]
	private void Start()
	{
	}

	[Token(Token = "0x6004231")]
	[Address(RVA = "0x147304C", Offset = "0x147304C", VA = "0x147304C")]
	private void Update()
	{
	}

	[Token(Token = "0x6004232")]
	[Address(RVA = "0x14730FC", Offset = "0x14730FC", VA = "0x14730FC")]
	public FreezePos()
	{
	}
}
