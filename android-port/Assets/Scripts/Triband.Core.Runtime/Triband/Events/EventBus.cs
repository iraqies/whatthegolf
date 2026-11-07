using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

namespace Triband.Events
{
	[Token(Token = "0x200000B")]
	public class EventBus
	{
		[Token(Token = "0x200000C")]
		private struct EventCallback
		{
			[Token(Token = "0x4000022")]
			[FieldOffset(Offset = "0x0")]
			public object action;

			[Token(Token = "0x4000023")]
			[FieldOffset(Offset = "0x8")]
			public object target;

			[Token(Token = "0x1700000B")]
			public bool isValid
			{
				[Token(Token = "0x600003D")]
				[Address(RVA = "0x29F9A48", Offset = "0x29F9A48", VA = "0x29F9A48")]
				get
				{
					return default;
				}
			}
		}

		[Token(Token = "0x200000D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF6D4", Offset = "0x1AF6D4")]
		private sealed class _003C_003Ec__DisplayClass17_0<T> where T : struct
		{
			[Token(Token = "0x4000024")]
			[FieldOffset(Offset = "0x0")]
			public UnityAction<T> callback;

			[Token(Token = "0x600003E")]
			public _003C_003Ec__DisplayClass17_0()
			{
			}

			[Token(Token = "0x600003F")]
			internal bool _003CAddListenerInternal_003Eb__0(EventCallback item)
			{
				return default;
			}
		}

		[Serializable]
		[Token(Token = "0x200000E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x1AF6E4", Offset = "0x1AF6E4")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x4000025")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x8")]
			public static Predicate<EventCallback> _003C_003E9__21_0;

			[Token(Token = "0x6000041")]
			[Address(RVA = "0x29F9974", Offset = "0x29F9974", VA = "0x29F9974")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x6000042")]
			[Address(RVA = "0x29F997C", Offset = "0x29F997C", VA = "0x29F997C")]
			internal bool _003CCleanupInvalidListenersInternal_003Eb__21_0(EventCallback e)
			{
				return default;
			}
		}

		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x0")]
		private static EventBus s_instance;

		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x8")]
		private static EventBusCallbacks s_callbacks;

		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x10")]
		private static bool s_appQuitting;

		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<Type, List<EventCallback>> _listenersPerEventType;

		[Token(Token = "0x1700000A")]
		private static EventBus instance
		{
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x29F7C44", Offset = "0x29F7C44", VA = "0x29F7C44")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600002B")]
		[Address(RVA = "0x29F7BDC", Offset = "0x29F7BDC", VA = "0x29F7BDC")]
		[AttributeAttribute(Name = "RuntimeInitializeOnLoadMethodAttribute", RVA = "0x1AF914", Offset = "0x1AF914")]
		private static void Init()
		{
		}

		[Token(Token = "0x600002D")]
		public static void RaiseEvent<T>(T eventInstance) where T : struct
		{
		}

		[Token(Token = "0x600002E")]
		public static void AddListener<T>(UnityAction<T> callback) where T : struct
		{
		}

		[Token(Token = "0x600002F")]
		public static void RemoveListener<T>(UnityAction<T> callback) where T : struct
		{
		}

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x29F805C", Offset = "0x29F805C", VA = "0x29F805C")]
		public static void RemoveAllListeners(UnityEngine.Object target)
		{
		}

		[Token(Token = "0x6000031")]
		[Address(RVA = "0x29F8388", Offset = "0x29F8388", VA = "0x29F8388")]
		public static void CleanupInvalidListeners()
		{
		}

		[Token(Token = "0x6000032")]
		[Address(RVA = "0x29F86B0", Offset = "0x29F86B0", VA = "0x29F86B0")]
		private void OnApplicationQuit()
		{
		}

		[Token(Token = "0x6000033")]
		[Address(RVA = "0x29F8718", Offset = "0x29F8718", VA = "0x29F8718")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000034")]
		[Address(RVA = "0x29F87E4", Offset = "0x29F87E4", VA = "0x29F87E4")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000035")]
		private void RaiseEventInternal<T>(T eventInstance) where T : struct
		{
		}

		[Token(Token = "0x6000036")]
		private void AddListenerInternal<T>(UnityAction<T> callback) where T : struct
		{
		}

		[Token(Token = "0x6000037")]
		private void RemoveListenerInternal<T>(UnityAction<T> callback) where T : struct
		{
		}

		[Token(Token = "0x6000038")]
		[Address(RVA = "0x29F8108", Offset = "0x29F8108", VA = "0x29F8108")]
		private void RemoveAllListenersInternal(UnityEngine.Object target)
		{
		}

		[Token(Token = "0x6000039")]
		[Address(RVA = "0x29F88B0", Offset = "0x29F88B0", VA = "0x29F88B0")]
		private void OnSceneUnloaded(Scene s)
		{
		}

		[Token(Token = "0x600003A")]
		[Address(RVA = "0x29F8420", Offset = "0x29F8420", VA = "0x29F8420")]
		public void CleanupInvalidListenersInternal()
		{
		}

		[Token(Token = "0x600003B")]
		[Address(RVA = "0x29F7FD0", Offset = "0x29F7FD0", VA = "0x29F7FD0")]
		public EventBus()
		{
		}
	}
}
