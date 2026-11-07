using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200040D")]
public class MaxPowerChallenge : Challenge
{
	[Token(Token = "0x4001617")]
	[FieldOffset(Offset = "0xA8")]
	private GolfBallController _controller;

	[Token(Token = "0x6001307")]
	[Address(RVA = "0x155F80C", Offset = "0x155F80C", VA = "0x155F80C", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x6001308")]
	[Address(RVA = "0x155F908", Offset = "0x155F908", VA = "0x155F908", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x6001309")]
	[Address(RVA = "0x155F910", Offset = "0x155F910", VA = "0x155F910")]
	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600130A")]
	[Address(RVA = "0x155F968", Offset = "0x155F968", VA = "0x155F968", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600130B")]
	[Address(RVA = "0x155FA38", Offset = "0x155FA38", VA = "0x155FA38", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x600130C")]
	[Address(RVA = "0x155FA9C", Offset = "0x155FA9C", VA = "0x155FA9C")]
	public MaxPowerChallenge()
	{
	}
}
