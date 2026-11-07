using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Core.UI;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200056E")]
public class ModalWindow : MonoBehaviour
{
	[Token(Token = "0x200056F")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40514", Offset = "0x40514")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4001BEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x60018DC")]
		[Address(RVA = "0x17F79C0", Offset = "0x17F79C0", VA = "0x17F79C0")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x60018DD")]
		[Address(RVA = "0x17F79C8", Offset = "0x17F79C8", VA = "0x17F79C8")]
		internal void _003CShowMenuAsync_003Eb__0()
		{
		}

		[Token(Token = "0x60018DE")]
		[Address(RVA = "0x17F7A20", Offset = "0x17F7A20", VA = "0x17F7A20")]
		internal void _003CShowMenuAsync_003Eb__1()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000570")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40524", Offset = "0x40524")]
	private struct _003CShowMenuAsync_003Ed__7 : IAsyncStateMachine
	{
		[Token(Token = "0x4001BF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001BF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		[Token(Token = "0x4001BF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModalWindow _003C_003E4__this;

		[Token(Token = "0x4001BF3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool rotatedToFakeLandscape;

		[Token(Token = "0x4001BF4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool handleExitInput;

		[Token(Token = "0x4001BF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string header;

		[Token(Token = "0x4001BF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string description;

		[Token(Token = "0x4001BF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string confirmString;

		[Token(Token = "0x4001BF8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public string cancelString;

		[Token(Token = "0x4001BF9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public Sprite img;

		[Token(Token = "0x4001BFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public int selectedButtonIndex;

		[Token(Token = "0x4001BFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		[Token(Token = "0x4001BFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x4001BFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x60018DF")]
		[Address(RVA = "0x17F8358", Offset = "0x17F8358", VA = "0x17F8358", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60018E0")]
		[Address(RVA = "0x17F8888", Offset = "0x17F8888", VA = "0x17F8888", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000571")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40534", Offset = "0x40534")]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000572")]
		private struct _003C_003CShowMenu_003Eg__CancelAction_007C0_003Ed : IAsyncStateMachine
		{
			[Token(Token = "0x4001C02")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C03")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C04")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public _003C_003Ec__DisplayClass8_0 _003C_003E4__this;

			[Token(Token = "0x4001C05")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x60018E4")]
			[Address(RVA = "0x188203C", Offset = "0x188203C", VA = "0x188203C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60018E5")]
			[Address(RVA = "0x1882270", Offset = "0x1882270", VA = "0x1882270", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000573")]
		private struct _003C_003CShowMenu_003Eg__ConfirmAction_007C1_003Ed : IAsyncStateMachine
		{
			[Token(Token = "0x4001C06")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C07")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C08")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public _003C_003Ec__DisplayClass8_0 _003C_003E4__this;

			[Token(Token = "0x4001C09")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x60018E6")]
			[Address(RVA = "0x188227C", Offset = "0x188227C", VA = "0x188227C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60018E7")]
			[Address(RVA = "0x18824B8", Offset = "0x18824B8", VA = "0x18824B8", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001BFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModalWindow _003C_003E4__this;

		[Token(Token = "0x4001BFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TaskCompletionSource<bool> finishedClosing;

		[Token(Token = "0x4001C00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action cancelAction;

		[Token(Token = "0x4001C01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action confirmAction;

		[Token(Token = "0x60018E1")]
		[Address(RVA = "0x17F7A78", Offset = "0x17F7A78", VA = "0x17F7A78")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x60018E2")]
		[Address(RVA = "0x17F7A80", Offset = "0x17F7A80", VA = "0x17F7A80")]
		internal void _003CShowMenu_003Eg__CancelAction_007C0()
		{
		}

		[Token(Token = "0x60018E3")]
		[Address(RVA = "0x17F7B18", Offset = "0x17F7B18", VA = "0x17F7B18")]
		internal void _003CShowMenu_003Eg__ConfirmAction_007C1()
		{
		}
	}

	[Token(Token = "0x2000574")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40544", Offset = "0x40544")]
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		[Token(Token = "0x4001C0A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public TaskCompletionSource<bool> tcs;

		[Token(Token = "0x60018E8")]
		[Address(RVA = "0x17F7BB0", Offset = "0x17F7BB0", VA = "0x17F7BB0")]
		public _003C_003Ec__DisplayClass9_0()
		{
		}

		[Token(Token = "0x60018E9")]
		[Address(RVA = "0x17F7BB8", Offset = "0x17F7BB8", VA = "0x17F7BB8")]
		internal void _003CShowInfoAsync_003Eb__0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000575")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40554", Offset = "0x40554")]
	private struct _003CShowInfoAsync_003Ed__9 : IAsyncStateMachine
	{
		[Token(Token = "0x4001C0B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001C0C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001C0D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ModalWindow _003C_003E4__this;

		[Token(Token = "0x4001C0E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool rotatedToFakeLandscape;

		[Token(Token = "0x4001C0F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		public bool handleExitInput;

		[Token(Token = "0x4001C10")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string description;

		[Token(Token = "0x4001C11")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string confirmString;

		[Token(Token = "0x4001C12")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string cancelString;

		[Token(Token = "0x4001C13")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Sprite image;

		[Token(Token = "0x4001C14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x4001C15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private TaskAwaiter _003C_003Eu__2;

		[Token(Token = "0x60018EA")]
		[Address(RVA = "0x17F7F14", Offset = "0x17F7F14", VA = "0x17F7F14", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60018EB")]
		[Address(RVA = "0x17F834C", Offset = "0x17F834C", VA = "0x17F834C", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x2000576")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40564", Offset = "0x40564")]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4001C16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModalWindow _003C_003E4__this;

		[Token(Token = "0x4001C17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action confirmAction;

		[Token(Token = "0x60018EC")]
		[Address(RVA = "0x17F76CC", Offset = "0x17F76CC", VA = "0x17F76CC")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x60018ED")]
		[Address(RVA = "0x17F76D4", Offset = "0x17F76D4", VA = "0x17F76D4")]
		internal void _003CShowInfo_003Eb__0()
		{
		}

		[Token(Token = "0x60018EE")]
		[Address(RVA = "0x17F7718", Offset = "0x17F7718", VA = "0x17F7718")]
		internal void _003CShowInfo_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2000577")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40574", Offset = "0x40574")]
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		[Token(Token = "0x4001C18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModalWindow _003C_003E4__this;

		[Token(Token = "0x4001C19")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action closeAction;

		[Token(Token = "0x4001C1A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action confirmAction;

		[Token(Token = "0x4001C1B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action cancelAction;

		[Token(Token = "0x60018EF")]
		[Address(RVA = "0x17F775C", Offset = "0x17F775C", VA = "0x17F775C")]
		public _003C_003Ec__DisplayClass12_0()
		{
		}

		[Token(Token = "0x60018F0")]
		[Address(RVA = "0x17F7764", Offset = "0x17F7764", VA = "0x17F7764")]
		internal void _003CShowMenuWithClose_003Eb__0()
		{
		}

		[Token(Token = "0x60018F1")]
		[Address(RVA = "0x17F77A8", Offset = "0x17F77A8", VA = "0x17F77A8")]
		internal void _003CShowMenuWithClose_003Eb__1()
		{
		}

		[Token(Token = "0x60018F2")]
		[Address(RVA = "0x17F77EC", Offset = "0x17F77EC", VA = "0x17F77EC")]
		internal void _003CShowMenuWithClose_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2000578")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40584", Offset = "0x40584")]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2000579")]
		private struct _003C_003CShowMenuWithResponse_003Eg__ConfirmAction_007C0_003Ed : IAsyncStateMachine
		{
			[Token(Token = "0x4001C25")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C26")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C27")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public _003C_003Ec__DisplayClass14_0 _003C_003E4__this;

			[Token(Token = "0x4001C28")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x60018F6")]
			[Address(RVA = "0x1881DB0", Offset = "0x1881DB0", VA = "0x1881DB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60018F7")]
			[Address(RVA = "0x1882030", Offset = "0x1882030", VA = "0x1882030", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200057A")]
		private struct _003C_003CShowMenuWithResponse_003Eg__CancelAction_007C1_003Ed : IAsyncStateMachine
		{
			[Token(Token = "0x4001C29")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4001C2A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x4001C2B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public _003C_003Ec__DisplayClass14_0 _003C_003E4__this;

			[Token(Token = "0x4001C2C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x60018F8")]
			[Address(RVA = "0x1881B24", Offset = "0x1881B24", VA = "0x1881B24", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60018F9")]
			[Address(RVA = "0x1881DA4", Offset = "0x1881DA4", VA = "0x1881DA4", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4001C1C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModalWindow _003C_003E4__this;

		[Token(Token = "0x4001C1D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public TaskCompletionSource<bool> finishedClosing;

		[Token(Token = "0x4001C1E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool rotatedToFakeLandscape;

		[Token(Token = "0x4001C1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool handleExitInput;

		[Token(Token = "0x4001C20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string header;

		[Token(Token = "0x4001C21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public string positiveResponse;

		[Token(Token = "0x4001C22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action confirmAction;

		[Token(Token = "0x4001C23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public string negativeResponse;

		[Token(Token = "0x4001C24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public Action cancelAction;

		[Token(Token = "0x60018F3")]
		[Address(RVA = "0x17F7830", Offset = "0x17F7830", VA = "0x17F7830")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x60018F4")]
		[Address(RVA = "0x17F7838", Offset = "0x17F7838", VA = "0x17F7838")]
		internal void _003CShowMenuWithResponse_003Eg__ConfirmAction_007C0()
		{
		}

		[Token(Token = "0x60018F5")]
		[Address(RVA = "0x17F78D0", Offset = "0x17F78D0", VA = "0x17F78D0")]
		internal void _003CShowMenuWithResponse_003Eg__CancelAction_007C1()
		{
		}
	}

	[Token(Token = "0x200057B")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x40594", Offset = "0x40594")]
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		[Token(Token = "0x4001C2D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public ModalWindow _003C_003E4__this;

		[Token(Token = "0x4001C2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public Action confirmAction;

		[Token(Token = "0x60018FA")]
		[Address(RVA = "0x17F7968", Offset = "0x17F7968", VA = "0x17F7968")]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[Token(Token = "0x60018FB")]
		[Address(RVA = "0x17F7970", Offset = "0x17F7970", VA = "0x17F7970")]
		internal void _003CShowNotificationWindow_003Eg__OnlyAction_007C0()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x200057C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x405A4", Offset = "0x405A4")]
	private struct _003CHideWindow_003Ed__19 : IAsyncStateMachine
	{
		[Token(Token = "0x4001C2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4001C30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4001C31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public ModalWindow _003C_003E4__this;

		[Token(Token = "0x4001C32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public bool didSayYes;

		[Token(Token = "0x4001C33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public TaskCompletionSource<bool> finishedClosing;

		[Token(Token = "0x4001C34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x60018FC")]
		[Address(RVA = "0x17F7C10", Offset = "0x17F7C10", VA = "0x17F7C10", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x60018FD")]
		[Address(RVA = "0x17F7F08", Offset = "0x17F7F08", VA = "0x17F7F08", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4001BE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public BasicMenu Menu;

	[Token(Token = "0x4001BEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Animator Animator;

	[Token(Token = "0x4001BEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public SVGImage image;

	[Token(Token = "0x4001BEC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Coroutine scaleRoutine;

	[Token(Token = "0x4001BED")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public AppleArcadeTextMeshProTextPreprocessor appleArcadeTextMeshProTextPreprocessor;

	[Token(Token = "0x4001BEE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public ModalWindowType Type;

	[Token(Token = "0x60018CD")]
	[Address(RVA = "0x1569400", Offset = "0x1569400", VA = "0x1569400")]
	private void SetImage(Sprite i)
	{
	}

	[Token(Token = "0x60018CE")]
	[Address(RVA = "0x1569524", Offset = "0x1569524", VA = "0x1569524")]
	public Task<bool> ShowMenuAsync(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, [Optional][DefaultParameterValue("ID_MENU_UI_YES")] string confirmString, [Optional][DefaultParameterValue("ID_MENU_UI_NO")] string cancelString, [Optional] Sprite img, int selectedButtonIndex = 0)
	{
		return null;
	}

	[Token(Token = "0x60018CF")]
	[Address(RVA = "0x156968C", Offset = "0x156968C", VA = "0x156968C")]
	public void ShowMenu(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction, [Optional] Action cancelAction, [Optional][DefaultParameterValue("ID_MENU_UI_YES")] string confirmString, [Optional][DefaultParameterValue("ID_MENU_UI_NO")] string cancelString, [Optional] Sprite img, int selectedButtonIndex = 0)
	{
	}

	[Token(Token = "0x60018D0")]
	[Address(RVA = "0x1569968", Offset = "0x1569968", VA = "0x1569968")]
	public Task ShowInfoAsync(bool rotatedToFakeLandscape, bool handleExitInput, string description, [Optional] string confirmString, [Optional] string cancelString, [Optional] Sprite image)
	{
		return null;
	}

	[Token(Token = "0x60018D1")]
	[Address(RVA = "0x1569A88", Offset = "0x1569A88", VA = "0x1569A88")]
	public void ShowInfo(bool rotatedToFakeLandscape, bool handleExitInput, string description, Action confirmAction, [Optional] string confirmString, [Optional] string cancelString, [Optional] Sprite image)
	{
	}

	[Token(Token = "0x60018D2")]
	[Address(RVA = "0x1569BD4", Offset = "0x1569BD4", VA = "0x1569BD4")]
	public void ShowMenu(string header, string description, Action confirmAction, [Optional] Action cancelAction, string confirmString = "ID_MENU_UI_OK", string cancelString = "ID_MENU_UI_CANCEL", int selectedButtonIndex = 0)
	{
	}

	[Token(Token = "0x60018D3")]
	[Address(RVA = "0x1569C1C", Offset = "0x1569C1C", VA = "0x1569C1C")]
	public void ShowMenuWithClose(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction, Action cancelAction, Action closeAction)
	{
	}

	[Token(Token = "0x60018D4")]
	[Address(RVA = "0x1569D90", Offset = "0x1569D90", VA = "0x1569D90")]
	public void ShowMenuWithResponse(string header, string description, string positiveResponse, string negativeResponse, Action confirmAction, [Optional] Action cancelAction)
	{
	}

	[Token(Token = "0x60018D5")]
	[Address(RVA = "0x1569DD0", Offset = "0x1569DD0", VA = "0x1569DD0")]
	public void ShowMenuWithResponse(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, string positiveResponse, string negativeResponse, Action confirmAction, [Optional] Action cancelAction, [Optional] string confirmString, [Optional] string cancelString)
	{
	}

	[Token(Token = "0x60018D6")]
	[Address(RVA = "0x1566570", Offset = "0x1566570", VA = "0x1566570")]
	public void ShowNotificationWindow(string header, string description, Action confirmAction)
	{
	}

	[Token(Token = "0x60018D7")]
	[Address(RVA = "0x1569FA4", Offset = "0x1569FA4", VA = "0x1569FA4")]
	private void ShowNotificationWindow(bool rotatedToFakeLandscape, bool handleExitInput, string header, string description, Action confirmAction)
	{
	}

	[Token(Token = "0x60018D8")]
	[Address(RVA = "0x1569840", Offset = "0x1569840", VA = "0x1569840")]
	private void ShowMenuWindow(bool rotatedToFakeLandscape, bool handleExitInputFlag, string header, string description, string confirmString, string cancelString, Action closeAction, Action confirmAction, Action cancelAction, int selectedButtonIndex = 0)
	{
	}

	[Token(Token = "0x60018D9")]
	[Address(RVA = "0x156A0D0", Offset = "0x156A0D0", VA = "0x156A0D0")]
	public void ForceClose()
	{
	}

	[Token(Token = "0x60018DA")]
	[Address(RVA = "0x156A1B0", Offset = "0x156A1B0", VA = "0x156A1B0")]
	public void HideWindow(bool didSayYes, [Optional] TaskCompletionSource<bool> finishedClosing)
	{
	}

	[Token(Token = "0x60018DB")]
	[Address(RVA = "0x156A260", Offset = "0x156A260", VA = "0x156A260")]
	public ModalWindow()
	{
	}
}
