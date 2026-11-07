using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000CF6")]
public class AutoSnowballThrower : MonoBehaviour
{
	[Token(Token = "0x2000CF7")]
	public enum ThrowStateEnum
	{
		[Token(Token = "0x4004673")]
		Idle = 0,
		[Token(Token = "0x4004674")]
		Swinging = 1,
		[Token(Token = "0x4004675")]
		Cooldown = 2
	}

	[Token(Token = "0x4004664")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private BowlingShooter shooter;

	[Token(Token = "0x4004665")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private List<Transform> targets;

	[Token(Token = "0x4004666")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform specialTarget;

	[Token(Token = "0x4004667")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float ThrowDistance;

	[Token(Token = "0x4004668")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private Vector2 cooldownRange;

	[Token(Token = "0x4004669")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private Vector2 swingTimeRange;

	[Token(Token = "0x400466A")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	private float lookAhead;

	[Token(Token = "0x400466B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private ClipSettingsCollection sfxOnRelease;

	[Token(Token = "0x400466C")]
	[FieldOffset(Offset = "0x50")]
	private ThrowStateEnum throwState;

	[Token(Token = "0x400466D")]
	[FieldOffset(Offset = "0x54")]
	private bool specialTargetIsNext;

	[Token(Token = "0x400466E")]
	[FieldOffset(Offset = "0x58")]
	private float swingTimer;

	[Token(Token = "0x400466F")]
	[FieldOffset(Offset = "0x60")]
	private Transform target;

	[Token(Token = "0x4004670")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 currentTarget;

	[Token(Token = "0x4004671")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody targetRigid;

	[Token(Token = "0x6003D46")]
	[Address(RVA = "0x1515328", Offset = "0x1515328", VA = "0x1515328")]
	private void Start()
	{
	}

	[Token(Token = "0x6003D47")]
	[Address(RVA = "0x1515548", Offset = "0x1515548", VA = "0x1515548")]
	public void NowTargetSpecialTarget()
	{
	}

	[Token(Token = "0x6003D48")]
	[Address(RVA = "0x15153FC", Offset = "0x15153FC", VA = "0x15153FC")]
	private void GetNextTarget()
	{
	}

	[Token(Token = "0x6003D49")]
	[Address(RVA = "0x15155D4", Offset = "0x15155D4", VA = "0x15155D4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003D4A")]
	[Address(RVA = "0x1515980", Offset = "0x1515980", VA = "0x1515980")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6003D4B")]
	[Address(RVA = "0x15159BC", Offset = "0x15159BC", VA = "0x15159BC")]
	public AutoSnowballThrower()
	{
	}

	[Token(Token = "0x6003D4C")]
	[Address(RVA = "0x15159E0", Offset = "0x15159E0", VA = "0x15159E0")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C008", Offset = "0x6C008")]
	private bool _003CGetNextTarget_003Eb__17_0(Transform t)
	{
		return default;
	}
}
