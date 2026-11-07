using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200031F")]
public class SpawnNewBallAfterShot : MonoBehaviour
{
	[Token(Token = "0x2000320")]
	public enum SpawnOrder
	{
		[Token(Token = "0x400115E")]
		Random = 0,
		[Token(Token = "0x400115F")]
		NextInList = 1
	}

	[Token(Token = "0x400114F")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> m_ball;

	[Token(Token = "0x4001150")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem OnDestroySystem;

	[Token(Token = "0x4001151")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SpawnOrder spawnOrder;

	[Token(Token = "0x4001152")]
	[FieldOffset(Offset = "0x2C")]
	private int NumBallsSpawned;

	[Token(Token = "0x4001153")]
	[FieldOffset(Offset = "0x30")]
	public float maxWaitTime;

	[Token(Token = "0x4001154")]
	[FieldOffset(Offset = "0x34")]
	public int maxAmount;

	[Token(Token = "0x4001155")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> doughnuts;

	[Token(Token = "0x4001156")]
	[FieldOffset(Offset = "0x40")]
	private float shootTime;

	[Token(Token = "0x4001157")]
	[FieldOffset(Offset = "0x48")]
	private GameObject ball;

	[Token(Token = "0x4001158")]
	[FieldOffset(Offset = "0x50")]
	private GolfBallController controller;

	[Token(Token = "0x4001159")]
	[FieldOffset(Offset = "0x58")]
	public ClipSettingsCollection OnAppear;

	[Token(Token = "0x400115A")]
	[FieldOffset(Offset = "0x60")]
	public bool isWon;

	[Token(Token = "0x400115B")]
	[FieldOffset(Offset = "0x61")]
	public bool destroy;

	[Token(Token = "0x400115C")]
	[FieldOffset(Offset = "0x62")]
	private bool checkForZeroVel;

	[Token(Token = "0x6000E64")]
	[Address(RVA = "0x16C7810", Offset = "0x16C7810", VA = "0x16C7810")]
	public void Complete()
	{
	}

	[Token(Token = "0x6000E65")]
	[Address(RVA = "0x16C781C", Offset = "0x16C781C", VA = "0x16C781C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000E66")]
	[Address(RVA = "0x16C7820", Offset = "0x16C7820", VA = "0x16C7820")]
	private void SpawnNew()
	{
	}

	[Token(Token = "0x6000E67")]
	[Address(RVA = "0x16C7B28", Offset = "0x16C7B28", VA = "0x16C7B28")]
	private int GetNextIndex()
	{
		return default;
	}

	[Token(Token = "0x6000E68")]
	[Address(RVA = "0x16C7BE4", Offset = "0x16C7BE4", VA = "0x16C7BE4")]
	private void StartCheck(Vector3 boost)
	{
	}

	[Token(Token = "0x6000E69")]
	[Address(RVA = "0x16C7CAC", Offset = "0x16C7CAC", VA = "0x16C7CAC")]
	private void Update()
	{
	}

	[Token(Token = "0x6000E6A")]
	[Address(RVA = "0x16C7E58", Offset = "0x16C7E58", VA = "0x16C7E58")]
	public SpawnNewBallAfterShot()
	{
	}
}
