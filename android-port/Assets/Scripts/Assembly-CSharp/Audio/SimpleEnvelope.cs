using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013AC")]
	public class SimpleEnvelope : BaseAudioValue
	{
		[Token(Token = "0x20013AD")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x48EDC", Offset = "0x48EDC")]
		private sealed class _003CEnvelopeCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40069F5")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40069F6")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40069F7")]
			[FieldOffset(Offset = "0x20")]
			public SimpleEnvelope _003C_003E4__this;

			[Token(Token = "0x40069F8")]
			[FieldOffset(Offset = "0x28")]
			private float _003CtimeInCurrentState_003E5__2;

			[Token(Token = "0x40069F9")]
			[FieldOffset(Offset = "0x2C")]
			private float _003Crange_003E5__3;

			[Token(Token = "0x17000A5D")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005BE5")]
				[Address(RVA = "0x184E1FC", Offset = "0x184E1FC", VA = "0x184E1FC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000A5E")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005BE7")]
				[Address(RVA = "0x184E244", Offset = "0x184E244", VA = "0x184E244", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005BE2")]
			[Address(RVA = "0x184E008", Offset = "0x184E008", VA = "0x184E008")]
			[DebuggerHidden]
			public _003CEnvelopeCoroutine_003Ed__13(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005BE3")]
			[Address(RVA = "0x184E034", Offset = "0x184E034", VA = "0x184E034", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005BE4")]
			[Address(RVA = "0x184E038", Offset = "0x184E038", VA = "0x184E038", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005BE5")]
			[Address(RVA = "0x184E1FC", Offset = "0x184E1FC", VA = "0x184E1FC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005BE6")]
			[Address(RVA = "0x184E204", Offset = "0x184E204", VA = "0x184E204", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005BE7")]
			[Address(RVA = "0x184E244", Offset = "0x184E244", VA = "0x184E244", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x40069ED")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public float attackTime;

		[Token(Token = "0x40069EE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		public float decayTime;

		[Token(Token = "0x40069EF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x5A98C", Offset = "0x5A98C")]
		public float sustainLevel;

		[Token(Token = "0x40069F0")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		public float sustainTime;

		[Token(Token = "0x40069F1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		public float releaseTime;

		[Token(Token = "0x40069F2")]
		[FieldOffset(Offset = "0x4C")]
		private float gain;

		[Token(Token = "0x40069F3")]
		[FieldOffset(Offset = "0x50")]
		private Coroutine envelopeRoutine;

		[Token(Token = "0x40069F4")]
		[FieldOffset(Offset = "0x58")]
		private ADSREnvelope.State envelopeState;

		[Token(Token = "0x17000A5C")]
		protected override bool Use2D
		{
			[Token(Token = "0x6005BDC")]
			[Address(RVA = "0x16AC75C", Offset = "0x16AC75C", VA = "0x16AC75C", Slot = "6")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6005BDD")]
		[Address(RVA = "0x16AC764", Offset = "0x16AC764", VA = "0x16AC764")]
		private void Update()
		{
		}

		[Token(Token = "0x6005BDE")]
		[Address(RVA = "0x16AC770", Offset = "0x16AC770", VA = "0x16AC770", Slot = "7")]
		protected override void SetValue()
		{
		}

		[Token(Token = "0x6005BDF")]
		[Address(RVA = "0x16AC780", Offset = "0x16AC780", VA = "0x16AC780")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x72708", Offset = "0x72708")]
		public void Trigger()
		{
		}

		[Token(Token = "0x6005BE0")]
		[Address(RVA = "0x16AC818", Offset = "0x16AC818", VA = "0x16AC818")]
		private IEnumerator EnvelopeCoroutine()
		{
			return null;
		}

		[Token(Token = "0x6005BE1")]
		[Address(RVA = "0x16AC88C", Offset = "0x16AC88C", VA = "0x16AC88C")]
		public SimpleEnvelope()
		{
		}
	}
}
