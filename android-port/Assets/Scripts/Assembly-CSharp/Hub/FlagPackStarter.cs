using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Il2CppDummyDll;
using UnityEngine;

namespace Hub
{
	[Token(Token = "0x2001073")]
	public class FlagPackStarter : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001074")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x478AC", Offset = "0x478AC")]
		private struct _003COnCollisionEnter2D_003Ed__19 : IAsyncStateMachine
		{
			[Token(Token = "0x40056B2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056B3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Collision2D collision;

			[Token(Token = "0x40056B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public FlagPackStarter _003C_003E4__this;

			[Token(Token = "0x40056B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x60049DF")]
			[Address(RVA = "0x17A7B3C", Offset = "0x17A7B3C", VA = "0x17A7B3C", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60049E0")]
			[Address(RVA = "0x17A7F18", Offset = "0x17A7F18", VA = "0x17A7F18", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x2001075")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x478BC", Offset = "0x478BC")]
		private struct _003CStartPack_003Ed__20 : IAsyncStateMachine
		{
			[Token(Token = "0x40056B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncVoidMethodBuilder _003C_003Et__builder;

			[Token(Token = "0x40056B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FlagPackStarter _003C_003E4__this;

			[Token(Token = "0x40056BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x40056BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private TaskAwaiter _003C_003Eu__2;

			[Token(Token = "0x60049E1")]
			[Address(RVA = "0x17A8470", Offset = "0x17A8470", VA = "0x17A8470", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60049E2")]
			[Address(RVA = "0x17A8970", Offset = "0x17A8970", VA = "0x17A8970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x2001076")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x478CC", Offset = "0x478CC")]
		private sealed class _003CDisableOverworldWithDelay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40056BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40056BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x170007C9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60049E6")]
				[Address(RVA = "0x17A7AEC", Offset = "0x17A7AEC", VA = "0x17A7AEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007CA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60049E8")]
				[Address(RVA = "0x17A7B34", Offset = "0x17A7B34", VA = "0x17A7B34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60049E3")]
			[Address(RVA = "0x17A79FC", Offset = "0x17A79FC", VA = "0x17A79FC")]
			[DebuggerHidden]
			public _003CDisableOverworldWithDelay_003Ed__21(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60049E4")]
			[Address(RVA = "0x17A7A28", Offset = "0x17A7A28", VA = "0x17A7A28", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60049E5")]
			[Address(RVA = "0x17A7A2C", Offset = "0x17A7A2C", VA = "0x17A7A2C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60049E6")]
			[Address(RVA = "0x17A7AEC", Offset = "0x17A7AEC", VA = "0x17A7AEC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60049E7")]
			[Address(RVA = "0x17A7AF4", Offset = "0x17A7AF4", VA = "0x17A7AF4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60049E8")]
			[Address(RVA = "0x17A7B34", Offset = "0x17A7B34", VA = "0x17A7B34", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001077")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x478DC", Offset = "0x478DC")]
		private sealed class _003C_003Ec__DisplayClass24_0
		{
			[Token(Token = "0x40056BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string id;

			[Token(Token = "0x60049E9")]
			[Address(RVA = "0x17A77FC", Offset = "0x17A77FC", VA = "0x17A77FC")]
			public _003C_003Ec__DisplayClass24_0()
			{
			}

			[Token(Token = "0x60049EA")]
			[Address(RVA = "0x17A7804", Offset = "0x17A7804", VA = "0x17A7804")]
			internal bool _003CGetNotification_003Eb__0(WTGNotification n)
			{
				return default;
			}

			[Token(Token = "0x60049EB")]
			[Address(RVA = "0x17A7854", Offset = "0x17A7854", VA = "0x17A7854")]
			internal bool _003CGetNotification_003Eb__1(WTGNotification n)
			{
				return default;
			}
		}

		[Token(Token = "0x2001078")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x478EC", Offset = "0x478EC")]
		private sealed class _003C_003Ec__DisplayClass25_0
		{
			[Token(Token = "0x40056BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DailyChallengeLevelDataContainer daily;

			[Token(Token = "0x60049EC")]
			[Address(RVA = "0x17A78A4", Offset = "0x17A78A4", VA = "0x17A78A4")]
			public _003C_003Ec__DisplayClass25_0()
			{
			}

			[Token(Token = "0x60049ED")]
			[Address(RVA = "0x17A78AC", Offset = "0x17A78AC", VA = "0x17A78AC")]
			internal bool _003CIsCompleted_003Eb__0(string d)
			{
				return default;
			}
		}

		[Token(Token = "0x2001079")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x478FC", Offset = "0x478FC")]
		private sealed class _003C_003Ec__DisplayClass25_1
		{
			[Token(Token = "0x40056C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public DailyChallengeLevelDataContainer special;

			[Token(Token = "0x60049EE")]
			[Address(RVA = "0x17A78EC", Offset = "0x17A78EC", VA = "0x17A78EC")]
			public _003C_003Ec__DisplayClass25_1()
			{
			}

			[Token(Token = "0x60049EF")]
			[Address(RVA = "0x17A78F4", Offset = "0x17A78F4", VA = "0x17A78F4")]
			internal bool _003CIsCompleted_003Eb__1(string d)
			{
				return default;
			}
		}

		[Token(Token = "0x200107A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4790C", Offset = "0x4790C")]
		private sealed class _003C_003Ec__DisplayClass26_0
		{
			[Token(Token = "0x40056C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string packId;

			[Token(Token = "0x60049F0")]
			[Address(RVA = "0x17A79D0", Offset = "0x17A79D0", VA = "0x17A79D0")]
			public _003C_003Ec__DisplayClass26_0()
			{
			}

			[Token(Token = "0x60049F1")]
			[Address(RVA = "0x17A79D8", Offset = "0x17A79D8", VA = "0x17A79D8")]
			internal bool _003CStartFlag_003Eb__0(FlagPackStarter f)
			{
				return default;
			}
		}

		[StructLayout((LayoutKind)3)]
		[Token(Token = "0x200107B")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4791C", Offset = "0x4791C")]
		private struct _003CStartFlag_003Ed__26 : IAsyncStateMachine
		{
			[Token(Token = "0x40056C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int _003C_003E1__state;

			[Token(Token = "0x40056C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

			[Token(Token = "0x40056C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string packId;

			[Token(Token = "0x40056C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private TaskAwaiter<bool> _003C_003Eu__1;

			[Token(Token = "0x60049F2")]
			[Address(RVA = "0x17A7F24", Offset = "0x17A7F24", VA = "0x17A7F24", Slot = "4")]
			private void MoveNext()
			{
			}

			[Token(Token = "0x60049F3")]
			[Address(RVA = "0x17A8414", Offset = "0x17A8414", VA = "0x17A8414", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Token(Token = "0x40056A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject crown;

		[Token(Token = "0x40056A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject completedFlag;

		[Token(Token = "0x40056AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject uncompletedFlag;

		[Token(Token = "0x40056AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Collider2D circleCollider;

		[Token(Token = "0x40056AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Collider2D boxCollider;

		[Token(Token = "0x40056AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool dontDisableOverworld;

		[Token(Token = "0x40056AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private WhatTheCarPopup carPopup;

		[Token(Token = "0x40056AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private DayOfWeek lastUpdate;

		[Token(Token = "0x40056B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		public string pack;

		[NonSerialized]
		[Token(Token = "0x40056B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ContentPackDef packDef;

		[Token(Token = "0x170007C6")]
		private NotificationConfiguration notifs
		{
			[Token(Token = "0x60049D0")]
			[Address(RVA = "0x146A890", Offset = "0x146A890", VA = "0x146A890")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170007C7")]
		private bool IsImpossiblePack
		{
			[Token(Token = "0x60049D1")]
			[Address(RVA = "0x146A958", Offset = "0x146A958", VA = "0x146A958")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170007C8")]
		private ContentPackDef PackDef
		{
			[Token(Token = "0x60049D2")]
			[Address(RVA = "0x146AA3C", Offset = "0x146AA3C", VA = "0x146AA3C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60049D3")]
		[Address(RVA = "0x146AA7C", Offset = "0x146AA7C", VA = "0x146AA7C")]
		private void Start()
		{
		}

		[Token(Token = "0x60049D4")]
		[Address(RVA = "0x146AC5C", Offset = "0x146AC5C", VA = "0x146AC5C")]
		private void Update()
		{
		}

		[Token(Token = "0x60049D5")]
		[Address(RVA = "0x146AB10", Offset = "0x146AB10", VA = "0x146AB10")]
		private void SetState()
		{
		}

		[Token(Token = "0x60049D6")]
		[Address(RVA = "0x146B048", Offset = "0x146B048", VA = "0x146B048", Slot = "4")]
		public virtual void OnCollisionEnter2D(Collision2D collision)
		{
		}

		[Token(Token = "0x60049D7")]
		[Address(RVA = "0x146B0E4", Offset = "0x146B0E4", VA = "0x146B0E4")]
		public void StartPack()
		{
		}

		[Token(Token = "0x60049D8")]
		[Address(RVA = "0x146B17C", Offset = "0x146B17C", VA = "0x146B17C")]
		private IEnumerator DisableOverworldWithDelay()
		{
			return null;
		}

		[Token(Token = "0x60049D9")]
		[Address(RVA = "0x146B1D8", Offset = "0x146B1D8", VA = "0x146B1D8")]
		private void DisableInteraction()
		{
		}

		[Token(Token = "0x60049DA")]
		[Address(RVA = "0x146B254", Offset = "0x146B254", VA = "0x146B254")]
		private void EnableInteraction()
		{
		}

		[Token(Token = "0x60049DB")]
		[Address(RVA = "0x146B2AC", Offset = "0x146B2AC", VA = "0x146B2AC")]
		private WTGNotification GetNotification()
		{
			return default;
		}

		[Token(Token = "0x60049DC")]
		[Address(RVA = "0x146AD24", Offset = "0x146AD24", VA = "0x146AD24")]
		private bool IsCompleted()
		{
			return default;
		}

		[Token(Token = "0x60049DD")]
		[Address(RVA = "0x146B594", Offset = "0x146B594", VA = "0x146B594")]
		public static Task<bool> StartFlag(string packId)
		{
			return null;
		}

		[Token(Token = "0x60049DE")]
		[Address(RVA = "0x146B6A0", Offset = "0x146B6A0", VA = "0x146B6A0")]
		public FlagPackStarter()
		{
		}
	}
}
