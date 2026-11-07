using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000882")]
public class LevelGate : MonoBehaviour
{
	[Token(Token = "0x4002EA3")]
	[FieldOffset(Offset = "0x18")]
	public float OpenY;

	[Token(Token = "0x4002EA4")]
	[FieldOffset(Offset = "0x1C")]
	public float CloseY;

	[Token(Token = "0x4002EA5")]
	[FieldOffset(Offset = "0x20")]
	public float Speed;

	[Token(Token = "0x4002EA6")]
	[FieldOffset(Offset = "0x24")]
	public bool IsOpen;

	[Token(Token = "0x4002EA7")]
	[FieldOffset(Offset = "0x28")]
	public int RequriedTurnOns;

	[Token(Token = "0x4002EA8")]
	[FieldOffset(Offset = "0x2C")]
	private float targetY;

	[Token(Token = "0x4002EA9")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody rigid;

	[Token(Token = "0x4002EAA")]
	[FieldOffset(Offset = "0x38")]
	private int currentOns;

	[Token(Token = "0x6002747")]
	[Address(RVA = "0x152DB40", Offset = "0x152DB40", VA = "0x152DB40")]
	private void Start()
	{
	}

	[Token(Token = "0x6002748")]
	[Address(RVA = "0x152DBC0", Offset = "0x152DBC0", VA = "0x152DBC0")]
	public void Toggle()
	{
	}

	[Token(Token = "0x6002749")]
	[Address(RVA = "0x152DBF8", Offset = "0x152DBF8", VA = "0x152DBF8")]
	public void TurnOn()
	{
	}

	[Token(Token = "0x600274A")]
	[Address(RVA = "0x152DC24", Offset = "0x152DC24", VA = "0x152DC24")]
	public void TurnOff()
	{
	}

	[Token(Token = "0x600274B")]
	[Address(RVA = "0x152DC4C", Offset = "0x152DC4C", VA = "0x152DC4C")]
	private void Update()
	{
	}

	[Token(Token = "0x600274C")]
	[Address(RVA = "0x152DD9C", Offset = "0x152DD9C", VA = "0x152DD9C")]
	public LevelGate()
	{
	}
}
