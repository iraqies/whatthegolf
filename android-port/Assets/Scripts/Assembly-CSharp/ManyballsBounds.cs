using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007CE")]
public class ManyballsBounds : MonoBehaviour
{
	[Token(Token = "0x4002950")]
	[FieldOffset(Offset = "0x18")]
	private List<GolfBallController> balls;

	[Token(Token = "0x60023BF")]
	[Address(RVA = "0x155AD84", Offset = "0x155AD84", VA = "0x155AD84")]
	private void Start()
	{
	}

	[Token(Token = "0x60023C0")]
	[Address(RVA = "0x155AE24", Offset = "0x155AE24", VA = "0x155AE24")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x155AF74", Offset = "0x155AF74", VA = "0x155AF74")]
	public ManyballsBounds()
	{
	}
}
