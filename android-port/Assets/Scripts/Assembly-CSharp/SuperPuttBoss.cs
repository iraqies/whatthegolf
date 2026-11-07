using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Chronos;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000820")]
public class SuperPuttBoss : MonoBehaviour
{
	[Token(Token = "0x2000821")]
	public enum MovementTypeEnum
	{
		[Token(Token = "0x4002BCE")]
		PingPong = 0,
		[Token(Token = "0x4002BCF")]
		Loop = 1
	}

	[Serializable]
	[Token(Token = "0x2000822")]
	public class BossPhase
	{
		[Token(Token = "0x4002BD0")]
		[FieldOffset(Offset = "0x10")]
		public string PhaseName;

		[Token(Token = "0x4002BD1")]
		[FieldOffset(Offset = "0x18")]
		public List<Transform> Movement;

		[Token(Token = "0x4002BD2")]
		[FieldOffset(Offset = "0x20")]
		public MovementTypeEnum MovementType;

		[Token(Token = "0x4002BD3")]
		[FieldOffset(Offset = "0x24")]
		public float TimePerRound;

		[Token(Token = "0x4002BD4")]
		[FieldOffset(Offset = "0x28")]
		public float GunTowerRotationSpeed;

		[Token(Token = "0x4002BD5")]
		[FieldOffset(Offset = "0x30")]
		public GameObject GunSettingsObject;

		[Token(Token = "0x6002567")]
		[Address(RVA = "0x185EAA8", Offset = "0x185EAA8", VA = "0x185EAA8")]
		public BossPhase()
		{
		}
	}

	[Token(Token = "0x2000823")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x417F0", Offset = "0x417F0")]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x4002BD6")]
		[FieldOffset(Offset = "0x10")]
		public SuperPuttBoss _003C_003E4__this;

		[Token(Token = "0x4002BD7")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 mid;

		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x30")]
		public Vector3 end;

		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0x40")]
		public Action<AudioSource> _003C_003E9__2;

		[Token(Token = "0x6002568")]
		[Address(RVA = "0x185D9A0", Offset = "0x185D9A0", VA = "0x185D9A0")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6002569")]
		[Address(RVA = "0x185D9A8", Offset = "0x185D9A8", VA = "0x185D9A8")]
		internal void _003CEndPhaseSequence_003Eb__2(AudioSource s)
		{
		}

		[Token(Token = "0x600256A")]
		[Address(RVA = "0x185DA04", Offset = "0x185DA04", VA = "0x185DA04")]
		internal void _003CEndPhaseSequence_003Eb__0(float t)
		{
		}

		[Token(Token = "0x600256B")]
		[Address(RVA = "0x185DAC0", Offset = "0x185DAC0", VA = "0x185DAC0")]
		internal void _003CEndPhaseSequence_003Eb__1(AudioSource s)
		{
		}
	}

	[Token(Token = "0x2000824")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41800", Offset = "0x41800")]
	private sealed class _003CEndPhaseSequence_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0x20")]
		public SuperPuttBoss _003C_003E4__this;

		[Token(Token = "0x4002BDE")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		[Token(Token = "0x1700040C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600256F")]
			[Address(RVA = "0x185E08C", Offset = "0x185E08C", VA = "0x185E08C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700040D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002571")]
			[Address(RVA = "0x185E0D4", Offset = "0x185E0D4", VA = "0x185E0D4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600256C")]
		[Address(RVA = "0x185DB1C", Offset = "0x185DB1C", VA = "0x185DB1C")]
		[DebuggerHidden]
		public _003CEndPhaseSequence_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600256D")]
		[Address(RVA = "0x185DB48", Offset = "0x185DB48", VA = "0x185DB48", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600256E")]
		[Address(RVA = "0x185DB4C", Offset = "0x185DB4C", VA = "0x185DB4C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600256F")]
		[Address(RVA = "0x185E08C", Offset = "0x185E08C", VA = "0x185E08C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002570")]
		[Address(RVA = "0x185E094", Offset = "0x185E094", VA = "0x185E094", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002571")]
		[Address(RVA = "0x185E0D4", Offset = "0x185E0D4", VA = "0x185E0D4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000825")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41810", Offset = "0x41810")]
	private sealed class _003CGameWonRoutine_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BE0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x20")]
		public SuperPuttBoss _003C_003E4__this;

		[Token(Token = "0x1700040E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002575")]
			[Address(RVA = "0x185E968", Offset = "0x185E968", VA = "0x185E968", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700040F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002577")]
			[Address(RVA = "0x185E9B0", Offset = "0x185E9B0", VA = "0x185E9B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002572")]
		[Address(RVA = "0x185E0DC", Offset = "0x185E0DC", VA = "0x185E0DC")]
		[DebuggerHidden]
		public _003CGameWonRoutine_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002573")]
		[Address(RVA = "0x185E108", Offset = "0x185E108", VA = "0x185E108", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002574")]
		[Address(RVA = "0x185E10C", Offset = "0x185E10C", VA = "0x185E10C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002575")]
		[Address(RVA = "0x185E968", Offset = "0x185E968", VA = "0x185E968", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002576")]
		[Address(RVA = "0x185E970", Offset = "0x185E970", VA = "0x185E970", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002577")]
		[Address(RVA = "0x185E9B0", Offset = "0x185E9B0", VA = "0x185E9B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000826")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x41820", Offset = "0x41820")]
	private sealed class _003CWaitFor_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002BE2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002BE3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002BE4")]
		[FieldOffset(Offset = "0x20")]
		public float t;

		[Token(Token = "0x17000410")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600257B")]
			[Address(RVA = "0x185EA58", Offset = "0x185EA58", VA = "0x185EA58", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000411")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600257D")]
			[Address(RVA = "0x185EAA0", Offset = "0x185EAA0", VA = "0x185EAA0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002578")]
		[Address(RVA = "0x185E9B8", Offset = "0x185E9B8", VA = "0x185E9B8")]
		[DebuggerHidden]
		public _003CWaitFor_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002579")]
		[Address(RVA = "0x185E9E4", Offset = "0x185E9E4", VA = "0x185E9E4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600257A")]
		[Address(RVA = "0x185E9E8", Offset = "0x185E9E8", VA = "0x185E9E8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600257B")]
		[Address(RVA = "0x185EA58", Offset = "0x185EA58", VA = "0x185EA58", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600257C")]
		[Address(RVA = "0x185EA60", Offset = "0x185EA60", VA = "0x185EA60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600257D")]
		[Address(RVA = "0x185EAA0", Offset = "0x185EAA0", VA = "0x185EAA0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4002BBB")]
	[FieldOffset(Offset = "0x18")]
	public RotateAxis GunTower;

	[Token(Token = "0x4002BBC")]
	[FieldOffset(Offset = "0x20")]
	public int Health;

	[Token(Token = "0x4002BBD")]
	[FieldOffset(Offset = "0x28")]
	public List<BossPhase> BossPhases;

	[Token(Token = "0x4002BBE")]
	[FieldOffset(Offset = "0x30")]
	public ParticleSystem PhaseEndingParticles;

	[Token(Token = "0x4002BBF")]
	[FieldOffset(Offset = "0x38")]
	public List<AudioClip> PhaseEndingClips;

	[Token(Token = "0x4002BC0")]
	[FieldOffset(Offset = "0x40")]
	public List<AudioClip> RoombaLandingClips;

	[Token(Token = "0x4002BC1")]
	[FieldOffset(Offset = "0x48")]
	public int StartPhaseIndex;

	[Token(Token = "0x4002BC2")]
	[FieldOffset(Offset = "0x50")]
	public Action OnBossDead;

	[Token(Token = "0x4002BC3")]
	[FieldOffset(Offset = "0x58")]
	private int currentPhase;

	[Token(Token = "0x4002BC4")]
	[FieldOffset(Offset = "0x5C")]
	private float movementTimerTarget;

	[Token(Token = "0x4002BC5")]
	[FieldOffset(Offset = "0x60")]
	private float movementTimer;

	[Token(Token = "0x4002BC6")]
	[FieldOffset(Offset = "0x64")]
	private float movementDist;

	[Token(Token = "0x4002BC7")]
	[FieldOffset(Offset = "0x68")]
	private Timeline timeline;

	[Token(Token = "0x4002BC8")]
	[FieldOffset(Offset = "0x70")]
	private int currentMovemenTargetIndex;

	[Token(Token = "0x4002BC9")]
	[FieldOffset(Offset = "0x78")]
	private Rigidbody rigid;

	[Token(Token = "0x4002BCA")]
	[FieldOffset(Offset = "0x80")]
	private int currentDirection;

	[Token(Token = "0x4002BCB")]
	[FieldOffset(Offset = "0x84")]
	private float moveSpeedMod;

	[Token(Token = "0x4002BCC")]
	[FieldOffset(Offset = "0x88")]
	private SuperGolfShooter player;

	[Token(Token = "0x6002555")]
	[Address(RVA = "0x16ED87C", Offset = "0x16ED87C", VA = "0x16ED87C")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002556")]
	[Address(RVA = "0x16ED950", Offset = "0x16ED950", VA = "0x16ED950")]
	private void Start()
	{
	}

	[Token(Token = "0x6002557")]
	[Address(RVA = "0x16EDBD0", Offset = "0x16EDBD0", VA = "0x16EDBD0")]
	private void Update()
	{
	}

	[Token(Token = "0x6002558")]
	[Address(RVA = "0x16EDF68", Offset = "0x16EDF68", VA = "0x16EDF68")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002559")]
	[Address(RVA = "0x16EE1D8", Offset = "0x16EE1D8", VA = "0x16EE1D8")]
	public void EndPhase()
	{
	}

	[Token(Token = "0x600255A")]
	[Address(RVA = "0x16EE348", Offset = "0x16EE348", VA = "0x16EE348")]
	private IEnumerator EndPhaseSequence()
	{
		return null;
	}

	[Token(Token = "0x600255B")]
	[Address(RVA = "0x16EE2D4", Offset = "0x16EE2D4", VA = "0x16EE2D4")]
	private IEnumerator GameWonRoutine()
	{
		return null;
	}

	[Token(Token = "0x600255C")]
	[Address(RVA = "0x16EE3BC", Offset = "0x16EE3BC", VA = "0x16EE3BC")]
	private IEnumerator WaitFor(float t)
	{
		return null;
	}

	[Token(Token = "0x600255D")]
	[Address(RVA = "0x16ED960", Offset = "0x16ED960", VA = "0x16ED960")]
	private void NextPhase()
	{
	}

	[Token(Token = "0x600255E")]
	[Address(RVA = "0x16EDD64", Offset = "0x16EDD64", VA = "0x16EDD64")]
	private void SetMovementTarget()
	{
	}

	[Token(Token = "0x600255F")]
	[Address(RVA = "0x16EE430", Offset = "0x16EE430", VA = "0x16EE430")]
	public void TakeDamage()
	{
	}

	[Token(Token = "0x6002560")]
	[Address(RVA = "0x16EE584", Offset = "0x16EE584", VA = "0x16EE584")]
	public SuperPuttBoss()
	{
	}

	[Token(Token = "0x6002561")]
	[Address(RVA = "0x16EE5AC", Offset = "0x16EE5AC", VA = "0x16EE5AC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66860", Offset = "0x66860")]
	private void _003CGameWonRoutine_003Eb__26_0(AudioSource s)
	{
	}

	[Token(Token = "0x6002562")]
	[Address(RVA = "0x16EE63C", Offset = "0x16EE63C", VA = "0x16EE63C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66870", Offset = "0x66870")]
	private void _003CGameWonRoutine_003Eb__26_1(AudioSource s)
	{
	}

	[Token(Token = "0x6002563")]
	[Address(RVA = "0x16EE6CC", Offset = "0x16EE6CC", VA = "0x16EE6CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66880", Offset = "0x66880")]
	private void _003CGameWonRoutine_003Eb__26_2(AudioSource s)
	{
	}

	[Token(Token = "0x6002564")]
	[Address(RVA = "0x16EE75C", Offset = "0x16EE75C", VA = "0x16EE75C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x66890", Offset = "0x66890")]
	private void _003CGameWonRoutine_003Eb__26_3(AudioSource s)
	{
	}

	[Token(Token = "0x6002565")]
	[Address(RVA = "0x16EE7EC", Offset = "0x16EE7EC", VA = "0x16EE7EC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668A0", Offset = "0x668A0")]
	private void _003CGameWonRoutine_003Eb__26_4(AudioSource s)
	{
	}

	[Token(Token = "0x6002566")]
	[Address(RVA = "0x16EE87C", Offset = "0x16EE87C", VA = "0x16EE87C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x668B0", Offset = "0x668B0")]
	private void _003CTakeDamage_003Eb__30_0(AudioSource s)
	{
	}
}
