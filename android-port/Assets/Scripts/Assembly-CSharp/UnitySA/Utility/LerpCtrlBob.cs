using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;

namespace UnitySA.Utility
{
	[Serializable]
	[Token(Token = "0x2000F44")]
	public class LerpCtrlBob
	{
		[Token(Token = "0x2000F45")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x45914", Offset = "0x45914")]
		private sealed class _003CDoBobCycle_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4005280")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4005281")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4005282")]
			[FieldOffset(Offset = "0x20")]
			public LerpCtrlBob _003C_003E4__this;

			[Token(Token = "0x4005283")]
			[FieldOffset(Offset = "0x28")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x17000760")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004760")]
				[Address(RVA = "0x17D056C", Offset = "0x17D056C", VA = "0x17D056C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000761")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004762")]
				[Address(RVA = "0x17D05B4", Offset = "0x17D05B4", VA = "0x17D05B4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600475D")]
			[Address(RVA = "0x17D03B8", Offset = "0x17D03B8", VA = "0x17D03B8")]
			[DebuggerHidden]
			public _003CDoBobCycle_003Ed__4(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600475E")]
			[Address(RVA = "0x17D03E4", Offset = "0x17D03E4", VA = "0x17D03E4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600475F")]
			[Address(RVA = "0x17D03E8", Offset = "0x17D03E8", VA = "0x17D03E8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004760")]
			[Address(RVA = "0x17D056C", Offset = "0x17D056C", VA = "0x17D056C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004761")]
			[Address(RVA = "0x17D0574", Offset = "0x17D0574", VA = "0x17D0574", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004762")]
			[Address(RVA = "0x17D05B4", Offset = "0x17D05B4", VA = "0x17D05B4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400527D")]
		[FieldOffset(Offset = "0x10")]
		public float BobDuration;

		[Token(Token = "0x400527E")]
		[FieldOffset(Offset = "0x14")]
		public float BobAmount;

		[Token(Token = "0x400527F")]
		[FieldOffset(Offset = "0x18")]
		private float m_Offset;

		[Token(Token = "0x600475A")]
		[Address(RVA = "0x1522B88", Offset = "0x1522B88", VA = "0x1522B88")]
		public float Offset()
		{
			return default;
		}

		[Token(Token = "0x600475B")]
		[Address(RVA = "0x1522B90", Offset = "0x1522B90", VA = "0x1522B90")]
		public IEnumerator DoBobCycle()
		{
			return null;
		}

		[Token(Token = "0x600475C")]
		[Address(RVA = "0x1522C04", Offset = "0x1522C04", VA = "0x1522C04")]
		public LerpCtrlBob()
		{
		}
	}
}
