using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000049")]
	public class DragRigidbody : MonoBehaviour
	{
		[Token(Token = "0x200004A")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x331D4", Offset = "0x331D4")]
		private sealed class _003CDragObject_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400011C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x400011D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x400011E")]
			[FieldOffset(Offset = "0x20")]
			public DragRigidbody _003C_003E4__this;

			[Token(Token = "0x400011F")]
			[FieldOffset(Offset = "0x28")]
			public float distance;

			[Token(Token = "0x4000120")]
			[FieldOffset(Offset = "0x2C")]
			private float _003ColdDrag_003E5__2;

			[Token(Token = "0x4000121")]
			[FieldOffset(Offset = "0x30")]
			private float _003ColdAngularDrag_003E5__3;

			[Token(Token = "0x4000122")]
			[FieldOffset(Offset = "0x38")]
			private Camera _003CmainCamera_003E5__4;

			[Token(Token = "0x1700001F")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600012B")]
				[Address(RVA = "0x1339D28", Offset = "0x1339D28", VA = "0x1339D28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000020")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600012D")]
				[Address(RVA = "0x1339D70", Offset = "0x1339D70", VA = "0x1339D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000128")]
			[Address(RVA = "0x1339AB8", Offset = "0x1339AB8", VA = "0x1339AB8")]
			[DebuggerHidden]
			public _003CDragObject_003Ed__8(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000129")]
			[Address(RVA = "0x1339AE4", Offset = "0x1339AE4", VA = "0x1339AE4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1339AE8", Offset = "0x1339AE8", VA = "0x1339AE8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1339D28", Offset = "0x1339D28", VA = "0x1339D28", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600012C")]
			[Address(RVA = "0x1339D30", Offset = "0x1339D30", VA = "0x1339D30", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600012D")]
			[Address(RVA = "0x1339D70", Offset = "0x1339D70", VA = "0x1339D70", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000115")]
		private const float k_Spring = 50f;

		[Token(Token = "0x4000116")]
		private const float k_Damper = 5f;

		[Token(Token = "0x4000117")]
		private const float k_Drag = 10f;

		[Token(Token = "0x4000118")]
		private const float k_AngularDrag = 5f;

		[Token(Token = "0x4000119")]
		private const float k_Distance = 0.2f;

		[Token(Token = "0x400011A")]
		private const bool k_AttachToCenterOfMass = false;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x18")]
		private SpringJoint m_SpringJoint;

		[Token(Token = "0x6000124")]
		[Address(RVA = "0x13656C4", Offset = "0x13656C4", VA = "0x13656C4")]
		private void Update()
		{
		}

		[Token(Token = "0x6000125")]
		[Address(RVA = "0x1365B08", Offset = "0x1365B08", VA = "0x1365B08")]
		private IEnumerator DragObject(float distance)
		{
			return null;
		}

		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1365A50", Offset = "0x1365A50", VA = "0x1365A50")]
		private Camera FindCamera()
		{
			return null;
		}

		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1365B8C", Offset = "0x1365B8C", VA = "0x1365B8C")]
		public DragRigidbody()
		{
		}
	}
}
