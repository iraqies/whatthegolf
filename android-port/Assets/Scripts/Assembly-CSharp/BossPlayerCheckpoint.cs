using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000633")]
public class BossPlayerCheckpoint : MonoBehaviour
{
	[Token(Token = "0x400200E")]
	[FieldOffset(Offset = "0x18")]
	public BossIslands BossIslands;

	[Token(Token = "0x400200F")]
	[FieldOffset(Offset = "0x20")]
	public FinalBoss Boss;

	[Token(Token = "0x4002010")]
	[FieldOffset(Offset = "0x28")]
	private GolfBallController currentController;

	[Token(Token = "0x4002011")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 nextEndPointPosition;

	[Token(Token = "0x4002012")]
	[FieldOffset(Offset = "0x40")]
	private List<BossIslandPart> islands;

	[Token(Token = "0x4002013")]
	[FieldOffset(Offset = "0x48")]
	private List<BossIslandPart> toBeRemoved;

	[Token(Token = "0x4002014")]
	[FieldOffset(Offset = "0x50")]
	private Transform currentCheckpoint;

	[Token(Token = "0x6001C48")]
	[Address(RVA = "0x16FEA44", Offset = "0x16FEA44", VA = "0x16FEA44")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C49")]
	[Address(RVA = "0x16FEC00", Offset = "0x16FEC00", VA = "0x16FEC00")]
	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
	}

	[Token(Token = "0x6001C4A")]
	[Address(RVA = "0x16FEC64", Offset = "0x16FEC64", VA = "0x16FEC64")]
	private void OnStageStarted(BossStage bossStage)
	{
	}

	[Token(Token = "0x6001C4B")]
	[Address(RVA = "0x16FED70", Offset = "0x16FED70", VA = "0x16FED70")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C4C")]
	[Address(RVA = "0x16FF1C0", Offset = "0x16FF1C0", VA = "0x16FF1C0")]
	public BossPlayerCheckpoint()
	{
	}
}
