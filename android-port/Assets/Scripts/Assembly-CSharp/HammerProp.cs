using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000211")]
public class HammerProp : MonoBehaviour
{
	[Token(Token = "0x2000212")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E460", Offset = "0x3E460")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x10")]
		public HammerProp _003C_003E4__this;

		[Token(Token = "0x4000A48")]
		[FieldOffset(Offset = "0x18")]
		public float amplitudeGain;

		[Token(Token = "0x4000A49")]
		[FieldOffset(Offset = "0x1C")]
		public float frequencyGain;

		[Token(Token = "0x6000942")]
		[Address(RVA = "0x17B97A4", Offset = "0x17B97A4", VA = "0x17B97A4")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6000943")]
		[Address(RVA = "0x17B97AC", Offset = "0x17B97AC", VA = "0x17B97AC")]
		internal void _003CShake_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000213")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E470", Offset = "0x3E470")]
	private sealed class _003CShake_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000A4A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000A4B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000A4C")]
		[FieldOffset(Offset = "0x20")]
		public HammerProp _003C_003E4__this;

		[Token(Token = "0x4000A4D")]
		[FieldOffset(Offset = "0x28")]
		public float amplitudeGain;

		[Token(Token = "0x4000A4E")]
		[FieldOffset(Offset = "0x2C")]
		public float frequencyGain;

		[Token(Token = "0x4000A4F")]
		[FieldOffset(Offset = "0x30")]
		public float duration;

		[Token(Token = "0x17000121")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000947")]
			[Address(RVA = "0x17B99BC", Offset = "0x17B99BC", VA = "0x17B99BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000122")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000949")]
			[Address(RVA = "0x17B9A04", Offset = "0x17B9A04", VA = "0x17B9A04", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000944")]
		[Address(RVA = "0x17B9828", Offset = "0x17B9828", VA = "0x17B9828")]
		[DebuggerHidden]
		public _003CShake_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000945")]
		[Address(RVA = "0x17B9854", Offset = "0x17B9854", VA = "0x17B9854", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0x17B9858", Offset = "0x17B9858", VA = "0x17B9858", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0x17B99BC", Offset = "0x17B99BC", VA = "0x17B99BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000948")]
		[Address(RVA = "0x17B99C4", Offset = "0x17B99C4", VA = "0x17B99C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000949")]
		[Address(RVA = "0x17B9A04", Offset = "0x17B9A04", VA = "0x17B9A04", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000A3C")]
	[FieldOffset(Offset = "0x18")]
	public LayerMask CollisionLayer;

	[Token(Token = "0x4000A3D")]
	[FieldOffset(Offset = "0x20")]
	public ParticleSystem Particles;

	[Token(Token = "0x4000A3E")]
	[FieldOffset(Offset = "0x28")]
	public Collider BorderCollider;

	[Token(Token = "0x4000A3F")]
	[FieldOffset(Offset = "0x30")]
	public Collider PropCollider;

	[Token(Token = "0x4000A40")]
	[FieldOffset(Offset = "0x38")]
	public CinemachineVirtualCamera Camera;

	[Token(Token = "0x4000A41")]
	[FieldOffset(Offset = "0x40")]
	public bool StopRigidOnCollision;

	[Token(Token = "0x4000A42")]
	[FieldOffset(Offset = "0x41")]
	public bool DoShake;

	[Token(Token = "0x4000A43")]
	[FieldOffset(Offset = "0x48")]
	public HammerThrowingCamera HammerCamera;

	[Token(Token = "0x4000A44")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody rigid;

	[Token(Token = "0x4000A45")]
	[FieldOffset(Offset = "0x58")]
	private Vector3 lastVel;

	[Token(Token = "0x4000A46")]
	[FieldOffset(Offset = "0x68")]
	private CinemachineBasicMultiChannelPerlin noise;

	[Token(Token = "0x600093C")]
	[Address(RVA = "0x14C1304", Offset = "0x14C1304", VA = "0x14C1304")]
	private void Awake()
	{
	}

	[Token(Token = "0x600093D")]
	[Address(RVA = "0x14C13E4", Offset = "0x14C13E4", VA = "0x14C13E4")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600093E")]
	[Address(RVA = "0x14C1484", Offset = "0x14C1484", VA = "0x14C1484")]
	private void OnCollisionEnter(Collision other)
	{
	}

	[Token(Token = "0x600093F")]
	[Address(RVA = "0x14C171C", Offset = "0x14C171C", VA = "0x14C171C")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000940")]
	[Address(RVA = "0x14C1684", Offset = "0x14C1684", VA = "0x14C1684")]
	private IEnumerator Shake(float amplitudeGain, float frequencyGain, float duration)
	{
		return null;
	}

	[Token(Token = "0x6000941")]
	[Address(RVA = "0x14C1870", Offset = "0x14C1870", VA = "0x14C1870")]
	public HammerProp()
	{
	}
}
