using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000242")]
	public class PuppetMasterPropMelee : PuppetMasterProp
	{
		[Token(Token = "0x2000243")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33F74", Offset = "0x33F74")]
		private sealed class _003CAction_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000EBE")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000EBF")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000EC0")]
			[FieldOffset(Offset = "0x20")]
			public PuppetMasterPropMelee _003C_003E4__this;

			[Token(Token = "0x4000EC1")]
			[FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x170001DB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000F17")]
				[Address(RVA = "0x1353D2C", Offset = "0x1353D2C", VA = "0x1353D2C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001DC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000F19")]
				[Address(RVA = "0x1353D74", Offset = "0x1353D74", VA = "0x1353D74", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000F14")]
			[Address(RVA = "0x1353BF4", Offset = "0x1353BF4", VA = "0x1353BF4")]
			[DebuggerHidden]
			public _003CAction_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000F15")]
			[Address(RVA = "0x1353C20", Offset = "0x1353C20", VA = "0x1353C20", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000F16")]
			[Address(RVA = "0x1353C24", Offset = "0x1353C24", VA = "0x1353C24", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000F17")]
			[Address(RVA = "0x1353D2C", Offset = "0x1353D2C", VA = "0x1353D2C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000F18")]
			[Address(RVA = "0x1353D34", Offset = "0x1353D34", VA = "0x1353D34", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000F19")]
			[Address(RVA = "0x1353D74", Offset = "0x1353D74", VA = "0x1353D74", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000EB5")]
		[FieldOffset(Offset = "0xB0")]
		public CapsuleCollider capsuleCollider;

		[Token(Token = "0x4000EB6")]
		[FieldOffset(Offset = "0xB8")]
		public BoxCollider boxCollider;

		[Token(Token = "0x4000EB7")]
		[FieldOffset(Offset = "0xC0")]
		public float actionColliderRadiusMlp;

		[Token(Token = "0x4000EB8")]
		[FieldOffset(Offset = "0xC4")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36DA0", Offset = "0x36DA0")]
		public float actionAdditionalPinWeight;

		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0xC8")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36DB8", Offset = "0x36DB8")]
		public float actionMassMlp;

		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0xCC")]
		public Vector3 COMOffset;

		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0xD8")]
		private float defaultColliderRadius;

		[Token(Token = "0x4000EBC")]
		[FieldOffset(Offset = "0xDC")]
		private float defaultMass;

		[Token(Token = "0x4000EBD")]
		[FieldOffset(Offset = "0xE0")]
		private float defaultAdditionalPinWeight;

		[Token(Token = "0x6000F0E")]
		[Address(RVA = "0x13D5130", Offset = "0x13D5130", VA = "0x13D5130")]
		public void StartAction(float duration)
		{
		}

		[Token(Token = "0x6000F0F")]
		[Address(RVA = "0x13D51C4", Offset = "0x13D51C4", VA = "0x13D51C4")]
		public IEnumerator Action(float duration)
		{
			return null;
		}

		[Token(Token = "0x6000F10")]
		[Address(RVA = "0x13D5248", Offset = "0x13D5248", VA = "0x13D5248", Slot = "7")]
		protected override void Start()
		{
		}

		[Token(Token = "0x6000F11")]
		[Address(RVA = "0x13D52B0", Offset = "0x13D52B0", VA = "0x13D52B0", Slot = "4")]
		protected override void OnPickUp(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000F12")]
		[Address(RVA = "0x13D5358", Offset = "0x13D5358", VA = "0x13D5358", Slot = "5")]
		protected override void OnDrop(PuppetMaster puppetMaster, int propMuscleIndex)
		{
		}

		[Token(Token = "0x6000F13")]
		[Address(RVA = "0x13D53BC", Offset = "0x13D53BC", VA = "0x13D53BC")]
		public PuppetMasterPropMelee()
		{
		}
	}
}
