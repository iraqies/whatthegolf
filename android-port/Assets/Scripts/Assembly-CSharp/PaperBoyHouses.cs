using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200012A")]
public class PaperBoyHouses : MonoBehaviour
{
	[Token(Token = "0x400052D")]
	[FieldOffset(Offset = "0x18")]
	private PaperBoyHouse[] houses;

	[Token(Token = "0x400052E")]
	[FieldOffset(Offset = "0x20")]
	private bool[] papersDelivered;

	[Token(Token = "0x400052F")]
	[FieldOffset(Offset = "0x28")]
	public Animator FlagController;

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x15D836C", Offset = "0x15D836C", VA = "0x15D836C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x15D810C", Offset = "0x15D810C", VA = "0x15D810C")]
	public void DeliverMail(PaperBoyHouse house)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x15D83F8", Offset = "0x15D83F8", VA = "0x15D83F8")]
	public PaperBoyHouses()
	{
	}
}
