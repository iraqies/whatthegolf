using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Triband.Events
{
	[Token(Token = "0x200000F")]
	public class EventBusCallbacks : MonoBehaviour
	{
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x18")]
		private Action _onEnableAction;

		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x20")]
		private Action _onDisableAction;

		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x28")]
		private Action _onApplicationQuitAction;

		[Token(Token = "0x6000043")]
		[Address(RVA = "0x29F8050", Offset = "0x29F8050", VA = "0x29F8050")]
		internal void RegisterCallbacks(Action onEnable, Action onDisable, Action onApplicationQuit)
		{
		}

		[Token(Token = "0x6000044")]
		[Address(RVA = "0x29F88B8", Offset = "0x29F88B8", VA = "0x29F88B8")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000045")]
		[Address(RVA = "0x29F88CC", Offset = "0x29F88CC", VA = "0x29F88CC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000046")]
		[Address(RVA = "0x29F88E0", Offset = "0x29F88E0", VA = "0x29F88E0")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000047")]
		[Address(RVA = "0x29F88F4", Offset = "0x29F88F4", VA = "0x29F88F4")]
		public EventBusCallbacks()
		{
		}
	}
}
