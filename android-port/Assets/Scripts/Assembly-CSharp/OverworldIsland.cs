using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A90")]
public class OverworldIsland : MonoBehaviour
{
	[Token(Token = "0x2000A91")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E70", Offset = "0x42E70")]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x4003AC6")]
		[FieldOffset(Offset = "0x10")]
		public OverworldIsland _003C_003E4__this;

		[Token(Token = "0x4003AC7")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPosition;

		[Token(Token = "0x4003AC8")]
		[FieldOffset(Offset = "0x24")]
		public Quaternion startRot;

		[Token(Token = "0x4003AC9")]
		[FieldOffset(Offset = "0x34")]
		public Vector3 dockPosition;

		[Token(Token = "0x600327D")]
		[Address(RVA = "0x1811464", Offset = "0x1811464", VA = "0x1811464")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x600327E")]
		[Address(RVA = "0x181146C", Offset = "0x181146C", VA = "0x181146C")]
		internal void _003CDockRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x600327F")]
		[Address(RVA = "0x18115E0", Offset = "0x18115E0", VA = "0x18115E0")]
		internal void _003CDockRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000A92")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E80", Offset = "0x42E80")]
	private sealed class _003CDockRoutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003ACA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003ACB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003ACC")]
		[FieldOffset(Offset = "0x20")]
		public OverworldIsland _003C_003E4__this;

		[Token(Token = "0x4003ACD")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x17000534")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003283")]
			[Address(RVA = "0x18125B0", Offset = "0x18125B0", VA = "0x18125B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000535")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003285")]
			[Address(RVA = "0x18125F8", Offset = "0x18125F8", VA = "0x18125F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003280")]
		[Address(RVA = "0x1811EF8", Offset = "0x1811EF8", VA = "0x1811EF8")]
		[DebuggerHidden]
		public _003CDockRoutine_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003281")]
		[Address(RVA = "0x1811F24", Offset = "0x1811F24", VA = "0x1811F24", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003282")]
		[Address(RVA = "0x1811F28", Offset = "0x1811F28", VA = "0x1811F28", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003283")]
		[Address(RVA = "0x18125B0", Offset = "0x18125B0", VA = "0x18125B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003284")]
		[Address(RVA = "0x18125B8", Offset = "0x18125B8", VA = "0x18125B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003285")]
		[Address(RVA = "0x18125F8", Offset = "0x18125F8", VA = "0x18125F8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A93")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42E90", Offset = "0x42E90")]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x4003ACE")]
		[FieldOffset(Offset = "0x10")]
		public OverworldIsland _003C_003E4__this;

		[Token(Token = "0x4003ACF")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPosition;

		[Token(Token = "0x4003AD0")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 dockPosition;

		[Token(Token = "0x4003AD1")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 undockPosition;

		[Token(Token = "0x4003AD2")]
		[FieldOffset(Offset = "0x3C")]
		public Quaternion startRot;

		[Token(Token = "0x4003AD3")]
		[FieldOffset(Offset = "0x4C")]
		public Quaternion endRot;

		[Token(Token = "0x6003286")]
		[Address(RVA = "0x181169C", Offset = "0x181169C", VA = "0x181169C")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6003287")]
		[Address(RVA = "0x18116A4", Offset = "0x18116A4", VA = "0x18116A4")]
		internal void _003CBoardBoatRoutine_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6003288")]
		[Address(RVA = "0x181175C", Offset = "0x181175C", VA = "0x181175C")]
		internal void _003CBoardBoatRoutine_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x2000A94")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42EA0", Offset = "0x42EA0")]
	private sealed class _003CBoardBoatRoutine_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4003AD4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4003AD5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4003AD6")]
		[FieldOffset(Offset = "0x20")]
		public OverworldIsland _003C_003E4__this;

		[Token(Token = "0x4003AD7")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		[Token(Token = "0x17000536")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600328C")]
			[Address(RVA = "0x1811EA8", Offset = "0x1811EA8", VA = "0x1811EA8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000537")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600328E")]
			[Address(RVA = "0x1811EF0", Offset = "0x1811EF0", VA = "0x1811EF0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003289")]
		[Address(RVA = "0x1811890", Offset = "0x1811890", VA = "0x1811890")]
		[DebuggerHidden]
		public _003CBoardBoatRoutine_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600328A")]
		[Address(RVA = "0x18118BC", Offset = "0x18118BC", VA = "0x18118BC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600328B")]
		[Address(RVA = "0x18118C0", Offset = "0x18118C0", VA = "0x18118C0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600328C")]
		[Address(RVA = "0x1811EA8", Offset = "0x1811EA8", VA = "0x1811EA8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600328D")]
		[Address(RVA = "0x1811EB0", Offset = "0x1811EB0", VA = "0x1811EB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600328E")]
		[Address(RVA = "0x1811EF0", Offset = "0x1811EF0", VA = "0x1811EF0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4003AB4")]
	[FieldOffset(Offset = "0x18")]
	public Collider2D IslandExitCollider;

	[Token(Token = "0x4003AB5")]
	[FieldOffset(Offset = "0x20")]
	public Collider2D WaveTrigger;

	[Token(Token = "0x4003AB6")]
	[FieldOffset(Offset = "0x28")]
	public Collider2D DockTrigger;

	[Token(Token = "0x4003AB7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PlayerPrefab;

	[Token(Token = "0x4003AB8")]
	[FieldOffset(Offset = "0x38")]
	public float DockDistance;

	[Token(Token = "0x4003AB9")]
	[FieldOffset(Offset = "0x3C")]
	public float ExitDistance;

	[Token(Token = "0x4003ABA")]
	[FieldOffset(Offset = "0x40")]
	public Transform IslandExit;

	[Token(Token = "0x4003ABB")]
	[FieldOffset(Offset = "0x48")]
	public float WaveForce;

	[Token(Token = "0x4003ABC")]
	[FieldOffset(Offset = "0x50")]
	public Transform DockPosition;

	[Token(Token = "0x4003ABD")]
	[FieldOffset(Offset = "0x58")]
	public Transform BoatParkingTransform;

	[Token(Token = "0x4003ABE")]
	[FieldOffset(Offset = "0x60")]
	private BoatPlayer boat;

	[Token(Token = "0x4003ABF")]
	[FieldOffset(Offset = "0x68")]
	private Rigidbody2D ballOnIsland;

	[Token(Token = "0x4003AC0")]
	[FieldOffset(Offset = "0x70")]
	private GolfBallController ballOnIslandController;

	[Token(Token = "0x4003AC1")]
	[FieldOffset(Offset = "0x78")]
	private bool pushPlayerTowardsIsland;

	[Token(Token = "0x4003AC2")]
	[FieldOffset(Offset = "0x79")]
	private bool playerCanLeave;

	[Token(Token = "0x4003AC3")]
	[FieldOffset(Offset = "0x80")]
	private OverworldBallFollower follower;

	[Token(Token = "0x4003AC4")]
	[FieldOffset(Offset = "0x88")]
	private bool routineRunning;

	[Token(Token = "0x4003AC5")]
	[FieldOffset(Offset = "0x8C")]
	private float baseBallDrag;

	[Token(Token = "0x6003270")]
	[Address(RVA = "0x15B92E0", Offset = "0x15B92E0", VA = "0x15B92E0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003271")]
	[Address(RVA = "0x15B9484", Offset = "0x15B9484", VA = "0x15B9484")]
	public void OnPierTriggerEnter(Collider2D other)
	{
	}

	[Token(Token = "0x6003272")]
	[Address(RVA = "0x15B97E8", Offset = "0x15B97E8", VA = "0x15B97E8")]
	private void OnTriggerStay2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003273")]
	[Address(RVA = "0x15B9928", Offset = "0x15B9928", VA = "0x15B9928")]
	public void OnTriggerExit2D(Collider2D other)
	{
	}

	[Token(Token = "0x6003274")]
	[Address(RVA = "0x15B9700", Offset = "0x15B9700", VA = "0x15B9700")]
	private IEnumerator DockRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003275")]
	[Address(RVA = "0x15B9A50", Offset = "0x15B9A50", VA = "0x15B9A50")]
	private void InstanceOnOnNewBall(Transmogrif.BALLSHAPES obj)
	{
	}

	[Token(Token = "0x6003276")]
	[Address(RVA = "0x15B9774", Offset = "0x15B9774", VA = "0x15B9774")]
	private IEnumerator BoardBoatRoutine()
	{
		return null;
	}

	[Token(Token = "0x6003277")]
	[Address(RVA = "0x15B9C88", Offset = "0x15B9C88", VA = "0x15B9C88")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003278")]
	[Address(RVA = "0x15B9E0C", Offset = "0x15B9E0C", VA = "0x15B9E0C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003279")]
	[Address(RVA = "0x15B9EC0", Offset = "0x15B9EC0", VA = "0x15B9EC0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600327A")]
	[Address(RVA = "0x15B9A84", Offset = "0x15B9A84", VA = "0x15B9A84")]
	public void DestroyBallOnIsland()
	{
	}

	[Token(Token = "0x600327B")]
	[Address(RVA = "0x15B9F74", Offset = "0x15B9F74", VA = "0x15B9F74")]
	public void ToogleBallOnIsland(bool state)
	{
	}

	[Token(Token = "0x600327C")]
	[Address(RVA = "0x15BA020", Offset = "0x15BA020", VA = "0x15BA020")]
	public OverworldIsland()
	{
	}
}
