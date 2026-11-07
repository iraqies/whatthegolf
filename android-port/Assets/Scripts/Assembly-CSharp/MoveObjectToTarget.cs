using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000E89")]
public class MoveObjectToTarget : MonoBehaviour
{
	[Token(Token = "0x2000E8A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x450C8", Offset = "0x450C8")]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x4004E93")]
		[FieldOffset(Offset = "0x10")]
		public MoveObjectToTarget _003C_003E4__this;

		[Token(Token = "0x4004E94")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x60043EA")]
		[Address(RVA = "0x17F984C", Offset = "0x17F984C", VA = "0x17F984C")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x60043EB")]
		[Address(RVA = "0x17F9854", Offset = "0x17F9854", VA = "0x17F9854")]
		internal void _003CMoveCR_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000E8B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x450D8", Offset = "0x450D8")]
	private sealed class _003CMoveCR_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004E95")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004E96")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004E97")]
		[FieldOffset(Offset = "0x20")]
		public MoveObjectToTarget _003C_003E4__this;

		[Token(Token = "0x4004E98")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		[Token(Token = "0x170006F4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60043EF")]
			[Address(RVA = "0x17F9B74", Offset = "0x17F9B74", VA = "0x17F9B74", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006F5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60043F1")]
			[Address(RVA = "0x17F9BBC", Offset = "0x17F9BBC", VA = "0x17F9BBC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60043EC")]
		[Address(RVA = "0x17F9934", Offset = "0x17F9934", VA = "0x17F9934")]
		[DebuggerHidden]
		public _003CMoveCR_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60043ED")]
		[Address(RVA = "0x17F9960", Offset = "0x17F9960", VA = "0x17F9960", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60043EE")]
		[Address(RVA = "0x17F9964", Offset = "0x17F9964", VA = "0x17F9964", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60043EF")]
		[Address(RVA = "0x17F9B74", Offset = "0x17F9B74", VA = "0x17F9B74", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60043F0")]
		[Address(RVA = "0x17F9B7C", Offset = "0x17F9B7C", VA = "0x17F9B7C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60043F1")]
		[Address(RVA = "0x17F9BBC", Offset = "0x17F9BBC", VA = "0x17F9BBC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004E83")]
	[FieldOffset(Offset = "0x18")]
	public GameObject objectToMove;

	[Token(Token = "0x4004E84")]
	[FieldOffset(Offset = "0x20")]
	public Transform targetTransform;

	[Token(Token = "0x4004E85")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private AnimationCurve _AnimationCurve;

	[Token(Token = "0x4004E86")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float duration;

	[Token(Token = "0x4004E87")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private bool usePhysics;

	[Token(Token = "0x4004E88")]
	[FieldOffset(Offset = "0x35")]
	[SerializeField]
	private bool enableOnStart;

	[Token(Token = "0x4004E89")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Rigidbody rigid;

	[Token(Token = "0x4004E8A")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private float delay;

	[Token(Token = "0x4004E8B")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private UnityEvent OnObjectMoving;

	[Token(Token = "0x4004E8C")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private UnityEvent OnObjectMoved;

	[Token(Token = "0x4004E8D")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private bool useDefaultCollision;

	[Token(Token = "0x4004E8E")]
	[FieldOffset(Offset = "0x59")]
	[SerializeField]
	private bool useCollision;

	[Token(Token = "0x4004E8F")]
	[FieldOffset(Offset = "0x5A")]
	[SerializeField]
	private bool useTrigger;

	[Token(Token = "0x4004E90")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private List<string> AcceptedTags;

	[Token(Token = "0x4004E91")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private List<Collider> Blacklist;

	[Token(Token = "0x4004E92")]
	[FieldOffset(Offset = "0x70")]
	private bool isMoving;

	[Token(Token = "0x60043E2")]
	[Address(RVA = "0x1572E58", Offset = "0x1572E58", VA = "0x1572E58")]
	private void Start()
	{
	}

	[Token(Token = "0x60043E3")]
	[Address(RVA = "0x1572E6C", Offset = "0x1572E6C", VA = "0x1572E6C")]
	public void Move()
	{
	}

	[Token(Token = "0x60043E4")]
	[Address(RVA = "0x1573008", Offset = "0x1573008", VA = "0x1573008")]
	private void OnDrawGizmos()
	{
	}

	[Token(Token = "0x60043E5")]
	[Address(RVA = "0x157312C", Offset = "0x157312C", VA = "0x157312C")]
	public void Stop()
	{
	}

	[Token(Token = "0x60043E6")]
	[Address(RVA = "0x1572F94", Offset = "0x1572F94", VA = "0x1572F94")]
	private IEnumerator MoveCR()
	{
		return null;
	}

	[Token(Token = "0x60043E7")]
	[Address(RVA = "0x1573134", Offset = "0x1573134", VA = "0x1573134")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x60043E8")]
	[Address(RVA = "0x1573248", Offset = "0x1573248", VA = "0x1573248")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x60043E9")]
	[Address(RVA = "0x1573364", Offset = "0x1573364", VA = "0x1573364")]
	public MoveObjectToTarget()
	{
	}
}
