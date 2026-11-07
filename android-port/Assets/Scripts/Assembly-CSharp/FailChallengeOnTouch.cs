using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200044F")]
public class FailChallengeOnTouch : MonoBehaviour
{
	[Token(Token = "0x400176C")]
	[FieldOffset(Offset = "0x18")]
	public bool CheckLayerMask;

	[Token(Token = "0x400176D")]
	[FieldOffset(Offset = "0x1C")]
	public LayerMask LayerMask;

	[Token(Token = "0x400176E")]
	[FieldOffset(Offset = "0x20")]
	public bool CheckTags;

	[Token(Token = "0x400176F")]
	[FieldOffset(Offset = "0x28")]
	public string[] Tags;

	[Token(Token = "0x4001770")]
	[FieldOffset(Offset = "0x30")]
	public Challenge challenge;

	[Token(Token = "0x6001430")]
	[Address(RVA = "0x145ABA8", Offset = "0x145ABA8", VA = "0x145ABA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001431")]
	[Address(RVA = "0x145AC50", Offset = "0x145AC50", VA = "0x145AC50")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6001432")]
	[Address(RVA = "0x145AE74", Offset = "0x145AE74", VA = "0x145AE74")]
	private void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6001433")]
	[Address(RVA = "0x145AFA8", Offset = "0x145AFA8", VA = "0x145AFA8")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001434")]
	[Address(RVA = "0x145B0D4", Offset = "0x145B0D4", VA = "0x145B0D4")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6001435")]
	[Address(RVA = "0x145AD84", Offset = "0x145AD84", VA = "0x145AD84")]
	private bool ValidIncomingObject(GameObject obj)
	{
		return default;
	}

	[Token(Token = "0x6001436")]
	[Address(RVA = "0x145B200", Offset = "0x145B200", VA = "0x145B200")]
	public FailChallengeOnTouch()
	{
	}
}
