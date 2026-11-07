using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D16")]
public class SnapToPositionOnTrigger : MonoBehaviour
{
	[Token(Token = "0x2000D17")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44698", Offset = "0x44698")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x400470A")]
		[FieldOffset(Offset = "0x10")]
		public Transform trans;

		[Token(Token = "0x400470B")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startPos;

		[Token(Token = "0x400470C")]
		[FieldOffset(Offset = "0x28")]
		public SnapToPositionOnTrigger _003C_003E4__this;

		[Token(Token = "0x400470D")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion startRot;

		[Token(Token = "0x6003DC4")]
		[Address(RVA = "0x1852010", Offset = "0x1852010", VA = "0x1852010")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6003DC5")]
		[Address(RVA = "0x1852018", Offset = "0x1852018", VA = "0x1852018")]
		internal void _003CSnapRoutine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000D18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x446A8", Offset = "0x446A8")]
	private sealed class _003CSnapRoutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400470E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400470F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004710")]
		[FieldOffset(Offset = "0x20")]
		public Transform trans;

		[Token(Token = "0x4004711")]
		[FieldOffset(Offset = "0x28")]
		public SnapToPositionOnTrigger _003C_003E4__this;

		[Token(Token = "0x4004712")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x17000651")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003DC9")]
			[Address(RVA = "0x1852368", Offset = "0x1852368", VA = "0x1852368", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000652")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003DCB")]
			[Address(RVA = "0x18523B0", Offset = "0x18523B0", VA = "0x18523B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003DC6")]
		[Address(RVA = "0x185215C", Offset = "0x185215C", VA = "0x185215C")]
		[DebuggerHidden]
		public _003CSnapRoutine_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003DC7")]
		[Address(RVA = "0x1852188", Offset = "0x1852188", VA = "0x1852188", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003DC8")]
		[Address(RVA = "0x185218C", Offset = "0x185218C", VA = "0x185218C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003DC9")]
		[Address(RVA = "0x1852368", Offset = "0x1852368", VA = "0x1852368", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003DCA")]
		[Address(RVA = "0x1852370", Offset = "0x1852370", VA = "0x1852370", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003DCB")]
		[Address(RVA = "0x18523B0", Offset = "0x18523B0", VA = "0x18523B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004707")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private LayerMask layerMask;

	[Token(Token = "0x4004708")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Transform target;

	[Token(Token = "0x4004709")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float snapTime;

	[Token(Token = "0x6003DC0")]
	[Address(RVA = "0x16BA2F0", Offset = "0x16BA2F0", VA = "0x16BA2F0")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6003DC1")]
	[Address(RVA = "0x16BA458", Offset = "0x16BA458", VA = "0x16BA458")]
	public void StartSnapping(Transform trans)
	{
	}

	[Token(Token = "0x6003DC2")]
	[Address(RVA = "0x16BA3E0", Offset = "0x16BA3E0", VA = "0x16BA3E0")]
	private IEnumerator SnapRoutine(Transform trans)
	{
		return null;
	}

	[Token(Token = "0x6003DC3")]
	[Address(RVA = "0x16BA4D8", Offset = "0x16BA4D8", VA = "0x16BA4D8")]
	public SnapToPositionOnTrigger()
	{
	}
}
