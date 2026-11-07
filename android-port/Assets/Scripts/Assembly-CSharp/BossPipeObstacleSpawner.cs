using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000632")]
public class BossPipeObstacleSpawner : MonoBehaviour
{
	[Token(Token = "0x4002001")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> Obstacles;

	[Token(Token = "0x4002002")]
	[FieldOffset(Offset = "0x20")]
	public Vector2 TimerIntervalRange;

	[Token(Token = "0x4002003")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 PipeAngleRange;

	[Token(Token = "0x4002004")]
	[FieldOffset(Offset = "0x30")]
	public BossStage Stage;

	[Token(Token = "0x4002005")]
	[FieldOffset(Offset = "0x38")]
	public Rigidbody PipeRigid;

	[Token(Token = "0x4002006")]
	[FieldOffset(Offset = "0x40")]
	public Transform Boss;

	[Token(Token = "0x4002007")]
	[FieldOffset(Offset = "0x48")]
	public float PipeMoveSpeed;

	[Token(Token = "0x4002008")]
	[FieldOffset(Offset = "0x50")]
	public Transform ItemSpawnPosition;

	[Token(Token = "0x4002009")]
	[FieldOffset(Offset = "0x58")]
	public float StartDelay;

	[Token(Token = "0x400200A")]
	[FieldOffset(Offset = "0x5C")]
	public float SpawnDistance;

	[Token(Token = "0x400200B")]
	[FieldOffset(Offset = "0x60")]
	private float timer;

	[Token(Token = "0x400200C")]
	[FieldOffset(Offset = "0x64")]
	private float nextAngle;

	[Token(Token = "0x400200D")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 lastSpawnPos;

	[Token(Token = "0x6001C41")]
	[Address(RVA = "0x16FE498", Offset = "0x16FE498", VA = "0x16FE498")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001C42")]
	[Address(RVA = "0x16FE6FC", Offset = "0x16FE6FC", VA = "0x16FE6FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001C43")]
	[Address(RVA = "0x16FE8E8", Offset = "0x16FE8E8", VA = "0x16FE8E8")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001C44")]
	[Address(RVA = "0x16FE698", Offset = "0x16FE698", VA = "0x16FE698")]
	private void SetupNext()
	{
	}

	[Token(Token = "0x6001C45")]
	[Address(RVA = "0x16FEA04", Offset = "0x16FEA04", VA = "0x16FEA04")]
	public BossPipeObstacleSpawner()
	{
	}

	[Token(Token = "0x6001C46")]
	[Address(RVA = "0x16FEA2C", Offset = "0x16FEA2C", VA = "0x16FEA2C")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F4C", Offset = "0x63F4C")]
	private void _003CAwake_003Eb__13_0()
	{
	}

	[Token(Token = "0x6001C47")]
	[Address(RVA = "0x16FEA38", Offset = "0x16FEA38", VA = "0x16FEA38")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x63F5C", Offset = "0x63F5C")]
	private void _003CAwake_003Eb__13_1()
	{
	}
}
