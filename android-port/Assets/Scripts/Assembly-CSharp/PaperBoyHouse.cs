using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000129")]
public class PaperBoyHouse : MonoBehaviour
{
	[Token(Token = "0x400052A")]
	[FieldOffset(Offset = "0x18")]
	private PaperBoyHouses houses;

	[Token(Token = "0x400052B")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem ConfettiSystem;

	[Token(Token = "0x400052C")]
	[FieldOffset(Offset = "0x28")]
	private Animator anim;

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x15D7FD4", Offset = "0x15D7FD4", VA = "0x15D7FD4")]
	private void Awake()
	{
	}

	[Token(Token = "0x600051A")]
	[Address(RVA = "0x15D8054", Offset = "0x15D8054", VA = "0x15D8054")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x15D80F0", Offset = "0x15D80F0", VA = "0x15D80F0")]
	private void DeliverMail()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x15D82FC", Offset = "0x15D82FC", VA = "0x15D82FC")]
	public void PlayEffects()
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x15D8364", Offset = "0x15D8364", VA = "0x15D8364")]
	public PaperBoyHouse()
	{
	}
}
