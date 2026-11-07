using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000A6")]
public class SwitchSplashScreen : MonoBehaviour
{
	[Token(Token = "0x20000A7")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D7C0", Offset = "0x3D7C0")]
	private sealed class _003CShowRoutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x20")]
		public SwitchSplashScreen _003C_003E4__this;

		[Token(Token = "0x1700007B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60002E2")]
			[Address(RVA = "0x1860CF4", Offset = "0x1860CF4", VA = "0x1860CF4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700007C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002E4")]
			[Address(RVA = "0x1860D3C", Offset = "0x1860D3C", VA = "0x1860D3C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x18609C8", Offset = "0x18609C8", VA = "0x18609C8")]
		[DebuggerHidden]
		public _003CShowRoutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002E0")]
		[Address(RVA = "0x18609F4", Offset = "0x18609F4", VA = "0x18609F4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002E1")]
		[Address(RVA = "0x18609F8", Offset = "0x18609F8", VA = "0x18609F8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002E2")]
		[Address(RVA = "0x1860CF4", Offset = "0x1860CF4", VA = "0x1860CF4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002E3")]
		[Address(RVA = "0x1860CFC", Offset = "0x1860CFC", VA = "0x1860CFC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002E4")]
		[Address(RVA = "0x1860D3C", Offset = "0x1860D3C", VA = "0x1860D3C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x20000A8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D7D0", Offset = "0x3D7D0")]
	private sealed class _003CHideRoutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400029E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400029F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002A0")]
		[FieldOffset(Offset = "0x20")]
		public SwitchSplashScreen _003C_003E4__this;

		[Token(Token = "0x1700007D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60002E8")]
			[Address(RVA = "0x1860978", Offset = "0x1860978", VA = "0x1860978", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700007E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x18609C0", Offset = "0x18609C0", VA = "0x18609C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60002E5")]
		[Address(RVA = "0x186083C", Offset = "0x186083C", VA = "0x186083C")]
		[DebuggerHidden]
		public _003CHideRoutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60002E6")]
		[Address(RVA = "0x1860868", Offset = "0x1860868", VA = "0x1860868", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60002E7")]
		[Address(RVA = "0x186086C", Offset = "0x186086C", VA = "0x186086C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60002E8")]
		[Address(RVA = "0x1860978", Offset = "0x1860978", VA = "0x1860978", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60002E9")]
		[Address(RVA = "0x1860980", Offset = "0x1860980", VA = "0x1860980", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60002EA")]
		[Address(RVA = "0x18609C0", Offset = "0x18609C0", VA = "0x18609C0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000296")]
	[FieldOffset(Offset = "0x0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x496C8", Offset = "0x496C8")]
	private static SwitchSplashScreen Instance__BackingField;

	[Token(Token = "0x4000297")]
	[FieldOffset(Offset = "0x18")]
	public List<Graphic> fadeGraphics;

	[Token(Token = "0x4000298")]
	[FieldOffset(Offset = "0x20")]
	public RawImage bgImage;

	[Token(Token = "0x4000299")]
	[FieldOffset(Offset = "0x28")]
	public RawImage bgBehindImage;

	[Token(Token = "0x400029A")]
	[FieldOffset(Offset = "0x30")]
	public Color bgColor;

	[Token(Token = "0x1700007A")]
	public static SwitchSplashScreen Instance
	{
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x16F549C", Offset = "0x16F549C", VA = "0x16F549C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DD50", Offset = "0x5DD50")]
		get
		{
			return null;
		}
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x16F54E8", Offset = "0x16F54E8", VA = "0x16F54E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DD60", Offset = "0x5DD60")]
		private set
		{
		}
	}

	[Token(Token = "0x60002D7")]
	[Address(RVA = "0x16F5540", Offset = "0x16F5540", VA = "0x16F5540")]
	protected void Awake()
	{
	}

	[Token(Token = "0x60002D8")]
	[Address(RVA = "0x16F562C", Offset = "0x16F562C", VA = "0x16F562C")]
	private void Start()
	{
	}

	[Token(Token = "0x60002D9")]
	[Address(RVA = "0x16F56A8", Offset = "0x16F56A8", VA = "0x16F56A8")]
	public IEnumerator ShowRoutine()
	{
		return null;
	}

	[Token(Token = "0x60002DA")]
	[Address(RVA = "0x16F571C", Offset = "0x16F571C", VA = "0x16F571C")]
	public IEnumerator HideRoutine()
	{
		return null;
	}

	[Token(Token = "0x60002DB")]
	[Address(RVA = "0x16F5790", Offset = "0x16F5790", VA = "0x16F5790")]
	public void SetOff()
	{
	}

	[Token(Token = "0x60002DC")]
	[Address(RVA = "0x16F5834", Offset = "0x16F5834", VA = "0x16F5834")]
	public SwitchSplashScreen()
	{
	}

	[Token(Token = "0x60002DD")]
	[Address(RVA = "0x16F583C", Offset = "0x16F583C", VA = "0x16F583C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DD70", Offset = "0x5DD70")]
	private void _003CShowRoutine_003Eb__10_0(float t)
	{
	}

	[Token(Token = "0x60002DE")]
	[Address(RVA = "0x16F59CC", Offset = "0x16F59CC", VA = "0x16F59CC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5DD80", Offset = "0x5DD80")]
	private void _003CHideRoutine_003Eb__11_0(float t)
	{
	}
}
