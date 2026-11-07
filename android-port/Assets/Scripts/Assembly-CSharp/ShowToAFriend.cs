using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;

[Token(Token = "0x2000527")]
public class ShowToAFriend : BasePackStarter
{
	[Token(Token = "0x2000528")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40294", Offset = "0x40294")]
	private sealed class _003CStartPackCR_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShowToAFriend _003C_003E4__this;

		[Token(Token = "0x4001A90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ContentPack pack;

		[Token(Token = "0x1700029C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001795")]
			[Address(RVA = "0x184D5E0", Offset = "0x184D5E0", VA = "0x184D5E0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700029D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001797")]
			[Address(RVA = "0x184D628", Offset = "0x184D628", VA = "0x184D628", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6001792")]
		[Address(RVA = "0x184D49C", Offset = "0x184D49C", VA = "0x184D49C")]
		[DebuggerHidden]
		public _003CStartPackCR_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001793")]
		[Address(RVA = "0x184D4C8", Offset = "0x184D4C8", VA = "0x184D4C8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001794")]
		[Address(RVA = "0x184D4CC", Offset = "0x184D4CC", VA = "0x184D4CC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6001795")]
		[Address(RVA = "0x184D5E0", Offset = "0x184D5E0", VA = "0x184D5E0", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6001796")]
		[Address(RVA = "0x184D5E8", Offset = "0x184D5E8", VA = "0x184D5E8", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6001797")]
		[Address(RVA = "0x184D628", Offset = "0x184D628", VA = "0x184D628", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000529")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x402A4", Offset = "0x402A4")]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4001A91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<LevelDataAndChallenge> levelsToPlay;

		[Token(Token = "0x4001A92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool aborted;

		[Token(Token = "0x4001A93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShowToAFriend _003C_003E4__this;

		[Token(Token = "0x4001A94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action _003C_003E9__1;

		[Token(Token = "0x6001798")]
		[Address(RVA = "0x184C760", Offset = "0x184C760", VA = "0x184C760")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6001799")]
		[Address(RVA = "0x184C768", Offset = "0x184C768", VA = "0x184C768")]
		internal void _003CPlayShowToAFriendLevels_003Eb__1()
		{
		}
	}

	[Token(Token = "0x200052A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x402B4", Offset = "0x402B4")]
	private sealed class _003C_003Ec__DisplayClass5_1
	{
		[Token(Token = "0x4001A95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int i;

		[Token(Token = "0x4001A96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x600179A")]
		[Address(RVA = "0x184C774", Offset = "0x184C774", VA = "0x184C774")]
		public _003C_003Ec__DisplayClass5_1()
		{
		}

		[Token(Token = "0x600179B")]
		[Address(RVA = "0x184C77C", Offset = "0x184C77C", VA = "0x184C77C")]
		internal void _003CPlayShowToAFriendLevels_003Eb__0(Level.CompletedState s)
		{
		}

		[Token(Token = "0x600179C")]
		[Address(RVA = "0x184C804", Offset = "0x184C804", VA = "0x184C804")]
		internal void _003CPlayShowToAFriendLevels_003Eb__2(bool isCompleted)
		{
		}
	}

	[Token(Token = "0x200052B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x402C4", Offset = "0x402C4")]
	private sealed class _003CPlayShowToAFriendLevels_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001A97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001A98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001A99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShowToAFriend _003C_003E4__this;

		[Token(Token = "0x4001A9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool allowMenuButtons;

		[Token(Token = "0x4001A9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x4001A9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass5_1 _003C_003E8__2;

		[Token(Token = "0x4001A9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private LevelManager _003ClevelManager_003E5__2;

		[Token(Token = "0x1700029E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60017A0")]
			[Address(RVA = "0x184D44C", Offset = "0x184D44C", VA = "0x184D44C", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700029F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60017A2")]
			[Address(RVA = "0x184D494", Offset = "0x184D494", VA = "0x184D494", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x600179D")]
		[Address(RVA = "0x184CE94", Offset = "0x184CE94", VA = "0x184CE94")]
		[DebuggerHidden]
		public _003CPlayShowToAFriendLevels_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600179E")]
		[Address(RVA = "0x184CEC0", Offset = "0x184CEC0", VA = "0x184CEC0", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600179F")]
		[Address(RVA = "0x184CEC4", Offset = "0x184CEC4", VA = "0x184CEC4", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60017A0")]
		[Address(RVA = "0x184D44C", Offset = "0x184D44C", VA = "0x184D44C", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60017A1")]
		[Address(RVA = "0x184D454", Offset = "0x184D454", VA = "0x184D454", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60017A2")]
		[Address(RVA = "0x184D494", Offset = "0x184D494", VA = "0x184D494", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200052C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x402D4", Offset = "0x402D4")]
	private struct _003CGoToHub_003Ed__6 : IAsyncStateMachine
	{
		[Token(Token = "0x4001A9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001A9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001AA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private object _003C_003Eu__1;

		[Token(Token = "0x4001AA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x60017A3")]
		[Address(RVA = "0x184CAA0", Offset = "0x184CAA0", VA = "0x184CAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60017A4")]
		[Address(RVA = "0x184CE88", Offset = "0x184CE88", VA = "0x184CE88", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001A8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private ContentPack _pack;

	[Token(Token = "0x4001A8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<LevelDataAndChallenge> _levels;

	[Token(Token = "0x600178C")]
	[Address(RVA = "0x16A85DC", Offset = "0x16A85DC", VA = "0x16A85DC", Slot = "4")]
	public override bool StartPack(ContentPack pack, params object[] additionalContext)
	{
		return default;
	}

	[Token(Token = "0x600178D")]
	[Address(RVA = "0x16A8668", Offset = "0x16A8668", VA = "0x16A8668")]
	private IEnumerator StartPackCR(ContentPack pack)
	{
		return null;
	}

	[Token(Token = "0x600178E")]
	[Address(RVA = "0x16A86E0", Offset = "0x16A86E0", VA = "0x16A86E0")]
	public void StartShowToAFriend(bool allowMenuButtons)
	{
	}

	[Token(Token = "0x600178F")]
	[Address(RVA = "0x16A8764", Offset = "0x16A8764", VA = "0x16A8764")]
	private IEnumerator PlayShowToAFriendLevels(bool allowMenuButtons)
	{
		return null;
	}

	[Token(Token = "0x6001790")]
	[Address(RVA = "0x16A87E0", Offset = "0x16A87E0", VA = "0x16A87E0")]
	private void GoToHub()
	{
	}

	[Token(Token = "0x6001791")]
	[Address(RVA = "0x16A886C", Offset = "0x16A886C", VA = "0x16A886C")]
	public ShowToAFriend()
	{
	}
}
