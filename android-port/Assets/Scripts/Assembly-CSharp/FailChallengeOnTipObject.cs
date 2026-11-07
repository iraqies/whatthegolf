using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200044E")]
public class FailChallengeOnTipObject : MonoBehaviour
{
	[Token(Token = "0x4001769")]
	[FieldOffset(Offset = "0x18")]
	public Challenge challenge;

	[Token(Token = "0x400176A")]
	[FieldOffset(Offset = "0x20")]
	public bool FindTippablesInChildren;

	[Token(Token = "0x400176B")]
	[FieldOffset(Offset = "0x28")]
	public List<TippableObjectBase> Tippables;

	[Token(Token = "0x600142D")]
	[Address(RVA = "0x145A980", Offset = "0x145A980", VA = "0x145A980")]
	private void Awake()
	{
	}

	[Token(Token = "0x600142E")]
	[Address(RVA = "0x145AB84", Offset = "0x145AB84", VA = "0x145AB84")]
	private void OnTip(GameObject obj)
	{
	}

	[Token(Token = "0x600142F")]
	[Address(RVA = "0x145ABA0", Offset = "0x145ABA0", VA = "0x145ABA0")]
	public FailChallengeOnTipObject()
	{
	}
}
