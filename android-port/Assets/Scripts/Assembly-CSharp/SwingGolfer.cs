using System;
using System.Collections.Generic;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000873")]
public class SwingGolfer : GolfBallShooterBase
{
	[Serializable]
	[Token(Token = "0x2000874")]
	public class SwingData
	{
		[Token(Token = "0x4002E63")]
		[FieldOffset(Offset = "0x10")]
		public Transform Swing;

		[Token(Token = "0x4002E64")]
		[FieldOffset(Offset = "0x18")]
		public Transform SwingPivot;

		[Token(Token = "0x4002E65")]
		[FieldOffset(Offset = "0x20")]
		public Transform SwingTarget;

		[Token(Token = "0x4002E66")]
		[FieldOffset(Offset = "0x28")]
		public Transform SwingSeat;

		[Token(Token = "0x4002E67")]
		[FieldOffset(Offset = "0x30")]
		public Rigidbody SwingRigidbody;

		[Token(Token = "0x600270E")]
		[Address(RVA = "0x186082C", Offset = "0x186082C", VA = "0x186082C")]
		public SwingData()
		{
		}
	}

	[Token(Token = "0x2000875")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41AD0", Offset = "0x41AD0")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x4002E68")]
		[FieldOffset(Offset = "0x10")]
		public GameObject newKidOnSwing;

		[Token(Token = "0x4002E69")]
		[FieldOffset(Offset = "0x18")]
		public SwingGolfer _003C_003E4__this;

		[Token(Token = "0x4002E6A")]
		[FieldOffset(Offset = "0x20")]
		public RagdollOnSwing lastKid;

		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x28")]
		public bool hitTarget;

		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x30")]
		public Action _003C_003E9__6;

		[Token(Token = "0x4002E6D")]
		[FieldOffset(Offset = "0x38")]
		public Action _003C_003E9__8;

		[Token(Token = "0x4002E6E")]
		[FieldOffset(Offset = "0x40")]
		public Action<GameObject> _003C_003E9__4;

		[Token(Token = "0x600270F")]
		[Address(RVA = "0x185FD48", Offset = "0x185FD48", VA = "0x185FD48")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x6002710")]
		[Address(RVA = "0x185FD50", Offset = "0x185FD50", VA = "0x185FD50")]
		internal void _003CKidHitGround_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002711")]
		[Address(RVA = "0x185FF08", Offset = "0x185FF08", VA = "0x185FF08")]
		internal void _003CKidHitGround_003Eb__1()
		{
		}

		[Token(Token = "0x6002712")]
		[Address(RVA = "0x185FF34", Offset = "0x185FF34", VA = "0x185FF34")]
		internal void _003CKidHitGround_003Eb__3()
		{
		}

		[Token(Token = "0x6002713")]
		[Address(RVA = "0x18602B4", Offset = "0x18602B4", VA = "0x18602B4")]
		internal void _003CKidHitGround_003Eb__6()
		{
		}

		[Token(Token = "0x6002714")]
		[Address(RVA = "0x1860310", Offset = "0x1860310", VA = "0x1860310")]
		internal void _003CKidHitGround_003Eb__4(GameObject go)
		{
		}

		[Token(Token = "0x6002715")]
		[Address(RVA = "0x18604FC", Offset = "0x18604FC", VA = "0x18604FC")]
		internal void _003CKidHitGround_003Eb__8()
		{
		}
	}

	[Token(Token = "0x2000876")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41AE0", Offset = "0x41AE0")]
	private sealed class _003C_003Ec__DisplayClass21_1
	{
		[Token(Token = "0x4002E6F")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 startPos;

		[Token(Token = "0x4002E70")]
		[FieldOffset(Offset = "0x20")]
		public _003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6002716")]
		[Address(RVA = "0x18602AC", Offset = "0x18602AC", VA = "0x18602AC")]
		public _003C_003Ec__DisplayClass21_1()
		{
		}

		[Token(Token = "0x6002717")]
		[Address(RVA = "0x1860574", Offset = "0x1860574", VA = "0x1860574")]
		internal void _003CKidHitGround_003Eb__5(float t)
		{
		}
	}

	[Token(Token = "0x2000877")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41AF0", Offset = "0x41AF0")]
	private sealed class _003C_003Ec__DisplayClass21_2
	{
		[Token(Token = "0x4002E71")]
		[FieldOffset(Offset = "0x10")]
		public GameObject go;

		[Token(Token = "0x4002E72")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals2;

		[Token(Token = "0x6002718")]
		[Address(RVA = "0x18604F4", Offset = "0x18604F4", VA = "0x18604F4")]
		public _003C_003Ec__DisplayClass21_2()
		{
		}

		[Token(Token = "0x6002719")]
		[Address(RVA = "0x1860660", Offset = "0x1860660", VA = "0x1860660")]
		internal void _003CKidHitGround_003Eb__7(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000878")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41B00", Offset = "0x41B00")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002E73")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002E74")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__21_2;

		[Token(Token = "0x600271B")]
		[Address(RVA = "0x185FD3C", Offset = "0x185FD3C", VA = "0x185FD3C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600271C")]
		[Address(RVA = "0x185FD44", Offset = "0x185FD44", VA = "0x185FD44")]
		internal void _003CKidHitGround_003Eb__21_2(float t)
		{
		}
	}

	[Token(Token = "0x4002E53")]
	[FieldOffset(Offset = "0x60")]
	public List<SwingData> Swings;

	[Token(Token = "0x4002E54")]
	[FieldOffset(Offset = "0x68")]
	public Vector2 AngleRange;

	[Token(Token = "0x4002E55")]
	[FieldOffset(Offset = "0x70")]
	public RagdollOnSwing KidOnSwing;

	[Token(Token = "0x4002E56")]
	[FieldOffset(Offset = "0x78")]
	public float FullVelocity;

	[Token(Token = "0x4002E57")]
	[FieldOffset(Offset = "0x7C")]
	public float KidForce;

	[Token(Token = "0x4002E58")]
	[FieldOffset(Offset = "0x80")]
	public float SwingPullBackForce;

	[Token(Token = "0x4002E59")]
	[FieldOffset(Offset = "0x88")]
	public List<GameObject> Kids;

	[Token(Token = "0x4002E5A")]
	[FieldOffset(Offset = "0x90")]
	public float SuccessDistanceToSwing;

	[Token(Token = "0x4002E5B")]
	[FieldOffset(Offset = "0x94")]
	private bool hasShot;

	[Token(Token = "0x4002E5C")]
	[FieldOffset(Offset = "0x98")]
	private float releaseAngle;

	[Token(Token = "0x4002E5D")]
	[FieldOffset(Offset = "0xA0")]
	private CBFollow followCam;

	[Token(Token = "0x4002E5E")]
	[FieldOffset(Offset = "0xA8")]
	private Vector3 shotDirection;

	[Token(Token = "0x4002E5F")]
	[FieldOffset(Offset = "0xB8")]
	private List<GameObject> kidsInQueue;

	[Token(Token = "0x4002E60")]
	[FieldOffset(Offset = "0xC0")]
	private List<Vector3> kidPositions;

	[Token(Token = "0x4002E61")]
	[FieldOffset(Offset = "0xC8")]
	private int currentSwing;

	[Token(Token = "0x4002E62")]
	[FieldOffset(Offset = "0xD0")]
	private GameObject cameraFollow;

	[Token(Token = "0x6002707")]
	[Address(RVA = "0x16F2CC4", Offset = "0x16F2CC4", VA = "0x16F2CC4")]
	private void Start()
	{
	}

	[Token(Token = "0x6002708")]
	[Address(RVA = "0x16F3004", Offset = "0x16F3004", VA = "0x16F3004", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6002709")]
	[Address(RVA = "0x16F31E8", Offset = "0x16F31E8", VA = "0x16F31E8", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x600270A")]
	[Address(RVA = "0x16F3470", Offset = "0x16F3470", VA = "0x16F3470")]
	private void Update()
	{
	}

	[Token(Token = "0x600270B")]
	[Address(RVA = "0x16F3754", Offset = "0x16F3754", VA = "0x16F3754")]
	private void KidHitGround(GameObject currentKid)
	{
	}

	[Token(Token = "0x600270C")]
	[Address(RVA = "0x16F3E64", Offset = "0x16F3E64", VA = "0x16F3E64")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600270D")]
	[Address(RVA = "0x16F3FF4", Offset = "0x16F3FF4", VA = "0x16F3FF4")]
	public SwingGolfer()
	{
	}
}
