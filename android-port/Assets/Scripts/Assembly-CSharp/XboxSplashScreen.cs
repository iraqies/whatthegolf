using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000A9")]
public class XboxSplashScreen : MonoBehaviour
{
	[Token(Token = "0x20000AA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D7E0", Offset = "0x3D7E0")]
	private sealed class _003CShowRoutine_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40002A6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002A7")]
		[FieldOffset(Offset = "0x20")]
		public XboxSplashScreen _003C_003E4__this;

		[Token(Token = "0x1700007F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x187DB64", Offset = "0x187DB64", VA = "0x187DB64", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000080")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002F7")]
			[Address(RVA = "0x187DBAC", Offset = "0x187DBAC", VA = "0x187DBAC", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x187D890", Offset = "0x187D890", VA = "0x187D890")]
		[DebuggerHidden]
		public _003CShowRoutine_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x187D8BC", Offset = "0x187D8BC", VA = "0x187D8BC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x187D8C0", Offset = "0x187D8C0", VA = "0x187D8C0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002F5")]
		[Address(RVA = "0x187DB64", Offset = "0x187DB64", VA = "0x187DB64", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x187DB6C", Offset = "0x187DB6C", VA = "0x187DB6C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x187DBAC", Offset = "0x187DBAC", VA = "0x187DBAC", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20000AB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D7F0", Offset = "0x3D7F0")]
	private sealed class _003CHideRoutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40002A9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x20")]
		public XboxSplashScreen _003C_003E4__this;

		[Token(Token = "0x17000081")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x187D840", Offset = "0x187D840", VA = "0x187D840", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000082")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002FD")]
			[Address(RVA = "0x187D888", Offset = "0x187D888", VA = "0x187D888", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x187D704", Offset = "0x187D704", VA = "0x187D704")]
		[DebuggerHidden]
		public _003CHideRoutine_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x187D730", Offset = "0x187D730", VA = "0x187D730", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x187D734", Offset = "0x187D734", VA = "0x187D734", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002FB")]
		[Address(RVA = "0x187D840", Offset = "0x187D840", VA = "0x187D840", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x187D848", Offset = "0x187D848", VA = "0x187D848", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x187D888", Offset = "0x187D888", VA = "0x187D888", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40002A1")]
	[FieldOffset(Offset = "0x18")]
	public List<Graphic> fadeGraphics;

	[Token(Token = "0x40002A2")]
	[FieldOffset(Offset = "0x20")]
	public RawImage bgImage;

	[Token(Token = "0x40002A3")]
	[FieldOffset(Offset = "0x28")]
	public RawImage bgBehindImage;

	[Token(Token = "0x40002A4")]
	[FieldOffset(Offset = "0x30")]
	public Color bgColor;

	[Token(Token = "0x60002EB")]
	[Address(RVA = "0x1761108", Offset = "0x1761108", VA = "0x1761108")]
	private void Awake()
	{
	}

	[Token(Token = "0x60002EC")]
	[Address(RVA = "0x1761164", Offset = "0x1761164", VA = "0x1761164")]
	public IEnumerator ShowRoutine()
	{
		return null;
	}

	[Token(Token = "0x60002ED")]
	[Address(RVA = "0x17611D8", Offset = "0x17611D8", VA = "0x17611D8")]
	public IEnumerator HideRoutine()
	{
		return null;
	}

	[Token(Token = "0x60002EE")]
	[Address(RVA = "0x176124C", Offset = "0x176124C", VA = "0x176124C")]
	public void SetOff()
	{
	}

	[Token(Token = "0x60002EF")]
	[Address(RVA = "0x1761290", Offset = "0x1761290", VA = "0x1761290")]
	public XboxSplashScreen()
	{
	}

	[Token(Token = "0x60002F0")]
	[Address(RVA = "0x1761298", Offset = "0x1761298", VA = "0x1761298")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DE30", Offset = "0x5DE30")]
	private void _003CShowRoutine_003Eb__5_0(float t)
	{
	}

	[Token(Token = "0x60002F1")]
	[Address(RVA = "0x1761428", Offset = "0x1761428", VA = "0x1761428")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DE40", Offset = "0x5DE40")]
	private void _003CHideRoutine_003Eb__6_0(float t)
	{
	}
}
