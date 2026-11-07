using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using RedBlueGames.Tools.TextTyper;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200087D")]
public class AdventureShooter : GolfBall2DShooterBase
{
	[Serializable]
	[Token(Token = "0x200087E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B10", Offset = "0x41B10")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002E8E")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002E8F")]
		[FieldOffset(Offset = "0x8")]
		public static Func<GameObject, bool> _003C_003E9__10_0;

		[Token(Token = "0x6002733")]
		[Address(RVA = "0x1768F2C", Offset = "0x1768F2C", VA = "0x1768F2C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002734")]
		[Address(RVA = "0x1768F34", Offset = "0x1768F34", VA = "0x1768F34")]
		internal bool _003COnAimUpdate_003Eb__10_0(GameObject c)
		{
			return default;
		}
	}

	[Token(Token = "0x4002E86")]
	[FieldOffset(Offset = "0x48")]
	public Transform DialogueTree;

	[Token(Token = "0x4002E87")]
	[FieldOffset(Offset = "0x50")]
	public Text MainText;

	[Token(Token = "0x4002E88")]
	[FieldOffset(Offset = "0x58")]
	public List<GameObject> Choices;

	[Token(Token = "0x4002E89")]
	[FieldOffset(Offset = "0x60")]
	private Transform currentRoom;

	[Token(Token = "0x4002E8A")]
	[FieldOffset(Offset = "0x68")]
	private bool winOnShot;

	[Token(Token = "0x4002E8B")]
	[FieldOffset(Offset = "0x70")]
	private TextTyper textTyper;

	[Token(Token = "0x4002E8C")]
	[FieldOffset(Offset = "0x78")]
	private bool hasFinishedPrinting;

	[Token(Token = "0x4002E8D")]
	[FieldOffset(Offset = "0x7C")]
	private int choiceIndex;

	[Token(Token = "0x6002728")]
	[Address(RVA = "0x140A554", Offset = "0x140A554", VA = "0x140A554")]
	private void Start()
	{
	}

	[Token(Token = "0x6002729")]
	[Address(RVA = "0x140A8B8", Offset = "0x140A8B8", VA = "0x140A8B8")]
	private void PrintCompleted()
	{
	}

	[Token(Token = "0x600272A")]
	[Address(RVA = "0x140AAEC", Offset = "0x140AAEC", VA = "0x140AAEC", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600272B")]
	[Address(RVA = "0x140AF28", Offset = "0x140AF28", VA = "0x140AF28", Slot = "8")]
	public override void OnCancel()
	{
	}

	[Token(Token = "0x600272C")]
	[Address(RVA = "0x140AF54", Offset = "0x140AF54", VA = "0x140AF54", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600272D")]
	[Address(RVA = "0x140B220", Offset = "0x140B220", VA = "0x140B220")]
	private void Update()
	{
	}

	[Token(Token = "0x600272E")]
	[Address(RVA = "0x140A634", Offset = "0x140A634", VA = "0x140A634")]
	private void SetCurrentRoom(Transform room)
	{
	}

	[Token(Token = "0x600272F")]
	[Address(RVA = "0x140B3D4", Offset = "0x140B3D4", VA = "0x140B3D4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6002730")]
	[Address(RVA = "0x140B410", Offset = "0x140B410", VA = "0x140B410")]
	private void DrawRoomConnections(Transform room)
	{
	}

	[Token(Token = "0x6002731")]
	[Address(RVA = "0x140B780", Offset = "0x140B780", VA = "0x140B780")]
	public AdventureShooter()
	{
	}
}
