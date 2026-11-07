using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200072E")]
public class EvilBoss : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x200072F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x412B0", Offset = "0x412B0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40025FA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40025FB")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__24_0;

		[Token(Token = "0x40025FC")]
		[FieldOffset(Offset = "0x10")]
		public static Action<float> _003C_003E9__25_0;

		[Token(Token = "0x600212A")]
		[Address(RVA = "0x17A0100", Offset = "0x17A0100", VA = "0x17A0100")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600212B")]
		[Address(RVA = "0x17A0108", Offset = "0x17A0108", VA = "0x17A0108")]
		internal void _003CDoKick_003Eb__24_0(AudioSource s)
		{
		}

		[Token(Token = "0x600212C")]
		[Address(RVA = "0x17A0164", Offset = "0x17A0164", VA = "0x17A0164")]
		internal void _003CStunned_003Eb__25_0(float t)
		{
		}
	}

	[Token(Token = "0x2000730")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x412C0", Offset = "0x412C0")]
	private sealed class _003CDoKick_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40025FD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40025FE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40025FF")]
		[FieldOffset(Offset = "0x20")]
		public EvilBoss _003C_003E4__this;

		[Token(Token = "0x4002600")]
		[FieldOffset(Offset = "0x28")]
		public Rigidbody other;

		[Token(Token = "0x4002601")]
		[FieldOffset(Offset = "0x30")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170003BA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002130")]
			[Address(RVA = "0x17A04F0", Offset = "0x17A04F0", VA = "0x17A04F0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170003BB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002132")]
			[Address(RVA = "0x17A0538", Offset = "0x17A0538", VA = "0x17A0538", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600212D")]
		[Address(RVA = "0x17A0168", Offset = "0x17A0168", VA = "0x17A0168")]
		[DebuggerHidden]
		public _003CDoKick_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600212E")]
		[Address(RVA = "0x17A0194", Offset = "0x17A0194", VA = "0x17A0194", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600212F")]
		[Address(RVA = "0x17A0198", Offset = "0x17A0198", VA = "0x17A0198", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002130")]
		[Address(RVA = "0x17A04F0", Offset = "0x17A04F0", VA = "0x17A04F0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002131")]
		[Address(RVA = "0x17A04F8", Offset = "0x17A04F8", VA = "0x17A04F8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002132")]
		[Address(RVA = "0x17A0538", Offset = "0x17A0538", VA = "0x17A0538", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40025E5")]
	[FieldOffset(Offset = "0x18")]
	public Rigidbody ball;

	[Token(Token = "0x40025E6")]
	[FieldOffset(Offset = "0x20")]
	public bool KickTarget;

	[Token(Token = "0x40025E7")]
	[FieldOffset(Offset = "0x24")]
	public float KickForce;

	[Token(Token = "0x40025E8")]
	[FieldOffset(Offset = "0x28")]
	public float kickRange;

	[Token(Token = "0x40025E9")]
	[FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x40025EA")]
	[FieldOffset(Offset = "0x30")]
	public float reactDistance;

	[Token(Token = "0x40025EB")]
	[FieldOffset(Offset = "0x34")]
	public float stopDistance;

	[Token(Token = "0x40025EC")]
	[FieldOffset(Offset = "0x38")]
	public List<AudioClip> sfxKick;

	[Token(Token = "0x40025ED")]
	[FieldOffset(Offset = "0x40")]
	public float rotateSpeed;

	[Token(Token = "0x40025EE")]
	[FieldOffset(Offset = "0x44")]
	public bool lookAlongVelocity;

	[Token(Token = "0x40025EF")]
	[FieldOffset(Offset = "0x48")]
	public int StrokePenaltiesOnCatch;

	[Token(Token = "0x40025F0")]
	[FieldOffset(Offset = "0x50")]
	public Animator Animator;

	[Token(Token = "0x40025F1")]
	[FieldOffset(Offset = "0x58")]
	public float StunDuration;

	[Token(Token = "0x40025F2")]
	[FieldOffset(Offset = "0x60")]
	public ParticleSystem StunParticles;

	[Token(Token = "0x40025F3")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 startPosition;

	[Token(Token = "0x40025F4")]
	[FieldOffset(Offset = "0x74")]
	private Quaternion startRotation;

	[Token(Token = "0x40025F5")]
	[FieldOffset(Offset = "0x88")]
	private Rigidbody rigid;

	[Token(Token = "0x40025F6")]
	[FieldOffset(Offset = "0x90")]
	private float nextHit;

	[Token(Token = "0x40025F7")]
	[FieldOffset(Offset = "0x98")]
	private Collider collider;

	[Token(Token = "0x40025F8")]
	[FieldOffset(Offset = "0xA0")]
	private float waitTime;

	[Token(Token = "0x40025F9")]
	[FieldOffset(Offset = "0xA4")]
	private bool targetIsTouching;

	[Token(Token = "0x6002121")]
	[Address(RVA = "0x14485D8", Offset = "0x14485D8", VA = "0x14485D8")]
	private void Start()
	{
	}

	[Token(Token = "0x6002122")]
	[Address(RVA = "0x144873C", Offset = "0x144873C", VA = "0x144873C")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6002123")]
	[Address(RVA = "0x14489B8", Offset = "0x14489B8", VA = "0x14489B8")]
	private void OnCollisionExit(Collision collision)
	{
	}

	[Token(Token = "0x6002124")]
	[Address(RVA = "0x1448940", Offset = "0x1448940", VA = "0x1448940")]
	private IEnumerator DoKick(Rigidbody other)
	{
		return null;
	}

	[Token(Token = "0x6002125")]
	[Address(RVA = "0x1448A5C", Offset = "0x1448A5C", VA = "0x1448A5C")]
	public void Stunned()
	{
	}

	[Token(Token = "0x6002126")]
	[Address(RVA = "0x1448C44", Offset = "0x1448C44", VA = "0x1448C44")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6002127")]
	[Address(RVA = "0x14495A4", Offset = "0x14495A4", VA = "0x14495A4")]
	public EvilBoss()
	{
	}

	[Token(Token = "0x6002128")]
	[Address(RVA = "0x14495D4", Offset = "0x14495D4", VA = "0x14495D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x65B10", Offset = "0x65B10")]
	private void _003CStunned_003Eb__25_1()
	{
	}
}
