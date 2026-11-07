using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000233")]
	public class Dying : MonoBehaviour
	{
		[Token(Token = "0x2000234")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33E74", Offset = "0x33E74")]
		private sealed class _003CFadeOutPinWeight_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E6E")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000E6F")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000E70")]
			[FieldOffset(Offset = "0x20")]
			public Dying _003C_003E4__this;

			[Token(Token = "0x170001D3")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000EDA")]
				[Address(RVA = "0x1339F5C", Offset = "0x1339F5C", VA = "0x1339F5C", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001D4")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000EDC")]
				[Address(RVA = "0x1339FA4", Offset = "0x1339FA4", VA = "0x1339FA4", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000ED7")]
			[Address(RVA = "0x1339E94", Offset = "0x1339E94", VA = "0x1339E94")]
			[DebuggerHidden]
			public _003CFadeOutPinWeight_003Ed__10(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000ED8")]
			[Address(RVA = "0x1339EC0", Offset = "0x1339EC0", VA = "0x1339EC0", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000ED9")]
			[Address(RVA = "0x1339EC4", Offset = "0x1339EC4", VA = "0x1339EC4", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000EDA")]
			[Address(RVA = "0x1339F5C", Offset = "0x1339F5C", VA = "0x1339F5C", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000EDB")]
			[Address(RVA = "0x1339F64", Offset = "0x1339F64", VA = "0x1339F64", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000EDC")]
			[Address(RVA = "0x1339FA4", Offset = "0x1339FA4", VA = "0x1339FA4", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000235")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33E84", Offset = "0x33E84")]
		private sealed class _003CFadeOutMuscleWeight_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E71")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000E72")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000E73")]
			[FieldOffset(Offset = "0x20")]
			public Dying _003C_003E4__this;

			[Token(Token = "0x170001D5")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000EE0")]
				[Address(RVA = "0x1339E44", Offset = "0x1339E44", VA = "0x1339E44", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001D6")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000EE2")]
				[Address(RVA = "0x1339E8C", Offset = "0x1339E8C", VA = "0x1339E8C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000EDD")]
			[Address(RVA = "0x1339D78", Offset = "0x1339D78", VA = "0x1339D78")]
			[DebuggerHidden]
			public _003CFadeOutMuscleWeight_003Ed__11(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000EDE")]
			[Address(RVA = "0x1339DA4", Offset = "0x1339DA4", VA = "0x1339DA4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000EDF")]
			[Address(RVA = "0x1339DA8", Offset = "0x1339DA8", VA = "0x1339DA8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000EE0")]
			[Address(RVA = "0x1339E44", Offset = "0x1339E44", VA = "0x1339E44", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000EE1")]
			[Address(RVA = "0x1339E4C", Offset = "0x1339E4C", VA = "0x1339E4C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000EE2")]
			[Address(RVA = "0x1339E8C", Offset = "0x1339E8C", VA = "0x1339E8C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0x18")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x20")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x24")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x28")]
		public float deadMuscleWeight;

		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x30")]
		private Animator animator;

		[Token(Token = "0x4000E6B")]
		[FieldOffset(Offset = "0x38")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000E6C")]
		[FieldOffset(Offset = "0x44")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000E6D")]
		[FieldOffset(Offset = "0x54")]
		private bool isDead;

		[Token(Token = "0x6000ED2")]
		[Address(RVA = "0x1365B94", Offset = "0x1365B94", VA = "0x1365B94")]
		private void Start()
		{
		}

		[Token(Token = "0x6000ED3")]
		[Address(RVA = "0x1365C34", Offset = "0x1365C34", VA = "0x1365C34")]
		private void Update()
		{
		}

		[Token(Token = "0x6000ED4")]
		[Address(RVA = "0x1365EB8", Offset = "0x1365EB8", VA = "0x1365EB8")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x6000ED5")]
		[Address(RVA = "0x1365F2C", Offset = "0x1365F2C", VA = "0x1365F2C")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x6000ED6")]
		[Address(RVA = "0x1365FA0", Offset = "0x1365FA0", VA = "0x1365FA0")]
		public Dying()
		{
		}
	}
}
