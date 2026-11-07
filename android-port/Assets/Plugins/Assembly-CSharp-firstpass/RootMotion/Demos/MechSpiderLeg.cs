using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x20001EA")]
	public class MechSpiderLeg : MonoBehaviour
	{
		[Token(Token = "0x20001EB")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3397C", Offset = "0x3397C")]
		private sealed class _003CStep_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000CFE")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000CFF")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000D00")]
			[FieldOffset(Offset = "0x20")]
			public MechSpiderLeg _003C_003E4__this;

			[Token(Token = "0x4000D01")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 stepStartPosition;

			[Token(Token = "0x4000D02")]
			[FieldOffset(Offset = "0x34")]
			public Vector3 targetPosition;

			[Token(Token = "0x170001BC")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000DC1")]
				[Address(RVA = "0x134FA14", Offset = "0x134FA14", VA = "0x134FA14", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001BD")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000DC3")]
				[Address(RVA = "0x134FA5C", Offset = "0x134FA5C", VA = "0x134FA5C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000DBE")]
			[Address(RVA = "0x134F714", Offset = "0x134F714", VA = "0x134F714")]
			[DebuggerHidden]
			public _003CStep_003Ed__33(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000DBF")]
			[Address(RVA = "0x134F740", Offset = "0x134F740", VA = "0x134F740", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000DC0")]
			[Address(RVA = "0x134F744", Offset = "0x134F744", VA = "0x134F744", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000DC1")]
			[Address(RVA = "0x134FA14", Offset = "0x134FA14", VA = "0x134FA14", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000DC2")]
			[Address(RVA = "0x134FA1C", Offset = "0x134FA1C", VA = "0x134FA1C", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000DC3")]
			[Address(RVA = "0x134FA5C", Offset = "0x134FA5C", VA = "0x134FA5C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000CE8")]
		[FieldOffset(Offset = "0x18")]
		public MechSpider mechSpider;

		[Token(Token = "0x4000CE9")]
		[FieldOffset(Offset = "0x20")]
		public MechSpiderLeg unSync;

		[Token(Token = "0x4000CEA")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 offset;

		[Token(Token = "0x4000CEB")]
		[FieldOffset(Offset = "0x34")]
		public float minDelay;

		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0x38")]
		public float maxOffset;

		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x3C")]
		public float stepSpeed;

		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x40")]
		public float footHeight;

		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x44")]
		public float velocityPrediction;

		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x48")]
		public float raycastFocus;

		[Token(Token = "0x4000CF1")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve yOffset;

		[Token(Token = "0x4000CF2")]
		[FieldOffset(Offset = "0x58")]
		public Transform foot;

		[Token(Token = "0x4000CF3")]
		[FieldOffset(Offset = "0x60")]
		public Vector3 footUpAxis;

		[Token(Token = "0x4000CF4")]
		[FieldOffset(Offset = "0x6C")]
		public float footRotationSpeed;

		[Token(Token = "0x4000CF5")]
		[FieldOffset(Offset = "0x70")]
		public ParticleSystem sand;

		[Token(Token = "0x4000CF6")]
		[FieldOffset(Offset = "0x78")]
		private IK ik;

		[Token(Token = "0x4000CF7")]
		[FieldOffset(Offset = "0x80")]
		private float stepProgress;

		[Token(Token = "0x4000CF8")]
		[FieldOffset(Offset = "0x84")]
		private float lastStepTime;

		[Token(Token = "0x4000CF9")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 defaultPosition;

		[Token(Token = "0x4000CFA")]
		[FieldOffset(Offset = "0x94")]
		private RaycastHit hit;

		[Token(Token = "0x4000CFB")]
		[FieldOffset(Offset = "0xC0")]
		private Quaternion lastFootLocalRotation;

		[Token(Token = "0x4000CFC")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 smoothHitNormal;

		[Token(Token = "0x4000CFD")]
		[FieldOffset(Offset = "0xDC")]
		private Vector3 lastStepPosition;

		[Token(Token = "0x170001BA")]
		public bool isStepping
		{
			[Token(Token = "0x6000DB3")]
			[Address(RVA = "0x13AC780", Offset = "0x13AC780", VA = "0x13AC780")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170001BB")]
		public Vector3 position
		{
			[Token(Token = "0x6000DB4")]
			[Address(RVA = "0x13AC3DC", Offset = "0x13AC3DC", VA = "0x13AC3DC")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000DB5")]
			[Address(RVA = "0x13AC794", Offset = "0x13AC794", VA = "0x13AC794")]
			set
			{
			}
		}

		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x13AC7E4", Offset = "0x13AC7E4", VA = "0x13AC7E4")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x13AC9E8", Offset = "0x13AC9E8", VA = "0x13AC9E8")]
		private void AfterIK()
		{
		}

		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x13ACB98", Offset = "0x13ACB98", VA = "0x13ACB98")]
		private void Start()
		{
		}

		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x13ACEC8", Offset = "0x13ACEC8", VA = "0x13ACEC8")]
		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default;
		}

		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x13AD194", Offset = "0x13AD194", VA = "0x13AD194")]
		private void UpdatePosition(float distance)
		{
		}

		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x13AD310", Offset = "0x13AD310", VA = "0x13AD310")]
		private void Update()
		{
		}

		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x13ACE18", Offset = "0x13ACE18", VA = "0x13ACE18")]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}

		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x13AD5CC", Offset = "0x13AD5CC", VA = "0x13AD5CC")]
		public MechSpiderLeg()
		{
		}
	}
}
