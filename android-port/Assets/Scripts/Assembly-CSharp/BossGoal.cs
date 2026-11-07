using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000629")]
public class BossGoal : GolfGoal
{
	[Token(Token = "0x4001FD3")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4E40C", Offset = "0x4E40C")]
	private new Action<string> m_OnGoal;

	[Token(Token = "0x4001FD4")]
	[FieldOffset(Offset = "0x50")]
	public Animator RobotFaceAnimator;

	[Token(Token = "0x14000027")]
	public new event Action<string> OnGoal
	{
		[Token(Token = "0x6001C13")]
		[Address(RVA = "0x16FCD88", Offset = "0x16FCD88", VA = "0x16FCD88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63E1C", Offset = "0x63E1C")]
		add
		{
		}
		[Token(Token = "0x6001C14")]
		[Address(RVA = "0x16FCE2C", Offset = "0x16FCE2C", VA = "0x16FCE2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x63E2C", Offset = "0x63E2C")]
		remove
		{
		}
	}

	[Token(Token = "0x6001C15")]
	[Address(RVA = "0x16FCED0", Offset = "0x16FCED0", VA = "0x16FCED0", Slot = "7")]
	public override void Complete(string message)
	{
	}

	[Token(Token = "0x6001C16")]
	[Address(RVA = "0x16FCFC0", Offset = "0x16FCFC0", VA = "0x16FCFC0", Slot = "8")]
	public override void Complete(string message, float delay)
	{
	}

	[Token(Token = "0x6001C17")]
	[Address(RVA = "0x16FD088", Offset = "0x16FD088", VA = "0x16FD088")]
	public BossGoal()
	{
	}
}
