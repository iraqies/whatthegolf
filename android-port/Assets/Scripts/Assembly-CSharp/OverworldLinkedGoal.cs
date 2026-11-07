using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A0B")]
public class OverworldLinkedGoal : GolfBehaviour
{
	[Serializable]
	[Token(Token = "0x2000A0C")]
	public class LinkedLevelData
	{
		[Token(Token = "0x4003779")]
		[FieldOffset(Offset = "0x10")]
		public LevelData LevelData;

		[Token(Token = "0x400377A")]
		[FieldOffset(Offset = "0x18")]
		public List<LevelData> AdditionalLevels;

		[Token(Token = "0x6002FAF")]
		[Address(RVA = "0x18126EC", Offset = "0x18126EC", VA = "0x18126EC")]
		public LinkedLevelData()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000A0D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42938", Offset = "0x42938")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x400377B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x400377C")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Collider2D, bool> _003C_003E9__11_0;

		[Token(Token = "0x6002FB1")]
		[Address(RVA = "0x1812694", Offset = "0x1812694", VA = "0x1812694")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0x181269C", Offset = "0x181269C", VA = "0x181269C")]
		internal bool _003CAwake_003Eb__11_0(Collider2D col)
		{
			return default;
		}
	}

	[Token(Token = "0x2000A0E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42948", Offset = "0x42948")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x400377D")]
		[FieldOffset(Offset = "0x10")]
		public Collider2D col;

		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0x18126C4", Offset = "0x18126C4", VA = "0x18126C4")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0x18126CC", Offset = "0x18126CC", VA = "0x18126CC")]
		internal void _003COnCollisionEnter2D_003Eb__0(OverworldGoal g)
		{
		}
	}

	[Token(Token = "0x4003770")]
	[FieldOffset(Offset = "0x20")]
	public List<OverworldGoal> Flags;

	[Token(Token = "0x4003771")]
	[FieldOffset(Offset = "0x28")]
	public List<LinkedLevelData> OrderedLevels;

	[Token(Token = "0x4003772")]
	[FieldOffset(Offset = "0x30")]
	private OverworldManager2d Manager;

	[Token(Token = "0x4003773")]
	[FieldOffset(Offset = "0x38")]
	private int completed;

	[Token(Token = "0x4003774")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<Collider2D, Collider2D[]> goals;

	[Token(Token = "0x4003775")]
	[FieldOffset(Offset = "0x48")]
	private int[] completeOrder;

	[Token(Token = "0x4003776")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Collider2D circleCollider;

	[Token(Token = "0x4003777")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private Collider2D boxCollider;

	[Token(Token = "0x4003778")]
	[FieldOffset(Offset = "0x60")]
	private readonly string saveFormat;

	[Token(Token = "0x6002FA7")]
	[Address(RVA = "0x15BAF68", Offset = "0x15BAF68", VA = "0x15BAF68", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x6002FA8")]
	[Address(RVA = "0x15BAFF4", Offset = "0x15BAFF4", VA = "0x15BAFF4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002FA9")]
	[Address(RVA = "0x15BBAFC", Offset = "0x15BBAFC", VA = "0x15BBAFC")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002FAA")]
	[Address(RVA = "0x15BBE18", Offset = "0x15BBE18", VA = "0x15BBE18")]
	private void OnlevelAbandoned(OverworldGoal overworldGoal)
	{
	}

	[Token(Token = "0x6002FAB")]
	[Address(RVA = "0x15BBF5C", Offset = "0x15BBF5C", VA = "0x15BBF5C")]
	private void OnlevelCompleted(OverworldGoal overworldGoal, bool parUnlocked)
	{
	}

	[Token(Token = "0x6002FAC")]
	[Address(RVA = "0x15BC148", Offset = "0x15BC148", VA = "0x15BC148")]
	private void OnCollisionEnter2D(Collision2D other)
	{
	}

	[Token(Token = "0x6002FAD")]
	[Address(RVA = "0x15BC4B4", Offset = "0x15BC4B4", VA = "0x15BC4B4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002FAE")]
	[Address(RVA = "0x15BC53C", Offset = "0x15BC53C", VA = "0x15BC53C")]
	public OverworldLinkedGoal()
	{
	}
}
