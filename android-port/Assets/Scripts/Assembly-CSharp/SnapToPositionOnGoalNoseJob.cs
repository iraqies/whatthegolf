using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E61")]
public class SnapToPositionOnGoalNoseJob : MonoBehaviour
{
	[Token(Token = "0x2000E62")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45038", Offset = "0x45038")]
	private sealed class _003CSnap_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004DE8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004DE9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004DEA")]
		[FieldOffset(Offset = "0x20")]
		public SnapToPositionOnGoalNoseJob _003C_003E4__this;

		[Token(Token = "0x4004DEB")]
		[FieldOffset(Offset = "0x28")]
		private Transform _003CinitialTransform_003E5__2;

		[Token(Token = "0x4004DEC")]
		[FieldOffset(Offset = "0x30")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x4004DED")]
		[FieldOffset(Offset = "0x34")]
		private float _003Cstep_003E5__4;

		[Token(Token = "0x170006E6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004349")]
			[Address(RVA = "0x1851FC0", Offset = "0x1851FC0", VA = "0x1851FC0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006E7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600434B")]
			[Address(RVA = "0x1852008", Offset = "0x1852008", VA = "0x1852008", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004346")]
		[Address(RVA = "0x1851C24", Offset = "0x1851C24", VA = "0x1851C24")]
		[DebuggerHidden]
		public _003CSnap_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004347")]
		[Address(RVA = "0x1851C50", Offset = "0x1851C50", VA = "0x1851C50", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004348")]
		[Address(RVA = "0x1851C54", Offset = "0x1851C54", VA = "0x1851C54", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004349")]
		[Address(RVA = "0x1851FC0", Offset = "0x1851FC0", VA = "0x1851FC0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600434A")]
		[Address(RVA = "0x1851FC8", Offset = "0x1851FC8", VA = "0x1851FC8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600434B")]
		[Address(RVA = "0x1852008", Offset = "0x1852008", VA = "0x1852008", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004DE3")]
	[FieldOffset(Offset = "0x18")]
	public Transform target;

	[Token(Token = "0x4004DE4")]
	[FieldOffset(Offset = "0x20")]
	public float angleRotations;

	[Token(Token = "0x4004DE5")]
	[FieldOffset(Offset = "0x24")]
	public float speed;

	[Token(Token = "0x4004DE6")]
	[FieldOffset(Offset = "0x28")]
	private bool started;

	[Token(Token = "0x4004DE7")]
	[FieldOffset(Offset = "0x30")]
	public AnimationCurve animationCurve;

	[Token(Token = "0x6004343")]
	[Address(RVA = "0x16BA1A0", Offset = "0x16BA1A0", VA = "0x16BA1A0")]
	public void SnapToPosition()
	{
	}

	[Token(Token = "0x6004344")]
	[Address(RVA = "0x16BA230", Offset = "0x16BA230", VA = "0x16BA230")]
	private IEnumerator Snap()
	{
		return null;
	}

	[Token(Token = "0x6004345")]
	[Address(RVA = "0x16BA2A4", Offset = "0x16BA2A4", VA = "0x16BA2A4")]
	public SnapToPositionOnGoalNoseJob()
	{
	}
}
