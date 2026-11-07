using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace DanceOff
{
	[Token(Token = "0x20011EF")]
	public class BeatFighterDancer : Dancer
	{
		[Token(Token = "0x20011F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x483F4", Offset = "0x483F4")]
		private sealed class _003CDanceCoroutine_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400607F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006080")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006081")]
			[FieldOffset(Offset = "0x20")]
			public BeatFighterDancer _003C_003E4__this;

			[Token(Token = "0x4006082")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 dir;

			[Token(Token = "0x17000909")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600526C")]
				[Address(RVA = "0x1772188", Offset = "0x1772188", VA = "0x1772188", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700090A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600526E")]
				[Address(RVA = "0x17721D0", Offset = "0x17721D0", VA = "0x17721D0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005269")]
			[Address(RVA = "0x1772064", Offset = "0x1772064", VA = "0x1772064")]
			[DebuggerHidden]
			public _003CDanceCoroutine_003Ed__6(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600526A")]
			[Address(RVA = "0x1772090", Offset = "0x1772090", VA = "0x1772090", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600526B")]
			[Address(RVA = "0x1772094", Offset = "0x1772094", VA = "0x1772094", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600526C")]
			[Address(RVA = "0x1772188", Offset = "0x1772188", VA = "0x1772188", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600526D")]
			[Address(RVA = "0x1772190", Offset = "0x1772190", VA = "0x1772190", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600526E")]
			[Address(RVA = "0x17721D0", Offset = "0x17721D0", VA = "0x17721D0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400607C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator animator;

		[Token(Token = "0x400607D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float minDelay;

		[Token(Token = "0x400607E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float maxDelay;

		[Token(Token = "0x6005263")]
		[Address(RVA = "0x160CD98", Offset = "0x160CD98", VA = "0x160CD98")]
		private string DirToAnimation(Vector2 dir)
		{
			return null;
		}

		[Token(Token = "0x6005264")]
		[Address(RVA = "0x160CF08", Offset = "0x160CF08", VA = "0x160CF08")]
		private void Start()
		{
		}

		[Token(Token = "0x6005265")]
		[Address(RVA = "0x160CF54", Offset = "0x160CF54", VA = "0x160CF54", Slot = "4")]
		public override void Dance(Vector2 dir)
		{
		}

		[Token(Token = "0x6005266")]
		[Address(RVA = "0x160CFE8", Offset = "0x160CFE8", VA = "0x160CFE8")]
		private IEnumerator DanceCoroutine(Vector3 dir)
		{
			return null;
		}

		[Token(Token = "0x6005267")]
		[Address(RVA = "0x160D080", Offset = "0x160D080", VA = "0x160D080", Slot = "5")]
		public override void Fail(Vector2 dir)
		{
		}

		[Token(Token = "0x6005268")]
		[Address(RVA = "0x160D084", Offset = "0x160D084", VA = "0x160D084")]
		public BeatFighterDancer()
		{
		}
	}
}
