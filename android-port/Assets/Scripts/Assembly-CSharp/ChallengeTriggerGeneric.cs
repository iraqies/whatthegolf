using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x200044B")]
public class ChallengeTriggerGeneric : ChallengeTriggerBase
{
	[Token(Token = "0x4001759")]
	[FieldOffset(Offset = "0x20")]
	public bool CheckLayerMask;

	[Token(Token = "0x400175A")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask LayerMask;

	[Token(Token = "0x400175B")]
	[FieldOffset(Offset = "0x28")]
	public bool CheckTags;

	[Token(Token = "0x400175C")]
	[FieldOffset(Offset = "0x30")]
	public string[] Tags;

	[Token(Token = "0x400175D")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent TriggerEnter;

	[Token(Token = "0x600141F")]
	[Address(RVA = "0x18955A0", Offset = "0x18955A0", VA = "0x18955A0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001420")]
	[Address(RVA = "0x18957AC", Offset = "0x18957AC", VA = "0x18957AC")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6001421")]
	[Address(RVA = "0x18958D0", Offset = "0x18958D0", VA = "0x18958D0")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x6001422")]
	[Address(RVA = "0x18956BC", Offset = "0x18956BC", VA = "0x18956BC")]
	private bool ValidIncomingObject(GameObject obj)
	{
		return default;
	}

	[Token(Token = "0x6001423")]
	[Address(RVA = "0x18959EC", Offset = "0x18959EC", VA = "0x18959EC")]
	public ChallengeTriggerGeneric()
	{
	}
}
