using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

[Token(Token = "0x200018F")]
public class GameboyPopup : PopupController
{
	[Token(Token = "0x2000190")]
	public enum Type
	{
		[Token(Token = "0x400071C")]
		DeepLink = 0,
		[Token(Token = "0x400071D")]
		PushNotif = 1,
		[Token(Token = "0x400071E")]
		Hub = 2,
		[Token(Token = "0x400071F")]
		WhatsNew = 3
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000191")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE60", Offset = "0x3DE60")]
	private struct _003CLoad_003Ed__21 : IAsyncStateMachine
	{
		[Token(Token = "0x4000720")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000721")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000722")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private TaskAwaiter<GameObject> _003C_003Eu__1;

		[Token(Token = "0x60006FC")]
		[Address(RVA = "0x17AEF58", Offset = "0x17AEF58", VA = "0x17AEF58", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60006FD")]
		[Address(RVA = "0x17AF1AC", Offset = "0x17AF1AC", VA = "0x17AF1AC", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000192")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE70", Offset = "0x3DE70")]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[Token(Token = "0x4000723")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string updatePromptNotif;

		[Token(Token = "0x60006FE")]
		[Address(RVA = "0x17AEB4C", Offset = "0x17AEB4C", VA = "0x17AEB4C")]
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		[Token(Token = "0x60006FF")]
		[Address(RVA = "0x17AEB54", Offset = "0x17AEB54", VA = "0x17AEB54")]
		internal bool _003CStart_003Eb__0(WTGNotification n)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000193")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE80", Offset = "0x3DE80")]
	private struct _003CStart_003Ed__26 : IAsyncStateMachine
	{
		[Token(Token = "0x4000724")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000725")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000726")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameboyPopup _003C_003E4__this;

		[Token(Token = "0x4000727")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		[Token(Token = "0x4000728")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x4000729")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private object _003C_003Eu__2;

		[Token(Token = "0x6000700")]
		[Address(RVA = "0x17B0490", Offset = "0x17B0490", VA = "0x17B0490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000701")]
		[Address(RVA = "0x17B0C20", Offset = "0x17B0C20", VA = "0x17B0C20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000194")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DE90", Offset = "0x3DE90")]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x400072A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public GameboyPopup _003C_003E4__this;

		[Token(Token = "0x400072B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public DailyChallengeLevelDataContainer challengePack;

		[Token(Token = "0x400072C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WTGNotification notification;

		[Token(Token = "0x6000702")]
		[Address(RVA = "0x17AEB68", Offset = "0x17AEB68", VA = "0x17AEB68")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x6000703")]
		[Address(RVA = "0x17AEB70", Offset = "0x17AEB70", VA = "0x17AEB70")]
		internal void _003CShowWithResult_003Eb__0()
		{
		}

		[Token(Token = "0x6000704")]
		[Address(RVA = "0x17AEBD0", Offset = "0x17AEBD0", VA = "0x17AEBD0")]
		internal void _003CShowWithResult_003Eb__1()
		{
		}

		[Token(Token = "0x6000705")]
		[Address(RVA = "0x17AEC30", Offset = "0x17AEC30", VA = "0x17AEC30")]
		internal bool _003CShowWithResult_003Eg__IsEventActive_007C2()
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000195")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DEA0", Offset = "0x3DEA0")]
	private struct _003CShowWithResult_003Ed__29 : IAsyncStateMachine
	{
		[Token(Token = "0x400072D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400072E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x400072F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameboyPopup _003C_003E4__this;

		[Token(Token = "0x4000730")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WTGNotification notification;

		[Token(Token = "0x4000731")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool startLevelsOnPlayClicked;

		[Token(Token = "0x4000732")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public Action onPopupDismissed;

		[Token(Token = "0x4000733")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		[Token(Token = "0x4000734")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public bool showImpossibleLeaderboard;

		[Token(Token = "0x4000735")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
		public Type type;

		[Token(Token = "0x4000736")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x4000737")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private object _003C_003Eu__2;

		[Token(Token = "0x4000738")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private TaskAwaiter<bool> _003C_003Eu__3;

		[Token(Token = "0x6000706")]
		[Address(RVA = "0x17AF9A4", Offset = "0x17AF9A4", VA = "0x17AF9A4", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6000707")]
		[Address(RVA = "0x17B0434", Offset = "0x17B0434", VA = "0x17B0434", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000196")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DEB0", Offset = "0x3DEB0")]
	private struct _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x4000739")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public WTGNotification notification;
	}

	[Token(Token = "0x2000197")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DEC0", Offset = "0x3DEC0")]
	private sealed class _003CShow_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400073A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400073B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400073C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameboyPopup _003C_003E4__this;

		[Token(Token = "0x400073D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ContentPackDef packContainer;

		[Token(Token = "0x400073E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public IPackWithData pack;

		[Token(Token = "0x400073F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public bool isLevelNotification;

		[Token(Token = "0x4000740")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public LocalizationData locData;

		[Token(Token = "0x170000F2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600070B")]
			[Address(RVA = "0x17AF720", Offset = "0x17AF720", VA = "0x17AF720", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000F3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600070D")]
			[Address(RVA = "0x17AF768", Offset = "0x17AF768", VA = "0x17AF768", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000708")]
		[Address(RVA = "0x17AF5C0", Offset = "0x17AF5C0", VA = "0x17AF5C0")]
		[DebuggerHidden]
		public _003CShow_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000709")]
		[Address(RVA = "0x17AF5EC", Offset = "0x17AF5EC", VA = "0x17AF5EC", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600070A")]
		[Address(RVA = "0x17AF5F0", Offset = "0x17AF5F0", VA = "0x17AF5F0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x600070B")]
		[Address(RVA = "0x17AF720", Offset = "0x17AF720", VA = "0x17AF720", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600070C")]
		[Address(RVA = "0x17AF728", Offset = "0x17AF728", VA = "0x17AF728", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600070D")]
		[Address(RVA = "0x17AF768", Offset = "0x17AF768", VA = "0x17AF768", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000198")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DED0", Offset = "0x3DED0")]
	private struct _003COnLeaderboardClicked_003Ed__34 : IAsyncStateMachine
	{
		[Token(Token = "0x4000741")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4000742")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4000743")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public GameboyPopup _003C_003E4__this;

		[Token(Token = "0x4000744")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x4000745")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private object _003C_003Eu__2;

		[Token(Token = "0x600070E")]
		[Address(RVA = "0x17AF1B8", Offset = "0x17AF1B8", VA = "0x17AF1B8", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600070F")]
		[Address(RVA = "0x17AF5B4", Offset = "0x17AF5B4", VA = "0x17AF5B4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000199")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DEE0", Offset = "0x3DEE0")]
	private sealed class _003CHideLeaderboard_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000746")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000747")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000748")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameboyPopup _003C_003E4__this;

		[Token(Token = "0x170000F4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000713")]
			[Address(RVA = "0x17AEF08", Offset = "0x17AEF08", VA = "0x17AEF08", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000F5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000715")]
			[Address(RVA = "0x17AEF50", Offset = "0x17AEF50", VA = "0x17AEF50", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000710")]
		[Address(RVA = "0x17AED5C", Offset = "0x17AED5C", VA = "0x17AED5C")]
		[DebuggerHidden]
		public _003CHideLeaderboard_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000711")]
		[Address(RVA = "0x17AED88", Offset = "0x17AED88", VA = "0x17AED88", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000712")]
		[Address(RVA = "0x17AED8C", Offset = "0x17AED8C", VA = "0x17AED8C", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000713")]
		[Address(RVA = "0x17AEF08", Offset = "0x17AEF08", VA = "0x17AEF08", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x6000714")]
		[Address(RVA = "0x17AEF10", Offset = "0x17AEF10", VA = "0x17AEF10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000715")]
		[Address(RVA = "0x17AEF50", Offset = "0x17AEF50", VA = "0x17AEF50", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[Token(Token = "0x200019A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DEF0", Offset = "0x3DEF0")]
	private sealed class _003CShowLeaderboard_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000749")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400074A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400074B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GameboyPopup _003C_003E4__this;

		[Token(Token = "0x170000F6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000719")]
			[Address(RVA = "0x17AF954", Offset = "0x17AF954", VA = "0x17AF954", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
			}
		}

		[Token(Token = "0x170000F7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600071B")]
			[Address(RVA = "0x17AF99C", Offset = "0x17AF99C", VA = "0x17AF99C", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return System_002ECollections_002EIEnumerator_002Eget_Current();
			}
		}

		[Token(Token = "0x6000716")]
		[Address(RVA = "0x17AF770", Offset = "0x17AF770", VA = "0x17AF770")]
		[DebuggerHidden]
		public _003CShowLeaderboard_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000717")]
		[Address(RVA = "0x17AF79C", Offset = "0x17AF79C", VA = "0x17AF79C", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000718")]
		[Address(RVA = "0x17AF7A0", Offset = "0x17AF7A0", VA = "0x17AF7A0", Slot = "6")]
		private bool MoveNext()
		{
			return default;
		}

		[Token(Token = "0x6000719")]
		[Address(RVA = "0x17AF954", Offset = "0x17AF954", VA = "0x17AF954", Slot = "4")]
		[DebuggerHidden]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
		{
			return null;
		}

		[Token(Token = "0x600071A")]
		[Address(RVA = "0x17AF95C", Offset = "0x17AF95C", VA = "0x17AF95C", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x600071B")]
		[Address(RVA = "0x17AF99C", Offset = "0x17AF99C", VA = "0x17AF99C", Slot = "7")]
		[DebuggerHidden]
		private object System_002ECollections_002EIEnumerator_002Eget_Current()
		{
			return null;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200019B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3DF00", Offset = "0x3DF00")]
	private struct _003CStartPack_003Ed__42 : IAsyncStateMachine
	{
		[Token(Token = "0x400074C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400074D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400074E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public IPackWithData pack;

		[Token(Token = "0x600071C")]
		[Address(RVA = "0x17B0C2C", Offset = "0x17B0C2C", VA = "0x17B0C2C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600071D")]
		[Address(RVA = "0x17B0DA0", Offset = "0x17B0DA0", VA = "0x17B0DA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4000707")]
	private const NotificationSystemType localizationType = NotificationSystemType.Gameboy;

	[Token(Token = "0x4000708")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Action _onClosedClicked;

	[Token(Token = "0x4000709")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Action _onPlayClicked;

	[Token(Token = "0x400070A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameboyPopup instance;

	[Token(Token = "0x400070B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	[SerializeField]
	private GameObject InactiveParent;

	[Token(Token = "0x400070C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	[SerializeField]
	private TextMeshProUGUI DaysLeftText;

	[Token(Token = "0x400070D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	[SerializeField]
	private SVGImage DioramaImage;

	[Token(Token = "0x400070E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	[SerializeField]
	private SVGImage DioramaImageLevelNotifications;

	[Token(Token = "0x400070F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	[SerializeField]
	private HighscoreList HighscoreList;

	[Token(Token = "0x4000710")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	[SerializeField]
	private Animator CloseButtonAnimator;

	[Token(Token = "0x4000711")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	[SerializeField]
	private RectTransform ContainerTransform;

	[Token(Token = "0x4000712")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	[SerializeField]
	private GameObject LeaderboardButton;

	[Token(Token = "0x4000713")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	[SerializeField]
	private TextMeshProLocalized DescriptionText;

	[Token(Token = "0x4000714")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	[SerializeField]
	private TextMeshProLocalized TitleText;

	[Token(Token = "0x4000715")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	[SerializeField]
	[AttributeAttribute(Name = "FormerlySerializedAsAttribute", RVA = "0x49F60", Offset = "0x49F60")]
	private GameObject ImpossibleChallengeLeaderboard;

	[Token(Token = "0x4000716")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private bool startLevelsOnPlayClicked;

	[Token(Token = "0x4000717")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static string gameNotificationsPlayerPrefsId;

	[Token(Token = "0x4000718")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA4")]
	private Type _type;

	[Token(Token = "0x4000719")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private TaskCompletionSource<bool> tcs;

	[Token(Token = "0x400071A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private bool _isShowingLeaderboard;

	[Token(Token = "0x170000F0")]
	public static string SeenNotifications
	{
		[Token(Token = "0x60006E2")]
		[Address(RVA = "0x147F844", Offset = "0x147F844", VA = "0x147F844")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000F1")]
	public static GameboyPopup Instance
	{
		[Token(Token = "0x60006E4")]
		[Address(RVA = "0x147F978", Offset = "0x147F978", VA = "0x147F978")]
		get
		{
			return null;
		}
		[Token(Token = "0x60006E5")]
		[Address(RVA = "0x147FBAC", Offset = "0x147FBAC", VA = "0x147FBAC")]
		private set
		{
		}
	}

	[Token(Token = "0x60006E3")]
	[Address(RVA = "0x147F8AC", Offset = "0x147F8AC", VA = "0x147F8AC")]
	public static Task Load()
	{
		return null;
	}

	[Token(Token = "0x60006E6")]
	[Address(RVA = "0x147FD84", Offset = "0x147FD84", VA = "0x147FD84")]
	private void Awake()
	{
	}

	[Token(Token = "0x60006E7")]
	[Address(RVA = "0x147FE08", Offset = "0x147FE08", VA = "0x147FE08")]
	private void Start()
	{
	}

	[Token(Token = "0x60006E8")]
	[Address(RVA = "0x147FEA4", Offset = "0x147FEA4", VA = "0x147FEA4", Slot = "4")]
	protected override void Update()
	{
	}

	[Token(Token = "0x60006E9")]
	[Address(RVA = "0x1480048", Offset = "0x1480048", VA = "0x1480048")]
	public Task<bool> ShowWithResult(WTGNotification notification, Action onPopupDismissed, bool startLevelsOnPlayClicked, Type type, bool showImpossibleLeaderboard = false)
	{
		return null;
	}

	[Token(Token = "0x60006EA")]
	[Address(RVA = "0x14801CC", Offset = "0x14801CC", VA = "0x14801CC")]
	private void InitLeaderboard(ContentPack pack)
	{
	}

	[Token(Token = "0x60006EB")]
	[Address(RVA = "0x14802A4", Offset = "0x14802A4", VA = "0x14802A4")]
	public void Show(WTGNotification notification, bool forceShow, Type type)
	{
	}

	[Token(Token = "0x60006EC")]
	[Address(RVA = "0x14805EC", Offset = "0x14805EC", VA = "0x14805EC")]
	public static bool HasBeenSeenBefore(string notificationId)
	{
		return default;
	}

	[Token(Token = "0x60006ED")]
	[Address(RVA = "0x14807B8", Offset = "0x14807B8", VA = "0x14807B8")]
	private IEnumerator Show(ContentPackDef packContainer, IPackWithData pack, LocalizationData locData, bool isLevelNotification)
	{
		return null;
	}

	[Token(Token = "0x60006EE")]
	[Address(RVA = "0x148085C", Offset = "0x148085C", VA = "0x148085C")]
	public void OnLeaderboardClicked()
	{
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x147FFC0", Offset = "0x147FFC0", VA = "0x147FFC0")]
	public void OnHideLeaderboardClicked()
	{
	}

	[Token(Token = "0x60006F0")]
	[Address(RVA = "0x14808F4", Offset = "0x14808F4", VA = "0x14808F4")]
	public IEnumerator HideLeaderboard()
	{
		return null;
	}

	[Token(Token = "0x60006F1")]
	[Address(RVA = "0x1480968", Offset = "0x1480968", VA = "0x1480968")]
	private IEnumerator ShowLeaderboard()
	{
		return null;
	}

	[Token(Token = "0x60006F2")]
	[Address(RVA = "0x14809DC", Offset = "0x14809DC", VA = "0x14809DC", Slot = "5")]
	protected override void OnOpen()
	{
	}

	[Token(Token = "0x60006F3")]
	[Address(RVA = "0x1480A44", Offset = "0x1480A44", VA = "0x1480A44", Slot = "7")]
	protected override void OnClose(bool confirmed, bool invokeCallbacks)
	{
	}

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x1480B4C", Offset = "0x1480B4C", VA = "0x1480B4C", Slot = "8")]
	protected override void OnPlay()
	{
	}

	[Token(Token = "0x60006F5")]
	[Address(RVA = "0x1480CC4", Offset = "0x1480CC4", VA = "0x1480CC4")]
	public void StartPack(IPackWithData pack)
	{
	}

	[Token(Token = "0x60006F6")]
	[Address(RVA = "0x1480D5C", Offset = "0x1480D5C", VA = "0x1480D5C")]
	public void SetState(bool isAvailable, bool showImpossibleLeaderboard)
	{
	}

	[Token(Token = "0x60006F7")]
	[Address(RVA = "0x1480E98", Offset = "0x1480E98", VA = "0x1480E98")]
	public GameboyPopup()
	{
	}

	[Token(Token = "0x60006F9")]
	[Address(RVA = "0x14806D0", Offset = "0x14806D0", VA = "0x14806D0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5EF08", Offset = "0x5EF08")]
	internal static void _003CShow_003Eg__MarkAsSeen_007C31_0(ref _003C_003Ec__DisplayClass31_0 P_0)
	{
	}

	[Token(Token = "0x60006FA")]
	[Address(RVA = "0x1480F14", Offset = "0x1480F14", VA = "0x1480F14")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5EF18", Offset = "0x5EF18")]
	private void _003CHideLeaderboard_003Eb__36_0(float t)
	{
	}

	[Token(Token = "0x60006FB")]
	[Address(RVA = "0x1480F9C", Offset = "0x1480F9C", VA = "0x1480F9C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5EF28", Offset = "0x5EF28")]
	private void _003CShowLeaderboard_003Eb__38_0(float t)
	{
	}
}
