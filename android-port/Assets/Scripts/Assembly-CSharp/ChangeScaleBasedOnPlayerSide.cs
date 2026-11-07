using System;
using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20000AC")]
public class ChangeScaleBasedOnPlayerSide : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20000AD")]
	public class ScaleChange
	{
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x10")]
		public LobbySpawnPoint.SpawnPointPositions Side;

		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x14")]
		public Vector3 ScaleMod;

		[Token(Token = "0x6000300")]
		[Address(RVA = "0x17833D8", Offset = "0x17833D8", VA = "0x17833D8")]
		public ScaleChange()
		{
		}
	}

	[Token(Token = "0x20000AE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D800", Offset = "0x3D800")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x6000301")]
		[Address(RVA = "0x17833A0", Offset = "0x17833A0", VA = "0x17833A0")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x6000302")]
		[Address(RVA = "0x17833A8", Offset = "0x17833A8", VA = "0x17833A8")]
		internal bool _003CStart_003Eb__0(ScaleChange s)
		{
			return default;
		}
	}

	[Token(Token = "0x40002AB")]
	[FieldOffset(Offset = "0x18")]
	public List<ScaleChange> ScaleChanges;

	[Token(Token = "0x40002AC")]
	[FieldOffset(Offset = "0x20")]
	public GolfBallController Controller;

	[Token(Token = "0x60002FE")]
	[Address(RVA = "0x18983D4", Offset = "0x18983D4", VA = "0x18983D4")]
	private void Start()
	{
	}

	[Token(Token = "0x60002FF")]
	[Address(RVA = "0x18985BC", Offset = "0x18985BC", VA = "0x18985BC")]
	public ChangeScaleBasedOnPlayerSide()
	{
	}
}
