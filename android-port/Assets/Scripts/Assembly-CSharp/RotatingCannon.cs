using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000123")]
public class RotatingCannon : MonoBehaviour
{
	[Token(Token = "0x2000124")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DB80", Offset = "0x3DB80")]
	private sealed class _003CShootCannonRoutine_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400051E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400051F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000520")]
		[FieldOffset(Offset = "0x20")]
		public RotatingCannon _003C_003E4__this;

		[Token(Token = "0x170000AD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600050B")]
			[Address(RVA = "0x18363BC", Offset = "0x18363BC", VA = "0x18363BC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000AE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600050D")]
			[Address(RVA = "0x1836404", Offset = "0x1836404", VA = "0x1836404", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000508")]
		[Address(RVA = "0x18362D0", Offset = "0x18362D0", VA = "0x18362D0")]
		[DebuggerHidden]
		public _003CShootCannonRoutine_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000509")]
		[Address(RVA = "0x18362FC", Offset = "0x18362FC", VA = "0x18362FC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600050A")]
		[Address(RVA = "0x1836300", Offset = "0x1836300", VA = "0x1836300", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600050B")]
		[Address(RVA = "0x18363BC", Offset = "0x18363BC", VA = "0x18363BC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600050C")]
		[Address(RVA = "0x18363C4", Offset = "0x18363C4", VA = "0x18363C4", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600050D")]
		[Address(RVA = "0x1836404", Offset = "0x1836404", VA = "0x1836404", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private bool startOnAwake;

	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float arcRange;

	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float speedFactor;

	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float timeOffset;

	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve rotationCurve;

	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ParticleSystem shootParticles;

	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Transform shootPointTransform;

	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float shootForce;

	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Rigidbody cannonBall;

	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x50")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x58")]
	private Quaternion _startRotation;

	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x68")]
	private Vector3 axis;

	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0x74")]
	private float time;

	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0x78")]
	private bool isRotating;

	[Token(Token = "0x6000501")]
	[Address(RVA = "0x1661074", Offset = "0x1661074", VA = "0x1661074")]
	public void StartRotating()
	{
	}

	[Token(Token = "0x6000502")]
	[Address(RVA = "0x1661080", Offset = "0x1661080", VA = "0x1661080")]
	public void StopRotating()
	{
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x1661088", Offset = "0x1661088", VA = "0x1661088")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000504")]
	[Address(RVA = "0x1661118", Offset = "0x1661118", VA = "0x1661118")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000505")]
	[Address(RVA = "0x1661268", Offset = "0x1661268", VA = "0x1661268")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000506")]
	[Address(RVA = "0x16614CC", Offset = "0x16614CC", VA = "0x16614CC")]
	private IEnumerator ShootCannonRoutine()
	{
		return null;
	}

	[Token(Token = "0x6000507")]
	[Address(RVA = "0x1661540", Offset = "0x1661540", VA = "0x1661540")]
	public RotatingCannon()
	{
	}
}
