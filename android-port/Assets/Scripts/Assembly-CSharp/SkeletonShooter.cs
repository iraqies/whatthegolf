using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CameraStack;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005BB")]
public class SkeletonShooter : GolfBallShooterBase
{
	[Token(Token = "0x20005BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40830", Offset = "0x40830")]
	private sealed class _003CPlayShootSequence_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001D52")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001D53")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001D54")]
		[FieldOffset(Offset = "0x20")]
		public SkeletonShooter _003C_003E4__this;

		[Token(Token = "0x4001D55")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 boost;

		[Token(Token = "0x170002D0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001A0D")]
			[Address(RVA = "0x1850FA8", Offset = "0x1850FA8", VA = "0x1850FA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170002D1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001A0F")]
			[Address(RVA = "0x1850FF0", Offset = "0x1850FF0", VA = "0x1850FF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001A0A")]
		[Address(RVA = "0x1850E34", Offset = "0x1850E34", VA = "0x1850E34")]
		[DebuggerHidden]
		public _003CPlayShootSequence_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001A0B")]
		[Address(RVA = "0x1850E60", Offset = "0x1850E60", VA = "0x1850E60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001A0C")]
		[Address(RVA = "0x1850E64", Offset = "0x1850E64", VA = "0x1850E64", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001A0D")]
		[Address(RVA = "0x1850FA8", Offset = "0x1850FA8", VA = "0x1850FA8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001A0E")]
		[Address(RVA = "0x1850FB0", Offset = "0x1850FB0", VA = "0x1850FB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001A0F")]
		[Address(RVA = "0x1850FF0", Offset = "0x1850FF0", VA = "0x1850FF0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001D44")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float minVelocity;

	[Token(Token = "0x4001D45")]
	[FieldOffset(Offset = "0x64")]
	[SerializeField]
	private float fullVelocity;

	[Token(Token = "0x4001D46")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private float fullPitch;

	[Token(Token = "0x4001D47")]
	[FieldOffset(Offset = "0x6C")]
	[SerializeField]
	private float fullSpin;

	[Token(Token = "0x4001D48")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Animator golfAnimator;

	[Token(Token = "0x4001D49")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private List<Rigidbody> skeletonParts;

	[Token(Token = "0x4001D4A")]
	[FieldOffset(Offset = "0x80")]
	private Rigidbody[] rigidbodies;

	[Token(Token = "0x4001D4B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Rigidbody hips;

	[Token(Token = "0x4001D4C")]
	[FieldOffset(Offset = "0x90")]
	private bool hasCollapsed;

	[Token(Token = "0x4001D4D")]
	[FieldOffset(Offset = "0x91")]
	private bool isCollapsing;

	[Token(Token = "0x4001D4E")]
	[FieldOffset(Offset = "0x94")]
	private Vector3 oldPosition;

	[Token(Token = "0x4001D4F")]
	[FieldOffset(Offset = "0xA0")]
	private Quaternion oldRotation;

	[Token(Token = "0x4001D50")]
	[FieldOffset(Offset = "0xB0")]
	private CBFollow followCamera;

	[Token(Token = "0x4001D51")]
	[FieldOffset(Offset = "0xB8")]
	private float mass;

	[Token(Token = "0x6001A02")]
	[Address(RVA = "0x16B453C", Offset = "0x16B453C", VA = "0x16B453C", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6001A03")]
	[Address(RVA = "0x16B468C", Offset = "0x16B468C", VA = "0x16B468C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001A04")]
	[Address(RVA = "0x16B4690", Offset = "0x16B4690", VA = "0x16B4690", Slot = "6")]
	public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
	{
	}

	[Token(Token = "0x6001A05")]
	[Address(RVA = "0x16B4698", Offset = "0x16B4698", VA = "0x16B4698", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6001A06")]
	[Address(RVA = "0x16B4C84", Offset = "0x16B4C84", VA = "0x16B4C84", Slot = "9")]
	public override void OnReset()
	{
	}

	[Token(Token = "0x6001A07")]
	[Address(RVA = "0x16B4B38", Offset = "0x16B4B38", VA = "0x16B4B38")]
	private Vector3 PitchBoost(Vector3 boost)
	{
		return default;
	}

	[Token(Token = "0x6001A08")]
	[Address(RVA = "0x16B4BEC", Offset = "0x16B4BEC", VA = "0x16B4BEC")]
	private IEnumerator PlayShootSequence(Vector3 boost)
	{
		return null;
	}

	[Token(Token = "0x6001A09")]
	[Address(RVA = "0x16B4D20", Offset = "0x16B4D20", VA = "0x16B4D20")]
	public SkeletonShooter()
	{
	}
}
