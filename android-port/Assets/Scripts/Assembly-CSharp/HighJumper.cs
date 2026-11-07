using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000717")]
public class HighJumper : GolfBall2DShooterBase
{
	[Serializable]
	[Token(Token = "0x2000718")]
	public class Judge
	{
		[Token(Token = "0x4002571")]
		[FieldOffset(Offset = "0x10")]
		public Transform SignPivot;

		[Token(Token = "0x4002572")]
		[FieldOffset(Offset = "0x18")]
		public List<ConstantForce2D> Hands;

		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x17BA8E8", Offset = "0x17BA8E8", VA = "0x17BA8E8")]
		public Judge()
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000719")]
	public class JumpStage
	{
		[Token(Token = "0x4002573")]
		[FieldOffset(Offset = "0x10")]
		public JumpStateEnum JumpState;

		[Token(Token = "0x4002574")]
		[FieldOffset(Offset = "0x18")]
		public Transform CameraFollow;

		[Token(Token = "0x4002575")]
		[FieldOffset(Offset = "0x20")]
		public float OrthographicSize;

		[Token(Token = "0x4002576")]
		[FieldOffset(Offset = "0x24")]
		public float TimeScale;

		[Token(Token = "0x4002577")]
		[FieldOffset(Offset = "0x28")]
		public float BlockTime;

		[Token(Token = "0x4002578")]
		[FieldOffset(Offset = "0x2C")]
		public float TimeScaleRevert;

		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x17BA8F0", Offset = "0x17BA8F0", VA = "0x17BA8F0")]
		public JumpStage()
		{
		}
	}

	[Token(Token = "0x200071A")]
	public enum JumpStateEnum
	{
		[Token(Token = "0x400257A")]
		OnSpringBoard = 0,
		[Token(Token = "0x400257B")]
		InAir = 1,
		[Token(Token = "0x400257C")]
		InWater = 2,
		[Token(Token = "0x400257D")]
		GettingJudged = 3
	}

	[Token(Token = "0x200071B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41260", Offset = "0x41260")]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x400257E")]
		[FieldOffset(Offset = "0x10")]
		public JumpStateEnum newState;

		[Token(Token = "0x400257F")]
		[FieldOffset(Offset = "0x18")]
		public HighJumper _003C_003E4__this;

		[Token(Token = "0x4002580")]
		[FieldOffset(Offset = "0x20")]
		public float start1;

		[Token(Token = "0x4002581")]
		[FieldOffset(Offset = "0x24")]
		public float end1;

		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x17BA6DC", Offset = "0x17BA6DC", VA = "0x17BA6DC")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x17BA6E4", Offset = "0x17BA6E4", VA = "0x17BA6E4")]
		internal bool _003CChangeJumpState_003Eb__0(JumpStage s)
		{
			return default;
		}

		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x17BA708", Offset = "0x17BA708", VA = "0x17BA708")]
		internal void _003CChangeJumpState_003Eb__1(float t)
		{
		}

		[Token(Token = "0x60020D4")]
		[Address(RVA = "0x17BA74C", Offset = "0x17BA74C", VA = "0x17BA74C")]
		internal void _003CChangeJumpState_003Eb__3(float t)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x200071C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41270", Offset = "0x41270")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4002582")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4002583")]
		[FieldOffset(Offset = "0x8")]
		public static Action<float> _003C_003E9__21_2;

		[Token(Token = "0x4002584")]
		[FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__23_0;

		[Token(Token = "0x4002585")]
		[FieldOffset(Offset = "0x18")]
		public static Action<float> _003C_003E9__23_2;

		[Token(Token = "0x60020D6")]
		[Address(RVA = "0x17BA6C8", Offset = "0x17BA6C8", VA = "0x17BA6C8")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60020D7")]
		[Address(RVA = "0x17BA6D0", Offset = "0x17BA6D0", VA = "0x17BA6D0")]
		internal void _003CChangeJumpState_003Eb__21_2(float t)
		{
		}

		[Token(Token = "0x60020D8")]
		[Address(RVA = "0x17BA6D4", Offset = "0x17BA6D4", VA = "0x17BA6D4")]
		internal void _003COnTriggerEnter2D_003Eb__23_0(float t)
		{
		}

		[Token(Token = "0x60020D9")]
		[Address(RVA = "0x17BA6D8", Offset = "0x17BA6D8", VA = "0x17BA6D8")]
		internal void _003COnTriggerEnter2D_003Eb__23_2(float t)
		{
		}
	}

	[Token(Token = "0x200071D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41280", Offset = "0x41280")]
	private sealed class _003CJudgeVerdicts_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002586")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002587")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002588")]
		[FieldOffset(Offset = "0x20")]
		public HighJumper _003C_003E4__this;

		[Token(Token = "0x170003B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60020DD")]
			[Address(RVA = "0x17BA898", Offset = "0x17BA898", VA = "0x17BA898", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60020DF")]
			[Address(RVA = "0x17BA8E0", Offset = "0x17BA8E0", VA = "0x17BA8E0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60020DA")]
		[Address(RVA = "0x17BA790", Offset = "0x17BA790", VA = "0x17BA790")]
		[DebuggerHidden]
		public _003CJudgeVerdicts_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60020DB")]
		[Address(RVA = "0x17BA7BC", Offset = "0x17BA7BC", VA = "0x17BA7BC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60020DC")]
		[Address(RVA = "0x17BA7C0", Offset = "0x17BA7C0", VA = "0x17BA7C0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60020DD")]
		[Address(RVA = "0x17BA898", Offset = "0x17BA898", VA = "0x17BA898", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60020DE")]
		[Address(RVA = "0x17BA8A0", Offset = "0x17BA8A0", VA = "0x17BA8A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60020DF")]
		[Address(RVA = "0x17BA8E0", Offset = "0x17BA8E0", VA = "0x17BA8E0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002561")]
	[FieldOffset(Offset = "0x48")]
	public List<JumpStage> JumpStages;

	[Token(Token = "0x4002562")]
	[FieldOffset(Offset = "0x50")]
	public List<ConstantForce2D> ForceAppliers;

	[Token(Token = "0x4002563")]
	[FieldOffset(Offset = "0x58")]
	public Collider2D Water;

	[Token(Token = "0x4002564")]
	[FieldOffset(Offset = "0x60")]
	public ParticleSystem WaterParticles;

	[Token(Token = "0x4002565")]
	[FieldOffset(Offset = "0x68")]
	public List<Judge> Judges;

	[Token(Token = "0x4002566")]
	[FieldOffset(Offset = "0x70")]
	public BoxCollider2D OnBoardTrigger;

	[Token(Token = "0x4002567")]
	[FieldOffset(Offset = "0x78")]
	public bool instantWin;

	[Token(Token = "0x4002568")]
	[FieldOffset(Offset = "0x7C")]
	public float winWaitTime;

	[Token(Token = "0x4002569")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float minShootVelocity;

	[Token(Token = "0x400256A")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float fullShootVelocity;

	[Token(Token = "0x400256B")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private float pitch;

	[Token(Token = "0x400256C")]
	[FieldOffset(Offset = "0x8C")]
	[SerializeField]
	private float spin;

	[Token(Token = "0x400256D")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private JumpStateEnum currentJumpState;

	[Token(Token = "0x400256E")]
	[FieldOffset(Offset = "0x98")]
	public Action onJump;

	[Token(Token = "0x400256F")]
	[FieldOffset(Offset = "0xA0")]
	private TimeControl timeControl;

	[Token(Token = "0x4002570")]
	[FieldOffset(Offset = "0xA8")]
	public Rigidbody2D[] rigidbodies;

	[Token(Token = "0x60020C5")]
	[Address(RVA = "0x14C88B0", Offset = "0x14C88B0", VA = "0x14C88B0")]
	private void Start()
	{
	}

	[Token(Token = "0x60020C6")]
	[Address(RVA = "0x14C8958", Offset = "0x14C8958", VA = "0x14C8958", Slot = "7")]
	public override void OnShoot(Vector3 boost)
	{
	}

	[Token(Token = "0x60020C7")]
	[Address(RVA = "0x14C8B34", Offset = "0x14C8B34", VA = "0x14C8B34")]
	private void ChangeJumpState(JumpStateEnum newState)
	{
	}

	[Token(Token = "0x60020C8")]
	[Address(RVA = "0x14C8E60", Offset = "0x14C8E60", VA = "0x14C8E60")]
	private void ReverseForces()
	{
	}

	[Token(Token = "0x60020C9")]
	[Address(RVA = "0x14C8FCC", Offset = "0x14C8FCC", VA = "0x14C8FCC")]
	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	[Token(Token = "0x60020CA")]
	[Address(RVA = "0x14C93A4", Offset = "0x14C93A4", VA = "0x14C93A4")]
	private void OnTriggerExit2D(Collider2D col)
	{
	}

	[Token(Token = "0x60020CB")]
	[Address(RVA = "0x14C956C", Offset = "0x14C956C", VA = "0x14C956C")]
	private IEnumerator JudgeVerdicts()
	{
		return null;
	}

	[Token(Token = "0x60020CC")]
	[Address(RVA = "0x14C95E0", Offset = "0x14C95E0", VA = "0x14C95E0")]
	public HighJumper()
	{
	}

	[Token(Token = "0x60020CD")]
	[Address(RVA = "0x14C9600", Offset = "0x14C9600", VA = "0x14C9600")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A60", Offset = "0x65A60")]
	private void _003COnTriggerEnter2D_003Eb__23_1()
	{
	}

	[Token(Token = "0x60020CE")]
	[Address(RVA = "0x14C9660", Offset = "0x14C9660", VA = "0x14C9660")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65A70", Offset = "0x65A70")]
	private void _003COnTriggerEnter2D_003Eb__23_3()
	{
	}
}
