using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C46")]
public class ShrinkAndDestroy : MonoBehaviour
{
	[Token(Token = "0x2000C47")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x440A8", Offset = "0x440A8")]
	private sealed class _003CShrink_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004366")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004367")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004368")]
		[FieldOffset(Offset = "0x20")]
		public ShrinkAndDestroy _003C_003E4__this;

		[Token(Token = "0x4004369")]
		[FieldOffset(Offset = "0x28")]
		private float _003CdurationTimer_003E5__2;

		[Token(Token = "0x400436A")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _003CstartScale_003E5__3;

		[Token(Token = "0x17000603")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003A75")]
			[Address(RVA = "0x184D81C", Offset = "0x184D81C", VA = "0x184D81C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000604")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003A77")]
			[Address(RVA = "0x184D864", Offset = "0x184D864", VA = "0x184D864", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003A72")]
		[Address(RVA = "0x184D630", Offset = "0x184D630", VA = "0x184D630")]
		[DebuggerHidden]
		public _003CShrink_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003A73")]
		[Address(RVA = "0x184D65C", Offset = "0x184D65C", VA = "0x184D65C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003A74")]
		[Address(RVA = "0x184D660", Offset = "0x184D660", VA = "0x184D660", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003A75")]
		[Address(RVA = "0x184D81C", Offset = "0x184D81C", VA = "0x184D81C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003A76")]
		[Address(RVA = "0x184D824", Offset = "0x184D824", VA = "0x184D824", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003A77")]
		[Address(RVA = "0x184D864", Offset = "0x184D864", VA = "0x184D864", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004363")]
	[FieldOffset(Offset = "0x18")]
	public AnimationCurve ShrinkCurve;

	[Token(Token = "0x4004364")]
	[FieldOffset(Offset = "0x20")]
	public float Duration;

	[Token(Token = "0x4004365")]
	[FieldOffset(Offset = "0x24")]
	public bool startOnStart;

	[Token(Token = "0x6003A6E")]
	[Address(RVA = "0x16A8874", Offset = "0x16A8874", VA = "0x16A8874")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A6F")]
	[Address(RVA = "0x16A890C", Offset = "0x16A890C", VA = "0x16A890C")]
	public void StartShrink()
	{
	}

	[Token(Token = "0x6003A70")]
	[Address(RVA = "0x16A8988", Offset = "0x16A8988", VA = "0x16A8988")]
	public IEnumerator Shrink()
	{
		return null;
	}

	[Token(Token = "0x6003A71")]
	[Address(RVA = "0x16A89FC", Offset = "0x16A89FC", VA = "0x16A89FC")]
	public ShrinkAndDestroy()
	{
	}
}
