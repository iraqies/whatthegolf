using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000210")]
	public class ResetInteractionObject : MonoBehaviour
	{
		[Token(Token = "0x2000211")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33D34", Offset = "0x33D34")]
		private sealed class _003CResetObject_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000DD4")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000DD5")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000DD6")]
			[FieldOffset(Offset = "0x20")]
			public float resetTime;

			[Token(Token = "0x4000DD7")]
			[FieldOffset(Offset = "0x28")]
			public ResetInteractionObject _003C_003E4__this;

			[Token(Token = "0x170001C2")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000E4C")]
				[Address(RVA = "0x135520C", Offset = "0x135520C", VA = "0x135520C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001C3")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000E4E")]
				[Address(RVA = "0x1355254", Offset = "0x1355254", VA = "0x1355254", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000E49")]
			[Address(RVA = "0x135502C", Offset = "0x135502C", VA = "0x135502C")]
			[DebuggerHidden]
			public _003CResetObject_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000E4A")]
			[Address(RVA = "0x1355058", Offset = "0x1355058", VA = "0x1355058", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000E4B")]
			[Address(RVA = "0x135505C", Offset = "0x135505C", VA = "0x135505C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000E4C")]
			[Address(RVA = "0x135520C", Offset = "0x135520C", VA = "0x135520C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000E4D")]
			[Address(RVA = "0x1355214", Offset = "0x1355214", VA = "0x1355214", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000E4E")]
			[Address(RVA = "0x1355254", Offset = "0x1355254", VA = "0x1355254", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000DCF")]
		[FieldOffset(Offset = "0x18")]
		public float resetDelay;

		[Token(Token = "0x4000DD0")]
		[FieldOffset(Offset = "0x1C")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000DD1")]
		[FieldOffset(Offset = "0x28")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000DD2")]
		[FieldOffset(Offset = "0x38")]
		private Transform defaultParent;

		[Token(Token = "0x4000DD3")]
		[FieldOffset(Offset = "0x40")]
		private Rigidbody r;

		[Token(Token = "0x6000E45")]
		[Address(RVA = "0x13DBCA0", Offset = "0x13DBCA0", VA = "0x13DBCA0")]
		private void Start()
		{
		}

		[Token(Token = "0x6000E46")]
		[Address(RVA = "0x13DBD54", Offset = "0x13DBD54", VA = "0x13DBD54")]
		private void OnPickUp(Transform t)
		{
		}

		[Token(Token = "0x6000E47")]
		[Address(RVA = "0x13DBDF8", Offset = "0x13DBDF8", VA = "0x13DBDF8")]
		private IEnumerator ResetObject(float resetTime)
		{
			return null;
		}

		[Token(Token = "0x6000E48")]
		[Address(RVA = "0x13DBE7C", Offset = "0x13DBE7C", VA = "0x13DBE7C")]
		public ResetInteractionObject()
		{
		}
	}
}
