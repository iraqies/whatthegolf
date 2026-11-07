using System.Collections.Generic;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using Utility;

[Token(Token = "0x2000711")]
public class AutoArrowShooter2D : MonoBehaviour
{
	[Token(Token = "0x2000712")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x41240", Offset = "0x41240")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x400253F")]
		[FieldOffset(Offset = "0x10")]
		public GameObject a;

		[Token(Token = "0x4002540")]
		[FieldOffset(Offset = "0x18")]
		public AutoArrowShooter2D _003C_003E4__this;

		[Token(Token = "0x60020A9")]
		[Address(RVA = "0x1770468", Offset = "0x1770468", VA = "0x1770468")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x60020AA")]
		[Address(RVA = "0x1770470", Offset = "0x1770470", VA = "0x1770470")]
		internal void _003CStart_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000713")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x41250", Offset = "0x41250")]
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		[Token(Token = "0x4002541")]
		[FieldOffset(Offset = "0x10")]
		public AutoArrowShooter2D _003C_003E4__this;

		[Token(Token = "0x4002542")]
		[FieldOffset(Offset = "0x18")]
		public Arrow2D newArrow;

		[Token(Token = "0x60020AB")]
		[Address(RVA = "0x17704D4", Offset = "0x17704D4", VA = "0x17704D4")]
		public _003C_003Ec__DisplayClass19_0()
		{
		}

		[Token(Token = "0x60020AC")]
		[Address(RVA = "0x17704DC", Offset = "0x17704DC", VA = "0x17704DC")]
		internal void _003CSpawnNewArrow_003Eb__0()
		{
		}
	}

	[Token(Token = "0x4002530")]
	[FieldOffset(Offset = "0x18")]
	public Animator Animator;

	[Token(Token = "0x4002531")]
	[FieldOffset(Offset = "0x20")]
	public Transform ArcherTorso;

	[Token(Token = "0x4002532")]
	[FieldOffset(Offset = "0x28")]
	public float ShootForce;

	[Token(Token = "0x4002533")]
	[FieldOffset(Offset = "0x2C")]
	public float ShootInterval;

	[Token(Token = "0x4002534")]
	[FieldOffset(Offset = "0x30")]
	public Transform ArrowStart;

	[Token(Token = "0x4002535")]
	[FieldOffset(Offset = "0x38")]
	public Arrow2D ArrowTemplate;

	[Token(Token = "0x4002536")]
	[FieldOffset(Offset = "0x40")]
	public List<Vector2> ShootDirections;

	[Token(Token = "0x4002537")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 ShotRandomnessRange;

	[Token(Token = "0x4002538")]
	[FieldOffset(Offset = "0x50")]
	public int MaxNumberOfActiveArrows;

	[Token(Token = "0x4002539")]
	[FieldOffset(Offset = "0x58")]
	private ObjectPool<Arrow2D> arrowPool;

	[Token(Token = "0x400253A")]
	[FieldOffset(Offset = "0x60")]
	private float timer;

	[Token(Token = "0x400253B")]
	[FieldOffset(Offset = "0x64")]
	private Vector2 nextShotDirection;

	[Token(Token = "0x400253C")]
	[FieldOffset(Offset = "0x6C")]
	private Quaternion lastRot;

	[Token(Token = "0x400253D")]
	[FieldOffset(Offset = "0x80")]
	private List<Arrow2D> spawnedArrows;

	[Token(Token = "0x400253E")]
	[FieldOffset(Offset = "0x88")]
	public ClipSettingsCollection ShootSFX;

	[Token(Token = "0x60020A2")]
	[Address(RVA = "0x1513B00", Offset = "0x1513B00", VA = "0x1513B00")]
	private void Start()
	{
	}

	[Token(Token = "0x60020A3")]
	[Address(RVA = "0x1514050", Offset = "0x1514050", VA = "0x1514050")]
	private void Update()
	{
	}

	[Token(Token = "0x60020A4")]
	[Address(RVA = "0x15144DC", Offset = "0x15144DC", VA = "0x15144DC")]
	private void OnHitGoal()
	{
	}

	[Token(Token = "0x60020A5")]
	[Address(RVA = "0x1514344", Offset = "0x1514344", VA = "0x1514344")]
	public void Shoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60020A6")]
	[Address(RVA = "0x1514510", Offset = "0x1514510", VA = "0x1514510")]
	private Arrow2D SpawnNewArrow()
	{
		return null;
	}

	[Token(Token = "0x60020A7")]
	[Address(RVA = "0x15147D0", Offset = "0x15147D0", VA = "0x15147D0")]
	public AutoArrowShooter2D()
	{
	}

	[Token(Token = "0x60020A8")]
	[Address(RVA = "0x15147EC", Offset = "0x15147EC", VA = "0x15147EC")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A10", Offset = "0x65A10")]
	private void _003CStart_003Eb__15_0(GameObject a)
	{
	}
}
