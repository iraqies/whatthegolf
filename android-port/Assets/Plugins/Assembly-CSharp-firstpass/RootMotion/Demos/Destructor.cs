using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000231")]
	public class Destructor : MonoBehaviour
	{
		[Token(Token = "0x2000232")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33E64", Offset = "0x33E64")]
		private sealed class _003CDestruct_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E63")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000E64")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000E65")]
			[FieldOffset(Offset = "0x20")]
			public Destructor _003C_003E4__this;

			[Token(Token = "0x170001D1")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000ECF")]
				[Address(RVA = "0x1339A68", Offset = "0x1339A68", VA = "0x1339A68", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001D2")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000ED1")]
				[Address(RVA = "0x1339AB0", Offset = "0x1339AB0", VA = "0x1339AB0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000ECC")]
			[Address(RVA = "0x1339938", Offset = "0x1339938", VA = "0x1339938")]
			[DebuggerHidden]
			public _003CDestruct_003Ed__2(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000ECD")]
			[Address(RVA = "0x1339964", Offset = "0x1339964", VA = "0x1339964", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000ECE")]
			[Address(RVA = "0x1339968", Offset = "0x1339968", VA = "0x1339968", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000ECF")]
			[Address(RVA = "0x1339A68", Offset = "0x1339A68", VA = "0x1339A68", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000ED0")]
			[Address(RVA = "0x1339A70", Offset = "0x1339A70", VA = "0x1339A70", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000ED1")]
			[Address(RVA = "0x1339AB0", Offset = "0x1339AB0", VA = "0x1339AB0", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x18")]
		public float delay;

		[Token(Token = "0x6000EC9")]
		[Address(RVA = "0x1365544", Offset = "0x1365544", VA = "0x1365544")]
		private void Start()
		{
		}

		[Token(Token = "0x6000ECA")]
		[Address(RVA = "0x13655C0", Offset = "0x13655C0", VA = "0x13655C0")]
		private IEnumerator Destruct()
		{
			return null;
		}

		[Token(Token = "0x6000ECB")]
		[Address(RVA = "0x1365634", Offset = "0x1365634", VA = "0x1365634")]
		public Destructor()
		{
		}
	}
}
