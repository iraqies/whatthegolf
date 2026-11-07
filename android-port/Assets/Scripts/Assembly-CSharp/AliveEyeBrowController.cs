using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D5C")]
public class AliveEyeBrowController : MonoBehaviour
{
	[Token(Token = "0x400489A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject madEyebrow;

	[Token(Token = "0x400489B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject surprisedEyebrow;

	[Token(Token = "0x400489C")]
	[FieldOffset(Offset = "0x28")]
	public int hitAmountBeforeMadMin;

	[Token(Token = "0x400489D")]
	[FieldOffset(Offset = "0x2C")]
	public int hitAmountBeforeMadMax;

	[Token(Token = "0x400489E")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent OnHitNoMad;

	[Token(Token = "0x400489F")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnHitMad;

	[Token(Token = "0x40048A0")]
	[FieldOffset(Offset = "0x40")]
	private bool hasAwakened;

	[Token(Token = "0x40048A1")]
	[FieldOffset(Offset = "0x44")]
	private int timesHit;

	[Token(Token = "0x40048A2")]
	[FieldOffset(Offset = "0x48")]
	private int randomHitBeforeMad;

	[Token(Token = "0x6003ED7")]
	[Address(RVA = "0x140D23C", Offset = "0x140D23C", VA = "0x140D23C")]
	private void Start()
	{
	}

	[Token(Token = "0x6003ED8")]
	[Address(RVA = "0x140D26C", Offset = "0x140D26C", VA = "0x140D26C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003ED9")]
	[Address(RVA = "0x140D39C", Offset = "0x140D39C", VA = "0x140D39C")]
	public AliveEyeBrowController()
	{
	}
}
