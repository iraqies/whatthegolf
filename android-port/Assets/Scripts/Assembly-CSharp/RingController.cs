using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200011E")]
public class RingController : MonoBehaviour
{
	[Token(Token = "0x200011F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB70", Offset = "0x3DB70")]
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		[Token(Token = "0x4000506")]
		[FieldOffset(Offset = "0x10")]
		public MultiplayerConfiguration.PlayerInfo player;

		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x1835524", Offset = "0x1835524", VA = "0x1835524")]
		public _003C_003Ec__DisplayClass11_0()
		{
		}

		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x183552C", Offset = "0x183552C", VA = "0x183552C")]
		internal void _003CInstanceOnOnMultiplayerSetup_003Eb__0(SetMaterialColorToPlayerColor r)
		{
		}
	}

	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x18")]
	public LobbySpawnPoint.SpawnPointPositions Side;

	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x1C")]
	public float MoveSpeed;

	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x20")]
	public List<SetMaterialColorToPlayerColor> Ring;

	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x28")]
	public SetMaterialColorToPlayerColor Ball;

	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x30")]
	public SetMaterialColorToPlayerColor Line;

	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x38")]
	public Transform Top;

	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x40")]
	public Transform Bottom;

	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x48")]
	public GolfGoal goal;

	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rigid;

	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x58")]
	private int playerIndex;

	[Token(Token = "0x60004F3")]
	[Address(RVA = "0x16581B0", Offset = "0x16581B0", VA = "0x16581B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x60004F4")]
	[Address(RVA = "0x165828C", Offset = "0x165828C", VA = "0x165828C")]
	private void InstanceOnOnMultiplayerSetup(MultiplayerLevelInfo obj)
	{
	}

	[Token(Token = "0x60004F5")]
	[Address(RVA = "0x1658568", Offset = "0x1658568", VA = "0x1658568")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60004F6")]
	[Address(RVA = "0x16587B8", Offset = "0x16587B8", VA = "0x16587B8")]
	public RingController()
	{
	}
}
