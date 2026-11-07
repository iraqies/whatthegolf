using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200041F")]
public class SuperPuttRealtimeChallenge : Challenge
{
	[Token(Token = "0x400168C")]
	[FieldOffset(Offset = "0xA4")]
	public Vector2 ShootIntervalOverride;

	[Token(Token = "0x6001366")]
	[Address(RVA = "0x16EED80", Offset = "0x16EED80", VA = "0x16EED80", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001367")]
	[Address(RVA = "0x16EEE78", Offset = "0x16EEE78", VA = "0x16EEE78", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6001368")]
	[Address(RVA = "0x16EEE80", Offset = "0x16EEE80", VA = "0x16EEE80")]
	public SuperPuttRealtimeChallenge()
	{
	}
}
