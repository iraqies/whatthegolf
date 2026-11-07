using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20006FC")]
public class FanControllerTrainMovement : MonoBehaviour
{
	[Token(Token = "0x400249B")]
	[FieldOffset(Offset = "0x18")]
	public Transform Train;

	[Token(Token = "0x400249C")]
	[FieldOffset(Offset = "0x20")]
	public List<MoveObjectAlongPoints> Movers;

	[Token(Token = "0x400249D")]
	[FieldOffset(Offset = "0x28")]
	public Transform WaypointContainer;

	[Token(Token = "0x400249E")]
	[FieldOffset(Offset = "0x30")]
	public Fan Fan;

	[Token(Token = "0x400249F")]
	[FieldOffset(Offset = "0x38")]
	private GolfBallController controller;

	[Token(Token = "0x40024A0")]
	[FieldOffset(Offset = "0x40")]
	private float startupTimeTarget;

	[Token(Token = "0x40024A1")]
	[FieldOffset(Offset = "0x44")]
	private float startupTimer;

	[Token(Token = "0x6002035")]
	[Address(RVA = "0x14607EC", Offset = "0x14607EC", VA = "0x14607EC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002036")]
	[Address(RVA = "0x1460964", Offset = "0x1460964", VA = "0x1460964")]
	private void OnCancel()
	{
	}

	[Token(Token = "0x6002037")]
	[Address(RVA = "0x146096C", Offset = "0x146096C", VA = "0x146096C")]
	private void Controller_OnAimStart()
	{
	}

	[Token(Token = "0x6002038")]
	[Address(RVA = "0x1460978", Offset = "0x1460978", VA = "0x1460978")]
	private void Update()
	{
	}

	[Token(Token = "0x6002039")]
	[Address(RVA = "0x1460BA4", Offset = "0x1460BA4", VA = "0x1460BA4")]
	public FanControllerTrainMovement()
	{
	}

	[Token(Token = "0x600203A")]
	[Address(RVA = "0x1460BAC", Offset = "0x1460BAC", VA = "0x1460BAC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x658E8", Offset = "0x658E8")]
	private void _003CAwake_003Eb__7_0(Vector3 v)
	{
	}
}
