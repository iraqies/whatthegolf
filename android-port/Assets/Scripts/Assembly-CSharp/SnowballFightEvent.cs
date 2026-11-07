using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D19")]
public class SnowballFightEvent : OverworldEvent
{
	[Token(Token = "0x2000D1A")]
	public enum Direction
	{
		[Token(Token = "0x400471F")]
		LEFT = 0,
		[Token(Token = "0x4004720")]
		RIGHT = 1
	}

	[Token(Token = "0x2000D1B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x446B8", Offset = "0x446B8")]
	private sealed class _003CKidWaitingSequence_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004721")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004722")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004723")]
		[FieldOffset(Offset = "0x20")]
		public SnowballFightEvent _003C_003E4__this;

		[Token(Token = "0x17000653")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003DD7")]
			[Address(RVA = "0x1852888", Offset = "0x1852888", VA = "0x1852888", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000654")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003DD9")]
			[Address(RVA = "0x18528D0", Offset = "0x18528D0", VA = "0x18528D0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003DD4")]
		[Address(RVA = "0x18526E8", Offset = "0x18526E8", VA = "0x18526E8")]
		[DebuggerHidden]
		public _003CKidWaitingSequence_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003DD5")]
		[Address(RVA = "0x1852714", Offset = "0x1852714", VA = "0x1852714", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003DD6")]
		[Address(RVA = "0x1852718", Offset = "0x1852718", VA = "0x1852718", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003DD7")]
		[Address(RVA = "0x1852888", Offset = "0x1852888", VA = "0x1852888", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003DD8")]
		[Address(RVA = "0x1852890", Offset = "0x1852890", VA = "0x1852890", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003DD9")]
		[Address(RVA = "0x18528D0", Offset = "0x18528D0", VA = "0x18528D0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000D1C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x446C8", Offset = "0x446C8")]
	private sealed class _003CSnowballSequence_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004724")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004725")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004726")]
		[FieldOffset(Offset = "0x20")]
		public SnowballFightEvent _003C_003E4__this;

		[Token(Token = "0x17000655")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003DDD")]
			[Address(RVA = "0x1852B08", Offset = "0x1852B08", VA = "0x1852B08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000656")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003DDF")]
			[Address(RVA = "0x1852B50", Offset = "0x1852B50", VA = "0x1852B50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003DDA")]
		[Address(RVA = "0x18528D8", Offset = "0x18528D8", VA = "0x18528D8")]
		[DebuggerHidden]
		public _003CSnowballSequence_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003DDB")]
		[Address(RVA = "0x1852904", Offset = "0x1852904", VA = "0x1852904", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003DDC")]
		[Address(RVA = "0x1852908", Offset = "0x1852908", VA = "0x1852908", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003DDD")]
		[Address(RVA = "0x1852B08", Offset = "0x1852B08", VA = "0x1852B08", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003DDE")]
		[Address(RVA = "0x1852B10", Offset = "0x1852B10", VA = "0x1852B10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003DDF")]
		[Address(RVA = "0x1852B50", Offset = "0x1852B50", VA = "0x1852B50", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004713")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ParticleSystem m_snowballParticle;

	[Token(Token = "0x4004714")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Animator m_snowballThrower;

	[Token(Token = "0x4004715")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Direction m_direction;

	[Token(Token = "0x4004716")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private float PickupDuration;

	[Token(Token = "0x4004717")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Animator animator;

	[Token(Token = "0x4004718")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioEventAsset sfxLaugh;

	[Token(Token = "0x4004719")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private ClipSettingsCollection sfxOnShoot;

	[Token(Token = "0x400471A")]
	[FieldOffset(Offset = "0x48")]
	private bool hasSnowball;

	[Token(Token = "0x400471B")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float MaxTimeBeforeSnowballPickup;

	[Token(Token = "0x400471C")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine m_currentSnowballSequence;

	[Token(Token = "0x400471D")]
	[FieldOffset(Offset = "0x58")]
	private List<ParticleSystem> m_particleSystemsToUpdate;

	[Token(Token = "0x6003DCC")]
	[Address(RVA = "0x16BC98C", Offset = "0x16BC98C", VA = "0x16BC98C")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6003DCD")]
	[Address(RVA = "0x16BC994", Offset = "0x16BC994", VA = "0x16BC994")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003DCE")]
	[Address(RVA = "0x16BC998", Offset = "0x16BC998", VA = "0x16BC998")]
	private void Start()
	{
	}

	[Token(Token = "0x6003DCF")]
	[Address(RVA = "0x16BCB8C", Offset = "0x16BCB8C", VA = "0x16BCB8C", Slot = "4")]
	public override void TriggerEvent()
	{
	}

	[Token(Token = "0x6003DD0")]
	[Address(RVA = "0x16BCC40", Offset = "0x16BCC40", VA = "0x16BCC40")]
	private void RandomizeSeeds()
	{
	}

	[Token(Token = "0x6003DD1")]
	[Address(RVA = "0x16BCB18", Offset = "0x16BCB18", VA = "0x16BCB18")]
	private IEnumerator KidWaitingSequence()
	{
		return null;
	}

	[Token(Token = "0x6003DD2")]
	[Address(RVA = "0x16BCCF4", Offset = "0x16BCCF4", VA = "0x16BCCF4")]
	private IEnumerator SnowballSequence()
	{
		return null;
	}

	[Token(Token = "0x6003DD3")]
	[Address(RVA = "0x16BCD68", Offset = "0x16BCD68", VA = "0x16BCD68")]
	public SnowballFightEvent()
	{
	}
}
