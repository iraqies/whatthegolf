using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace WhatTheGolf.LevelDesigner
{
	[Token(Token = "0x200125D")]
	public static class ClientServerUtil
	{
		[Token(Token = "0x200125E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48654", Offset = "0x48654")]
		private sealed class _003CPostPlayer_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ulong playerId;

			[Token(Token = "0x40062DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool> result;

			[Token(Token = "0x17000991")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60054D5")]
				[Address(RVA = "0x1788C9C", Offset = "0x1788C9C", VA = "0x1788C9C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000992")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60054D7")]
				[Address(RVA = "0x1788CE4", Offset = "0x1788CE4", VA = "0x1788CE4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60054D2")]
			[Address(RVA = "0x1788AE4", Offset = "0x1788AE4", VA = "0x1788AE4")]
			[DebuggerHidden]
			public _003CPostPlayer_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60054D3")]
			[Address(RVA = "0x1788B10", Offset = "0x1788B10", VA = "0x1788B10", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60054D4")]
			[Address(RVA = "0x1788B14", Offset = "0x1788B14", VA = "0x1788B14", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60054D5")]
			[Address(RVA = "0x1788C9C", Offset = "0x1788C9C", VA = "0x1788C9C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60054D6")]
			[Address(RVA = "0x1788CA4", Offset = "0x1788CA4", VA = "0x1788CA4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60054D7")]
			[Address(RVA = "0x1788CE4", Offset = "0x1788CE4", VA = "0x1788CE4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200125F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48664", Offset = "0x48664")]
		private sealed class _003CPostPlay_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public ulong playerId;

			[Token(Token = "0x40062E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Guid levelId;

			[Token(Token = "0x40062E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<bool> result;

			[Token(Token = "0x17000993")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60054DB")]
				[Address(RVA = "0x1788A94", Offset = "0x1788A94", VA = "0x1788A94", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000994")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60054DD")]
				[Address(RVA = "0x1788ADC", Offset = "0x1788ADC", VA = "0x1788ADC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60054D8")]
			[Address(RVA = "0x17887D8", Offset = "0x17887D8", VA = "0x17887D8")]
			[DebuggerHidden]
			public _003CPostPlay_003Ed__3(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60054D9")]
			[Address(RVA = "0x1788804", Offset = "0x1788804", VA = "0x1788804", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60054DA")]
			[Address(RVA = "0x1788808", Offset = "0x1788808", VA = "0x1788808", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60054DB")]
			[Address(RVA = "0x1788A94", Offset = "0x1788A94", VA = "0x1788A94", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60054DC")]
			[Address(RVA = "0x1788A9C", Offset = "0x1788A9C", VA = "0x1788A9C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60054DD")]
			[Address(RVA = "0x1788ADC", Offset = "0x1788ADC", VA = "0x1788ADC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001260")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48674", Offset = "0x48674")]
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			[Token(Token = "0x40062E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Action<bool, SerializableLevelData[]> result;

			[Token(Token = "0x60054DE")]
			[Address(RVA = "0x1787D68", Offset = "0x1787D68", VA = "0x1787D68")]
			public _003C_003Ec__DisplayClass4_0()
			{
			}

			[Token(Token = "0x60054DF")]
			[Address(RVA = "0x1787D70", Offset = "0x1787D70", VA = "0x1787D70")]
			internal void _003CGetLevels_003Eb__0(bool e, string s)
			{
			}
		}

		[Serializable]
		[Token(Token = "0x2001261")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48684", Offset = "0x48684")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40062E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40062E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public static Func<CloudLevelData, SerializableLevelData> _003C_003E9__4_1;

			[Token(Token = "0x60054E1")]
			[Address(RVA = "0x1787D48", Offset = "0x1787D48", VA = "0x1787D48")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60054E2")]
			[Address(RVA = "0x1787D50", Offset = "0x1787D50", VA = "0x1787D50")]
			internal SerializableLevelData _003CGetLevels_003Eb__4_1(CloudLevelData x)
			{
				return null;
			}
		}

		[Token(Token = "0x2001262")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48694", Offset = "0x48694")]
		private sealed class _003CGetLevels_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public Action<bool, SerializableLevelData[]> result;

			[Token(Token = "0x40062EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string query;

			[Token(Token = "0x17000995")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60054E6")]
				[Address(RVA = "0x17882EC", Offset = "0x17882EC", VA = "0x17882EC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000996")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60054E8")]
				[Address(RVA = "0x1788334", Offset = "0x1788334", VA = "0x1788334", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60054E3")]
			[Address(RVA = "0x1788178", Offset = "0x1788178", VA = "0x1788178")]
			[DebuggerHidden]
			public _003CGetLevels_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60054E4")]
			[Address(RVA = "0x17881A4", Offset = "0x17881A4", VA = "0x17881A4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60054E5")]
			[Address(RVA = "0x17881A8", Offset = "0x17881A8", VA = "0x17881A8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60054E6")]
			[Address(RVA = "0x17882EC", Offset = "0x17882EC", VA = "0x17882EC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60054E7")]
			[Address(RVA = "0x17882F4", Offset = "0x17882F4", VA = "0x17882F4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60054E8")]
			[Address(RVA = "0x1788334", Offset = "0x1788334", VA = "0x1788334", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001263")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x486A4", Offset = "0x486A4")]
		private sealed class _003CPostLevel_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062EC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062ED")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public SerializableLevelData levelData;

			[Token(Token = "0x40062EE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool> result;

			[Token(Token = "0x40062EF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public ulong playerId;

			[Token(Token = "0x17000997")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60054EC")]
				[Address(RVA = "0x1788788", Offset = "0x1788788", VA = "0x1788788", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000998")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60054EE")]
				[Address(RVA = "0x17887D0", Offset = "0x17887D0", VA = "0x17887D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60054E9")]
			[Address(RVA = "0x17885DC", Offset = "0x17885DC", VA = "0x17885DC")]
			[DebuggerHidden]
			public _003CPostLevel_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60054EA")]
			[Address(RVA = "0x1788608", Offset = "0x1788608", VA = "0x1788608", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60054EB")]
			[Address(RVA = "0x178860C", Offset = "0x178860C", VA = "0x178860C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60054EC")]
			[Address(RVA = "0x1788788", Offset = "0x1788788", VA = "0x1788788", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60054ED")]
			[Address(RVA = "0x1788790", Offset = "0x1788790", VA = "0x1788790", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60054EE")]
			[Address(RVA = "0x17887D0", Offset = "0x17887D0", VA = "0x17887D0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001264")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x486B4", Offset = "0x486B4")]
		private sealed class _003CGet_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062F0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string query;

			[Token(Token = "0x40062F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action<bool, string> result;

			[Token(Token = "0x40062F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x17000999")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60054F2")]
				[Address(RVA = "0x1788128", Offset = "0x1788128", VA = "0x1788128", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700099A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60054F4")]
				[Address(RVA = "0x1788170", Offset = "0x1788170", VA = "0x1788170", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60054EF")]
			[Address(RVA = "0x1787F6C", Offset = "0x1787F6C", VA = "0x1787F6C")]
			[DebuggerHidden]
			public _003CGet_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60054F0")]
			[Address(RVA = "0x1787F98", Offset = "0x1787F98", VA = "0x1787F98", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60054F1")]
			[Address(RVA = "0x1787F9C", Offset = "0x1787F9C", VA = "0x1787F9C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60054F2")]
			[Address(RVA = "0x1788128", Offset = "0x1788128", VA = "0x1788128", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60054F3")]
			[Address(RVA = "0x1788130", Offset = "0x1788130", VA = "0x1788130", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60054F4")]
			[Address(RVA = "0x1788170", Offset = "0x1788170", VA = "0x1788170", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2001265")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x486C4", Offset = "0x486C4")]
		private sealed class _003CPost_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40062F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40062F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40062F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public string directory;

			[Token(Token = "0x40062F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public string body;

			[Token(Token = "0x40062F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public (string, string)[] headers;

			[Token(Token = "0x40062FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Action<bool> result;

			[Token(Token = "0x40062FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private UnityWebRequest _003Cwww_003E5__2;

			[Token(Token = "0x1700099B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x60054F8")]
				[Address(RVA = "0x178858C", Offset = "0x178858C", VA = "0x178858C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700099C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60054FA")]
				[Address(RVA = "0x17885D4", Offset = "0x17885D4", VA = "0x17885D4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x60054F5")]
			[Address(RVA = "0x178833C", Offset = "0x178833C", VA = "0x178833C")]
			[DebuggerHidden]
			public _003CPost_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x60054F6")]
			[Address(RVA = "0x1788368", Offset = "0x1788368", VA = "0x1788368", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x60054F7")]
			[Address(RVA = "0x178836C", Offset = "0x178836C", VA = "0x178836C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x60054F8")]
			[Address(RVA = "0x178858C", Offset = "0x178858C", VA = "0x178858C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x60054F9")]
			[Address(RVA = "0x1788594", Offset = "0x1788594", VA = "0x1788594", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x60054FA")]
			[Address(RVA = "0x17885D4", Offset = "0x17885D4", VA = "0x17885D4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40062DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static StringBuilder s_JsonBuilder;

		[Token(Token = "0x60054C8")]
		[Address(RVA = "0x189FF34", Offset = "0x189FF34", VA = "0x189FF34")]
		public static IEnumerator PostPlayer(ulong playerId, Action<bool> result)
		{
			return null;
		}

		[Token(Token = "0x60054C9")]
		[Address(RVA = "0x189FFAC", Offset = "0x189FFAC", VA = "0x189FFAC")]
		public static IEnumerator PostPlay(ulong playerId, Guid levelId, [Optional] Action<bool> result)
		{
			return null;
		}

		[Token(Token = "0x60054CA")]
		[Address(RVA = "0x18A0038", Offset = "0x18A0038", VA = "0x18A0038")]
		public static IEnumerator GetLevels(string query, Action<bool, SerializableLevelData[]> result)
		{
			return null;
		}

		[Token(Token = "0x60054CB")]
		[Address(RVA = "0x18A00B0", Offset = "0x18A00B0", VA = "0x18A00B0")]
		public static IEnumerator PostLevel(ulong playerId, SerializableLevelData levelData, Action<bool> result)
		{
			return null;
		}

		[Token(Token = "0x60054CC")]
		[Address(RVA = "0x18A0138", Offset = "0x18A0138", VA = "0x18A0138")]
		private static IEnumerator Get(string query, Action<bool, string> result, [Optional] (string, string)[] headers)
		{
			return null;
		}

		[Token(Token = "0x60054CD")]
		[Address(RVA = "0x18A01B0", Offset = "0x18A01B0", VA = "0x18A01B0")]
		private static IEnumerator Post(string directory, string body, Action<bool> result, [Optional] (string, string)[] headers)
		{
			return null;
		}

		[Token(Token = "0x60054CE")]
		[Address(RVA = "0x18A023C", Offset = "0x18A023C", VA = "0x18A023C")]
		private static void SetHeaders(ref UnityWebRequest www, (string, string)[] headers)
		{
		}

		[Token(Token = "0x60054CF")]
		[Address(RVA = "0x18A0314", Offset = "0x18A0314", VA = "0x18A0314")]
		public static void WrapJsonContainer(ref string json)
		{
		}

		[Token(Token = "0x60054D0")]
		[Address(RVA = "0x18A0488", Offset = "0x18A0488", VA = "0x18A0488")]
		private static void ValidateRequest(UnityWebRequest www, out bool isError)
		{
		}
	}
}
