using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20009C7")]
public class IntroSinger : MonoBehaviour
{
	[Token(Token = "0x20009C8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x426D0", Offset = "0x426D0")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x40035AF")]
		[FieldOffset(Offset = "0x10")]
		public IntroSinger _003C_003E4__this;

		[Token(Token = "0x40035B0")]
		[FieldOffset(Offset = "0x18")]
		public Vector2 outPos;

		[Token(Token = "0x40035B1")]
		[FieldOffset(Offset = "0x20")]
		public Vector2 inPos;

		[Token(Token = "0x40035B2")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 startPos;

		[Token(Token = "0x6002DF9")]
		[Address(RVA = "0x17C929C", Offset = "0x17C929C", VA = "0x17C929C")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6002DFA")]
		[Address(RVA = "0x17C92A4", Offset = "0x17C92A4", VA = "0x17C92A4")]
		internal void _003CAnimate_003Eb__0(float t)
		{
		}

		[Token(Token = "0x6002DFB")]
		[Address(RVA = "0x17C9350", Offset = "0x17C9350", VA = "0x17C9350")]
		internal void _003CAnimate_003Eb__1(float t)
		{
		}
	}

	[Token(Token = "0x20009C9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x426E0", Offset = "0x426E0")]
	private sealed class _003CAnimate_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40035B3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40035B4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40035B5")]
		[FieldOffset(Offset = "0x20")]
		public IntroSinger _003C_003E4__this;

		[Token(Token = "0x40035B6")]
		[FieldOffset(Offset = "0x28")]
		public float time;

		[Token(Token = "0x40035B7")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		[Token(Token = "0x170004BF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002DFF")]
			[Address(RVA = "0x17C9668", Offset = "0x17C9668", VA = "0x17C9668", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170004C0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E01")]
			[Address(RVA = "0x17C96B0", Offset = "0x17C96B0", VA = "0x17C96B0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6002DFC")]
		[Address(RVA = "0x17C93EC", Offset = "0x17C93EC", VA = "0x17C93EC")]
		[DebuggerHidden]
		public _003CAnimate_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002DFD")]
		[Address(RVA = "0x17C9418", Offset = "0x17C9418", VA = "0x17C9418", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002DFE")]
		[Address(RVA = "0x17C941C", Offset = "0x17C941C", VA = "0x17C941C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6002DFF")]
		[Address(RVA = "0x17C9668", Offset = "0x17C9668", VA = "0x17C9668", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6002E00")]
		[Address(RVA = "0x17C9670", Offset = "0x17C9670", VA = "0x17C9670", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6002E01")]
		[Address(RVA = "0x17C96B0", Offset = "0x17C96B0", VA = "0x17C96B0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40035AB")]
	[FieldOffset(Offset = "0x18")]
	public float movebackOffset;

	[Token(Token = "0x40035AC")]
	[FieldOffset(Offset = "0x1C")]
	public float moveforwardOffset;

	[Token(Token = "0x40035AD")]
	[FieldOffset(Offset = "0x20")]
	public AnimationCurve animCurve;

	[Token(Token = "0x40035AE")]
	[FieldOffset(Offset = "0x28")]
	public Vector2 dir;

	[Token(Token = "0x6002DF4")]
	[Address(RVA = "0x14F3DD4", Offset = "0x14F3DD4", VA = "0x14F3DD4")]
	public Vector2 GetBorderPos(Vector2 dir)
	{
		return default;
	}

	[Token(Token = "0x6002DF5")]
	[Address(RVA = "0x14F3E6C", Offset = "0x14F3E6C", VA = "0x14F3E6C")]
	public void BeginAnimat(float v)
	{
	}

	[Token(Token = "0x6002DF6")]
	[Address(RVA = "0x14F407C", Offset = "0x14F407C", VA = "0x14F407C")]
	public void Hide()
	{
	}

	[Token(Token = "0x6002DF7")]
	[Address(RVA = "0x14F3FF8", Offset = "0x14F3FF8", VA = "0x14F3FF8")]
	public IEnumerator Animate(float time)
	{
		return null;
	}

	[Token(Token = "0x6002DF8")]
	[Address(RVA = "0x14F40A4", Offset = "0x14F40A4", VA = "0x14F40A4")]
	public IntroSinger()
	{
	}
}
