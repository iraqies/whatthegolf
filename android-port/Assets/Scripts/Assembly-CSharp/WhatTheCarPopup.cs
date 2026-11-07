using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E5D")]
public class WhatTheCarPopup : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E5E")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x45008", Offset = "0x45008")]
	private struct _003CShowAndAwait_003Ed__3 : IAsyncStateMachine
	{
		[Token(Token = "0x4004DD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004DD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004DD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WhatTheCarPopup _003C_003E4__this;

		[Token(Token = "0x4004DD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x600433D")]
		[Address(RVA = "0x1877568", Offset = "0x1877568", VA = "0x1877568", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x600433E")]
		[Address(RVA = "0x1877714", Offset = "0x1877714", VA = "0x1877714", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E5F")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x45018", Offset = "0x45018")]
	private struct _003CShowPopup_003Ed__4 : IAsyncStateMachine
	{
		[Token(Token = "0x4004DD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004DDA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncVoidMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004DDB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public WhatTheCarPopup _003C_003E4__this;

		[Token(Token = "0x4004DDC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x600433F")]
		[Address(RVA = "0x1877720", Offset = "0x1877720", VA = "0x1877720", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6004340")]
		[Address(RVA = "0x1877920", Offset = "0x1877920", VA = "0x1877920", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E60")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x45028", Offset = "0x45028")]
	private struct _003CShowPopupWithLinks_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x4004DDD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004DDE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004DDF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public WhatTheCarPopup _003C_003E4__this;

		[Token(Token = "0x4004DE0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string popupTextID;

		[Token(Token = "0x4004DE1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private TaskAwaiter _003C_003Eu__1;

		[Token(Token = "0x4004DE2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private TaskAwaiter<bool> _003C_003Eu__2;

		[Token(Token = "0x6004341")]
		[Address(RVA = "0x187792C", Offset = "0x187792C", VA = "0x187792C", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6004342")]
		[Address(RVA = "0x1877D20", Offset = "0x1877D20", VA = "0x1877D20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Token(Token = "0x4004DD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public Sprite WTC_With_QR;

	[Token(Token = "0x4004DD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Sprite WTC_Image;

	[Token(Token = "0x4004DD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private string linkToWTC;

	[Token(Token = "0x6004339")]
	[Address(RVA = "0x1752F6C", Offset = "0x1752F6C", VA = "0x1752F6C")]
	public Task ShowAndAwait()
	{
		return null;
	}

	[Token(Token = "0x600433A")]
	[Address(RVA = "0x1753048", Offset = "0x1753048", VA = "0x1753048")]
	public void ShowPopup()
	{
	}

	[Token(Token = "0x600433B")]
	[Address(RVA = "0x17530E0", Offset = "0x17530E0", VA = "0x17530E0")]
	private Task ShowPopupWithLinks(string popupTextID)
	{
		return null;
	}

	[Token(Token = "0x600433C")]
	[Address(RVA = "0x17531C0", Offset = "0x17531C0", VA = "0x17531C0")]
	public WhatTheCarPopup()
	{
	}
}
