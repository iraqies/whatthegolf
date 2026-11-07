using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Rewired
{
	[Token(Token = "0x2000117")]
	public struct PlayerSaveData
	{
		[Token(Token = "0x2000118")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x190CC0", Offset = "0x190CC0")]
		private sealed class jcmfcfDmEPriidrjNuUCBHvqGqh : IDisposable, IEnumerable, IEnumerator, IEnumerable<ControllerMapSaveData>, IEnumerator<ControllerMapSaveData>
		{
			[Token(Token = "0x400065E")]
			[FieldOffset(Offset = "0x10")]
			private int RxAoyfYzYDsYonLGXsvUgwChukLk;

			[Token(Token = "0x400065F")]
			[FieldOffset(Offset = "0x18")]
			private ControllerMapSaveData VqEePGSMyrGKIqkWibsjeHcWPSIx;

			[Token(Token = "0x4000660")]
			[FieldOffset(Offset = "0x20")]
			private int wLBvvzlDcbAEPyDfgnprolEZBsgN;

			[Token(Token = "0x4000661")]
			[FieldOffset(Offset = "0x28")]
			public PlayerSaveData TtytLoUfsgUyhsklaKccrnoMiiek;

			[Token(Token = "0x4000662")]
			[FieldOffset(Offset = "0x50")]
			public PlayerSaveData VcegqUFyBwMOmouaOvBMcbuTaLUj;

			[Token(Token = "0x4000663")]
			[FieldOffset(Offset = "0x78")]
			private int hWZNbLCFLBBWXNZxiKeGtzgrnTsg;

			[Token(Token = "0x17000286")]
			private ControllerMapSaveData System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerMapSaveData_003E_002ECurrent
			{
				[Token(Token = "0x600081D")]
				[Address(RVA = "0x238E5EC", Offset = "0x238E5EC", VA = "0x238E5EC", Slot = "10")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerMapSaveData_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000287")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600081F")]
				[Address(RVA = "0x238E634", Offset = "0x238E634", VA = "0x238E634", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x238E3A8", Offset = "0x238E3A8", VA = "0x238E3A8")]
			[DebuggerHidden]
			public jcmfcfDmEPriidrjNuUCBHvqGqh(int P_0)
			{
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x238E3F0", Offset = "0x238E3F0", VA = "0x238E3F0", Slot = "4")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x238E3F4", Offset = "0x238E3F4", VA = "0x238E3F4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x238E5EC", Offset = "0x238E5EC", VA = "0x238E5EC", Slot = "10")]
			[DebuggerHidden]
			private ControllerMapSaveData System_002ECollections_002EGeneric_002EIEnumerator_003CRewired_002EControllerMapSaveData_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x238E5F4", Offset = "0x238E5F4", VA = "0x238E5F4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x238E634", Offset = "0x238E634", VA = "0x238E634", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x238E63C", Offset = "0x238E63C", VA = "0x238E63C", Slot = "9")]
			[DebuggerHidden]
			private IEnumerator<ControllerMapSaveData> System_002ECollections_002EGeneric_002EIEnumerable_003CRewired_002EControllerMapSaveData_003E_002EGetEnumerator()
			{
				return null;
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x238E708", Offset = "0x238E708", VA = "0x238E708", Slot = "5")]
			[DebuggerHidden]
			private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
			{
				return null;
			}
		}

		[Token(Token = "0x4000659")]
		[FieldOffset(Offset = "0x0")]
		private JoystickMapSaveData[] fGkhnrZreVfsKFkiCBwgRXmLffZiA;

		[Token(Token = "0x400065A")]
		[FieldOffset(Offset = "0x8")]
		private KeyboardMapSaveData[] TESySTzsPCYrvnwodhrZwdEFNbzg;

		[Token(Token = "0x400065B")]
		[FieldOffset(Offset = "0x10")]
		private MouseMapSaveData[] zgHsiOSBqkgENsUtnonHsDhuLFRL;

		[Token(Token = "0x400065C")]
		[FieldOffset(Offset = "0x18")]
		private CustomControllerMapSaveData[] bRUJjStNLhfhdGxPTIWVqbPOYlxI;

		[Token(Token = "0x400065D")]
		[FieldOffset(Offset = "0x20")]
		private InputBehavior[] KMKAZUaApKfvqwOoRgPVXZKcQJvw;

		[Token(Token = "0x17000284")]
		public InputBehavior[] inputBehaviors
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x23FE8C8", Offset = "0x23FE8C8", VA = "0x23FE8C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000285")]
		public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x23FE8D0", Offset = "0x23FE8D0", VA = "0x23FE8D0")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000819")]
		[Address(RVA = "0x23FE950", Offset = "0x23FE950", VA = "0x23FE950")]
		internal PlayerSaveData(JoystickMapSaveData[] P_0, KeyboardMapSaveData[] P_1, MouseMapSaveData[] P_2, CustomControllerMapSaveData[] P_3, IList<InputBehavior> P_4)
		{
		}
	}
}
