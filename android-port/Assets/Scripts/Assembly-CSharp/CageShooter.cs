using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200072B")]
public class CageShooter : GolfBallShooterBase
{
	[Token(Token = "0x200072C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x412A0", Offset = "0x412A0")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x40025E1")]
		[FieldOffset(Offset = "0x10")]
		public GolfBallController controller;

		[Token(Token = "0x600211D")]
		[Address(RVA = "0x17808BC", Offset = "0x17808BC", VA = "0x17808BC")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x600211E")]
		[Address(RVA = "0x17808C4", Offset = "0x17808C4", VA = "0x17808C4")]
		internal void _003CBreakCage_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x40025DD")]
	[FieldOffset(Offset = "0x60")]
	public GameObject FreePlayerObject;

	[Token(Token = "0x40025DE")]
	[FieldOffset(Offset = "0x68")]
	public Animator Animator;

	[Token(Token = "0x40025DF")]
	[FieldOffset(Offset = "0x70")]
	public HingeJoint CageJoint;

	[Token(Token = "0x40025E0")]
	[FieldOffset(Offset = "0x78")]
	public Vector2 JointMotorForceRange;

	[Token(Token = "0x600211A")]
	[Address(RVA = "0x17E3A78", Offset = "0x17E3A78", VA = "0x17E3A78", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600211B")]
	[Address(RVA = "0x17E3BB8", Offset = "0x17E3BB8", VA = "0x17E3BB8")]
	public void BreakCage(Vector3 position)
	{
	}

	[Token(Token = "0x600211C")]
	[Address(RVA = "0x17E3D6C", Offset = "0x17E3D6C", VA = "0x17E3D6C")]
	public CageShooter()
	{
	}
}
