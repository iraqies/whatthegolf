using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002D4")]
public class CannonShooter : MonoBehaviour
{
	[Token(Token = "0x20002D5")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3ECCC", Offset = "0x3ECCC")]
	private sealed class _003CRecoil_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F86")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000F87")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000F88")]
		[FieldOffset(Offset = "0x20")]
		public CannonShooter _003C_003E4__this;

		[Token(Token = "0x1700018C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000D01")]
			[Address(RVA = "0x1781A6C", Offset = "0x1781A6C", VA = "0x1781A6C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700018D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000D03")]
			[Address(RVA = "0x1781AB4", Offset = "0x1781AB4", VA = "0x1781AB4", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000CFE")]
		[Address(RVA = "0x178191C", Offset = "0x178191C", VA = "0x178191C")]
		[DebuggerHidden]
		public _003CRecoil_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000CFF")]
		[Address(RVA = "0x1781948", Offset = "0x1781948", VA = "0x1781948", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000D00")]
		[Address(RVA = "0x178194C", Offset = "0x178194C", VA = "0x178194C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000D01")]
		[Address(RVA = "0x1781A6C", Offset = "0x1781A6C", VA = "0x1781A6C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000D02")]
		[Address(RVA = "0x1781A74", Offset = "0x1781A74", VA = "0x1781A74", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000D03")]
		[Address(RVA = "0x1781AB4", Offset = "0x1781AB4", VA = "0x1781AB4", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000F74")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GolfBallController controller;

	[Token(Token = "0x4000F75")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Rigidbody cannonBall;

	[Token(Token = "0x4000F76")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform shootPosition;

	[Token(Token = "0x4000F77")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector3 additionalShootDirection;

	[Token(Token = "0x4000F78")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Transform recoilPos;

	[Token(Token = "0x4000F79")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float recoilDuration;

	[Token(Token = "0x4000F7A")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private AnimationCurve recoilCurve;

	[Token(Token = "0x4000F7B")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float shootForce;

	[Token(Token = "0x4000F7C")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private bool useArrowForce;

	[Token(Token = "0x4000F7D")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private float LookInAimDirectionSpeed;

	[Token(Token = "0x4000F7E")]
	[FieldOffset(Offset = "0x68")]
	private Rigidbody rigid;

	[Token(Token = "0x4000F7F")]
	[FieldOffset(Offset = "0x70")]
	private Vector3 startPos;

	[Token(Token = "0x4000F80")]
	[FieldOffset(Offset = "0x7C")]
	private bool canShoot;

	[Token(Token = "0x4000F81")]
	[FieldOffset(Offset = "0x7D")]
	[SerializeField]
	private bool moveable;

	[Token(Token = "0x4000F82")]
	[FieldOffset(Offset = "0x7E")]
	[SerializeField]
	private bool lookInAim;

	[Token(Token = "0x4000F83")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private float spin;

	[Token(Token = "0x4000F84")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private float forceOnShoot;

	[Token(Token = "0x4000F85")]
	[FieldOffset(Offset = "0x88")]
	private float ShootTime;

	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x18863DC", Offset = "0x18863DC", VA = "0x18863DC")]
	private void AimUpdate(Vector3 boost, bool b)
	{
	}

	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x1886540", Offset = "0x1886540", VA = "0x1886540")]
	private void Shoot(Vector3 boost)
	{
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x1886A2C", Offset = "0x1886A2C", VA = "0x1886A2C")]
	private IEnumerator Recoil()
	{
		return null;
	}

	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x1886AA0", Offset = "0x1886AA0", VA = "0x1886AA0")]
	private bool Cool()
	{
		return default;
	}

	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x1886AD8", Offset = "0x1886AD8", VA = "0x1886AD8")]
	private void Start()
	{
	}

	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x1886CF0", Offset = "0x1886CF0", VA = "0x1886CF0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x1886E10", Offset = "0x1886E10", VA = "0x1886E10")]
	public CannonShooter()
	{
	}

	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x1886E34", Offset = "0x1886E34", VA = "0x1886E34")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x606FC", Offset = "0x606FC")]
	private void _003CRecoil_003Eb__20_0(float t)
	{
	}
}
