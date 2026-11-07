using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000D73")]
public class ExplodingDynamiteForLivingThings : MonoBehaviour, IAudioEvent
{
	[Token(Token = "0x2000D74")]
	private enum State
	{
		[Token(Token = "0x4004937")]
		Appear = 0,
		[Token(Token = "0x4004938")]
		Warning = 1,
		[Token(Token = "0x4004939")]
		Explode = 2,
		[Token(Token = "0x400493A")]
		Done = 3
	}

	[Token(Token = "0x2000D75")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x449D0", Offset = "0x449D0")]
	private sealed class _003CAduio_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400493B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400493C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400493D")]
		[FieldOffset(Offset = "0x20")]
		public ExplodingDynamiteForLivingThings _003C_003E4__this;

		[Token(Token = "0x17000671")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003F4E")]
			[Address(RVA = "0x17A1794", Offset = "0x17A1794", VA = "0x17A1794", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000672")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003F50")]
			[Address(RVA = "0x17A17DC", Offset = "0x17A17DC", VA = "0x17A17DC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003F4B")]
		[Address(RVA = "0x17A1678", Offset = "0x17A1678", VA = "0x17A1678")]
		[DebuggerHidden]
		public _003CAduio_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003F4C")]
		[Address(RVA = "0x17A16A4", Offset = "0x17A16A4", VA = "0x17A16A4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003F4D")]
		[Address(RVA = "0x17A16A8", Offset = "0x17A16A8", VA = "0x17A16A8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003F4E")]
		[Address(RVA = "0x17A1794", Offset = "0x17A1794", VA = "0x17A1794", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003F4F")]
		[Address(RVA = "0x17A179C", Offset = "0x17A179C", VA = "0x17A179C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003F50")]
		[Address(RVA = "0x17A17DC", Offset = "0x17A17DC", VA = "0x17A17DC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x400491D")]
	[FieldOffset(Offset = "0x18")]
	private double _time;

	[Token(Token = "0x400491E")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float _warningTime;

	[Token(Token = "0x400491F")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float _appearTime;

	[Token(Token = "0x4004920")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve _appearCurve;

	[Token(Token = "0x4004921")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private AnimationCurve _blinkCurve;

	[Token(Token = "0x4004922")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private float _warningSpeed;

	[Token(Token = "0x4004923")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	private float _warningSizeIncrease;

	[Token(Token = "0x4004924")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private bool _startWarningOnPickup;

	[Token(Token = "0x4004925")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject _rings;

	[Token(Token = "0x4004926")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private GameObject _explosionshadow;

	[Token(Token = "0x4004927")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private GameObject _blinkRenderer;

	[Token(Token = "0x4004928")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private GameObject _normalRenderer;

	[Token(Token = "0x4004929")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ParticleSystem _splash;

	[Token(Token = "0x400492A")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private LayerMask _mask;

	[Token(Token = "0x400492B")]
	[FieldOffset(Offset = "0x74")]
	private State _state;

	[Token(Token = "0x400492C")]
	[FieldOffset(Offset = "0x78")]
	private Vector3 _startPos;

	[Token(Token = "0x400492D")]
	[FieldOffset(Offset = "0x88")]
	public UnityEvent OnExplodeEvent;

	[Token(Token = "0x400492E")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private float _blinkSomething;

	[Token(Token = "0x400492F")]
	[FieldOffset(Offset = "0x98")]
	[SerializeField]
	private GameObject _audio;

	[Token(Token = "0x4004930")]
	[FieldOffset(Offset = "0xA0")]
	[SerializeField]
	private float _radius;

	[Token(Token = "0x4004931")]
	[FieldOffset(Offset = "0xA4")]
	[SerializeField]
	private float _explosionForce;

	[Token(Token = "0x4004932")]
	[FieldOffset(Offset = "0xA8")]
	[SerializeField]
	private ParticleSystem _explosionParticles;

	[Token(Token = "0x4004933")]
	[FieldOffset(Offset = "0xB0")]
	private bool _exploded;

	[Token(Token = "0x4004934")]
	[FieldOffset(Offset = "0xB8")]
	private Collider _ballCollider;

	[Token(Token = "0x4004935")]
	[FieldOffset(Offset = "0xC0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x51D14", Offset = "0x51D14")]
	private Action<Vector3> OnAudioEvent__BackingField;

	[Token(Token = "0x17000670")]
	public Action<Vector3> OnAudioEvent
	{
		[Token(Token = "0x6003F48")]
		[Address(RVA = "0x1450F14", Offset = "0x1450F14", VA = "0x1450F14", Slot = "4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C79C", Offset = "0x6C79C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6003F49")]
		[Address(RVA = "0x1450F1C", Offset = "0x1450F1C", VA = "0x1450F1C", Slot = "5")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6C7AC", Offset = "0x6C7AC")]
		set
		{
		}
	}

	[Token(Token = "0x6003F3E")]
	[Address(RVA = "0x14505A8", Offset = "0x14505A8", VA = "0x14505A8")]
	private void Start()
	{
	}

	[Token(Token = "0x6003F3F")]
	[Address(RVA = "0x14505E4", Offset = "0x14505E4", VA = "0x14505E4")]
	private void Update()
	{
	}

	[Token(Token = "0x6003F40")]
	[Address(RVA = "0x1450664", Offset = "0x1450664", VA = "0x1450664")]
	private void Appear()
	{
	}

	[Token(Token = "0x6003F41")]
	[Address(RVA = "0x1450D10", Offset = "0x1450D10", VA = "0x1450D10")]
	private void SetWarning()
	{
	}

	[Token(Token = "0x6003F42")]
	[Address(RVA = "0x1450724", Offset = "0x1450724", VA = "0x1450724")]
	private void Warning()
	{
	}

	[Token(Token = "0x6003F43")]
	[Address(RVA = "0x1450DA4", Offset = "0x1450DA4", VA = "0x1450DA4")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x6003F44")]
	[Address(RVA = "0x1450878", Offset = "0x1450878", VA = "0x1450878")]
	private void Explode()
	{
	}

	[Token(Token = "0x6003F45")]
	[Address(RVA = "0x1450DF4", Offset = "0x1450DF4", VA = "0x1450DF4")]
	private IEnumerator Aduio()
	{
		return null;
	}

	[Token(Token = "0x6003F46")]
	[Address(RVA = "0x1450E68", Offset = "0x1450E68", VA = "0x1450E68")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6003F47")]
	[Address(RVA = "0x1450EFC", Offset = "0x1450EFC", VA = "0x1450EFC")]
	public void OnPickedUp(Collider ballCollider)
	{
	}

	[Token(Token = "0x6003F4A")]
	[Address(RVA = "0x1450F24", Offset = "0x1450F24", VA = "0x1450F24")]
	public ExplodingDynamiteForLivingThings()
	{
	}
}
