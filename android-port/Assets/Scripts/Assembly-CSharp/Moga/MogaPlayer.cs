using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Core;
using Il2CppDummyDll;
using UnityEngine;

namespace Moga
{
	[Token(Token = "0x20010D2")]
	public class MogaPlayer : MogaEntity
	{
		[Token(Token = "0x20010D3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47B94", Offset = "0x47B94")]
		private sealed class _003CDelayDeath_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40058A1")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40058A2")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40058A3")]
			[FieldOffset(Offset = "0x20")]
			public MogaPlayer _003C_003E4__this;

			[Token(Token = "0x170007F4")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6004B5F")]
				[Address(RVA = "0x17F9154", Offset = "0x17F9154", VA = "0x17F9154", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170007F5")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6004B61")]
				[Address(RVA = "0x17F919C", Offset = "0x17F919C", VA = "0x17F919C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6004B5C")]
			[Address(RVA = "0x17F8FE4", Offset = "0x17F8FE4", VA = "0x17F8FE4")]
			[DebuggerHidden]
			public _003CDelayDeath_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6004B5D")]
			[Address(RVA = "0x17F9010", Offset = "0x17F9010", VA = "0x17F9010", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6004B5E")]
			[Address(RVA = "0x17F9014", Offset = "0x17F9014", VA = "0x17F9014", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6004B5F")]
			[Address(RVA = "0x17F9154", Offset = "0x17F9154", VA = "0x17F9154", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6004B60")]
			[Address(RVA = "0x17F915C", Offset = "0x17F915C", VA = "0x17F915C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6004B61")]
			[Address(RVA = "0x17F919C", Offset = "0x17F919C", VA = "0x17F919C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x400589D")]
		[FieldOffset(Offset = "0xBC")]
		public LayerMask DamageLayer;

		[Token(Token = "0x400589E")]
		[FieldOffset(Offset = "0xC0")]
		public float MinDamgeVelocity;

		[Token(Token = "0x400589F")]
		[FieldOffset(Offset = "0xC8")]
		private Rigidbody rigidbody;

		[Token(Token = "0x40058A0")]
		[FieldOffset(Offset = "0xD0")]
		private GolfBallController controller;

		[Token(Token = "0x6004B56")]
		[Address(RVA = "0x156C764", Offset = "0x156C764", VA = "0x156C764", Slot = "4")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6004B57")]
		[Address(RVA = "0x156C7F0", Offset = "0x156C7F0", VA = "0x156C7F0", Slot = "5")]
		protected override void SelectNewTarget()
		{
		}

		[Token(Token = "0x6004B58")]
		[Address(RVA = "0x156C7F4", Offset = "0x156C7F4", VA = "0x156C7F4", Slot = "6")]
		protected override void Die()
		{
		}

		[Token(Token = "0x6004B59")]
		[Address(RVA = "0x156C870", Offset = "0x156C870", VA = "0x156C870")]
		private IEnumerator DelayDeath()
		{
			return null;
		}

		[Token(Token = "0x6004B5A")]
		[Address(RVA = "0x156C8E4", Offset = "0x156C8E4", VA = "0x156C8E4")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6004B5B")]
		[Address(RVA = "0x156CA04", Offset = "0x156CA04", VA = "0x156CA04")]
		public MogaPlayer()
		{
		}
	}
}
