using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000A44")]
[AttributeAttribute(Name = "DefaultExecutionOrder", RVA = "0x42BC4", Offset = "0x42BC4")]
public class ShortcutTunnelEntry : MonoBehaviour
{
	[Token(Token = "0x2000A45")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42BD8", Offset = "0x42BD8")]
	private sealed class _003CStart_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40038D5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40038D6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40038D7")]
		[FieldOffset(Offset = "0x20")]
		public ShortcutTunnelEntry _003C_003E4__this;

		[Token(Token = "0x1700050E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60030FD")]
			[Address(RVA = "0x184AAE4", Offset = "0x184AAE4", VA = "0x184AAE4", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700050F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60030FF")]
			[Address(RVA = "0x184AB2C", Offset = "0x184AB2C", VA = "0x184AB2C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60030FA")]
		[Address(RVA = "0x184A918", Offset = "0x184A918", VA = "0x184A918")]
		[DebuggerHidden]
		public _003CStart_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60030FB")]
		[Address(RVA = "0x184A944", Offset = "0x184A944", VA = "0x184A944", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60030FC")]
		[Address(RVA = "0x184A948", Offset = "0x184A948", VA = "0x184A948", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60030FD")]
		[Address(RVA = "0x184AAE4", Offset = "0x184AAE4", VA = "0x184AAE4", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60030FE")]
		[Address(RVA = "0x184AAEC", Offset = "0x184AAEC", VA = "0x184AAEC", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60030FF")]
		[Address(RVA = "0x184AB2C", Offset = "0x184AB2C", VA = "0x184AB2C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000A46")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x42BE8", Offset = "0x42BE8")]
	private sealed class _003CPushAway_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40038D8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40038D9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40038DA")]
		[FieldOffset(Offset = "0x20")]
		public ShortcutTunnelTraversable thing;

		[Token(Token = "0x40038DB")]
		[FieldOffset(Offset = "0x28")]
		public ShortcutTunnelEntry _003C_003E4__this;

		[Token(Token = "0x40038DC")]
		[FieldOffset(Offset = "0x30")]
		private Rigidbody2D _003Crigid_003E5__2;

		[Token(Token = "0x40038DD")]
		[FieldOffset(Offset = "0x38")]
		private float _003Ctime_003E5__3;

		[Token(Token = "0x17000510")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003103")]
			[Address(RVA = "0x184A8C8", Offset = "0x184A8C8", VA = "0x184A8C8", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000511")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003105")]
			[Address(RVA = "0x184A910", Offset = "0x184A910", VA = "0x184A910", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003100")]
		[Address(RVA = "0x184A73C", Offset = "0x184A73C", VA = "0x184A73C")]
		[DebuggerHidden]
		public _003CPushAway_003Ed__17(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003101")]
		[Address(RVA = "0x184A768", Offset = "0x184A768", VA = "0x184A768", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003102")]
		[Address(RVA = "0x184A76C", Offset = "0x184A76C", VA = "0x184A76C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003103")]
		[Address(RVA = "0x184A8C8", Offset = "0x184A8C8", VA = "0x184A8C8", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003104")]
		[Address(RVA = "0x184A8D0", Offset = "0x184A8D0", VA = "0x184A8D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003105")]
		[Address(RVA = "0x184A910", Offset = "0x184A910", VA = "0x184A910", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40038C8")]
	[FieldOffset(Offset = "0x18")]
	public bool isBlocked;

	[Token(Token = "0x40038C9")]
	[FieldOffset(Offset = "0x19")]
	public bool isOnlyForExit;

	[Token(Token = "0x40038CA")]
	[FieldOffset(Offset = "0x1A")]
	public bool isOneWayAndItsNotThisOne;

	[Token(Token = "0x40038CB")]
	[FieldOffset(Offset = "0x1C")]
	public float pushAwayForce;

	[Token(Token = "0x40038CC")]
	[FieldOffset(Offset = "0x20")]
	public float pushAwayTime;

	[NonSerialized]
	[Token(Token = "0x40038CD")]
	[FieldOffset(Offset = "0x24")]
	public bool canBeUsed;

	[Token(Token = "0x40038CE")]
	[FieldOffset(Offset = "0x25")]
	public bool isPathReverse;

	[Token(Token = "0x40038CF")]
	[FieldOffset(Offset = "0x28")]
	public Transform block;

	[Token(Token = "0x40038D0")]
	[FieldOffset(Offset = "0x30")]
	public ClipSettingsCollection EnterSFX;

	[Token(Token = "0x40038D1")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x50404", Offset = "0x50404")]
	private Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> m_OnEntered;

	[Token(Token = "0x40038D2")]
	[FieldOffset(Offset = "0x40")]
	private readonly string saveFormat;

	[Token(Token = "0x40038D3")]
	[FieldOffset(Offset = "0x48")]
	private GridFiller filler;

	[Token(Token = "0x40038D4")]
	[FieldOffset(Offset = "0x50")]
	private float nextEnterTime;

	[Token(Token = "0x14000067")]
	public event Action<ShortcutTunnelEntry, ShortcutTunnelTraversable> OnEntered
	{
		[Token(Token = "0x60030F3")]
		[Address(RVA = "0x16A5060", Offset = "0x16A5060", VA = "0x16A5060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x696D4", Offset = "0x696D4")]
		add
		{
		}
		[Token(Token = "0x60030F4")]
		[Address(RVA = "0x16A576C", Offset = "0x16A576C", VA = "0x16A576C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x696E4", Offset = "0x696E4")]
		remove
		{
		}
	}

	[Token(Token = "0x60030F5")]
	[Address(RVA = "0x16A5810", Offset = "0x16A5810", VA = "0x16A5810")]
	public IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x60030F6")]
	[Address(RVA = "0x16A55F8", Offset = "0x16A55F8", VA = "0x16A55F8")]
	public void UnblockAndSave()
	{
	}

	[Token(Token = "0x60030F7")]
	[Address(RVA = "0x16A5884", Offset = "0x16A5884", VA = "0x16A5884")]
	private IEnumerator PushAway(ShortcutTunnelTraversable thing)
	{
		return null;
	}

	[Token(Token = "0x60030F8")]
	[Address(RVA = "0x16A58FC", Offset = "0x16A58FC", VA = "0x16A58FC")]
	public void EnterTunnel(ShortcutTunnelTraversable thing)
	{
	}

	[Token(Token = "0x60030F9")]
	[Address(RVA = "0x16A5A74", Offset = "0x16A5A74", VA = "0x16A5A74")]
	public ShortcutTunnelEntry()
	{
	}
}
