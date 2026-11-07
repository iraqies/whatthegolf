using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000788")]
public class MoveBasedOnX : MonoBehaviour
{
	[Token(Token = "0x40027CA")]
	[FieldOffset(Offset = "0x18")]
	public Transform trackObject;

	[Token(Token = "0x40027CB")]
	[FieldOffset(Offset = "0x20")]
	public Transform A;

	[Token(Token = "0x40027CC")]
	[FieldOffset(Offset = "0x28")]
	public Transform B;

	[Token(Token = "0x40027CD")]
	[FieldOffset(Offset = "0x30")]
	public float offsetTimer;

	[Token(Token = "0x40027CE")]
	[FieldOffset(Offset = "0x34")]
	public float Speed;

	[Token(Token = "0x40027CF")]
	[FieldOffset(Offset = "0x38")]
	private Rigidbody2D rigid;

	[Token(Token = "0x40027D0")]
	[FieldOffset(Offset = "0x40")]
	private float timer;

	[Token(Token = "0x40027D1")]
	[FieldOffset(Offset = "0x44")]
	private float baseX;

	[Token(Token = "0x600229A")]
	[Address(RVA = "0x1570734", Offset = "0x1570734", VA = "0x1570734")]
	private void Awake()
	{
	}

	[Token(Token = "0x600229B")]
	[Address(RVA = "0x15707A8", Offset = "0x15707A8", VA = "0x15707A8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600229C")]
	[Address(RVA = "0x1570884", Offset = "0x1570884", VA = "0x1570884")]
	public MoveBasedOnX()
	{
	}
}
