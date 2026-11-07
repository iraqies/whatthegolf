using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006DB")]
public class BadlandsChickenCounter : MonoBehaviour
{
	[Token(Token = "0x40023E7")]
	[FieldOffset(Offset = "0x18")]
	public float CameraMinSpeed;

	[Token(Token = "0x40023E8")]
	[FieldOffset(Offset = "0x20")]
	public List<BadlandsChicken> Chickens;

	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0x1516FF8", Offset = "0x1516FF8", VA = "0x1516FF8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001FA9")]
	[Address(RVA = "0x15171F4", Offset = "0x15171F4", VA = "0x15171F4")]
	private void OnDeath(BadlandsChicken deadChicken)
	{
	}

	[Token(Token = "0x6001FAA")]
	[Address(RVA = "0x15172C4", Offset = "0x15172C4", VA = "0x15172C4")]
	private void Update()
	{
	}

	[Token(Token = "0x6001FAB")]
	[Address(RVA = "0x151755C", Offset = "0x151755C", VA = "0x151755C")]
	public BadlandsChickenCounter()
	{
	}
}
