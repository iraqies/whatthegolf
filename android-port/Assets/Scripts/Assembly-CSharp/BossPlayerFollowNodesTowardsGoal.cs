using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000637")]
public class BossPlayerFollowNodesTowardsGoal : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000638")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40AE0", Offset = "0x40AE0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002033")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002034")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Transform, float> _003C_003E9__10_0;

		[Token(Token = "0x4002035")]
		[FieldOffset(Offset = "0x10")]
		public static Func<Transform, float> _003C_003E9__11_0;

		[Token(Token = "0x4002036")]
		[FieldOffset(Offset = "0x18")]
		public static Func<Transform, float> _003C_003E9__12_0;

		[Token(Token = "0x6001C5E")]
		[Address(RVA = "0x17771E0", Offset = "0x17771E0", VA = "0x17771E0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6001C5F")]
		[Address(RVA = "0x17771E8", Offset = "0x17771E8", VA = "0x17771E8")]
		internal float _003CStart_003Eb__10_0(Transform n)
		{
			return default;
		}

		[Token(Token = "0x6001C60")]
		[Address(RVA = "0x1777210", Offset = "0x1777210", VA = "0x1777210")]
		internal float _003CNewIslandSpawned_003Eb__11_0(Transform n)
		{
			return default;
		}

		[Token(Token = "0x6001C61")]
		[Address(RVA = "0x1777238", Offset = "0x1777238", VA = "0x1777238")]
		internal float _003CFixedUpdate_003Eb__12_0(Transform n)
		{
			return default;
		}
	}

	[Token(Token = "0x4002029")]
	[FieldOffset(Offset = "0x18")]
	public BossIslands IslandsCreator;

	[Token(Token = "0x400202A")]
	[FieldOffset(Offset = "0x20")]
	public Rigidbody PlayerRigid;

	[Token(Token = "0x400202B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private List<Transform> nodes;

	[Token(Token = "0x400202C")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve MoveSpeed;

	[Token(Token = "0x400202D")]
	[FieldOffset(Offset = "0x38")]
	public float RotateSpeed;

	[Token(Token = "0x400202E")]
	[FieldOffset(Offset = "0x3C")]
	public float MoveSpeedIncreaseSpeed;

	[Token(Token = "0x400202F")]
	[FieldOffset(Offset = "0x40")]
	public Transform Goal;

	[Token(Token = "0x4002030")]
	[FieldOffset(Offset = "0x48")]
	public float DeathTimer;

	[Token(Token = "0x4002031")]
	[FieldOffset(Offset = "0x4C")]
	public float minDistance;

	[Token(Token = "0x4002032")]
	[FieldOffset(Offset = "0x50")]
	private float moveTimer;

	[Token(Token = "0x6001C57")]
	[Address(RVA = "0x16FF2D8", Offset = "0x16FF2D8", VA = "0x16FF2D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6001C58")]
	[Address(RVA = "0x16FF678", Offset = "0x16FF678", VA = "0x16FF678")]
	private void NewIslandSpawned(BossIslandPart bossIslandPart)
	{
	}

	[Token(Token = "0x6001C59")]
	[Address(RVA = "0x16FF834", Offset = "0x16FF834", VA = "0x16FF834")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6001C5A")]
	[Address(RVA = "0x16FFD54", Offset = "0x16FFD54", VA = "0x16FFD54")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x6001C5B")]
	[Address(RVA = "0x16FFE20", Offset = "0x16FFE20", VA = "0x16FFE20")]
	private void OnTriggerStay(Collider other)
	{
	}

	[Token(Token = "0x6001C5C")]
	[Address(RVA = "0x16FFE9C", Offset = "0x16FFE9C", VA = "0x16FFE9C")]
	public BossPlayerFollowNodesTowardsGoal()
	{
	}
}
