using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006AF")]
public class CarGoalCounter : MonoBehaviour
{
	[Token(Token = "0x40022EF")]
	[FieldOffset(Offset = "0x18")]
	private int currentPlayerPosition;

	[Token(Token = "0x40022F0")]
	[FieldOffset(Offset = "0x20")]
	private List<CarOpponentController> opponentsInGoal;

	[Token(Token = "0x6001EC3")]
	[Address(RVA = "0x1889718", Offset = "0x1889718", VA = "0x1889718")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001EC4")]
	[Address(RVA = "0x1889790", Offset = "0x1889790", VA = "0x1889790")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6001EC5")]
	[Address(RVA = "0x18899BC", Offset = "0x18899BC", VA = "0x18899BC")]
	public CarGoalCounter()
	{
	}
}
