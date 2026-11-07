using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000442")]
public class ChallengeHoleAbsorber : MonoBehaviour
{
	[Token(Token = "0x4001743")]
	[FieldOffset(Offset = "0x18")]
	public Action<GameObject> onStoneSwallow;

	[Token(Token = "0x6001402")]
	[Address(RVA = "0x189419C", Offset = "0x189419C", VA = "0x189419C")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6001403")]
	[Address(RVA = "0x1894258", Offset = "0x1894258", VA = "0x1894258")]
	public ChallengeHoleAbsorber()
	{
	}
}
