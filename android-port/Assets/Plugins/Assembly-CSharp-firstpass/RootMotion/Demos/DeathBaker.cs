using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200022D")]
	public class DeathBaker : MonoBehaviour
	{
		[Token(Token = "0x200022E")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33E34", Offset = "0x33E34")]
		private sealed class _003CBake_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E59")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000E5A")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000E5B")]
			[FieldOffset(Offset = "0x20")]
			public DeathBaker _003C_003E4__this;

			[Token(Token = "0x170001CB")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000EBA")]
				[Address(RVA = "0x13396B4", Offset = "0x13396B4", VA = "0x13396B4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001CC")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000EBC")]
				[Address(RVA = "0x13396FC", Offset = "0x13396FC", VA = "0x13396FC", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000EB7")]
			[Address(RVA = "0x13395AC", Offset = "0x13395AC", VA = "0x13395AC")]
			[DebuggerHidden]
			public _003CBake_003Ed__12(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000EB8")]
			[Address(RVA = "0x13395D8", Offset = "0x13395D8", VA = "0x13395D8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000EB9")]
			[Address(RVA = "0x13395DC", Offset = "0x13395DC", VA = "0x13395DC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000EBA")]
			[Address(RVA = "0x13396B4", Offset = "0x13396B4", VA = "0x13396B4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000EBB")]
			[Address(RVA = "0x13396BC", Offset = "0x13396BC", VA = "0x13396BC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000EBC")]
			[Address(RVA = "0x13396FC", Offset = "0x13396FC", VA = "0x13396FC", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x200022F")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33E44", Offset = "0x33E44")]
		private sealed class _003CFadeOutPinWeight_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E5C")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000E5D")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000E5E")]
			[FieldOffset(Offset = "0x20")]
			public DeathBaker _003C_003E4__this;

			[Token(Token = "0x170001CD")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000EC0")]
				[Address(RVA = "0x13398E8", Offset = "0x13398E8", VA = "0x13398E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001CE")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000EC2")]
				[Address(RVA = "0x1339930", Offset = "0x1339930", VA = "0x1339930", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000EBD")]
			[Address(RVA = "0x1339820", Offset = "0x1339820", VA = "0x1339820")]
			[DebuggerHidden]
			public _003CFadeOutPinWeight_003Ed__13(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000EBE")]
			[Address(RVA = "0x133984C", Offset = "0x133984C", VA = "0x133984C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000EBF")]
			[Address(RVA = "0x1339850", Offset = "0x1339850", VA = "0x1339850", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000EC0")]
			[Address(RVA = "0x13398E8", Offset = "0x13398E8", VA = "0x13398E8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000EC1")]
			[Address(RVA = "0x13398F0", Offset = "0x13398F0", VA = "0x13398F0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000EC2")]
			[Address(RVA = "0x1339930", Offset = "0x1339930", VA = "0x1339930", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000230")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33E54", Offset = "0x33E54")]
		private sealed class _003CFadeOutMuscleWeight_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000E5F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000E60")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000E61")]
			[FieldOffset(Offset = "0x20")]
			public DeathBaker _003C_003E4__this;

			[Token(Token = "0x170001CF")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000EC6")]
				[Address(RVA = "0x13397D0", Offset = "0x13397D0", VA = "0x13397D0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001D0")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000EC8")]
				[Address(RVA = "0x1339818", Offset = "0x1339818", VA = "0x1339818", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000EC3")]
			[Address(RVA = "0x1339704", Offset = "0x1339704", VA = "0x1339704")]
			[DebuggerHidden]
			public _003CFadeOutMuscleWeight_003Ed__14(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000EC4")]
			[Address(RVA = "0x1339730", Offset = "0x1339730", VA = "0x1339730", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000EC5")]
			[Address(RVA = "0x1339734", Offset = "0x1339734", VA = "0x1339734", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000EC6")]
			[Address(RVA = "0x13397D0", Offset = "0x13397D0", VA = "0x13397D0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000EC7")]
			[Address(RVA = "0x13397D8", Offset = "0x13397D8", VA = "0x13397D8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000EC8")]
			[Address(RVA = "0x1339818", Offset = "0x1339818", VA = "0x1339818", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000E4F")]
		[FieldOffset(Offset = "0x18")]
		public HumanoidBaker baker;

		[Token(Token = "0x4000E50")]
		[FieldOffset(Offset = "0x20")]
		public float bakeTime;

		[Token(Token = "0x4000E51")]
		[FieldOffset(Offset = "0x28")]
		public PuppetMaster puppetMaster;

		[Token(Token = "0x4000E52")]
		[FieldOffset(Offset = "0x30")]
		public float fadeOutPinWeightSpeed;

		[Token(Token = "0x4000E53")]
		[FieldOffset(Offset = "0x34")]
		public float fadeOutMuscleWeightSpeed;

		[Token(Token = "0x4000E54")]
		[FieldOffset(Offset = "0x38")]
		public float deadMuscleWeight;

		[Token(Token = "0x4000E55")]
		[FieldOffset(Offset = "0x40")]
		private Animator animator;

		[Token(Token = "0x4000E56")]
		[FieldOffset(Offset = "0x48")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000E57")]
		[FieldOffset(Offset = "0x54")]
		private Quaternion defaultRotation;

		[Token(Token = "0x4000E58")]
		[FieldOffset(Offset = "0x64")]
		private bool isDead;

		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x1364094", Offset = "0x1364094", VA = "0x1364094")]
		private void Start()
		{
		}

		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x1364134", Offset = "0x1364134", VA = "0x1364134")]
		private void Update()
		{
		}

		[Token(Token = "0x6000EB3")]
		[Address(RVA = "0x1364514", Offset = "0x1364514", VA = "0x1364514")]
		private IEnumerator Bake()
		{
			return null;
		}

		[Token(Token = "0x6000EB4")]
		[Address(RVA = "0x136442C", Offset = "0x136442C", VA = "0x136442C")]
		private IEnumerator FadeOutPinWeight()
		{
			return null;
		}

		[Token(Token = "0x6000EB5")]
		[Address(RVA = "0x13644A0", Offset = "0x13644A0", VA = "0x13644A0")]
		private IEnumerator FadeOutMuscleWeight()
		{
			return null;
		}

		[Token(Token = "0x6000EB6")]
		[Address(RVA = "0x1364588", Offset = "0x1364588", VA = "0x1364588")]
		public DeathBaker()
		{
		}
	}
}
