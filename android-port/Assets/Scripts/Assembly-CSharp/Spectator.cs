using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000298")]
public class Spectator : MonoBehaviour
{
	[Token(Token = "0x2000299")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E914", Offset = "0x3E914")]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x4000DDB")]
		[FieldOffset(Offset = "0x10")]
		public bool levelCompleted;

		[Token(Token = "0x6000BE8")]
		[Address(RVA = "0x1856B18", Offset = "0x1856B18", VA = "0x1856B18")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6000BE9")]
		[Address(RVA = "0x1856B20", Offset = "0x1856B20", VA = "0x1856B20")]
		internal void _003CStart_003Eb__0(Level.CompletedState s)
		{
		}
	}

	[Token(Token = "0x200029A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E924", Offset = "0x3E924")]
	private sealed class _003CStart_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000DDC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000DDD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000DDE")]
		[FieldOffset(Offset = "0x20")]
		public Spectator _003C_003E4__this;

		[Token(Token = "0x4000DDF")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		[Token(Token = "0x4000DE0")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ctimer_003E5__2;

		[Token(Token = "0x1700016C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000BED")]
			[Address(RVA = "0x18574D8", Offset = "0x18574D8", VA = "0x18574D8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700016D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000BEF")]
			[Address(RVA = "0x1857520", Offset = "0x1857520", VA = "0x1857520", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000BEA")]
		[Address(RVA = "0x1856E70", Offset = "0x1856E70", VA = "0x1856E70")]
		[DebuggerHidden]
		public _003CStart_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000BEB")]
		[Address(RVA = "0x1856E9C", Offset = "0x1856E9C", VA = "0x1856E9C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000BEC")]
		[Address(RVA = "0x1856EA0", Offset = "0x1856EA0", VA = "0x1856EA0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000BED")]
		[Address(RVA = "0x18574D8", Offset = "0x18574D8", VA = "0x18574D8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000BEE")]
		[Address(RVA = "0x18574E0", Offset = "0x18574E0", VA = "0x18574E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000BEF")]
		[Address(RVA = "0x1857520", Offset = "0x1857520", VA = "0x1857520", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200029B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E934", Offset = "0x3E934")]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x4000DE1")]
		[FieldOffset(Offset = "0x10")]
		public bool levelCompleted;

		[Token(Token = "0x6000BF0")]
		[Address(RVA = "0x1856B2C", Offset = "0x1856B2C", VA = "0x1856B2C")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000BF1")]
		[Address(RVA = "0x1856B34", Offset = "0x1856B34", VA = "0x1856B34")]
		internal void _003CLookAtRoutine_003Eb__0(Level.CompletedState s)
		{
		}
	}

	[Token(Token = "0x200029C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E944", Offset = "0x3E944")]
	private sealed class _003CLookAtRoutine_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000DE2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000DE3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000DE4")]
		[FieldOffset(Offset = "0x20")]
		public Spectator _003C_003E4__this;

		[Token(Token = "0x4000DE5")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		[Token(Token = "0x1700016E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000BF5")]
			[Address(RVA = "0x1856E20", Offset = "0x1856E20", VA = "0x1856E20", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700016F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000BF7")]
			[Address(RVA = "0x1856E68", Offset = "0x1856E68", VA = "0x1856E68", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000BF2")]
		[Address(RVA = "0x1856B40", Offset = "0x1856B40", VA = "0x1856B40")]
		[DebuggerHidden]
		public _003CLookAtRoutine_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000BF3")]
		[Address(RVA = "0x1856B6C", Offset = "0x1856B6C", VA = "0x1856B6C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000BF4")]
		[Address(RVA = "0x1856B70", Offset = "0x1856B70", VA = "0x1856B70", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000BF5")]
		[Address(RVA = "0x1856E20", Offset = "0x1856E20", VA = "0x1856E20", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000BF6")]
		[Address(RVA = "0x1856E28", Offset = "0x1856E28", VA = "0x1856E28", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000BF7")]
		[Address(RVA = "0x1856E68", Offset = "0x1856E68", VA = "0x1856E68", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000DC7")]
	[FieldOffset(Offset = "0x18")]
	public Transform LookingAt;

	[Token(Token = "0x4000DC8")]
	[FieldOffset(Offset = "0x20")]
	public Animator Animator;

	[Token(Token = "0x4000DC9")]
	[FieldOffset(Offset = "0x28")]
	public float ViewDistance;

	[Token(Token = "0x4000DCA")]
	[FieldOffset(Offset = "0x2C")]
	public float CheckInterval;

	[Token(Token = "0x4000DCB")]
	[FieldOffset(Offset = "0x30")]
	public Transform ViewOriginOverride;

	[Token(Token = "0x4000DCC")]
	[FieldOffset(Offset = "0x38")]
	public Transform HeadJointTransform;

	[Token(Token = "0x4000DCD")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4B254", Offset = "0x4B254")]
	[SerializeField]
	private float heldObjectActiveChance;

	[Token(Token = "0x4000DCE")]
	[FieldOffset(Offset = "0x48")]
	public GameObject HeldObject;

	[Token(Token = "0x4000DCF")]
	[FieldOffset(Offset = "0x50")]
	public Transform[] DummyLookTargets;

	[Token(Token = "0x4000DD0")]
	[FieldOffset(Offset = "0x58")]
	public float DummyLookTimerMin;

	[Token(Token = "0x4000DD1")]
	[FieldOffset(Offset = "0x5C")]
	public float DummyLookTimerMax;

	[Token(Token = "0x4000DD2")]
	[FieldOffset(Offset = "0x60")]
	public float DummyLookCooldownMin;

	[Token(Token = "0x4000DD3")]
	[FieldOffset(Offset = "0x64")]
	public float DummyLookCooldownMax;

	[Token(Token = "0x4000DD4")]
	[FieldOffset(Offset = "0x68")]
	public float HeadRotationSpeedMin;

	[Token(Token = "0x4000DD5")]
	[FieldOffset(Offset = "0x6C")]
	public float HeadRotationSpeedMax;

	[Token(Token = "0x4000DD6")]
	[FieldOffset(Offset = "0x70")]
	public float HeadRotationSpeed;

	[Token(Token = "0x4000DD7")]
	[FieldOffset(Offset = "0x78")]
	public Transform CurrentLookAtTarget;

	[Token(Token = "0x4000DD8")]
	[FieldOffset(Offset = "0x80")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B294", Offset = "0x4B294")]
	private Action m_OnSpectatorSeeingTarget;

	[Token(Token = "0x4000DD9")]
	[FieldOffset(Offset = "0x88")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B2A4", Offset = "0x4B2A4")]
	private Action m_OnSpectatorLosingTarget;

	[Token(Token = "0x4000DDA")]
	[FieldOffset(Offset = "0x90")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B2B4", Offset = "0x4B2B4")]
	private bool canSeePlayer__BackingField;

	[Token(Token = "0x1700016B")]
	public bool canSeePlayer
	{
		[Token(Token = "0x6000BDE")]
		[Address(RVA = "0x16CDD44", Offset = "0x16CDD44", VA = "0x16CDD44")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6029C", Offset = "0x6029C")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000BDF")]
		[Address(RVA = "0x16CDD4C", Offset = "0x16CDD4C", VA = "0x16CDD4C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x602AC", Offset = "0x602AC")]
		private set
		{
		}
	}

	[Token(Token = "0x1400000A")]
	public event Action OnSpectatorSeeingTarget
	{
		[Token(Token = "0x6000BDA")]
		[Address(RVA = "0x16CDAB4", Offset = "0x16CDAB4", VA = "0x16CDAB4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6025C", Offset = "0x6025C")]
		add
		{
		}
		[Token(Token = "0x6000BDB")]
		[Address(RVA = "0x16CDB58", Offset = "0x16CDB58", VA = "0x16CDB58")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6026C", Offset = "0x6026C")]
		remove
		{
		}
	}

	[Token(Token = "0x1400000B")]
	public event Action OnSpectatorLosingTarget
	{
		[Token(Token = "0x6000BDC")]
		[Address(RVA = "0x16CDBFC", Offset = "0x16CDBFC", VA = "0x16CDBFC")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6027C", Offset = "0x6027C")]
		add
		{
		}
		[Token(Token = "0x6000BDD")]
		[Address(RVA = "0x16CDCA0", Offset = "0x16CDCA0", VA = "0x16CDCA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6028C", Offset = "0x6028C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000BE0")]
	[Address(RVA = "0x16CDD54", Offset = "0x16CDD54", VA = "0x16CDD54")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000BE1")]
	[Address(RVA = "0x16CDDC8", Offset = "0x16CDDC8", VA = "0x16CDDC8")]
	public void StopHoldingThing()
	{
	}

	[Token(Token = "0x6000BE2")]
	[Address(RVA = "0x16CDE24", Offset = "0x16CDE24", VA = "0x16CDE24")]
	private IEnumerator LookAtRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000BE3")]
	[Address(RVA = "0x16CDE98", Offset = "0x16CDE98", VA = "0x16CDE98")]
	private void Update()
	{
	}

	[Token(Token = "0x6000BE4")]
	[Address(RVA = "0x16CE01C", Offset = "0x16CE01C", VA = "0x16CE01C")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6000BE5")]
	[Address(RVA = "0x16CE0CC", Offset = "0x16CE0CC", VA = "0x16CE0CC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000BE6")]
	[Address(RVA = "0x16CE0D4", Offset = "0x16CE0D4", VA = "0x16CE0D4")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6000BE7")]
	[Address(RVA = "0x16CE0DC", Offset = "0x16CE0DC", VA = "0x16CE0DC")]
	public Spectator()
	{
	}
}
