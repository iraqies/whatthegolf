using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000507")]
public class MultiplayerStarter : BasePackStarter
{
	[Token(Token = "0x2000508")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x400CC", Offset = "0x400CC")]
	private sealed class _003CPlayPartyModeCR_003Ed__1 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A09")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A0A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A0B")]
		[FieldOffset(Offset = "0x20")]
		public MultiplayerStarter _003C_003E4__this;

		[Token(Token = "0x17000287")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001707")]
			[Address(RVA = "0x1803FD0", Offset = "0x1803FD0", VA = "0x1803FD0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000288")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001709")]
			[Address(RVA = "0x1804018", Offset = "0x1804018", VA = "0x1804018", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001704")]
		[Address(RVA = "0x1803E18", Offset = "0x1803E18", VA = "0x1803E18")]
		[DebuggerHidden]
		public _003CPlayPartyModeCR_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001705")]
		[Address(RVA = "0x1803E44", Offset = "0x1803E44", VA = "0x1803E44", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001706")]
		[Address(RVA = "0x1803E48", Offset = "0x1803E48", VA = "0x1803E48", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001707")]
		[Address(RVA = "0x1803FD0", Offset = "0x1803FD0", VA = "0x1803FD0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001708")]
		[Address(RVA = "0x1803FD8", Offset = "0x1803FD8", VA = "0x1803FD8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001709")]
		[Address(RVA = "0x1804018", Offset = "0x1804018", VA = "0x1804018", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x6001701")]
	[Address(RVA = "0x15848D8", Offset = "0x15848D8", VA = "0x15848D8", Slot = "4")]
	public override bool StartPack(ContentPack container, params object[] additionalContext)
	{
		return default;
	}

	[Token(Token = "0x6001702")]
	[Address(RVA = "0x158498C", Offset = "0x158498C", VA = "0x158498C")]
	private IEnumerator PlayPartyModeCR()
	{
		return null;
	}

	[Token(Token = "0x6001703")]
	[Address(RVA = "0x1584A00", Offset = "0x1584A00", VA = "0x1584A00")]
	public MultiplayerStarter()
	{
	}
}
