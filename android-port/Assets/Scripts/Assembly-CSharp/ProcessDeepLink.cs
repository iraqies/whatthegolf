using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;

[Token(Token = "0x200006D")]
public class ProcessDeepLink : WTGSingleton<ProcessDeepLink>
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200006E")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D548", Offset = "0x3D548")]
	private struct _003CGoToEvent_003Ed__16 : IAsyncStateMachine
	{
		[Token(Token = "0x40001B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ProcessDeepLink _003C_003E4__this;

		[Token(Token = "0x40001BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x40001BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> _003C_003Eu__2;

		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x182B788", Offset = "0x182B788", VA = "0x182B788", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x182BB9C", Offset = "0x182BB9C", VA = "0x182BB9C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200006F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D558", Offset = "0x3D558")]
	private struct _003CShowCard_003Ed__17 : IAsyncStateMachine
	{
		[Token(Token = "0x40001BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ProcessDeepLink _003C_003E4__this;

		[Token(Token = "0x40001C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x182C6BC", Offset = "0x182C6BC", VA = "0x182C6BC", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x182C9E0", Offset = "0x182C9E0", VA = "0x182C9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000070")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D568", Offset = "0x3D568")]
	private sealed class _003C_003Ec__DisplayClass18_0
	{
		[Token(Token = "0x40001C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string id;

		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x182B520", Offset = "0x182B520", VA = "0x182B520")]
		public _003C_003Ec__DisplayClass18_0()
		{
		}

		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x182B528", Offset = "0x182B528", VA = "0x182B528")]
		internal bool _003CGetNotificationFromUrl_003Eb__0(WTGNotification n)
		{
			return default;
		}
	}

	[Token(Token = "0x2000071")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D578", Offset = "0x3D578")]
	private sealed class _003C_003Ec__DisplayClass18_1
	{
		[Token(Token = "0x40001C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string activityId;

		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x182B560", Offset = "0x182B560", VA = "0x182B560")]
		public _003C_003Ec__DisplayClass18_1()
		{
		}

		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x182B568", Offset = "0x182B568", VA = "0x182B568")]
		internal bool _003CGetNotificationFromUrl_003Eb__1(WTGNotification n)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000072")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D588", Offset = "0x3D588")]
	private struct _003CGoToHubFromAnywhereAsync_003Ed__20 : IAsyncStateMachine
	{
		[Token(Token = "0x40001C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x40001C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x40001C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ProcessDeepLink _003C_003E4__this;

		[Token(Token = "0x40001C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x182C4C8", Offset = "0x182C4C8", VA = "0x182C4C8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x182C6B0", Offset = "0x182C6B0", VA = "0x182C6B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000073")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D598", Offset = "0x3D598")]
	private sealed class _003CAbandonLevelIfAny_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x1700004D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60001E4")]
			[Address(RVA = "0x182B738", Offset = "0x182B738", VA = "0x182B738", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x1700004E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60001E6")]
			[Address(RVA = "0x182B780", Offset = "0x182B780", VA = "0x182B780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x182B5A0", Offset = "0x182B5A0", VA = "0x182B5A0")]
		[DebuggerHidden]
		public _003CAbandonLevelIfAny_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x182B5CC", Offset = "0x182B5CC", VA = "0x182B5CC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x182B5D0", Offset = "0x182B5D0", VA = "0x182B5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60001E4")]
		[Address(RVA = "0x182B738", Offset = "0x182B738", VA = "0x182B738", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60001E5")]
		[Address(RVA = "0x182B740", Offset = "0x182B740", VA = "0x182B740", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x182B780", Offset = "0x182B780", VA = "0x182B780", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Serializable]
	[Token(Token = "0x2000074")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D5A8", Offset = "0x3D5A8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40001CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40001CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> _003C_003E9__22_0;

		[Token(Token = "0x40001CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public static Func<bool> _003C_003E9__22_1;

		[Token(Token = "0x40001CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public static Func<bool> _003C_003E9__22_2;

		[Token(Token = "0x40001CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static Func<bool> _003C_003E9__22_3;

		[Token(Token = "0x40001CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public static Func<bool> _003C_003E9__22_4;

		[Token(Token = "0x40001D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public static Func<bool> _003C_003E9__22_5;

		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x182B324", Offset = "0x182B324", VA = "0x182B324")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x182B32C", Offset = "0x182B32C", VA = "0x182B32C")]
		internal bool _003CGoToHubFromAnywhere_003Eb__22_0()
		{
			return default;
		}

		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x182B3C8", Offset = "0x182B3C8", VA = "0x182B3C8")]
		internal bool _003CGoToHubFromAnywhere_003Eb__22_1()
		{
			return default;
		}

		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x182B424", Offset = "0x182B424", VA = "0x182B424")]
		internal bool _003CGoToHubFromAnywhere_003Eb__22_2()
		{
			return default;
		}

		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x182B42C", Offset = "0x182B42C", VA = "0x182B42C")]
		internal bool _003CGoToHubFromAnywhere_003Eb__22_3()
		{
			return default;
		}

		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x182B4A0", Offset = "0x182B4A0", VA = "0x182B4A0")]
		internal bool _003CGoToHubFromAnywhere_003Eb__22_4()
		{
			return default;
		}

		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x182B4C4", Offset = "0x182B4C4", VA = "0x182B4C4")]
		internal bool _003CGoToHubFromAnywhere_003Eb__22_5()
		{
			return default;
		}
	}

	[Token(Token = "0x2000075")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3D5B8", Offset = "0x3D5B8")]
	private sealed class _003CGoToHubFromAnywhere_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40001D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40001D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ProcessDeepLink _003C_003E4__this;

		[Token(Token = "0x1700004F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60001F2")]
			[Address(RVA = "0x182C478", Offset = "0x182C478", VA = "0x182C478", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x17000050")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60001F4")]
			[Address(RVA = "0x182C4C0", Offset = "0x182C4C0", VA = "0x182C4C0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x182BBA8", Offset = "0x182BBA8", VA = "0x182BBA8")]
		[DebuggerHidden]
		public _003CGoToHubFromAnywhere_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x182BBD4", Offset = "0x182BBD4", VA = "0x182BBD4", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x182BBD8", Offset = "0x182BBD8", VA = "0x182BBD8", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x182C478", Offset = "0x182C478", VA = "0x182C478", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x182C480", Offset = "0x182C480", VA = "0x182C480", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x182C4C0", Offset = "0x182C4C0", VA = "0x182C4C0", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x40001B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private WTGNotification? _notification;

	[Token(Token = "0x40001B7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Action OnDeepLinkActivatedEvent;

	[Token(Token = "0x40001B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public bool HadEventThisSession;

	[Token(Token = "0x17000049")]
	public List<WTGNotification> AllNotifications
	{
		[Token(Token = "0x60001C6")]
		[Address(RVA = "0x1622404", Offset = "0x1622404", VA = "0x1622404")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700004A")]
	private bool IsLoaded
	{
		[Token(Token = "0x60001C7")]
		[Address(RVA = "0x16224E4", Offset = "0x16224E4", VA = "0x16224E4")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700004B")]
	public bool HasEvent
	{
		[Token(Token = "0x60001C8")]
		[Address(RVA = "0x1622574", Offset = "0x1622574", VA = "0x1622574")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x1700004C")]
	public bool HasChallengeEvent
	{
		[Token(Token = "0x60001C9")]
		[Address(RVA = "0x1622640", Offset = "0x1622640", VA = "0x1622640")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x16226B8", Offset = "0x16226B8", VA = "0x16226B8", Slot = "4")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x1622758", Offset = "0x1622758", VA = "0x1622758")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x1622984", Offset = "0x1622984", VA = "0x1622984")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5D624", Offset = "0x5D624")]
	private void TestDeepLink_PlayTogetherChallenge()
	{
	}

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x16229DC", Offset = "0x16229DC", VA = "0x16229DC")]
	[AttributeAttribute(Name = "ContextMenu", RVA = "0x5D65C", Offset = "0x5D65C")]
	private void TestDeepLink_SpecialEvent()
	{
	}

	[Token(Token = "0x60001CE")]
	[Address(RVA = "0x16227A0", Offset = "0x16227A0", VA = "0x16227A0")]
	public void OnDeepLinkActivated(string url)
	{
	}

	[Token(Token = "0x60001CF")]
	[Address(RVA = "0x1622F2C", Offset = "0x1622F2C", VA = "0x1622F2C")]
	private void GoToEvent()
	{
	}

	[Token(Token = "0x60001D0")]
	[Address(RVA = "0x1622FC4", Offset = "0x1622FC4", VA = "0x1622FC4")]
	private void ShowCard()
	{
	}

	[Token(Token = "0x60001D1")]
	[Address(RVA = "0x1622A34", Offset = "0x1622A34", VA = "0x1622A34")]
	private WTGNotification? GetNotificationFromUrl(string url)
	{
		return null;
	}

	[Token(Token = "0x60001D2")]
	[Address(RVA = "0x162305C", Offset = "0x162305C", VA = "0x162305C")]
	private void DismissNotification()
	{
	}

	[Token(Token = "0x60001D3")]
	[Address(RVA = "0x1623080", Offset = "0x1623080", VA = "0x1623080")]
	public Task GoToHubFromAnywhereAsync(bool force = false)
	{
		return null;
	}

	[Token(Token = "0x60001D4")]
	[Address(RVA = "0x162315C", Offset = "0x162315C", VA = "0x162315C")]
	public IEnumerator AbandonLevelIfAny()
	{
		return null;
	}

	[Token(Token = "0x60001D5")]
	[Address(RVA = "0x16231B8", Offset = "0x16231B8", VA = "0x16231B8")]
	private IEnumerator GoToHubFromAnywhere()
	{
		return null;
	}

	[Token(Token = "0x60001D6")]
	[Address(RVA = "0x162322C", Offset = "0x162322C", VA = "0x162322C")]
	public ProcessDeepLink()
	{
	}
}
