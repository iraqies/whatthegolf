using System;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000419")]
public class ReachGoalChallenge : Challenge
{
	[Serializable]
	[Token(Token = "0x200041A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3F9EC", Offset = "0x3F9EC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400166F")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4001670")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__5_0;

		[Token(Token = "0x600134F")]
		[Address(RVA = "0x1830A78", Offset = "0x1830A78", VA = "0x1830A78")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001350")]
		[Address(RVA = "0x1830A80", Offset = "0x1830A80", VA = "0x1830A80")]
		internal void _003COnLevelComplete_003Eb__5_0(float v)
		{
		}
	}

	[Token(Token = "0x400166D")]
	[FieldOffset(Offset = "0xA1")]
	public bool CompleteAfterDelay;

	[Token(Token = "0x400166E")]
	[FieldOffset(Offset = "0xA4")]
	public float delay;

	[Token(Token = "0x6001349")]
	[Address(RVA = "0x1641F60", Offset = "0x1641F60", VA = "0x1641F60", Slot = "8")]
	protected override void Activate()
	{
	}

	[Token(Token = "0x600134A")]
	[Address(RVA = "0x1641F64", Offset = "0x1641F64", VA = "0x1641F64", Slot = "5")]
	public override string GetDescription()
	{
		return null;
	}

	[Token(Token = "0x600134B")]
	[Address(RVA = "0x1642034", Offset = "0x1642034", VA = "0x1642034", Slot = "6")]
	public override string GetWinMessageID()
	{
		return null;
	}

	[Token(Token = "0x600134C")]
	[Address(RVA = "0x1642098", Offset = "0x1642098", VA = "0x1642098", Slot = "10")]
	public override void OnLevelComplete(Level.CompletedState completedState)
	{
	}

	[Token(Token = "0x600134D")]
	[Address(RVA = "0x1642270", Offset = "0x1642270", VA = "0x1642270")]
	public ReachGoalChallenge()
	{
	}
}
