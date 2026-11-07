using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace PersistentData
{
	[Token(Token = "0x2001031")]
	public static class PersistentStoryDataStorage
	{
		[Token(Token = "0x2001032")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x475D4", Offset = "0x475D4")]
		private sealed class _003C_003Ec__DisplayClass2_0
		{
			[Token(Token = "0x400555C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public string path;

			[Token(Token = "0x400555D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public string json;

			[Token(Token = "0x6004885")]
			[Address(RVA = "0x1823A4C", Offset = "0x1823A4C", VA = "0x1823A4C")]
			public _003C_003Ec__DisplayClass2_0()
			{
			}

			[Token(Token = "0x6004886")]
			[Address(RVA = "0x1823A54", Offset = "0x1823A54", VA = "0x1823A54")]
			internal void _003CSaveStory_003Eb__0()
			{
			}
		}

		[Token(Token = "0x2001033")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x475E4", Offset = "0x475E4")]
		private sealed class _003CSaveStory_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400555E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400555F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005560")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PersistentStoryData data;

			[Token(Token = "0x4005561")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public Action doneSavingCallBack;

			[Token(Token = "0x4005562")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private Thread _003Ct_003E5__2;

			[Token(Token = "0x170007AB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600488A")]
				[Address(RVA = "0x1823E4C", Offset = "0x1823E4C", VA = "0x1823E4C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007AC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600488C")]
				[Address(RVA = "0x1823E94", Offset = "0x1823E94", VA = "0x1823E94", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004887")]
			[Address(RVA = "0x1823C14", Offset = "0x1823C14", VA = "0x1823C14")]
			[DebuggerHidden]
			public _003CSaveStory_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004888")]
			[Address(RVA = "0x1823C40", Offset = "0x1823C40", VA = "0x1823C40", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004889")]
			[Address(RVA = "0x1823C44", Offset = "0x1823C44", VA = "0x1823C44", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600488A")]
			[Address(RVA = "0x1823E4C", Offset = "0x1823E4C", VA = "0x1823E4C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600488B")]
			[Address(RVA = "0x1823E54", Offset = "0x1823E54", VA = "0x1823E54", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600488C")]
			[Address(RVA = "0x1823E94", Offset = "0x1823E94", VA = "0x1823E94", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x6004883")]
		[Address(RVA = "0x15DF75C", Offset = "0x15DF75C", VA = "0x15DF75C")]
		public static bool LoadStory(int storyID, out PersistentStoryData data)
		{
			return default;
		}

		[Token(Token = "0x6004884")]
		[Address(RVA = "0x15DFD30", Offset = "0x15DFD30", VA = "0x15DFD30")]
		public static IEnumerator SaveStory(PersistentStoryData data, [Optional] Action doneSavingCallBack)
		{
			return null;
		}
	}
}
