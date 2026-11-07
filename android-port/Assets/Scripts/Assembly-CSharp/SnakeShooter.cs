using System.Collections.Generic;
using Audio;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000851")]
public class SnakeShooter : GolfBall2DShooterBase
{
	[Token(Token = "0x4002D0C")]
	[FieldOffset(Offset = "0x48")]
	public List<GameObject> FoodItems;

	[Token(Token = "0x4002D0D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Flag;

	[Token(Token = "0x4002D0E")]
	[FieldOffset(Offset = "0x58")]
	public float SpawnInterval;

	[Token(Token = "0x4002D0F")]
	[FieldOffset(Offset = "0x60")]
	public BoxCollider SpawnArea;

	[Token(Token = "0x4002D10")]
	[FieldOffset(Offset = "0x68")]
	public int EatGoal;

	[Token(Token = "0x4002D11")]
	[FieldOffset(Offset = "0x6C")]
	public LayerMask FoodLayer;

	[Token(Token = "0x4002D12")]
	[FieldOffset(Offset = "0x70")]
	public LayerMask WallLayer;

	[Token(Token = "0x4002D13")]
	[FieldOffset(Offset = "0x78")]
	public Snake2D SnakePart;

	[Token(Token = "0x4002D14")]
	[FieldOffset(Offset = "0x80")]
	public float Force;

	[Token(Token = "0x4002D15")]
	[FieldOffset(Offset = "0x88")]
	public RandomAudioClips EatClips;

	[Token(Token = "0x4002D16")]
	[FieldOffset(Offset = "0x90")]
	public RandomAudioClips FailClips;

	[Token(Token = "0x4002D17")]
	[FieldOffset(Offset = "0x98")]
	private readonly Dictionary<int, Vector2> directions;

	[Token(Token = "0x4002D18")]
	[FieldOffset(Offset = "0xA0")]
	private Quaternion targetLookAt;

	[Token(Token = "0x4002D19")]
	[FieldOffset(Offset = "0xB0")]
	private bool objectSpawnedAndAlive;

	[Token(Token = "0x4002D1A")]
	[FieldOffset(Offset = "0xB4")]
	private float objectSpawnTimer;

	[Token(Token = "0x4002D1B")]
	[FieldOffset(Offset = "0xB8")]
	private float eatCooldown;

	[Token(Token = "0x4002D1C")]
	[FieldOffset(Offset = "0xBC")]
	private bool dead;

	[Token(Token = "0x4002D1D")]
	[FieldOffset(Offset = "0xBD")]
	private bool nextSpawnIsFlag;

	[Token(Token = "0x4002D1E")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject flagRef;

	[Token(Token = "0x600265B")]
	[Address(RVA = "0x16B93F8", Offset = "0x16B93F8", VA = "0x16B93F8")]
	private void Start()
	{
	}

	[Token(Token = "0x600265C")]
	[Address(RVA = "0x16B94A0", Offset = "0x16B94A0", VA = "0x16B94A0", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600265D")]
	[Address(RVA = "0x16B95AC", Offset = "0x16B95AC", VA = "0x16B95AC", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x600265E")]
	[Address(RVA = "0x16B9684", Offset = "0x16B9684", VA = "0x16B9684")]
	private void Update()
	{
	}

	[Token(Token = "0x600265F")]
	[Address(RVA = "0x16B9A90", Offset = "0x16B9A90", VA = "0x16B9A90")]
	private void OnTriggerEnter2D(Collider2D col)
	{
	}

	[Token(Token = "0x6002660")]
	[Address(RVA = "0x16B9E3C", Offset = "0x16B9E3C", VA = "0x16B9E3C")]
	public SnakeShooter()
	{
	}
}
