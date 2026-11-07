using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000CAA")]
public class NotificationDataHandler : WTGSingleton<NotificationDataHandler>
{
	[Token(Token = "0x2000CAB")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44308", Offset = "0x44308")]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4004511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string url;

		[Token(Token = "0x6003BE3")]
		[Address(RVA = "0x1806C30", Offset = "0x1806C30", VA = "0x1806C30")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x6003BE4")]
		[Address(RVA = "0x1806C38", Offset = "0x1806C38", VA = "0x1806C38")]
		internal bool _003COnOpenedFromNotification_003Eb__0(WTGNotification n)
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CAC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44318", Offset = "0x44318")]
	private struct _003COnOpenedFromNotification_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x4004512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string url;

		[Token(Token = "0x4004515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public NotificationDataHandler _003C_003E4__this;

		[Token(Token = "0x4004516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003BE5")]
		[Address(RVA = "0x180766C", Offset = "0x180766C", VA = "0x180766C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BE6")]
		[Address(RVA = "0x1807A58", Offset = "0x1807A58", VA = "0x1807A58", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000CAD")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44328", Offset = "0x44328")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<bool> _003C_003E9__5_0;

		[Token(Token = "0x6003BE8")]
		[Address(RVA = "0x1806B8C", Offset = "0x1806B8C", VA = "0x1806B8C")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6003BE9")]
		[Address(RVA = "0x1806B94", Offset = "0x1806B94", VA = "0x1806B94")]
		internal bool _003COnOpenedFromNotification_003Eb__5_0()
		{
			return default;
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CAE")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44338", Offset = "0x44338")]
	private struct _003COnOpenedFromNotification_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x4004519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400451A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400451B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NotificationDataHandler _003C_003E4__this;

		[Token(Token = "0x400451C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WTGNotification notification;

		[Token(Token = "0x400451D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public bool returnFromAppUpdate;

		[Token(Token = "0x400451E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x400451F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6003BEA")]
		[Address(RVA = "0x1807A64", Offset = "0x1807A64", VA = "0x1807A64", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BEB")]
		[Address(RVA = "0x1808018", Offset = "0x1808018", VA = "0x1808018", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CAF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44348", Offset = "0x44348")]
	private struct _003CHandleValidNotification_003Ed__6 : IAsyncStateMachine
	{
		[Token(Token = "0x4004520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WTGNotification notification;

		[Token(Token = "0x4004523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x4004524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private TaskAwaiter<bool> _003C_003Eu__2;

		[Token(Token = "0x6003BEC")]
		[Address(RVA = "0x1806F58", Offset = "0x1806F58", VA = "0x1806F58", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BED")]
		[Address(RVA = "0x1807660", Offset = "0x1807660", VA = "0x1807660", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CB0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44358", Offset = "0x44358")]
	private struct _003CHandleInvalidNotification_003Ed__7 : IAsyncStateMachine
	{
		[Token(Token = "0x4004525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool returnFromAppUpdate;

		[Token(Token = "0x4004528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public WTGNotification notification;

		[Token(Token = "0x4004529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public bool isOnBoardingComplete;

		[Token(Token = "0x400452A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public NotificationDataHandler _003C_003E4__this;

		[Token(Token = "0x400452B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x6003BEE")]
		[Address(RVA = "0x1806C4C", Offset = "0x1806C4C", VA = "0x1806C4C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BEF")]
		[Address(RVA = "0x1806F4C", Offset = "0x1806F4C", VA = "0x1806F4C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000CB1")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44368", Offset = "0x44368")]
	private struct _003CPromptAppUpdate_003Ed__8 : IAsyncStateMachine
	{
		[Token(Token = "0x400452C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x400452D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x400452E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string notificationId;

		[Token(Token = "0x400452F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x4004530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x6003BF0")]
		[Address(RVA = "0x1808024", Offset = "0x1808024", VA = "0x1808024", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6003BF1")]
		[Address(RVA = "0x18084C0", Offset = "0x18084C0", VA = "0x18084C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x400450D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Button sendButton;

	[Token(Token = "0x400450E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Button closeButton;

	[Token(Token = "0x400450F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private TMP_Text sendButtonText;

	[Token(Token = "0x4004510")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private string lastUrl;

	[Token(Token = "0x6003BDD")]
	[Address(RVA = "0x158E3E8", Offset = "0x158E3E8", VA = "0x158E3E8")]
	public void OnOpenedFromNotification(string url)
	{
	}

	[Token(Token = "0x6003BDE")]
	[Address(RVA = "0x158E484", Offset = "0x158E484", VA = "0x158E484")]
	public Task OnOpenedFromNotification(WTGNotification notification, bool returnFromAppUpdate = false)
	{
		return null;
	}

	[Token(Token = "0x6003BDF")]
	[Address(RVA = "0x158E5BC", Offset = "0x158E5BC", VA = "0x158E5BC")]
	private Task HandleValidNotification(WTGNotification notification)
	{
		return null;
	}

	[Token(Token = "0x6003BE0")]
	[Address(RVA = "0x158E6C4", Offset = "0x158E6C4", VA = "0x158E6C4")]
	private void HandleInvalidNotification(WTGNotification notification, bool isOnBoardingComplete, bool returnFromAppUpdate)
	{
	}

	[Token(Token = "0x6003BE1")]
	[Address(RVA = "0x158E7B4", Offset = "0x158E7B4", VA = "0x158E7B4")]
	private Task PromptAppUpdate(string notificationId)
	{
		return null;
	}

	[Token(Token = "0x6003BE2")]
	[Address(RVA = "0x158E894", Offset = "0x158E894", VA = "0x158E894")]
	public NotificationDataHandler()
	{
	}
}
