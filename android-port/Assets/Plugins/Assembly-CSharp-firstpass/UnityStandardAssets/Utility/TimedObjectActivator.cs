using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x200005B")]
	public class TimedObjectActivator : MonoBehaviour
	{
		[Token(Token = "0x200005C")]
		public enum Action
		{
			[Token(Token = "0x4000174")]
			Activate = 0,
			[Token(Token = "0x4000175")]
			Deactivate = 1,
			[Token(Token = "0x4000176")]
			Destroy = 2,
			[Token(Token = "0x4000177")]
			ReloadLevel = 3,
			[Token(Token = "0x4000178")]
			Call = 4
		}

		[Serializable]
		[Token(Token = "0x200005D")]
		public class Entry
		{
			[Token(Token = "0x4000179")]
			[FieldOffset(Offset = "0x10")]
			public GameObject target;

			[Token(Token = "0x400017A")]
			[FieldOffset(Offset = "0x18")]
			public Action action;

			[Token(Token = "0x400017B")]
			[FieldOffset(Offset = "0x1C")]
			public float delay;

			[Token(Token = "0x6000171")]
			[Address(RVA = "0x1356ED0", Offset = "0x1356ED0", VA = "0x1356ED0")]
			public Entry()
			{
			}
		}

		[Serializable]
		[Token(Token = "0x200005E")]
		public class Entries
		{
			[Token(Token = "0x400017C")]
			[FieldOffset(Offset = "0x10")]
			public Entry[] entries;

			[Token(Token = "0x6000172")]
			[Address(RVA = "0x1356EC8", Offset = "0x1356EC8", VA = "0x1356EC8")]
			public Entries()
			{
			}
		}

		[Token(Token = "0x200005F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3329C", Offset = "0x3329C")]
		private sealed class _003CActivate_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400017D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400017E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400017F")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700002B")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000176")]
				[Address(RVA = "0x1356B98", Offset = "0x1356B98", VA = "0x1356B98", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700002C")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000178")]
				[Address(RVA = "0x1356BE0", Offset = "0x1356BE0", VA = "0x1356BE0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000173")]
			[Address(RVA = "0x1356A98", Offset = "0x1356A98", VA = "0x1356A98")]
			[DebuggerHidden]
			public _003CActivate_003Ed__5(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000174")]
			[Address(RVA = "0x1356AC4", Offset = "0x1356AC4", VA = "0x1356AC4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000175")]
			[Address(RVA = "0x1356AC8", Offset = "0x1356AC8", VA = "0x1356AC8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000176")]
			[Address(RVA = "0x1356B98", Offset = "0x1356B98", VA = "0x1356B98", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000177")]
			[Address(RVA = "0x1356BA0", Offset = "0x1356BA0", VA = "0x1356BA0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000178")]
			[Address(RVA = "0x1356BE0", Offset = "0x1356BE0", VA = "0x1356BE0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000060")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x332AC", Offset = "0x332AC")]
		private sealed class _003CDeactivate_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000180")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000181")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000182")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700002D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600017C")]
				[Address(RVA = "0x1356CE8", Offset = "0x1356CE8", VA = "0x1356CE8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700002E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600017E")]
				[Address(RVA = "0x1356D30", Offset = "0x1356D30", VA = "0x1356D30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000179")]
			[Address(RVA = "0x1356BE8", Offset = "0x1356BE8", VA = "0x1356BE8")]
			[DebuggerHidden]
			public _003CDeactivate_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600017A")]
			[Address(RVA = "0x1356C14", Offset = "0x1356C14", VA = "0x1356C14", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600017B")]
			[Address(RVA = "0x1356C18", Offset = "0x1356C18", VA = "0x1356C18", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600017C")]
			[Address(RVA = "0x1356CE8", Offset = "0x1356CE8", VA = "0x1356CE8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600017D")]
			[Address(RVA = "0x1356CF0", Offset = "0x1356CF0", VA = "0x1356CF0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600017E")]
			[Address(RVA = "0x1356D30", Offset = "0x1356D30", VA = "0x1356D30", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000061")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x332BC", Offset = "0x332BC")]
		private sealed class _003CReloadLevel_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000183")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000184")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000185")]
			[FieldOffset(Offset = "0x20")]
			public Entry entry;

			[Token(Token = "0x1700002F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000182")]
				[Address(RVA = "0x1356E78", Offset = "0x1356E78", VA = "0x1356E78", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000030")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000184")]
				[Address(RVA = "0x1356EC0", Offset = "0x1356EC0", VA = "0x1356EC0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600017F")]
			[Address(RVA = "0x1356D38", Offset = "0x1356D38", VA = "0x1356D38")]
			[DebuggerHidden]
			public _003CReloadLevel_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000180")]
			[Address(RVA = "0x1356D64", Offset = "0x1356D64", VA = "0x1356D64", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000181")]
			[Address(RVA = "0x1356D68", Offset = "0x1356D68", VA = "0x1356D68", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000182")]
			[Address(RVA = "0x1356E78", Offset = "0x1356E78", VA = "0x1356E78", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000183")]
			[Address(RVA = "0x1356E80", Offset = "0x1356E80", VA = "0x1356E80", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000184")]
			[Address(RVA = "0x1356EC0", Offset = "0x1356EC0", VA = "0x1356EC0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x18")]
		public Entries entries;

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x131B07C", Offset = "0x131B07C", VA = "0x131B07C")]
		private void Awake()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x131B2A0", Offset = "0x131B2A0", VA = "0x131B2A0")]
		private IEnumerator Activate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600016E")]
		[Address(RVA = "0x131B314", Offset = "0x131B314", VA = "0x131B314")]
		private IEnumerator Deactivate(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x600016F")]
		[Address(RVA = "0x131B388", Offset = "0x131B388", VA = "0x131B388")]
		private IEnumerator ReloadLevel(Entry entry)
		{
			return null;
		}

		[Token(Token = "0x6000170")]
		[Address(RVA = "0x131B3FC", Offset = "0x131B3FC", VA = "0x131B3FC")]
		public TimedObjectActivator()
		{
		}
	}
}
