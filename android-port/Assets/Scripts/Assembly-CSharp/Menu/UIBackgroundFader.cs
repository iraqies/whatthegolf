using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Menu
{
	[Token(Token = "0x200106E")]
	public class UIBackgroundFader : AddressableSingleton<UIBackgroundFader>
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200106F")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x47824", Offset = "0x47824")]
		private struct _003CDelayedUpdate_003Ed__7 : IAsyncStateMachine
		{
			[Token(Token = "0x4005698")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x4005699")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x400569A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public UIBackgroundFader _003C_003E4__this;

			[Token(Token = "0x400569B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private object _003C_003Eu__1;

			[Token(Token = "0x60049B5")]
			[Address(RVA = "0x1871310", Offset = "0x1871310", VA = "0x1871310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60049B6")]
			[Address(RVA = "0x187161C", Offset = "0x187161C", VA = "0x187161C", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x4005695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AnimateRectTransform animateRectTransform;

		[Token(Token = "0x4005696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int popupCount;

		[Token(Token = "0x4005697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private int lastPopupCount;

		[Token(Token = "0x170007C1")]
		public bool IsActive
		{
			[Token(Token = "0x60049AF")]
			[Address(RVA = "0x1736BD4", Offset = "0x1736BD4", VA = "0x1736BD4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60049B0")]
		[Address(RVA = "0x1736BE4", Offset = "0x1736BE4", VA = "0x1736BE4")]
		public void Register()
		{
		}

		[Token(Token = "0x60049B1")]
		[Address(RVA = "0x1736D4C", Offset = "0x1736D4C", VA = "0x1736D4C")]
		public void Deregister()
		{
		}

		[Token(Token = "0x60049B2")]
		[Address(RVA = "0x1736CB4", Offset = "0x1736CB4", VA = "0x1736CB4")]
		private void DelayedUpdate()
		{
		}

		[Token(Token = "0x60049B3")]
		[Address(RVA = "0x1736DF4", Offset = "0x1736DF4", VA = "0x1736DF4")]
		public void Clear()
		{
		}

		[Token(Token = "0x60049B4")]
		[Address(RVA = "0x1736E90", Offset = "0x1736E90", VA = "0x1736E90")]
		public UIBackgroundFader()
		{
		}
	}
}
