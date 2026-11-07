using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200005D")]
public class DemoEndLoader : MonoBehaviour
{
	[Token(Token = "0x200005E")]
	public enum EDemoEnded
	{
		[Token(Token = "0x4000186")]
		InMainCampaign = 0,
		[Token(Token = "0x4000187")]
		InPartyMode = 1
	}

	[Token(Token = "0x200005F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D4B0", Offset = "0x3D4B0")]
	private sealed class _003CLoadEndCR_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x20")]
		public DemoEndLoader _003C_003E4__this;

		[Token(Token = "0x17000042")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x179B724", Offset = "0x179B724", VA = "0x179B724", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000043")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x179B76C", Offset = "0x179B76C", VA = "0x179B76C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000191")]
		[Address(RVA = "0x179B5C4", Offset = "0x179B5C4", VA = "0x179B5C4")]
		[DebuggerHidden]
		public _003CLoadEndCR_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000192")]
		[Address(RVA = "0x179B5F0", Offset = "0x179B5F0", VA = "0x179B5F0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000193")]
		[Address(RVA = "0x179B5F4", Offset = "0x179B5F4", VA = "0x179B5F4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000194")]
		[Address(RVA = "0x179B724", Offset = "0x179B724", VA = "0x179B724", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000195")]
		[Address(RVA = "0x179B72C", Offset = "0x179B72C", VA = "0x179B72C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000196")]
		[Address(RVA = "0x179B76C", Offset = "0x179B76C", VA = "0x179B76C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4000182")]
	[FieldOffset(Offset = "0x0")]
	public static EDemoEnded lastDemoEndType;

	[Token(Token = "0x4000183")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private EDemoEnded _endType;

	[Token(Token = "0x4000184")]
	[FieldOffset(Offset = "0x1C")]
	private bool _loading;

	[Token(Token = "0x600018D")]
	[Address(RVA = "0x18DA4B0", Offset = "0x18DA4B0", VA = "0x18DA4B0")]
	public void LoadEnd()
	{
	}

	[Token(Token = "0x600018E")]
	[Address(RVA = "0x18DA580", Offset = "0x18DA580", VA = "0x18DA580")]
	private IEnumerator LoadEndCR()
	{
		return null;
	}

	[Token(Token = "0x600018F")]
	[Address(RVA = "0x18DA5F4", Offset = "0x18DA5F4", VA = "0x18DA5F4")]
	public void OnCollisionEnter2D(Collision2D collision)
	{
	}

	[Token(Token = "0x6000190")]
	[Address(RVA = "0x18DA5F8", Offset = "0x18DA5F8", VA = "0x18DA5F8")]
	public DemoEndLoader()
	{
	}
}
