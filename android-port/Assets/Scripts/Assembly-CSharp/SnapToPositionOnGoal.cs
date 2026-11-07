using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000D14")]
public class SnapToPositionOnGoal : MonoBehaviour
{
	[Token(Token = "0x2000D15")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44688", Offset = "0x44688")]
	private sealed class _003CSnap_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004701")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004702")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004703")]
		[FieldOffset(Offset = "0x20")]
		public SnapToPositionOnGoal _003C_003E4__this;

		[Token(Token = "0x4004704")]
		[FieldOffset(Offset = "0x28")]
		private Transform _003CinitialTransform_003E5__2;

		[Token(Token = "0x4004705")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x4004706")]
		[FieldOffset(Offset = "0x34")]
		private float _003Cstep_003E5__4;

		[Token(Token = "0x1700064F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003DBD")]
			[Address(RVA = "0x1851BD4", Offset = "0x1851BD4", VA = "0x1851BD4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000650")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003DBF")]
			[Address(RVA = "0x1851C1C", Offset = "0x1851C1C", VA = "0x1851C1C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x18517BC", Offset = "0x18517BC", VA = "0x18517BC")]
		[DebuggerHidden]
		public _003CSnap_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x18517E8", Offset = "0x18517E8", VA = "0x18517E8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0x18517EC", Offset = "0x18517EC", VA = "0x18517EC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003DBD")]
		[Address(RVA = "0x1851BD4", Offset = "0x1851BD4", VA = "0x1851BD4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003DBE")]
		[Address(RVA = "0x1851BDC", Offset = "0x1851BDC", VA = "0x1851BDC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003DBF")]
		[Address(RVA = "0x1851C1C", Offset = "0x1851C1C", VA = "0x1851C1C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40046F9")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x40046FA")]
	[FieldOffset(Offset = "0x20")]
	public Transform head;

	[Token(Token = "0x40046FB")]
	[FieldOffset(Offset = "0x28")]
	public float angleRotations;

	[Token(Token = "0x40046FC")]
	[FieldOffset(Offset = "0x2C")]
	public float speed;

	[Token(Token = "0x40046FD")]
	[FieldOffset(Offset = "0x30")]
	private bool started;

	[Token(Token = "0x40046FE")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem Particles;

	[Token(Token = "0x40046FF")]
	[FieldOffset(Offset = "0x40")]
	private Quaternion headStart;

	[Token(Token = "0x4004700")]
	[FieldOffset(Offset = "0x50")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x6003DB6")]
	[Address(RVA = "0x16BA018", Offset = "0x16BA018", VA = "0x16BA018")]
	private void Start()
	{
	}

	[Token(Token = "0x6003DB7")]
	[Address(RVA = "0x16BA050", Offset = "0x16BA050", VA = "0x16BA050")]
	public void SnapToPosition()
	{
	}

	[Token(Token = "0x6003DB8")]
	[Address(RVA = "0x16BA0E0", Offset = "0x16BA0E0", VA = "0x16BA0E0")]
	private IEnumerator Snap()
	{
		return null;
	}

	[Token(Token = "0x6003DB9")]
	[Address(RVA = "0x16BA154", Offset = "0x16BA154", VA = "0x16BA154")]
	public SnapToPositionOnGoal()
	{
	}
}
