using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001F7")]
public class GiraffeRagdollController : GolfBallShooterBase
{
	[Token(Token = "0x20001F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E340", Offset = "0x3E340")]
	private sealed class _003CStart_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009A0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40009A1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40009A2")]
		[FieldOffset(Offset = "0x20")]
		public GiraffeRagdollController _003C_003E4__this;

		[Token(Token = "0x1700011A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60008D9")]
			[Address(RVA = "0x17B497C", Offset = "0x17B497C", VA = "0x17B497C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700011B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60008DB")]
			[Address(RVA = "0x17B49C4", Offset = "0x17B49C4", VA = "0x17B49C4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x17B4848", Offset = "0x17B4848", VA = "0x17B4848")]
		[DebuggerHidden]
		public _003CStart_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x17B4874", Offset = "0x17B4874", VA = "0x17B4874", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x17B4878", Offset = "0x17B4878", VA = "0x17B4878", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x17B497C", Offset = "0x17B497C", VA = "0x17B497C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60008DA")]
		[Address(RVA = "0x17B4984", Offset = "0x17B4984", VA = "0x17B4984", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60008DB")]
		[Address(RVA = "0x17B49C4", Offset = "0x17B49C4", VA = "0x17B49C4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000996")]
	[FieldOffset(Offset = "0x60")]
	public Transform ArrowPositionAfterShot;

	[Token(Token = "0x4000997")]
	[FieldOffset(Offset = "0x68")]
	public float Force;

	[Token(Token = "0x4000998")]
	[FieldOffset(Offset = "0x6C")]
	public float Pitch;

	[Token(Token = "0x4000999")]
	[FieldOffset(Offset = "0x70")]
	public Vector2 RandomRange;

	[Token(Token = "0x400099A")]
	[FieldOffset(Offset = "0x78")]
	public List<Rigidbody> rigidbodies;

	[Token(Token = "0x400099B")]
	[FieldOffset(Offset = "0x80")]
	public Rigidbody[] blacklist;

	[Token(Token = "0x400099C")]
	[FieldOffset(Offset = "0x88")]
	public Animator CameraAnimator;

	[Token(Token = "0x400099D")]
	[FieldOffset(Offset = "0x90")]
	public PoseMachine Poser;

	[Token(Token = "0x400099E")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 FirstShotVelocity;

	[Token(Token = "0x400099F")]
	[FieldOffset(Offset = "0xA4")]
	private bool firstShot;

	[Token(Token = "0x60008D1")]
	[Address(RVA = "0x148C904", Offset = "0x148C904", VA = "0x148C904", Slot = "11")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x60008D2")]
	[Address(RVA = "0x148CAAC", Offset = "0x148CAAC", VA = "0x148CAAC")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60008D3")]
	[Address(RVA = "0x148CB20", Offset = "0x148CB20", VA = "0x148CB20", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60008D4")]
	[Address(RVA = "0x148CED4", Offset = "0x148CED4", VA = "0x148CED4")]
	public GiraffeRagdollController()
	{
	}

	[Token(Token = "0x60008D5")]
	[Address(RVA = "0x148CF28", Offset = "0x148CF28", VA = "0x148CF28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5F63C", Offset = "0x5F63C")]
	private void _003CStart_003Eb__11_0()
	{
	}
}
