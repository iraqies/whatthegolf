using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Audio;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000DE8")]
public class TunnelWithToungueExit : MonoBehaviour
{
	[Token(Token = "0x2000DE9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44DD8", Offset = "0x44DD8")]
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		[Token(Token = "0x4004BCD")]
		[FieldOffset(Offset = "0x10")]
		public Rigidbody2D rb;

		[Token(Token = "0x4004BCE")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 start;

		[Token(Token = "0x4004BCF")]
		[FieldOffset(Offset = "0x28")]
		public TunnelWithToungueExit _003C_003E4__this;

		[Token(Token = "0x6004184")]
		[Address(RVA = "0x186F798", Offset = "0x186F798", VA = "0x186F798")]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[Token(Token = "0x6004185")]
		[Address(RVA = "0x186F7A0", Offset = "0x186F7A0", VA = "0x186F7A0")]
		internal void _003CExit_003Eb__0(float t)
		{
		}
	}

	[Token(Token = "0x2000DEA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44DE8", Offset = "0x44DE8")]
	private sealed class _003CExit_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4004BD0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4004BD1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004BD2")]
		[FieldOffset(Offset = "0x20")]
		public TunnelWithToungueExit _003C_003E4__this;

		[Token(Token = "0x4004BD3")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass15_0 _003C_003E8__1;

		[Token(Token = "0x170006C0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6004189")]
			[Address(RVA = "0x186FBF0", Offset = "0x186FBF0", VA = "0x186FBF0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170006C1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600418B")]
			[Address(RVA = "0x186FC38", Offset = "0x186FC38", VA = "0x186FC38", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6004186")]
		[Address(RVA = "0x186F860", Offset = "0x186F860", VA = "0x186F860")]
		[DebuggerHidden]
		public _003CExit_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004187")]
		[Address(RVA = "0x186F88C", Offset = "0x186F88C", VA = "0x186F88C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004188")]
		[Address(RVA = "0x186F890", Offset = "0x186F890", VA = "0x186F890", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6004189")]
		[Address(RVA = "0x186FBF0", Offset = "0x186FBF0", VA = "0x186FBF0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600418A")]
		[Address(RVA = "0x186FBF8", Offset = "0x186FBF8", VA = "0x186FBF8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600418B")]
		[Address(RVA = "0x186FC38", Offset = "0x186FC38", VA = "0x186FC38", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x4004BC2")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ShortcutTunnel _tunnel;

	[Token(Token = "0x4004BC3")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x52840", Offset = "0x52840")]
	private ShortcutTunnelEntry _otherEntryEnd;

	[Token(Token = "0x4004BC4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x5288C", Offset = "0x5288C")]
	private ShortcutTunnelEntry _entryEndWithTounge;

	[Token(Token = "0x4004BC5")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ClipSettingsCollection _exitAudio;

	[Token(Token = "0x4004BC6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Animator _animator;

	[Token(Token = "0x4004BC7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private AnimationCurve _curve;

	[Token(Token = "0x4004BC8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private float _duration;

	[Token(Token = "0x4004BC9")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Transform _end;

	[Token(Token = "0x4004BCA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int Spit;

	[Token(Token = "0x4004BCB")]
	[FieldOffset(Offset = "0x58")]
	private bool no;

	[Token(Token = "0x4004BCC")]
	[FieldOffset(Offset = "0x59")]
	private bool isExiting;

	[Token(Token = "0x600417B")]
	[Address(RVA = "0x17306F0", Offset = "0x17306F0", VA = "0x17306F0")]
	private void Start()
	{
	}

	[Token(Token = "0x600417C")]
	[Address(RVA = "0x17308C8", Offset = "0x17308C8", VA = "0x17308C8")]
	private void EntryEndWithToungeOnOnEntered(ShortcutTunnelEntry arg1, ShortcutTunnelTraversable arg2)
	{
	}

	[Token(Token = "0x600417D")]
	[Address(RVA = "0x17308D0", Offset = "0x17308D0", VA = "0x17308D0")]
	private void OtherEntryOnOnEntered(ShortcutTunnelEntry arg1, ShortcutTunnelTraversable arg2)
	{
	}

	[Token(Token = "0x600417E")]
	[Address(RVA = "0x17308DC", Offset = "0x17308DC", VA = "0x17308DC")]
	private void TunnelOnOnMovementUpdate(float obj)
	{
	}

	[Token(Token = "0x600417F")]
	[Address(RVA = "0x1730A78", Offset = "0x1730A78", VA = "0x1730A78")]
	private void TunnelOnOnBallExitTunnel(ShortcutTunnel obj)
	{
	}

	[Token(Token = "0x6004180")]
	[Address(RVA = "0x1730A04", Offset = "0x1730A04", VA = "0x1730A04")]
	private IEnumerator Exit()
	{
		return null;
	}

	[Token(Token = "0x6004181")]
	[Address(RVA = "0x1730A7C", Offset = "0x1730A7C", VA = "0x1730A7C")]
	private void PlayAudio()
	{
	}

	[Token(Token = "0x6004182")]
	[Address(RVA = "0x1730AC4", Offset = "0x1730AC4", VA = "0x1730AC4")]
	public TunnelWithToungueExit()
	{
	}
}
