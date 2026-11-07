using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Core.UI;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000E57")]
public class NewsletterPopup : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[Token(Token = "0x2000E58")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44FD8", Offset = "0x44FD8")]
	private struct _003CShowAndAwait_003Ed__5 : IAsyncStateMachine
	{
		[Token(Token = "0x4004DC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int _003C_003E1__state;

		[Token(Token = "0x4004DC6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public AsyncTaskMethodBuilder _003C_003Et__builder;

		[Token(Token = "0x4004DC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public NewsletterPopup _003C_003E4__this;

		[Token(Token = "0x4004DC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private TaskAwaiter<bool> _003C_003Eu__1;

		[Token(Token = "0x6004328")]
		[Address(RVA = "0x1806650", Offset = "0x1806650", VA = "0x1806650", Slot = "4")]
		private void MoveNext()
		{
		}

		[Token(Token = "0x6004329")]
		[Address(RVA = "0x18068B4", Offset = "0x18068B4", VA = "0x18068B4", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2000E59")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44FE8", Offset = "0x44FE8")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4004DC9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4004DCA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static Func<ExternalLinks.LinksOnPlatform, bool> _003C_003E9__6_0;

		[Token(Token = "0x600432B")]
		[Address(RVA = "0x1806598", Offset = "0x1806598", VA = "0x1806598")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x600432C")]
		[Address(RVA = "0x18065A0", Offset = "0x18065A0", VA = "0x18065A0")]
		internal bool _003CShowPopup_003Eb__6_0(ExternalLinks.LinksOnPlatform i)
		{
			return default;
		}
	}

	[Token(Token = "0x2000E5A")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x44FF8", Offset = "0x44FF8")]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4004DCB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public NewsletterPopup _003C_003E4__this;

		[Token(Token = "0x4004DCC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string link;

		[Token(Token = "0x600432D")]
		[Address(RVA = "0x18065DC", Offset = "0x18065DC", VA = "0x18065DC")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x600432E")]
		[Address(RVA = "0x18065E4", Offset = "0x18065E4", VA = "0x18065E4")]
		internal void _003CShowPopupWithLinks_003Eb__0()
		{
		}

		[Token(Token = "0x600432F")]
		[Address(RVA = "0x1806608", Offset = "0x1806608", VA = "0x1806608")]
		internal void _003CShowPopupWithLinks_003Eb__1()
		{
		}

		[Token(Token = "0x6004330")]
		[Address(RVA = "0x180662C", Offset = "0x180662C", VA = "0x180662C")]
		internal void _003CShowPopupWithLinks_003Eb__2()
		{
		}
	}

	[Token(Token = "0x4004DC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public ExternalLinks linksList;

	[Token(Token = "0x4004DC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public ExternalLinks.LinkType popupLinkType;

	[Token(Token = "0x4004DC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public ModalWindowType modalWindowType;

	[Token(Token = "0x4004DC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TaskCompletionSource<bool> tcs;

	[Token(Token = "0x4004DC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private bool _shouldEnableInteraction;

	[Token(Token = "0x600431C")]
	[Address(RVA = "0x158C9EC", Offset = "0x158C9EC", VA = "0x158C9EC")]
	public Task ShowAndAwait()
	{
		return null;
	}

	[Token(Token = "0x600431D")]
	[Address(RVA = "0x158CAC8", Offset = "0x158CAC8", VA = "0x158CAC8")]
	public void ShowPopup()
	{
	}

	[Token(Token = "0x600431E")]
	[Address(RVA = "0x158CE44", Offset = "0x158CE44", VA = "0x158CE44")]
	private void ShowPopupWithLinks(Sprite QR, string link, string popupTextID)
	{
	}

	[Token(Token = "0x600431F")]
	[Address(RVA = "0x158D2A4", Offset = "0x158D2A4", VA = "0x158D2A4")]
	private void Agree(string link)
	{
	}

	[Token(Token = "0x6004320")]
	[Address(RVA = "0x158D3D4", Offset = "0x158D3D4", VA = "0x158D3D4")]
	private void Disagree()
	{
	}

	[Token(Token = "0x6004321")]
	[Address(RVA = "0x158D360", Offset = "0x158D360", VA = "0x158D360")]
	private void EnableInteraction()
	{
	}

	[Token(Token = "0x6004322")]
	[Address(RVA = "0x158D23C", Offset = "0x158D23C", VA = "0x158D23C")]
	private void DisableInteraction()
	{
	}

	[Token(Token = "0x6004323")]
	[Address(RVA = "0x158D484", Offset = "0x158D484", VA = "0x158D484")]
	public NewsletterPopup()
	{
	}

	[Token(Token = "0x6004324")]
	[Address(RVA = "0x158D48C", Offset = "0x158D48C", VA = "0x158D48C")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA74", Offset = "0x6DA74")]
	private bool _003CShowPopup_003Eb__6_1(ExternalLinks.Link i)
	{
		return default;
	}

	[Token(Token = "0x6004325")]
	[Address(RVA = "0x158D4B0", Offset = "0x158D4B0", VA = "0x158D4B0")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA84", Offset = "0x6DA84")]
	private bool _003CShowPopup_003Eb__6_2(ExternalLinks.Link i)
	{
		return default;
	}

	[Token(Token = "0x6004326")]
	[Address(RVA = "0x158D4D4", Offset = "0x158D4D4", VA = "0x158D4D4")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DA94", Offset = "0x6DA94")]
	private bool _003CShowPopup_003Eb__6_3(ExternalLinks.PopupText i)
	{
		return default;
	}

	[Token(Token = "0x6004327")]
	[Address(RVA = "0x158D4F8", Offset = "0x158D4F8", VA = "0x158D4F8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6DAA4", Offset = "0x6DAA4")]
	private bool _003CShowPopup_003Eb__6_4(ExternalLinks.PopupText i)
	{
		return default;
	}
}
