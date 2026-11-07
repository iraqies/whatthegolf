using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200044A")]
public abstract class ChallengeTriggerBase : MonoBehaviour
{
	[Token(Token = "0x4001758")]
	[FieldOffset(Offset = "0x18")]
	public Action<ChallengeTriggerBase> OnTrigger;

	[Token(Token = "0x600141E")]
	[Address(RVA = "0x1895598", Offset = "0x1895598", VA = "0x1895598")]
	protected ChallengeTriggerBase()
	{
	}
}
