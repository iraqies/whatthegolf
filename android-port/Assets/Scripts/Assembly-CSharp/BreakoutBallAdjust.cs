using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000762")]
public class BreakoutBallAdjust : MonoBehaviour
{
	[Token(Token = "0x400272B")]
	[FieldOffset(Offset = "0x18")]
	private Rigidbody2D rigid;

	[Token(Token = "0x400272C")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 adjustAxis;

	[Token(Token = "0x400272D")]
	[FieldOffset(Offset = "0x28")]
	public float snapShootDirWithinAngle;

	[Token(Token = "0x6002209")]
	[Address(RVA = "0x17083FC", Offset = "0x17083FC", VA = "0x17083FC")]
	private void Start()
	{
	}

	[Token(Token = "0x600220A")]
	[Address(RVA = "0x1708524", Offset = "0x1708524", VA = "0x1708524")]
	private void Handle_OnShootEvent(Vector2 dir)
	{
	}

	[Token(Token = "0x600220B")]
	[Address(RVA = "0x17086BC", Offset = "0x17086BC", VA = "0x17086BC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600220C")]
	[Address(RVA = "0x170885C", Offset = "0x170885C", VA = "0x170885C")]
	public BreakoutBallAdjust()
	{
	}
}
