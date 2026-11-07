using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

[Token(Token = "0x2000CB9")]
public static class WTGNotificationStorage
{
	[Serializable]
	[Token(Token = "0x2000CBA")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443A8", Offset = "0x443A8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004546")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004547")]
		[FieldOffset(Offset = "0x8")]
		public static Func<bool> _003C_003E9__5_0;

		[Token(Token = "0x4004548")]
		[FieldOffset(Offset = "0x10")]
		public static Func<bool> _003C_003E9__5_1;

		[Token(Token = "0x4004549")]
		[FieldOffset(Offset = "0x18")]
		public static Func<bool> _003C_003E9__6_0;

		[Token(Token = "0x6003C21")]
		[Address(RVA = "0x18750F0", Offset = "0x18750F0", VA = "0x18750F0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003C22")]
		[Address(RVA = "0x18750F8", Offset = "0x18750F8", VA = "0x18750F8")]
		internal bool _003CMarkAsSeen_003Eb__5_0()
		{
			return default;
		}

		[Token(Token = "0x6003C23")]
		[Address(RVA = "0x1875194", Offset = "0x1875194", VA = "0x1875194")]
		internal bool _003CMarkAsSeen_003Eb__5_1()
		{
			return default;
		}

		[Token(Token = "0x6003C24")]
		[Address(RVA = "0x18751E0", Offset = "0x18751E0", VA = "0x18751E0")]
		internal bool _003CUnmarkAsSeen_003Eb__6_0()
		{
			return default;
		}
	}

	[Token(Token = "0x2000CBB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443B8", Offset = "0x443B8")]
	private sealed class _003CMarkAsSeen_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400454A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400454B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400454C")]
		[FieldOffset(Offset = "0x20")]
		public WTGNotification notification;

		[Token(Token = "0x400454D")]
		[FieldOffset(Offset = "0x88")]
		public bool opened;

		[Token(Token = "0x17000620")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003C28")]
			[Address(RVA = "0x1875638", Offset = "0x1875638", VA = "0x1875638", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000621")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C2A")]
			[Address(RVA = "0x1875680", Offset = "0x1875680", VA = "0x1875680", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003C25")]
		[Address(RVA = "0x187527C", Offset = "0x187527C", VA = "0x187527C")]
		[DebuggerHidden]
		public _003CMarkAsSeen_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003C26")]
		[Address(RVA = "0x18752A8", Offset = "0x18752A8", VA = "0x18752A8", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003C27")]
		[Address(RVA = "0x18752AC", Offset = "0x18752AC", VA = "0x18752AC", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003C28")]
		[Address(RVA = "0x1875638", Offset = "0x1875638", VA = "0x1875638", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C29")]
		[Address(RVA = "0x1875640", Offset = "0x1875640", VA = "0x1875640", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003C2A")]
		[Address(RVA = "0x1875680", Offset = "0x1875680", VA = "0x1875680", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x2000CBC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x443C8", Offset = "0x443C8")]
	private sealed class _003CUnmarkAsSeen_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400454E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400454F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4004550")]
		[FieldOffset(Offset = "0x20")]
		public string notificationId;

		[Token(Token = "0x17000622")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003C2E")]
			[Address(RVA = "0x1875910", Offset = "0x1875910", VA = "0x1875910", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000623")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003C30")]
			[Address(RVA = "0x1875958", Offset = "0x1875958", VA = "0x1875958", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6003C2B")]
		[Address(RVA = "0x1875688", Offset = "0x1875688", VA = "0x1875688")]
		[DebuggerHidden]
		public _003CUnmarkAsSeen_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003C2C")]
		[Address(RVA = "0x18756B4", Offset = "0x18756B4", VA = "0x18756B4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003C2D")]
		[Address(RVA = "0x18756B8", Offset = "0x18756B8", VA = "0x18756B8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6003C2E")]
		[Address(RVA = "0x1875910", Offset = "0x1875910", VA = "0x1875910", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6003C2F")]
		[Address(RVA = "0x1875918", Offset = "0x1875918", VA = "0x1875918", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6003C30")]
		[Address(RVA = "0x1875958", Offset = "0x1875958", VA = "0x1875958", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x6003C1C")]
	[Address(RVA = "0x174CD70", Offset = "0x174CD70", VA = "0x174CD70")]
	public static void ClearAllNotifications()
	{
	}

	[Token(Token = "0x6003C1D")]
	[Address(RVA = "0x174CF00", Offset = "0x174CF00", VA = "0x174CF00")]
	public static void SaveToPlayerPrefs(ScheduledNotification notification)
	{
	}

	[Token(Token = "0x6003C1E")]
	[Address(RVA = "0x174CFC4", Offset = "0x174CFC4", VA = "0x174CFC4")]
	public static IEnumerator MarkAsSeen(WTGNotification notification, bool opened = false)
	{
		return null;
	}

	[Token(Token = "0x6003C1F")]
	[Address(RVA = "0x174D05C", Offset = "0x174D05C", VA = "0x174D05C")]
	public static IEnumerator UnmarkAsSeen(string notificationId)
	{
		return null;
	}
}
