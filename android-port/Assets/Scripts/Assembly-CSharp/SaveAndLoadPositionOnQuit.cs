using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B48")]
public class SaveAndLoadPositionOnQuit : GolfBehaviour
{
	[Token(Token = "0x2000B49")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x43780", Offset = "0x43780")]
	private sealed class _003C_003Ec__DisplayClass17_0
	{
		[Token(Token = "0x4003ED2")]
		[FieldOffset(Offset = "0x10")]
		public string savePosition;

		[Token(Token = "0x60035AB")]
		[Address(RVA = "0x1839560", Offset = "0x1839560", VA = "0x1839560")]
		public _003C_003Ec__DisplayClass17_0()
		{
		}

		[Token(Token = "0x60035AC")]
		[Address(RVA = "0x1839568", Offset = "0x1839568", VA = "0x1839568")]
		internal bool _003CTeleportBallToCurrentSpot_003Eb__0(SaveSpot s)
		{
			return default;
		}
	}

	[Token(Token = "0x2000B4A")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x43790", Offset = "0x43790")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x4003ED3")]
		[FieldOffset(Offset = "0x10")]
		public string savePosition;

		[Token(Token = "0x60035AD")]
		[Address(RVA = "0x18395CC", Offset = "0x18395CC", VA = "0x18395CC")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60035AE")]
		[Address(RVA = "0x18395D4", Offset = "0x18395D4", VA = "0x18395D4")]
		internal bool _003CHubSectionFromSaveSpot_003Eb__0(SaveSpot s)
		{
			return default;
		}
	}

	[Token(Token = "0x4003EC3")]
	[FieldOffset(Offset = "0x20")]
	public GridFiller grid;

	[Token(Token = "0x4003EC4")]
	[FieldOffset(Offset = "0x28")]
	public float CheckInterval;

	[Token(Token = "0x4003EC5")]
	[FieldOffset(Offset = "0x30")]
	private readonly string key;

	[Token(Token = "0x4003EC6")]
	[FieldOffset(Offset = "0x38")]
	private float checkTimer;

	[Token(Token = "0x4003EC7")]
	[FieldOffset(Offset = "0x40")]
	private SaveSpot lastSavePosition;

	[Token(Token = "0x4003EC8")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 lastValidPosition;

	[Token(Token = "0x4003EC9")]
	[FieldOffset(Offset = "0x54")]
	private int lastSaveShape;

	[Token(Token = "0x4003ECA")]
	[FieldOffset(Offset = "0x58")]
	private GolfBallController controller;

	[Token(Token = "0x4003ECB")]
	[FieldOffset(Offset = "0x60")]
	private bool hasValidPositionEverBeenFound;

	[Token(Token = "0x4003ECC")]
	[FieldOffset(Offset = "0x68")]
	private SaveEvents saveEvents;

	[Token(Token = "0x4003ECD")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private OverworldBallFollower follower;

	[Token(Token = "0x4003ECE")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<SaveSpot> savespots;

	[Token(Token = "0x4003ECF")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private DefaultSaveSpot deafultSaveSpot;

	[Token(Token = "0x4003ED0")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private LevelToHubSectionDictionary levelHubSections;

	[Token(Token = "0x4003ED1")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private bool isInHub;

	[Token(Token = "0x60035A2")]
	[Address(RVA = "0x166A284", Offset = "0x166A284", VA = "0x166A284", Slot = "4")]
	public override void OnPrePlayOrPreCompile()
	{
	}

	[Token(Token = "0x60035A3")]
	[Address(RVA = "0x166A76C", Offset = "0x166A76C", VA = "0x166A76C")]
	private void Start()
	{
	}

	[Token(Token = "0x60035A4")]
	[Address(RVA = "0x166AB6C", Offset = "0x166AB6C", VA = "0x166AB6C")]
	public void TeleportBallToCurrentSpot()
	{
	}

	[Token(Token = "0x60035A5")]
	[Address(RVA = "0x166AF44", Offset = "0x166AF44", VA = "0x166AF44")]
	public HubSection HubSectionFromSaveSpot(string savePosition)
	{
		return null;
	}

	[Token(Token = "0x60035A6")]
	[Address(RVA = "0x166B0C4", Offset = "0x166B0C4", VA = "0x166B0C4")]
	public List<HubSection> HubSectionFromLevelSection(OverworldLevelSection section)
	{
		return null;
	}

	[Token(Token = "0x60035A7")]
	[Address(RVA = "0x166B280", Offset = "0x166B280", VA = "0x166B280")]
	private void Instance_OnNewBall(Transmogrif.BALLSHAPES newShape)
	{
	}

	[Token(Token = "0x60035A8")]
	[Address(RVA = "0x166B3F0", Offset = "0x166B3F0", VA = "0x166B3F0")]
	private void SaveEvents_OnEnterSaveSpot(SaveSpot savespot)
	{
	}

	[Token(Token = "0x60035A9")]
	[Address(RVA = "0x166B61C", Offset = "0x166B61C", VA = "0x166B61C")]
	private void Update()
	{
	}

	[Token(Token = "0x60035AA")]
	[Address(RVA = "0x166B7B8", Offset = "0x166B7B8", VA = "0x166B7B8")]
	public SaveAndLoadPositionOnQuit()
	{
	}
}
