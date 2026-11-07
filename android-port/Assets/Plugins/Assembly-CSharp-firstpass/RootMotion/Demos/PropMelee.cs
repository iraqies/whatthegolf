using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200023E")]
	public class PropMelee : Prop
	{
		[Token(Token = "0x200023F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33F64", Offset = "0x33F64")]
		private sealed class _003CAction_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000EA9")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000EAA")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000EAB")]
			[FieldOffset(Offset = "0x20")]
			public PropMelee _003C_003E4__this;

			[Token(Token = "0x4000EAC")]
			[FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x4000EAD")]
			[FieldOffset(Offset = "0x2C")]
			private int _003CadditionalPinMuscleIndex_003E5__2;

			[Token(Token = "0x170001D9")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000F06")]
				[Address(RVA = "0x13522D0", Offset = "0x13522D0", VA = "0x13522D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001DA")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000F08")]
				[Address(RVA = "0x1352318", Offset = "0x1352318", VA = "0x1352318", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000F03")]
			[Address(RVA = "0x1352060", Offset = "0x1352060", VA = "0x1352060")]
			[DebuggerHidden]
			public _003CAction_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000F04")]
			[Address(RVA = "0x135208C", Offset = "0x135208C", VA = "0x135208C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000F05")]
			[Address(RVA = "0x1352090", Offset = "0x1352090", VA = "0x1352090", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000F06")]
			[Address(RVA = "0x13522D0", Offset = "0x13522D0", VA = "0x13522D0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000F07")]
			[Address(RVA = "0x13522D8", Offset = "0x13522D8", VA = "0x13522D8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000F08")]
			[Address(RVA = "0x1352318", Offset = "0x1352318", VA = "0x1352318", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000E9F")]
		[FieldOffset(Offset = "0x90")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000EA0")]
		[FieldOffset(Offset = "0x98")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000EA1")]
		[FieldOffset(Offset = "0xA0")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000EA2")]
		[FieldOffset(Offset = "0xA4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36D68", Offset = "0x36D68")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0xA8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36D80", Offset = "0x36D80")]
		public float actionMassMlp;

		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0xAC")]
		public Vector3 COMOffset;

		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0xB8")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000EA6")]
		[FieldOffset(Offset = "0xBC")]
		private float defaultMass;

		[Token(Token = "0x4000EA7")]
		[FieldOffset(Offset = "0xC0")]
		private float defaultAddMass;

		[Token(Token = "0x4000EA8")]
		[FieldOffset(Offset = "0xC8")]
		private Rigidbody r;

		[Token(Token = "0x6000EFD")]
		[Address(RVA = "0x13C1B7C", Offset = "0x13C1B7C", VA = "0x13C1B7C")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x6000EFE")]
		[Address(RVA = "0x13C1C10", Offset = "0x13C1C10", VA = "0x13C1C10")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000EFF")]
		[Address(RVA = "0x13C1C94", Offset = "0x13C1C94", VA = "0x13C1C94", Slot = "6")]
		protected override void OnStart()
		{
		}

		[Token(Token = "0x6000F00")]
		[Address(RVA = "0x13C1D48", Offset = "0x13C1D48", VA = "0x13C1D48", Slot = "4")]
		protected override void OnPickUp(PropRoot propRoot)
		{
		}

		[Token(Token = "0x6000F01")]
		[Address(RVA = "0x13C1DC0", Offset = "0x13C1DC0", VA = "0x13C1DC0", Slot = "5")]
		protected override void OnDrop()
		{
		}

		[Token(Token = "0x6000F02")]
		[Address(RVA = "0x13C1E38", Offset = "0x13C1E38", VA = "0x13C1E38")]
		public PropMelee()
		{
		}
	}
}
