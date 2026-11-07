using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200061C")]
public class BossWheels : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200061D")]
	public class WheelParticle
	{
		[Token(Token = "0x4001F99")]
		[FieldOffset(Offset = "0x10")]
		public BossCarState.CarStateEnum State;

		[Token(Token = "0x4001F9A")]
		[FieldOffset(Offset = "0x18")]
		public ParticleSystem Particles;

		[Token(Token = "0x6001BE4")]
		[Address(RVA = "0x177B200", Offset = "0x177B200", VA = "0x177B200")]
		public WheelParticle()
		{
		}
	}

	[Token(Token = "0x200061E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A30", Offset = "0x40A30")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4001F9B")]
		[FieldOffset(Offset = "0x10")]
		public BossCarState.CarStateEnum state;

		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0x177B088", Offset = "0x177B088", VA = "0x177B088")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x6001BE6")]
		[Address(RVA = "0x177B090", Offset = "0x177B090", VA = "0x177B090")]
		internal bool _003CSetState_003Eb__0(WheelParticle w)
		{
			return default;
		}
	}

	[Token(Token = "0x200061F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40A40", Offset = "0x40A40")]
	private sealed class _003CWaitForReset_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001F9C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001F9D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001F9E")]
		[FieldOffset(Offset = "0x20")]
		public BossWheels _003C_003E4__this;

		[Token(Token = "0x17000311")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001BEA")]
			[Address(RVA = "0x177B1B0", Offset = "0x177B1B0", VA = "0x177B1B0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000312")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001BEC")]
			[Address(RVA = "0x177B1F8", Offset = "0x177B1F8", VA = "0x177B1F8", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0x177B0B4", Offset = "0x177B0B4", VA = "0x177B0B4")]
		[DebuggerHidden]
		public _003CWaitForReset_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001BE8")]
		[Address(RVA = "0x177B0E0", Offset = "0x177B0E0", VA = "0x177B0E0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001BE9")]
		[Address(RVA = "0x177B0E4", Offset = "0x177B0E4", VA = "0x177B0E4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001BEA")]
		[Address(RVA = "0x177B1B0", Offset = "0x177B1B0", VA = "0x177B1B0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001BEB")]
		[Address(RVA = "0x177B1B8", Offset = "0x177B1B8", VA = "0x177B1B8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x177B1F8", Offset = "0x177B1F8", VA = "0x177B1F8", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4001F8E")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody BossRigid;

	[Token(Token = "0x4001F8F")]
	[FieldOffset(Offset = "0x20")]
	public float TurnMultiplier;

	[Token(Token = "0x4001F90")]
	[FieldOffset(Offset = "0x24")]
	public float SpinMultiplier;

	[Token(Token = "0x4001F91")]
	[FieldOffset(Offset = "0x28")]
	public float WheelStateChangeSpeed;

	[Token(Token = "0x4001F92")]
	[FieldOffset(Offset = "0x2C")]
	public bool RightSideWheel;

	[Token(Token = "0x4001F93")]
	[FieldOffset(Offset = "0x30")]
	public List<WheelParticle> WheelParticles;

	[Token(Token = "0x4001F94")]
	[FieldOffset(Offset = "0x38")]
	private float spin;

	[Token(Token = "0x4001F95")]
	[FieldOffset(Offset = "0x3C")]
	private float stateChangeValue;

	[Token(Token = "0x4001F96")]
	[FieldOffset(Offset = "0x40")]
	private BossCarState.CarStateEnum currentState;

	[Token(Token = "0x4001F97")]
	[FieldOffset(Offset = "0x44")]
	private BossCarState.CarStateEnum nextState;

	[Token(Token = "0x4001F98")]
	[FieldOffset(Offset = "0x48")]
	private ParticleSystem currentParticles;

	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x16FC1F0", Offset = "0x16FC1F0", VA = "0x16FC1F0")]
	public void SetState(BossCarState.CarStateEnum state)
	{
	}

	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x1700F68", Offset = "0x1700F68", VA = "0x1700F68")]
	private IEnumerator WaitForReset()
	{
		return null;
	}

	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x1700FDC", Offset = "0x1700FDC", VA = "0x1700FDC")]
	private void Update()
	{
	}

	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x17012C0", Offset = "0x17012C0", VA = "0x17012C0")]
	public BossWheels()
	{
	}
}
