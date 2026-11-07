using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C0B")]
public class MoveObjectAlongCurve : MonoBehaviour
{
	[Token(Token = "0x2000C0C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F60", Offset = "0x43F60")]
	private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40042A3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40042A4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40042A5")]
		[FieldOffset(Offset = "0x20")]
		public MoveObjectAlongCurve _003C_003E4__this;

		[Token(Token = "0x170005FE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60039C9")]
			[Address(RVA = "0x17F9584", Offset = "0x17F9584", VA = "0x17F9584", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170005FF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60039CB")]
			[Address(RVA = "0x17F95CC", Offset = "0x17F95CC", VA = "0x17F95CC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60039C6")]
		[Address(RVA = "0x17F9434", Offset = "0x17F9434", VA = "0x17F9434")]
		[DebuggerHidden]
		public _003CStart_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60039C7")]
		[Address(RVA = "0x17F9460", Offset = "0x17F9460", VA = "0x17F9460", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60039C8")]
		[Address(RVA = "0x17F9464", Offset = "0x17F9464", VA = "0x17F9464", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60039C9")]
		[Address(RVA = "0x17F9584", Offset = "0x17F9584", VA = "0x17F9584", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60039CA")]
		[Address(RVA = "0x17F958C", Offset = "0x17F958C", VA = "0x17F958C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60039CB")]
		[Address(RVA = "0x17F95CC", Offset = "0x17F95CC", VA = "0x17F95CC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000C0D")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x43F70", Offset = "0x43F70")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40042A6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40042A7")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Transform, bool> _003C_003E9__13_0;

		[Token(Token = "0x60039CD")]
		[Address(RVA = "0x17F93BC", Offset = "0x17F93BC", VA = "0x17F93BC")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60039CE")]
		[Address(RVA = "0x17F93C4", Offset = "0x17F93C4", VA = "0x17F93C4")]
		internal bool _003COnDrawGizmos_003Eb__13_0(Transform c)
		{
			return default;
		}
	}

	[Token(Token = "0x400429A")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> CurvePoints;

	[Token(Token = "0x400429B")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x400429C")]
	[FieldOffset(Offset = "0x24")]
	public float Delay;

	[Token(Token = "0x400429D")]
	[FieldOffset(Offset = "0x28")]
	public bool UsePhysics;

	[Token(Token = "0x400429E")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody Rigid;

	[Token(Token = "0x400429F")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x40042A0")]
	[FieldOffset(Offset = "0x3C")]
	private int curIndex;

	[Token(Token = "0x40042A1")]
	[FieldOffset(Offset = "0x40")]
	private bool running;

	[Token(Token = "0x40042A2")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	private bool loop;

	[Token(Token = "0x60039C0")]
	[Address(RVA = "0x1571378", Offset = "0x1571378", VA = "0x1571378")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60039C1")]
	[Address(RVA = "0x15713EC", Offset = "0x15713EC", VA = "0x15713EC")]
	private void Update()
	{
	}

	[Token(Token = "0x60039C2")]
	[Address(RVA = "0x1571640", Offset = "0x1571640", VA = "0x1571640")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60039C3")]
	[Address(RVA = "0x15714E4", Offset = "0x15714E4", VA = "0x15714E4")]
	private Vector3 GetPosition()
	{
		return default;
	}

	[Token(Token = "0x60039C4")]
	[Address(RVA = "0x1571694", Offset = "0x1571694", VA = "0x1571694")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60039C5")]
	[Address(RVA = "0x15719C4", Offset = "0x15719C4", VA = "0x15719C4")]
	public MoveObjectAlongCurve()
	{
	}
}
