using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200078A")]
public class MoveWithAim : MonoBehaviour
{
	[Token(Token = "0x40027DF")]
	[FieldOffset(Offset = "0x18")]
	public float startOffset;

	[Token(Token = "0x40027E0")]
	[FieldOffset(Offset = "0x1C")]
	public float speed;

	[Token(Token = "0x40027E1")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 moveDirection;

	[Token(Token = "0x40027E2")]
	[FieldOffset(Offset = "0x30")]
	public GolfBallController Controller;

	[Token(Token = "0x40027E3")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 lastPosition;

	[Token(Token = "0x40027E4")]
	[FieldOffset(Offset = "0x44")]
	private float total;

	[Token(Token = "0x40027E5")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 basePosition;

	[Token(Token = "0x60022A1")]
	[Address(RVA = "0x1574D58", Offset = "0x1574D58", VA = "0x1574D58")]
	private void Start()
	{
	}

	[Token(Token = "0x60022A2")]
	[Address(RVA = "0x1574E2C", Offset = "0x1574E2C", VA = "0x1574E2C")]
	private void OnAimUpdate(Vector3 dir, bool b)
	{
	}

	[Token(Token = "0x60022A3")]
	[Address(RVA = "0x1574F04", Offset = "0x1574F04", VA = "0x1574F04")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x1574F10", Offset = "0x1574F10", VA = "0x1574F10")]
	public MoveWithAim()
	{
	}
}
