using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnityStandardAssets.Utility
{
	[Serializable]
	[Token(Token = "0x2000051")]
	public class LerpControlledBob
	{
		[Token(Token = "0x2000052")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3326C", Offset = "0x3326C")]
		private sealed class _003CDoBobCycle_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000147")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000148")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000149")]
			[FieldOffset(Offset = "0x20")]
			public LerpControlledBob _003C_003E4__this;

			[Token(Token = "0x400014A")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x17000025")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600014D")]
				[Address(RVA = "0x134F1A8", Offset = "0x134F1A8", VA = "0x134F1A8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000026")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600014F")]
				[Address(RVA = "0x134F1F0", Offset = "0x134F1F0", VA = "0x134F1F0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600014A")]
			[Address(RVA = "0x134EFF4", Offset = "0x134EFF4", VA = "0x134EFF4")]
			[DebuggerHidden]
			public _003CDoBobCycle_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600014B")]
			[Address(RVA = "0x134F020", Offset = "0x134F020", VA = "0x134F020", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600014C")]
			[Address(RVA = "0x134F024", Offset = "0x134F024", VA = "0x134F024", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600014D")]
			[Address(RVA = "0x134F1A8", Offset = "0x134F1A8", VA = "0x134F1A8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600014E")]
			[Address(RVA = "0x134F1B0", Offset = "0x134F1B0", VA = "0x134F1B0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600014F")]
			[Address(RVA = "0x134F1F0", Offset = "0x134F1F0", VA = "0x134F1F0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x6000147")]
		[Address(RVA = "0x13A877C", Offset = "0x13A877C", VA = "0x13A877C")]
		public float Offset()
		{
			return default;
		}

		[Token(Token = "0x6000148")]
		[Address(RVA = "0x13A8784", Offset = "0x13A8784", VA = "0x13A8784")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x6000149")]
		[Address(RVA = "0x13A87F8", Offset = "0x13A87F8", VA = "0x13A87F8")]
		public LerpControlledBob()
		{
		}
	}
}
