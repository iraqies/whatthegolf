using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000617")]
public class BossBehaviourFollowNodes : BossBehaviour
{
	[Token(Token = "0x4001F64")]
	[FieldOffset(Offset = "0x28")]
	public BossIslands IslandsCreator;

	[Token(Token = "0x4001F65")]
	[FieldOffset(Offset = "0x30")]
	public List<Transform> Nodes;

	[Token(Token = "0x4001F66")]
	[FieldOffset(Offset = "0x38")]
	public float MoveSpeed;

	[Token(Token = "0x4001F67")]
	[FieldOffset(Offset = "0x3C")]
	public float RotateSpeed;

	[Token(Token = "0x4001F68")]
	[FieldOffset(Offset = "0x40")]
	public float UpAndDownBobSpeed;

	[Token(Token = "0x4001F69")]
	[FieldOffset(Offset = "0x44")]
	public float UpAndDownBobAmount;

	[Token(Token = "0x4001F6A")]
	[FieldOffset(Offset = "0x48")]
	public float BaseCarHeight;

	[Token(Token = "0x4001F6B")]
	[FieldOffset(Offset = "0x4C")]
	public float MaxDistanceFromCar;

	[Token(Token = "0x4001F6C")]
	[FieldOffset(Offset = "0x50")]
	public Transform Player;

	[Token(Token = "0x4001F6D")]
	[FieldOffset(Offset = "0x58")]
	private int currentNodeIndex;

	[Token(Token = "0x4001F6E")]
	[FieldOffset(Offset = "0x5C")]
	private float currentCarBaseHeight;

	[Token(Token = "0x4001F6F")]
	[FieldOffset(Offset = "0x60")]
	private float upAndDownBobVal;

	[Token(Token = "0x17000307")]
	public override Vector3 Position
	{
		[Token(Token = "0x6001BC7")]
		[Address(RVA = "0x16FAF9C", Offset = "0x16FAF9C", VA = "0x16FAF9C", Slot = "5")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x17000308")]
	public override Quaternion Rotation
	{
		[Token(Token = "0x6001BC8")]
		[Address(RVA = "0x16FB218", Offset = "0x16FB218", VA = "0x16FB218", Slot = "6")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x6001BC4")]
	[Address(RVA = "0x16FA8EC", Offset = "0x16FA8EC", VA = "0x16FA8EC", Slot = "7")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001BC5")]
	[Address(RVA = "0x16FAD60", Offset = "0x16FAD60", VA = "0x16FAD60")]
	private void OnIslandDestroyed(BossIslandPart bossIslandPart)
	{
	}

	[Token(Token = "0x6001BC6")]
	[Address(RVA = "0x16FAF08", Offset = "0x16FAF08", VA = "0x16FAF08")]
	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
	}

	[Token(Token = "0x6001BC9")]
	[Address(RVA = "0x16FB3E4", Offset = "0x16FB3E4", VA = "0x16FB3E4", Slot = "8")]
	public override float GetSpeed()
	{
		return default;
	}

	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x16FB3EC", Offset = "0x16FB3EC", VA = "0x16FB3EC")]
	public BossBehaviourFollowNodes()
	{
	}
}
