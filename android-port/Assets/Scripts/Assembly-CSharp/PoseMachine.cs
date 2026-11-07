using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20001FE")]
public class PoseMachine : MonoBehaviour
{
	[Token(Token = "0x20001FF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E3B8", Offset = "0x3E3B8")]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		[Token(Token = "0x40009C0")]
		[FieldOffset(Offset = "0x10")]
		public PoseMachine _003C_003E4__this;

		[Token(Token = "0x40009C1")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 startEuler;

		[Token(Token = "0x40009C2")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 endEuler;

		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x182ABC8", Offset = "0x182ABC8", VA = "0x182ABC8")]
		public _003C_003Ec__DisplayClass3_0()
		{
		}

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x182ABD0", Offset = "0x182ABD0", VA = "0x182ABD0")]
		internal void _003CChangePoseMachine_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000200")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3E3C8", Offset = "0x3E3C8")]
	private sealed class _003CChangePoseMachine_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40009C3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40009C4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40009C5")]
		[FieldOffset(Offset = "0x20")]
		public PoseMachine _003C_003E4__this;

		[Token(Token = "0x40009C6")]
		[FieldOffset(Offset = "0x28")]
		public bool next;

		[Token(Token = "0x40009C7")]
		[FieldOffset(Offset = "0x30")]
		public Action onDone;

		[Token(Token = "0x1700011D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60008F9")]
			[Address(RVA = "0x182AE68", Offset = "0x182AE68", VA = "0x182AE68", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700011E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60008FB")]
			[Address(RVA = "0x182AEB0", Offset = "0x182AEB0", VA = "0x182AEB0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x182ACAC", Offset = "0x182ACAC", VA = "0x182ACAC")]
		[DebuggerHidden]
		public _003CChangePoseMachine_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60008F7")]
		[Address(RVA = "0x182ACD8", Offset = "0x182ACD8", VA = "0x182ACD8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60008F8")]
		[Address(RVA = "0x182ACDC", Offset = "0x182ACDC", VA = "0x182ACDC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60008F9")]
		[Address(RVA = "0x182AE68", Offset = "0x182AE68", VA = "0x182AE68", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60008FA")]
		[Address(RVA = "0x182AE70", Offset = "0x182AE70", VA = "0x182AE70", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60008FB")]
		[Address(RVA = "0x182AEB0", Offset = "0x182AEB0", VA = "0x182AEB0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x18")]
	public Transform Pivot;

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x161D5FC", Offset = "0x161D5FC", VA = "0x161D5FC")]
	public void NextPose(Action onDone)
	{
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x161D714", Offset = "0x161D714", VA = "0x161D714")]
	public void RedoPose(Action onDone)
	{
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x161D688", Offset = "0x161D688", VA = "0x161D688")]
	private IEnumerator ChangePoseMachine(Action onDone, bool next)
	{
		return null;
	}

	[Token(Token = "0x60008F3")]
	[Address(RVA = "0x161D79C", Offset = "0x161D79C", VA = "0x161D79C")]
	public PoseMachine()
	{
	}
}
