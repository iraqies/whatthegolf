using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DAF")]
public class MoveObjectAlongCurveOnTrigger : MonoBehaviour
{
	[Token(Token = "0x2000DB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C20", Offset = "0x44C20")]
	private sealed class _003CStart_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004AA4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004AA5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004AA6")]
		[FieldOffset(Offset = "0x20")]
		public MoveObjectAlongCurveOnTrigger _003C_003E4__this;

		[Token(Token = "0x17000699")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004069")]
			[Address(RVA = "0x17F97FC", Offset = "0x17F97FC", VA = "0x17F97FC", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700069A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600406B")]
			[Address(RVA = "0x17F9844", Offset = "0x17F9844", VA = "0x17F9844", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004066")]
		[Address(RVA = "0x17F96AC", Offset = "0x17F96AC", VA = "0x17F96AC")]
		[DebuggerHidden]
		public _003CStart_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004067")]
		[Address(RVA = "0x17F96D8", Offset = "0x17F96D8", VA = "0x17F96D8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004068")]
		[Address(RVA = "0x17F96DC", Offset = "0x17F96DC", VA = "0x17F96DC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004069")]
		[Address(RVA = "0x17F97FC", Offset = "0x17F97FC", VA = "0x17F97FC", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600406A")]
		[Address(RVA = "0x17F9804", Offset = "0x17F9804", VA = "0x17F9804", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600406B")]
		[Address(RVA = "0x17F9844", Offset = "0x17F9844", VA = "0x17F9844", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000DB1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44C30", Offset = "0x44C30")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004AA7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004AA8")]
		[FieldOffset(Offset = "0x8")]
		public static Func<Transform, bool> _003C_003E9__13_0;

		[Token(Token = "0x600406D")]
		[Address(RVA = "0x17F9634", Offset = "0x17F9634", VA = "0x17F9634")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600406E")]
		[Address(RVA = "0x17F963C", Offset = "0x17F963C", VA = "0x17F963C")]
		internal bool _003COnDrawGizmosSelected_003Eb__13_0(Transform c)
		{
			return default;
		}
	}

	[Token(Token = "0x4004A9B")]
	[FieldOffset(Offset = "0x18")]
	public List<Transform> CurvePoints;

	[Token(Token = "0x4004A9C")]
	[FieldOffset(Offset = "0x20")]
	public float MoveSpeed;

	[Token(Token = "0x4004A9D")]
	[FieldOffset(Offset = "0x24")]
	public float Delay;

	[Token(Token = "0x4004A9E")]
	[FieldOffset(Offset = "0x28")]
	public bool UsePhysics;

	[Token(Token = "0x4004A9F")]
	[FieldOffset(Offset = "0x30")]
	public Rigidbody Rigid;

	[Token(Token = "0x4004AA0")]
	[FieldOffset(Offset = "0x38")]
	private float timer;

	[Token(Token = "0x4004AA1")]
	[FieldOffset(Offset = "0x3C")]
	public int curIndex;

	[Token(Token = "0x4004AA2")]
	[FieldOffset(Offset = "0x40")]
	private bool running;

	[Token(Token = "0x4004AA3")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x600405E")]
	[Address(RVA = "0x15719D4", Offset = "0x15719D4", VA = "0x15719D4")]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600405F")]
	[Address(RVA = "0x1571A48", Offset = "0x1571A48", VA = "0x1571A48")]
	private void Update()
	{
	}

	[Token(Token = "0x6004060")]
	[Address(RVA = "0x1571C9C", Offset = "0x1571C9C", VA = "0x1571C9C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6004061")]
	[Address(RVA = "0x1571B1C", Offset = "0x1571B1C", VA = "0x1571B1C")]
	private Vector3 GetPosition()
	{
		return default;
	}

	[Token(Token = "0x6004062")]
	[Address(RVA = "0x1571CF0", Offset = "0x1571CF0", VA = "0x1571CF0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x6004063")]
	[Address(RVA = "0x1572020", Offset = "0x1572020", VA = "0x1572020")]
	public void ResetIndex()
	{
	}

	[Token(Token = "0x6004064")]
	[Address(RVA = "0x1572028", Offset = "0x1572028", VA = "0x1572028")]
	public void SetSpeed(float newSpeed)
	{
	}

	[Token(Token = "0x6004065")]
	[Address(RVA = "0x1572030", Offset = "0x1572030", VA = "0x1572030")]
	public MoveObjectAlongCurveOnTrigger()
	{
	}
}
