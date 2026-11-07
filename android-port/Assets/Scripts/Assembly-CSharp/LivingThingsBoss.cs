using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DA7")]
public class LivingThingsBoss : MonoBehaviour
{
	[Token(Token = "0x2000DA8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44BF0", Offset = "0x44BF0")]
	private sealed class _003CAfterShoot_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004A7A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004A7B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004A7C")]
		[FieldOffset(Offset = "0x20")]
		public LivingThingsBoss _003C_003E4__this;

		[Token(Token = "0x4004A7D")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 Dir;

		[Token(Token = "0x4004A7E")]
		[FieldOffset(Offset = "0x38")]
		public Collider c;

		[Token(Token = "0x17000693")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004040")]
			[Address(RVA = "0x17EA804", Offset = "0x17EA804", VA = "0x17EA804", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000694")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6004042")]
			[Address(RVA = "0x17EA84C", Offset = "0x17EA84C", VA = "0x17EA84C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600403D")]
		[Address(RVA = "0x17EA44C", Offset = "0x17EA44C", VA = "0x17EA44C")]
		[DebuggerHidden]
		public _003CAfterShoot_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600403E")]
		[Address(RVA = "0x17EA478", Offset = "0x17EA478", VA = "0x17EA478", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600403F")]
		[Address(RVA = "0x17EA47C", Offset = "0x17EA47C", VA = "0x17EA47C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004040")]
		[Address(RVA = "0x17EA804", Offset = "0x17EA804", VA = "0x17EA804", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6004041")]
		[Address(RVA = "0x17EA80C", Offset = "0x17EA80C", VA = "0x17EA80C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6004042")]
		[Address(RVA = "0x17EA84C", Offset = "0x17EA84C", VA = "0x17EA84C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004A72")]
	[FieldOffset(Offset = "0x18")]
	private GolfBallController _controller;

	[Token(Token = "0x4004A73")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform m_FrogTarget;

	[Token(Token = "0x4004A74")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float _ShootSpeed;

	[Token(Token = "0x4004A75")]
	[FieldOffset(Offset = "0x2C")]
	private bool _hasThing;

	[Token(Token = "0x4004A76")]
	[FieldOffset(Offset = "0x30")]
	private Rigidbody thing;

	[Token(Token = "0x4004A77")]
	[FieldOffset(Offset = "0x38")]
	private Collider thingCollider;

	[Token(Token = "0x4004A78")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Collider m_BallCollider;

	[Token(Token = "0x4004A79")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float m_ExtraUp;

	[Token(Token = "0x6004036")]
	[Address(RVA = "0x1537F5C", Offset = "0x1537F5C", VA = "0x1537F5C")]
	private void Start()
	{
	}

	[Token(Token = "0x6004037")]
	[Address(RVA = "0x1537FB8", Offset = "0x1537FB8", VA = "0x1537FB8")]
	private void Update()
	{
	}

	[Token(Token = "0x6004038")]
	[Address(RVA = "0x1538080", Offset = "0x1538080", VA = "0x1538080")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6004039")]
	[Address(RVA = "0x15382CC", Offset = "0x15382CC", VA = "0x15382CC")]
	private void BallExploded()
	{
	}

	[Token(Token = "0x600403A")]
	[Address(RVA = "0x1538364", Offset = "0x1538364", VA = "0x1538364")]
	private void ControllerOnOnShoot(Vector3 obj)
	{
	}

	[Token(Token = "0x600403B")]
	[Address(RVA = "0x1538578", Offset = "0x1538578", VA = "0x1538578")]
	private IEnumerator AfterShoot(Collider c, Vector3 Dir)
	{
		return null;
	}

	[Token(Token = "0x600403C")]
	[Address(RVA = "0x1538618", Offset = "0x1538618", VA = "0x1538618")]
	public LivingThingsBoss()
	{
	}
}
