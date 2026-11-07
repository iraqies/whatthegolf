using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x200011B")]
	public class PuppetMaster : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200011C")]
		public enum Mode
		{
			[Token(Token = "0x40006E6")]
			Active = 0,
			[Token(Token = "0x40006E7")]
			Kinematic = 1,
			[Token(Token = "0x40006E8")]
			Disabled = 2
		}

		[Token(Token = "0x200011D")]
		public delegate void UpdateDelegate();

		[Token(Token = "0x200011E")]
		public delegate void MuscleDelegate(Muscle muscle);

		[Serializable]
		[Token(Token = "0x200011F")]
		public enum UpdateMode
		{
			[Token(Token = "0x40006EA")]
			Normal = 0,
			[Token(Token = "0x40006EB")]
			AnimatePhysics = 1,
			[Token(Token = "0x40006EC")]
			FixedUpdate = 2
		}

		[Serializable]
		[Token(Token = "0x2000120")]
		public enum State
		{
			[Token(Token = "0x40006EE")]
			Alive = 0,
			[Token(Token = "0x40006EF")]
			Dead = 1,
			[Token(Token = "0x40006F0")]
			Frozen = 2
		}

		[Serializable]
		[Token(Token = "0x2000121")]
		public struct StateSettings
		{
			[Token(Token = "0x40006F1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float killDuration;

			[Token(Token = "0x40006F2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float deadMuscleWeight;

			[Token(Token = "0x40006F3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float deadMuscleDamper;

			[Token(Token = "0x40006F4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public float maxFreezeSqrVelocity;

			[Token(Token = "0x40006F5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool freezePermanently;

			[Token(Token = "0x40006F6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool enableAngularLimitsOnKill;

			[Token(Token = "0x40006F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
			public bool enableInternalCollisionsOnKill;

			[Token(Token = "0x17000110")]
			public static StateSettings Default
			{
				[Token(Token = "0x6000811")]
				[Address(RVA = "0x1353AF4", Offset = "0x1353AF4", VA = "0x1353AF4")]
				get
				{
					return default;
				}
			}

			[Token(Token = "0x6000810")]
			[Address(RVA = "0x1353ADC", Offset = "0x1353ADC", VA = "0x1353ADC")]
			public StateSettings(float killDuration, float deadMuscleWeight = 0.01f, float deadMuscleDamper = 2f, float maxFreezeSqrVelocity = 0.02f, bool freezePermanently = false, bool enableAngularLimitsOnKill = true, bool enableInternalCollisionsOnKill = true)
			{
			}
		}

		[Token(Token = "0x2000122")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33874", Offset = "0x33874")]
		private sealed class _003CDisabledToActive_003Ed__173 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40006F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40006FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster _003C_003E4__this;

			[Token(Token = "0x17000111")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000815")]
				[Address(RVA = "0x13533CC", Offset = "0x13533CC", VA = "0x13533CC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000112")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000817")]
				[Address(RVA = "0x1353414", Offset = "0x1353414", VA = "0x1353414", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000812")]
			[Address(RVA = "0x1353130", Offset = "0x1353130", VA = "0x1353130")]
			[DebuggerHidden]
			public _003CDisabledToActive_003Ed__173(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000813")]
			[Address(RVA = "0x135315C", Offset = "0x135315C", VA = "0x135315C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000814")]
			[Address(RVA = "0x1353160", Offset = "0x1353160", VA = "0x1353160", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000815")]
			[Address(RVA = "0x13533CC", Offset = "0x13533CC", VA = "0x13533CC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000816")]
			[Address(RVA = "0x13533D4", Offset = "0x13533D4", VA = "0x13533D4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000817")]
			[Address(RVA = "0x1353414", Offset = "0x1353414", VA = "0x1353414", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000123")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33884", Offset = "0x33884")]
		private sealed class _003CKinematicToActive_003Ed__175 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40006FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x40006FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster _003C_003E4__this;

			[Token(Token = "0x17000113")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600081B")]
				[Address(RVA = "0x1353634", Offset = "0x1353634", VA = "0x1353634", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000114")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600081D")]
				[Address(RVA = "0x135367C", Offset = "0x135367C", VA = "0x135367C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000818")]
			[Address(RVA = "0x135341C", Offset = "0x135341C", VA = "0x135341C")]
			[DebuggerHidden]
			public _003CKinematicToActive_003Ed__175(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000819")]
			[Address(RVA = "0x1353448", Offset = "0x1353448", VA = "0x1353448", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600081A")]
			[Address(RVA = "0x135344C", Offset = "0x135344C", VA = "0x135344C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600081B")]
			[Address(RVA = "0x1353634", Offset = "0x1353634", VA = "0x1353634", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600081C")]
			[Address(RVA = "0x135363C", Offset = "0x135363C", VA = "0x135363C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600081D")]
			[Address(RVA = "0x135367C", Offset = "0x135367C", VA = "0x135367C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000124")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x33894", Offset = "0x33894")]
		private sealed class _003CActiveToDisabled_003Ed__176 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x40006FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x40006FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000700")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster _003C_003E4__this;

			[Token(Token = "0x17000115")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000821")]
				[Address(RVA = "0x13528E8", Offset = "0x13528E8", VA = "0x13528E8", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000116")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000823")]
				[Address(RVA = "0x1352930", Offset = "0x1352930", VA = "0x1352930", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600081E")]
			[Address(RVA = "0x1352778", Offset = "0x1352778", VA = "0x1352778")]
			[DebuggerHidden]
			public _003CActiveToDisabled_003Ed__176(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600081F")]
			[Address(RVA = "0x13527A4", Offset = "0x13527A4", VA = "0x13527A4", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000820")]
			[Address(RVA = "0x13527A8", Offset = "0x13527A8", VA = "0x13527A8", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000821")]
			[Address(RVA = "0x13528E8", Offset = "0x13528E8", VA = "0x13528E8", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000822")]
			[Address(RVA = "0x13528F0", Offset = "0x13528F0", VA = "0x13528F0", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000823")]
			[Address(RVA = "0x1352930", Offset = "0x1352930", VA = "0x1352930", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000125")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x338A4", Offset = "0x338A4")]
		private sealed class _003CActiveToKinematic_003Ed__177 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000701")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000702")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000703")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster _003C_003E4__this;

			[Token(Token = "0x17000117")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000827")]
				[Address(RVA = "0x1352AEC", Offset = "0x1352AEC", VA = "0x1352AEC", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000118")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000829")]
				[Address(RVA = "0x1352B34", Offset = "0x1352B34", VA = "0x1352B34", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000824")]
			[Address(RVA = "0x1352938", Offset = "0x1352938", VA = "0x1352938")]
			[DebuggerHidden]
			public _003CActiveToKinematic_003Ed__177(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000825")]
			[Address(RVA = "0x1352964", Offset = "0x1352964", VA = "0x1352964", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000826")]
			[Address(RVA = "0x1352968", Offset = "0x1352968", VA = "0x1352968", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000827")]
			[Address(RVA = "0x1352AEC", Offset = "0x1352AEC", VA = "0x1352AEC", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000828")]
			[Address(RVA = "0x1352AF4", Offset = "0x1352AF4", VA = "0x1352AF4", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000829")]
			[Address(RVA = "0x1352B34", Offset = "0x1352B34", VA = "0x1352B34", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x2000126")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x338B4", Offset = "0x338B4")]
		private sealed class _003CAliveToDead_003Ed__228 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000704")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000705")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000706")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public PuppetMaster _003C_003E4__this;

			[Token(Token = "0x4000707")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public bool freeze;

			[Token(Token = "0x4000708")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			private float _003Crange_003E5__2;

			[Token(Token = "0x4000709")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private float _003CmW_003E5__3;

			[Token(Token = "0x17000119")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x600082D")]
				[Address(RVA = "0x13530E0", Offset = "0x13530E0", VA = "0x13530E0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x1700011A")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x600082F")]
				[Address(RVA = "0x1353128", Offset = "0x1353128", VA = "0x1353128", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x600082A")]
			[Address(RVA = "0x1352B3C", Offset = "0x1352B3C", VA = "0x1352B3C")]
			[DebuggerHidden]
			public _003CAliveToDead_003Ed__228(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x600082B")]
			[Address(RVA = "0x1352B68", Offset = "0x1352B68", VA = "0x1352B68", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x600082C")]
			[Address(RVA = "0x1352B6C", Offset = "0x1352B6C", VA = "0x1352B6C", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x600082D")]
			[Address(RVA = "0x13530E0", Offset = "0x13530E0", VA = "0x13530E0", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x600082E")]
			[Address(RVA = "0x13530E8", Offset = "0x13530E8", VA = "0x13530E8", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x600082F")]
			[Address(RVA = "0x1353128", Offset = "0x1353128", VA = "0x1353128", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000691")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PuppetMasterHumanoidConfig humanoidConfig;

		[Token(Token = "0x4000692")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Transform targetRoot;

		[Token(Token = "0x4000693")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public State state;

		[Token(Token = "0x4000694")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
		public StateSettings stateSettings;

		[Token(Token = "0x4000695")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public Mode mode;

		[Token(Token = "0x4000696")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public float blendTime;

		[Token(Token = "0x4000697")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public bool fixTargetTransforms;

		[Token(Token = "0x4000698")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		public int solverIterationCount;

		[Token(Token = "0x4000699")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public bool visualizeTargetPose;

		[Token(Token = "0x400069A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x35894", Offset = "0x35894")]
		public float mappingWeight;

		[Token(Token = "0x400069B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x358AC", Offset = "0x358AC")]
		public float pinWeight;

		[Token(Token = "0x400069C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x358C4", Offset = "0x358C4")]
		public float muscleWeight;

		[Token(Token = "0x400069D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public float muscleSpring;

		[Token(Token = "0x400069E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x64")]
		public float muscleDamper;

		[Token(Token = "0x400069F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x358DC", Offset = "0x358DC")]
		public float pinPow;

		[Token(Token = "0x40006A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x358F4", Offset = "0x358F4")]
		public float pinDistanceFalloff;

		[Token(Token = "0x40006A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		public bool angularPinning;

		[Token(Token = "0x40006A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		public bool updateJointAnchors;

		[Token(Token = "0x40006A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x72")]
		public bool supportTranslationAnimation;

		[Token(Token = "0x40006A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x73")]
		public bool angularLimits;

		[Token(Token = "0x40006A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		public bool internalCollisions;

		[Token(Token = "0x40006A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		public Muscle[] muscles;

		[Token(Token = "0x40006A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		public PropMuscle[] propMuscles;

		[Token(Token = "0x40006A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		public UpdateDelegate OnPostInitiate;

		[Token(Token = "0x40006A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		public UpdateDelegate OnRead;

		[Token(Token = "0x40006AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		public UpdateDelegate OnWrite;

		[Token(Token = "0x40006AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		public UpdateDelegate OnPostLateUpdate;

		[Token(Token = "0x40006AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		public UpdateDelegate OnFixTransforms;

		[Token(Token = "0x40006AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		public UpdateDelegate OnHierarchyChanged;

		[Token(Token = "0x40006AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		public MuscleDelegate OnMuscleRemoved;

		[Token(Token = "0x40006AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		public MuscleDelegate OnMuscleDisconnected;

		[Token(Token = "0x40006B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		public MuscleDelegate OnMuscleReconnected;

		[Token(Token = "0x40006B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private Animator _targetAnimator;

		[Token(Token = "0x40006B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35920", Offset = "0x35920")]
		private Animation targetAnimation__BackingField;

		[Token(Token = "0x40006B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35930", Offset = "0x35930")]
		private BehaviourBase[] behaviours__BackingField;

		[Token(Token = "0x40006B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35940", Offset = "0x35940")]
		private bool initiated__BackingField;

		[Token(Token = "0x40006B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		public List<SolverManager> solvers;

		[NonSerialized]
		[Token(Token = "0x40006B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		public bool manualInternalCollisionControl;

		[NonSerialized]
		[Token(Token = "0x40006B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF9")]
		public bool manualAngularLimitControl;

		[Token(Token = "0x40006B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFA")]
		[SerializeField]
		public bool mapDisconnectedMuscles;

		[Token(Token = "0x40006B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFB")]
		private bool internalCollisionsEnabled;

		[Token(Token = "0x40006BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
		private bool angularLimitsEnabled;

		[Token(Token = "0x40006BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xFD")]
		private bool fixedFrame;

		[Token(Token = "0x40006BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private int lastSolverIterationCount;

		[Token(Token = "0x40006BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x104")]
		private bool isLegacy;

		[Token(Token = "0x40006BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x105")]
		private bool animatorDisabled;

		[Token(Token = "0x40006BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x106")]
		private bool awakeFailed;

		[Token(Token = "0x40006C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x107")]
		private bool interpolated;

		[Token(Token = "0x40006C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool freezeFlag;

		[Token(Token = "0x40006C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x109")]
		private bool hasBeenDisabled;

		[Token(Token = "0x40006C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10A")]
		private bool hierarchyIsFlat;

		[Token(Token = "0x40006C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10B")]
		private bool teleport;

		[Token(Token = "0x40006C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10C")]
		private Vector3 teleportPosition;

		[Token(Token = "0x40006C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Quaternion teleportRotation;

		[Token(Token = "0x40006C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private bool teleportMoveToTarget;

		[Token(Token = "0x40006C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x129")]
		private bool rebuildFlag;

		[Token(Token = "0x40006C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x12A")]
		private bool onPostRebuildFlag;

		[Token(Token = "0x40006CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private bool[] disconnectMuscleFlags;

		[Token(Token = "0x40006CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private MuscleDisconnectMode[] muscleDisconnectModes;

		[Token(Token = "0x40006CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private bool[] disconnectDeactivateFlags;

		[Token(Token = "0x40006CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private bool[] reconnectMuscleFlags;

		[Token(Token = "0x40006CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private Muscle[] defaultMuscles;

		[Token(Token = "0x40006CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private Vector3 rebuildPelvisPos;

		[Token(Token = "0x40006D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
		private Quaternion rebuildPelvisRot;

		[Token(Token = "0x40006D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x174")]
		private bool readInFixedUpdate;

		[Token(Token = "0x40006D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x175")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35960", Offset = "0x35960")]
		private bool isSwitchingMode__BackingField;

		[Token(Token = "0x40006D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private Mode activeMode;

		[Token(Token = "0x40006D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x17C")]
		private Mode lastMode;

		[Token(Token = "0x40006D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private float mappingBlend;

		[Token(Token = "0x40006D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x184")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x35970", Offset = "0x35970")]
		private bool isKilling__BackingField;

		[Token(Token = "0x40006D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		public UpdateDelegate OnFreeze;

		[Token(Token = "0x40006D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		public UpdateDelegate OnUnfreeze;

		[Token(Token = "0x40006D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		public UpdateDelegate OnDeath;

		[Token(Token = "0x40006DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		public UpdateDelegate OnResurrection;

		[Token(Token = "0x40006DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private State activeState;

		[Token(Token = "0x40006DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1AC")]
		private State lastState;

		[Token(Token = "0x40006DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private bool angularLimitsEnabledOnKill;

		[Token(Token = "0x40006DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B1")]
		private bool internalCollisionsEnabledOnKill;

		[Token(Token = "0x40006DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B2")]
		private bool animationDisabledbyStates;

		[Token(Token = "0x40006E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B3")]
		public bool storeTargetMappedState;

		[Token(Token = "0x40006E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B4")]
		private bool targetMappedStateStored;

		[Token(Token = "0x40006E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B5")]
		private bool targetMappedStateSampled;

		[Token(Token = "0x40006E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B6")]
		private bool sampleTargetMappedState;

		[Token(Token = "0x40006E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B7")]
		private bool hasProp;

		[Token(Token = "0x17000101")]
		public Animator targetAnimator
		{
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x13C5990", Offset = "0x13C5990", VA = "0x13C5990")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x13C5AE8", Offset = "0x13C5AE8", VA = "0x13C5AE8")]
			set
			{
			}
		}

		[Token(Token = "0x17000102")]
		public Animation targetAnimation
		{
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x13C5AF0", Offset = "0x13C5AF0", VA = "0x13C5AF0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x389D4", Offset = "0x389D4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x13C5AF8", Offset = "0x13C5AF8", VA = "0x13C5AF8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x389E4", Offset = "0x389E4")]
			private set
			{
			}
		}

		[Token(Token = "0x17000103")]
		public BehaviourBase[] behaviours
		{
			[Token(Token = "0x6000779")]
			[Address(RVA = "0x13C5B00", Offset = "0x13C5B00", VA = "0x13C5B00")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x389F4", Offset = "0x389F4")]
			get
			{
				return null;
			}
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x13C5B08", Offset = "0x13C5B08", VA = "0x13C5B08")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38A04", Offset = "0x38A04")]
			private set
			{
			}
		}

		[Token(Token = "0x17000104")]
		public bool isActive
		{
			[Token(Token = "0x600077B")]
			[Address(RVA = "0x13C5B10", Offset = "0x13C5B10", VA = "0x13C5B10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000105")]
		public bool initiated
		{
			[Token(Token = "0x600077C")]
			[Address(RVA = "0x13C5BA8", Offset = "0x13C5BA8", VA = "0x13C5BA8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38A14", Offset = "0x38A14")]
			get
			{
				return default;
			}
			[Token(Token = "0x600077D")]
			[Address(RVA = "0x13C5BB0", Offset = "0x13C5BB0", VA = "0x13C5BB0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38A24", Offset = "0x38A24")]
			private set
			{
			}
		}

		[Token(Token = "0x17000106")]
		public UpdateMode updateMode
		{
			[Token(Token = "0x600077E")]
			[Address(RVA = "0x13C5BB8", Offset = "0x13C5BB8", VA = "0x13C5BB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000107")]
		public bool controlsAnimator
		{
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x13C5CEC", Offset = "0x13C5CEC", VA = "0x13C5CEC")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000108")]
		public bool isBlending
		{
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x13C5B84", Offset = "0x13C5B84", VA = "0x13C5B84")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x17000109")]
		private bool autoSimulate
		{
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x13C66F4", Offset = "0x13C66F4", VA = "0x13C66F4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010A")]
		private AnimatorUpdateMode targetUpdateMode
		{
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x13C5BF8", Offset = "0x13C5BF8", VA = "0x13C5BF8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010B")]
		public bool isSwitchingMode
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x13CE104", Offset = "0x13CE104", VA = "0x13CE104")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38B14", Offset = "0x38B14")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x13CE10C", Offset = "0x13CE10C", VA = "0x13CE10C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38B24", Offset = "0x38B24")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010C")]
		public bool isSwitchingState
		{
			[Token(Token = "0x60007E3")]
			[Address(RVA = "0x13C5D90", Offset = "0x13C5D90", VA = "0x13C5D90")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010D")]
		public bool isKilling
		{
			[Token(Token = "0x60007E4")]
			[Address(RVA = "0x13D1EBC", Offset = "0x13D1EBC", VA = "0x13D1EBC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38B34", Offset = "0x38B34")]
			get
			{
				return default;
			}
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x13D1EC4", Offset = "0x13D1EC4", VA = "0x13D1EC4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x38B44", Offset = "0x38B44")]
			private set
			{
			}
		}

		[Token(Token = "0x1700010E")]
		public bool isAlive
		{
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x13CB14C", Offset = "0x13CB14C", VA = "0x13CB14C")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700010F")]
		public bool isFrozen
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x13C9BB8", Offset = "0x13C9BB8", VA = "0x13C9BB8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600076E")]
		[Address(RVA = "0x13C57A0", Offset = "0x13C57A0", VA = "0x13C57A0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38884", Offset = "0x38884")]
		private void OpenUserManualSetup()
		{
		}

		[Token(Token = "0x600076F")]
		[Address(RVA = "0x13C57E8", Offset = "0x13C57E8", VA = "0x13C57E8")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x388BC", Offset = "0x388BC")]
		private void OpenUserManualComponent()
		{
		}

		[Token(Token = "0x6000770")]
		[Address(RVA = "0x13C5830", Offset = "0x13C5830", VA = "0x13C5830")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x388F4", Offset = "0x388F4")]
		private void OpenUserManualPerformance()
		{
		}

		[Token(Token = "0x6000771")]
		[Address(RVA = "0x13C5878", Offset = "0x13C5878", VA = "0x13C5878")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3892C", Offset = "0x3892C")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000772")]
		[Address(RVA = "0x13C58C0", Offset = "0x13C58C0", VA = "0x13C58C0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38964", Offset = "0x38964")]
		private void OpenSetupTutorial()
		{
		}

		[Token(Token = "0x6000773")]
		[Address(RVA = "0x13C5908", Offset = "0x13C5908", VA = "0x13C5908")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3899C", Offset = "0x3899C")]
		private void OpenComponentTutorial()
		{
		}

		[Token(Token = "0x6000774")]
		[Address(RVA = "0x13C5950", Offset = "0x13C5950", VA = "0x13C5950")]
		private void ResetStateSettings()
		{
		}

		[Token(Token = "0x6000781")]
		[Address(RVA = "0x13C5DA4", Offset = "0x13C5DA4", VA = "0x13C5DA4")]
		public void Teleport(Vector3 position, Quaternion rotation, bool moveToTarget)
		{
		}

		[Token(Token = "0x6000782")]
		[Address(RVA = "0x13C6568", Offset = "0x13C6568", VA = "0x13C6568")]
		public void SetInternalCollisionsManual(bool collide, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x6000783")]
		[Address(RVA = "0x13C666C", Offset = "0x13C666C", VA = "0x13C666C")]
		public void SetAngularLimitsManual(bool limited)
		{
		}

		[Token(Token = "0x6000785")]
		[Address(RVA = "0x13C66FC", Offset = "0x13C66FC", VA = "0x13C66FC")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6000786")]
		[Address(RVA = "0x13C67AC", Offset = "0x13C67AC", VA = "0x13C67AC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000787")]
		[Address(RVA = "0x13C6F0C", Offset = "0x13C6F0C", VA = "0x13C6F0C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000788")]
		[Address(RVA = "0x13C79CC", Offset = "0x13C79CC", VA = "0x13C79CC")]
		public void Start()
		{
		}

		[Token(Token = "0x6000789")]
		[Address(RVA = "0x13C7A78", Offset = "0x13C7A78", VA = "0x13C7A78")]
		public Transform FindTargetRootRecursive(Transform t)
		{
			return null;
		}

		[Token(Token = "0x600078A")]
		[Address(RVA = "0x13C6F50", Offset = "0x13C6F50", VA = "0x13C6F50")]
		private void Initiate()
		{
		}

		[Token(Token = "0x600078B")]
		[Address(RVA = "0x13C8C9C", Offset = "0x13C8C9C", VA = "0x13C8C9C")]
		private void ActivateBehaviour(BehaviourBase behaviour)
		{
		}

		[Token(Token = "0x600078C")]
		[Address(RVA = "0x13C8D9C", Offset = "0x13C8D9C", VA = "0x13C8D9C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x600078D")]
		[Address(RVA = "0x13C8EC0", Offset = "0x13C8EC0", VA = "0x13C8EC0")]
		private bool IsInterpolated()
		{
			return default;
		}

		[Token(Token = "0x600078E")]
		[Address(RVA = "0x13C8F60", Offset = "0x13C8F60", VA = "0x13C8F60")]
		private void OnRebuild()
		{
		}

		[Token(Token = "0x600078F")]
		[Address(RVA = "0x13C932C", Offset = "0x13C932C", VA = "0x13C932C")]
		public void OnPreSimulate(float deltaTime)
		{
		}

		[Token(Token = "0x6000790")]
		[Address(RVA = "0x13C9C9C", Offset = "0x13C9C9C", VA = "0x13C9C9C")]
		public void OnPostSimulate()
		{
		}

		[Token(Token = "0x6000791")]
		[Address(RVA = "0x13CA498", Offset = "0x13CA498", VA = "0x13CA498", Slot = "4")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6000792")]
		[Address(RVA = "0x13CAACC", Offset = "0x13CAACC", VA = "0x13CAACC", Slot = "5")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x6000793")]
		[Address(RVA = "0x13CABB8", Offset = "0x13CABB8", VA = "0x13CABB8", Slot = "6")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x6000794")]
		[Address(RVA = "0x13CAD54", Offset = "0x13CAD54", VA = "0x13CAD54", Slot = "7")]
		protected virtual void OnLateUpdate()
		{
		}

		[Token(Token = "0x6000795")]
		[Address(RVA = "0x13CA02C", Offset = "0x13CA02C", VA = "0x13CA02C")]
		private void MoveToTarget()
		{
		}

		[Token(Token = "0x6000796")]
		[Address(RVA = "0x13C5DE0", Offset = "0x13C5DE0", VA = "0x13C5DE0")]
		private void Read()
		{
		}

		[Token(Token = "0x6000797")]
		[Address(RVA = "0x13C9A34", Offset = "0x13C9A34", VA = "0x13C9A34")]
		private void FixTargetTransforms()
		{
		}

		[Token(Token = "0x6000799")]
		[Address(RVA = "0x13CB15C", Offset = "0x13CB15C", VA = "0x13CB15C")]
		private void VisualizeTargetPose()
		{
		}

		[Token(Token = "0x600079A")]
		[Address(RVA = "0x13CB494", Offset = "0x13CB494", VA = "0x13CB494")]
		private void VisualizeHierarchy(Transform t, Color color)
		{
		}

		[Token(Token = "0x600079B")]
		[Address(RVA = "0x13C8B3C", Offset = "0x13C8B3C", VA = "0x13C8B3C")]
		public void FlagInternalCollisionsForUpdate()
		{
		}

		[Token(Token = "0x600079C")]
		[Address(RVA = "0x13C9BC8", Offset = "0x13C9BC8", VA = "0x13C9BC8")]
		private void UpdateInternalCollisions()
		{
		}

		[Token(Token = "0x600079D")]
		[Address(RVA = "0x13CB7B8", Offset = "0x13CB7B8", VA = "0x13CB7B8")]
		public void UpdateInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x600079E")]
		[Address(RVA = "0x13CB6E8", Offset = "0x13CB6E8", VA = "0x13CB6E8")]
		private void IgnoreInternalCollisions()
		{
		}

		[Token(Token = "0x600079F")]
		[Address(RVA = "0x13CB880", Offset = "0x13CB880", VA = "0x13CB880")]
		public void IgnoreInternalCollisions(Muscle m)
		{
		}

		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x13CB610", Offset = "0x13CB610", VA = "0x13CB610")]
		private void ResetInternalCollisions()
		{
		}

		[Token(Token = "0x60007A1")]
		[Address(RVA = "0x13CB918", Offset = "0x13CB918", VA = "0x13CB918")]
		public void ResetInternalCollisions(Muscle m, bool useInternalCollisionIgnores)
		{
		}

		[Token(Token = "0x60007A2")]
		[Address(RVA = "0x13C8B54", Offset = "0x13C8B54", VA = "0x13C8B54")]
		public void FlagAngularLimitsForUpdate()
		{
		}

		[Token(Token = "0x60007A3")]
		[Address(RVA = "0x13C9BF0", Offset = "0x13C9BF0", VA = "0x13C9BF0")]
		private void UpdateAngularLimits()
		{
		}

		[Token(Token = "0x60007A4")]
		[Address(RVA = "0x13CB9C0", Offset = "0x13CB9C0", VA = "0x13CB9C0")]
		public bool AddPropMuscle(ConfigurableJoint addPropMuscleTo, Vector3 position, Quaternion rotation, Vector3 additionalPinOffset, [Optional] Transform targetParent, [Optional] PuppetMasterProp initiateWithProp)
		{
			return default;
		}

		[Token(Token = "0x60007A5")]
		[Address(RVA = "0x13C2E44", Offset = "0x13C2E44", VA = "0x13C2E44")]
		public bool IsDisconnecting(int muscleIndex)
		{
			return default;
		}

		[Token(Token = "0x60007A6")]
		[Address(RVA = "0x13C2E80", Offset = "0x13C2E80", VA = "0x13C2E80")]
		public bool IsReconnecting(int muscleIndex)
		{
			return default;
		}

		[Token(Token = "0x60007A7")]
		[Address(RVA = "0x13C2694", Offset = "0x13C2694", VA = "0x13C2694")]
		public void DisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60007A8")]
		[Address(RVA = "0x13C2EBC", Offset = "0x13C2EBC", VA = "0x13C2EBC")]
		public void ReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60007A9")]
		[Address(RVA = "0x13C4BA4", Offset = "0x13C4BA4", VA = "0x13C4BA4")]
		public void AddMuscle(ConfigurableJoint joint, Transform target, Rigidbody connectTo, Transform targetParent, [Optional] Muscle.Props muscleProps, bool forceTreeHierarchy = false, bool forceLayers = true)
		{
		}

		[Token(Token = "0x60007AA")]
		[Address(RVA = "0x13CC578", Offset = "0x13CC578", VA = "0x13CC578")]
		public void Rebuild()
		{
		}

		[Token(Token = "0x60007AB")]
		[Address(RVA = "0x13C36A0", Offset = "0x13C36A0", VA = "0x13C36A0")]
		public void RemoveMuscleRecursive(ConfigurableJoint joint, bool attachTarget, bool blockTargetAnimation = false, MuscleRemoveMode removeMode = MuscleRemoveMode.Sever)
		{
		}

		[Token(Token = "0x60007AC")]
		[Address(RVA = "0x13CC8B4", Offset = "0x13CC8B4", VA = "0x13CC8B4")]
		public void ReplaceMuscle(ConfigurableJoint oldJoint, ConfigurableJoint newJoint)
		{
		}

		[Token(Token = "0x60007AD")]
		[Address(RVA = "0x13CC9C4", Offset = "0x13CC9C4", VA = "0x13CC9C4")]
		public void SetMuscles(Muscle[] newMuscles)
		{
		}

		[Token(Token = "0x60007AE")]
		[Address(RVA = "0x13CCAD4", Offset = "0x13CCAD4", VA = "0x13CCAD4")]
		public void DisableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60007AF")]
		[Address(RVA = "0x13CCBE4", Offset = "0x13CCBE4", VA = "0x13CCBE4")]
		public void EnableMuscleRecursive(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60007B0")]
		[Address(RVA = "0x13CCCF4", Offset = "0x13CCCF4", VA = "0x13CCCF4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38A34", Offset = "0x38A34")]
		public void FlattenHierarchy()
		{
		}

		[Token(Token = "0x60007B1")]
		[Address(RVA = "0x13CCE14", Offset = "0x13CCE14", VA = "0x13CCE14")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38A6C", Offset = "0x38A6C")]
		public void TreeHierarchy()
		{
		}

		[Token(Token = "0x60007B2")]
		[Address(RVA = "0x13CCFA4", Offset = "0x13CCFA4", VA = "0x13CCFA4")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38AA4", Offset = "0x38AA4")]
		public void FixMusclePositions()
		{
		}

		[Token(Token = "0x60007B3")]
		[Address(RVA = "0x13CD0EC", Offset = "0x13CD0EC", VA = "0x13CD0EC")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38ADC", Offset = "0x38ADC")]
		public void FixMusclePositionsAndRotations()
		{
		}

		[Token(Token = "0x60007B4")]
		[Address(RVA = "0x13C8A2C", Offset = "0x13C8A2C", VA = "0x13C8A2C")]
		public bool HierarchyIsFlat()
		{
			return default;
		}

		[Token(Token = "0x60007B5")]
		[Address(RVA = "0x13CC0FC", Offset = "0x13CC0FC", VA = "0x13CC0FC")]
		private int GetHighestDisconnectedParentIndex(int index)
		{
			return default;
		}

		[Token(Token = "0x60007B6")]
		[Address(RVA = "0x13C98AC", Offset = "0x13C98AC", VA = "0x13C98AC")]
		private void ProcessDisconnects()
		{
		}

		[Token(Token = "0x60007B7")]
		[Address(RVA = "0x13C999C", Offset = "0x13C999C", VA = "0x13C999C")]
		private void ProcessReconnects()
		{
		}

		[Token(Token = "0x60007B8")]
		[Address(RVA = "0x13CD268", Offset = "0x13CD268", VA = "0x13CD268")]
		private void OnDisconnectMuscleRecursive(int index, MuscleDisconnectMode disconnectMode = MuscleDisconnectMode.Sever, bool deactivate = false)
		{
		}

		[Token(Token = "0x60007B9")]
		[Address(RVA = "0x13CD6C0", Offset = "0x13CD6C0", VA = "0x13CD6C0")]
		private void DisconnectMuscle(Muscle m, bool sever, bool deactivate)
		{
		}

		[Token(Token = "0x60007BA")]
		[Address(RVA = "0x13CD540", Offset = "0x13CD540", VA = "0x13CD540")]
		private void OnReconnectMuscleRecursive(int index)
		{
		}

		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x13CDB80", Offset = "0x13CDB80", VA = "0x13CDB80")]
		private void ReconnectMuscle(Muscle m)
		{
		}

		[Token(Token = "0x60007BC")]
		[Address(RVA = "0x13CDF84", Offset = "0x13CDF84", VA = "0x13CDF84")]
		private void AddIndexesRecursive(int index, ref int[] indexes)
		{
		}

		[Token(Token = "0x60007BD")]
		[Address(RVA = "0x13CC76C", Offset = "0x13CC76C", VA = "0x13CC76C")]
		private void DisconnectJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60007BE")]
		[Address(RVA = "0x13CC830", Offset = "0x13CC830", VA = "0x13CC830")]
		private void KillJoint(ConfigurableJoint joint)
		{
		}

		[Token(Token = "0x60007BF")]
		[Address(RVA = "0x13CE0E4", Offset = "0x13CE0E4", VA = "0x13CE0E4")]
		public void SwitchToActiveMode()
		{
		}

		[Token(Token = "0x60007C0")]
		[Address(RVA = "0x13CE0EC", Offset = "0x13CE0EC", VA = "0x13CE0EC")]
		public void SwitchToKinematicMode()
		{
		}

		[Token(Token = "0x60007C1")]
		[Address(RVA = "0x13CE0F8", Offset = "0x13CE0F8", VA = "0x13CE0F8")]
		public void SwitchToDisabledMode()
		{
		}

		[Token(Token = "0x60007C4")]
		[Address(RVA = "0x13CE114", Offset = "0x13CE114", VA = "0x13CE114")]
		public void DisableImmediately()
		{
		}

		[Token(Token = "0x60007C5")]
		[Address(RVA = "0x13CE1B8", Offset = "0x13CE1B8", VA = "0x13CE1B8", Slot = "8")]
		protected virtual void SwitchModes()
		{
		}

		[Token(Token = "0x60007C6")]
		[Address(RVA = "0x13CE330", Offset = "0x13CE330", VA = "0x13CE330")]
		private void DisabledToKinematic()
		{
		}

		[Token(Token = "0x60007C7")]
		[Address(RVA = "0x13CE4AC", Offset = "0x13CE4AC", VA = "0x13CE4AC")]
		private IEnumerator DisabledToActive()
		{
			return null;
		}

		[Token(Token = "0x60007C8")]
		[Address(RVA = "0x13CE520", Offset = "0x13CE520", VA = "0x13CE520")]
		private void KinematicToDisabled()
		{
		}

		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x13CE5C8", Offset = "0x13CE5C8", VA = "0x13CE5C8")]
		private IEnumerator KinematicToActive()
		{
			return null;
		}

		[Token(Token = "0x60007CA")]
		[Address(RVA = "0x13CE63C", Offset = "0x13CE63C", VA = "0x13CE63C")]
		private IEnumerator ActiveToDisabled()
		{
			return null;
		}

		[Token(Token = "0x60007CB")]
		[Address(RVA = "0x13CE6B0", Offset = "0x13CE6B0", VA = "0x13CE6B0")]
		private IEnumerator ActiveToKinematic()
		{
			return null;
		}

		[Token(Token = "0x60007CC")]
		[Address(RVA = "0x13CE724", Offset = "0x13CE724", VA = "0x13CE724")]
		public void SetMuscleWeights(Muscle.Group group, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x13CE850", Offset = "0x13CE850", VA = "0x13CE850")]
		public void SetMuscleWeights(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x13CED60", Offset = "0x13CED60", VA = "0x13CED60")]
		public void SetMuscleWeights(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x13CF124", Offset = "0x13CF124", VA = "0x13CF124")]
		public void SetMuscleWeightsRecursive(Transform target, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x13CF2C0", Offset = "0x13CF2C0", VA = "0x13CF2C0")]
		public void SetMuscleWeightsRecursive(int muscleIndex, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x13CF418", Offset = "0x13CF418", VA = "0x13CF418")]
		public void SetMuscleWeightsRecursive(HumanBodyBones humanBodyBone, float muscleWeight, float pinWeight = 1f, float mappingWeight = 1f, float muscleDamper = 1f)
		{
		}

		[Token(Token = "0x60007D2")]
		[Address(RVA = "0x13CEBA4", Offset = "0x13CEBA4", VA = "0x13CEBA4")]
		public void SetMuscleWeights(int muscleIndex, float muscleWeight, float pinWeight, float mappingWeight, float muscleDamper)
		{
		}

		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x13CF518", Offset = "0x13CF518", VA = "0x13CF518")]
		public Muscle GetMuscle(Transform target)
		{
			return null;
		}

		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x13CC210", Offset = "0x13CC210", VA = "0x13CC210")]
		public Muscle GetMuscle(Rigidbody rigidbody)
		{
			return null;
		}

		[Token(Token = "0x60007D5")]
		[Address(RVA = "0x13C1EFC", Offset = "0x13C1EFC", VA = "0x13C1EFC")]
		public Muscle GetMuscle(ConfigurableJoint joint)
		{
			return null;
		}

		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x13C91D4", Offset = "0x13C91D4", VA = "0x13C91D4")]
		public bool ContainsJoint(ConfigurableJoint joint)
		{
			return default;
		}

		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x13CEE60", Offset = "0x13CEE60", VA = "0x13CEE60")]
		public int GetMuscleIndex(HumanBodyBones humanBodyBone)
		{
			return default;
		}

		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x13CE950", Offset = "0x13CE950", VA = "0x13CE950")]
		public int GetMuscleIndex(Transform target)
		{
			return default;
		}

		[Token(Token = "0x60007D9")]
		[Address(RVA = "0x13CF574", Offset = "0x13CF574", VA = "0x13CF574")]
		public int GetMuscleIndex(Rigidbody rigidbody)
		{
			return default;
		}

		[Token(Token = "0x60007DA")]
		[Address(RVA = "0x13CC584", Offset = "0x13CC584", VA = "0x13CC584")]
		public int GetMuscleIndex(ConfigurableJoint joint)
		{
			return default;
		}

		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x13CF7C8", Offset = "0x13CF7C8", VA = "0x13CF7C8")]
		public static PuppetMaster SetUp(Transform target, Transform ragdoll, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x13D05C8", Offset = "0x13D05C8", VA = "0x13D05C8")]
		public static PuppetMaster SetUp(Transform target, int characterControllerLayer, int ragdollLayer)
		{
			return null;
		}

		[Token(Token = "0x60007DD")]
		[Address(RVA = "0x13CF8C4", Offset = "0x13CF8C4", VA = "0x13CF8C4")]
		public void SetUpTo(Transform setUpTo, int characterControllerLayer, int ragdollLayer)
		{
		}

		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x13D0744", Offset = "0x13D0744", VA = "0x13D0744")]
		public static void RemoveRagdollComponents(Transform target, int characterControllerLayer)
		{
		}

		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x13D0FEC", Offset = "0x13D0FEC", VA = "0x13D0FEC")]
		private void SetUpMuscles(Transform setUpTo)
		{
		}

		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x13D1A54", Offset = "0x13D1A54", VA = "0x13D1A54")]
		private static Muscle.Group FindGroup(Animator animator, Transform t)
		{
			return default;
		}

		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x13D0BC4", Offset = "0x13D0BC4", VA = "0x13D0BC4")]
		private void RemoveUnnecessaryBones()
		{
		}

		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x13D1730", Offset = "0x13D1730", VA = "0x13D1730")]
		private static bool IsClothCollider(Collider collider, Cloth[] cloths)
		{
			return default;
		}

		[Token(Token = "0x60007E8")]
		[Address(RVA = "0x13D1ECC", Offset = "0x13D1ECC", VA = "0x13D1ECC")]
		public void Kill()
		{
		}

		[Token(Token = "0x60007E9")]
		[Address(RVA = "0x13D1ED8", Offset = "0x13D1ED8", VA = "0x13D1ED8")]
		public void Kill(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60007EA")]
		[Address(RVA = "0x13D1EF4", Offset = "0x13D1EF4", VA = "0x13D1EF4")]
		public void Freeze()
		{
		}

		[Token(Token = "0x60007EB")]
		[Address(RVA = "0x13D1F00", Offset = "0x13D1F00", VA = "0x13D1F00")]
		public void Freeze(StateSettings stateSettings)
		{
		}

		[Token(Token = "0x60007EC")]
		[Address(RVA = "0x13D1F1C", Offset = "0x13D1F1C", VA = "0x13D1F1C")]
		public void Resurrect()
		{
		}

		[Token(Token = "0x60007ED")]
		[Address(RVA = "0x13D1F24", Offset = "0x13D1F24", VA = "0x13D1F24", Slot = "9")]
		protected virtual void SwitchStates()
		{
		}

		[Token(Token = "0x60007EE")]
		[Address(RVA = "0x13D2098", Offset = "0x13D2098", VA = "0x13D2098")]
		private IEnumerator AliveToDead(bool freeze)
		{
			return null;
		}

		[Token(Token = "0x60007EF")]
		[Address(RVA = "0x13CA208", Offset = "0x13CA208", VA = "0x13CA208")]
		private void OnFreezeFlag()
		{
		}

		[Token(Token = "0x60007F0")]
		[Address(RVA = "0x13D2114", Offset = "0x13D2114", VA = "0x13D2114")]
		private void DeadToAlive()
		{
		}

		[Token(Token = "0x60007F1")]
		[Address(RVA = "0x13C6C60", Offset = "0x13C6C60", VA = "0x13C6C60")]
		private void SetAnimationEnabled(bool to)
		{
		}

		[Token(Token = "0x60007F2")]
		[Address(RVA = "0x13D222C", Offset = "0x13D222C", VA = "0x13D222C")]
		private void DeadToFrozen()
		{
		}

		[Token(Token = "0x60007F3")]
		[Address(RVA = "0x13D2238", Offset = "0x13D2238", VA = "0x13D2238")]
		private void FrozenToAlive()
		{
		}

		[Token(Token = "0x60007F4")]
		[Address(RVA = "0x13D247C", Offset = "0x13D247C", VA = "0x13D247C")]
		private void FrozenToDead()
		{
		}

		[Token(Token = "0x60007F5")]
		[Address(RVA = "0x13C6D64", Offset = "0x13C6D64", VA = "0x13C6D64")]
		private void ActivateRagdoll(bool kinematic = false)
		{
		}

		[Token(Token = "0x60007F6")]
		[Address(RVA = "0x13D2568", Offset = "0x13D2568", VA = "0x13D2568")]
		private bool CanFreeze()
		{
			return default;
		}

		[Token(Token = "0x60007F7")]
		[Address(RVA = "0x13D2624", Offset = "0x13D2624", VA = "0x13D2624")]
		public void SampleTargetMappedState()
		{
		}

		[Token(Token = "0x60007F8")]
		[Address(RVA = "0x13D2750", Offset = "0x13D2750", VA = "0x13D2750")]
		public void FixTargetToSampledState(float weight)
		{
		}

		[Token(Token = "0x60007F9")]
		[Address(RVA = "0x13C8B6C", Offset = "0x13C8B6C", VA = "0x13C8B6C")]
		public void StoreTargetMappedState()
		{
		}

		[Token(Token = "0x60007FA")]
		[Address(RVA = "0x13C8734", Offset = "0x13C8734", VA = "0x13C8734")]
		private void UpdateHierarchies()
		{
		}

		[Token(Token = "0x60007FB")]
		[Address(RVA = "0x13D2FC0", Offset = "0x13D2FC0", VA = "0x13D2FC0")]
		private bool HasProp()
		{
			return default;
		}

		[Token(Token = "0x60007FC")]
		[Address(RVA = "0x13D2E34", Offset = "0x13D2E34", VA = "0x13D2E34")]
		private void UpdateBroadcasterMuscleIndexes()
		{
		}

		[Token(Token = "0x60007FD")]
		[Address(RVA = "0x13D2A00", Offset = "0x13D2A00", VA = "0x13D2A00")]
		private void AssignParentAndChildIndexes()
		{
		}

		[Token(Token = "0x60007FE")]
		[Address(RVA = "0x13D3040", Offset = "0x13D3040", VA = "0x13D3040")]
		private void AddToParentsRecursive(ConfigurableJoint joint, ref int[] indexes)
		{
		}

		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x13D31C4", Offset = "0x13D31C4", VA = "0x13D31C4")]
		private void AddToChildrenRecursive(ConfigurableJoint joint, ref int[] indexes, ref bool[] childFlags)
		{
		}

		[Token(Token = "0x6000800")]
		[Address(RVA = "0x13D2D2C", Offset = "0x13D2D2C", VA = "0x13D2D2C")]
		private void AssignKinshipDegrees()
		{
		}

		[Token(Token = "0x6000801")]
		[Address(RVA = "0x13D34D0", Offset = "0x13D34D0", VA = "0x13D34D0")]
		private void AssignKinshipsDownRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000802")]
		[Address(RVA = "0x13D3638", Offset = "0x13D3638", VA = "0x13D3638")]
		private void AssignKinshipsUpRecursive(ref int[] kinshipDegrees, int degree, int index)
		{
		}

		[Token(Token = "0x6000803")]
		[Address(RVA = "0x13D33F4", Offset = "0x13D33F4", VA = "0x13D33F4")]
		private int GetMuscleIndexLowLevel(ConfigurableJoint joint)
		{
			return default;
		}

		[Token(Token = "0x6000804")]
		[Address(RVA = "0x13C7E64", Offset = "0x13C7E64", VA = "0x13C7E64")]
		public bool IsValid(bool log)
		{
			return default;
		}

		[Token(Token = "0x6000805")]
		[Address(RVA = "0x13CC26C", Offset = "0x13CC26C", VA = "0x13CC26C")]
		private bool CheckMassVariation(float threshold, bool log)
		{
			return default;
		}

		[Token(Token = "0x6000806")]
		[Address(RVA = "0x13CC188", Offset = "0x13CC188", VA = "0x13CC188")]
		private bool CheckIfInitiated()
		{
			return default;
		}

		[Token(Token = "0x6000807")]
		[Address(RVA = "0x13D3884", Offset = "0x13D3884", VA = "0x13D3884")]
		public PuppetMaster()
		{
		}
	}
}
