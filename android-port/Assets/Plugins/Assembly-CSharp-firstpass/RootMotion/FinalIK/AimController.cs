using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001B2")]
	public class AimController : MonoBehaviour
	{
		[Token(Token = "0x20001B3")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3393C", Offset = "0x3393C")]
		private sealed class _003CTurnToTarget_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000BB1")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4000BB2")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4000BB3")]
			[FieldOffset(Offset = "0x20")]
			public AimController _003C_003E4__this;

			[Token(Token = "0x170001A0")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6000CDD")]
				[Address(RVA = "0x1330670", Offset = "0x1330670", VA = "0x1330670", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x170001A1")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6000CDF")]
				[Address(RVA = "0x13306B8", Offset = "0x13306B8", VA = "0x13306B8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6000CDA")]
			[Address(RVA = "0x133057C", Offset = "0x133057C", VA = "0x133057C")]
			[DebuggerHidden]
			public _003CTurnToTarget_003Ed__33(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6000CDB")]
			[Address(RVA = "0x13305A8", Offset = "0x13305A8", VA = "0x13305A8", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6000CDC")]
			[Address(RVA = "0x13305AC", Offset = "0x13305AC", VA = "0x13305AC", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6000CDD")]
			[Address(RVA = "0x1330670", Offset = "0x1330670", VA = "0x1330670", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6000CDE")]
			[Address(RVA = "0x1330678", Offset = "0x1330678", VA = "0x1330678", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6000CDF")]
			[Address(RVA = "0x13306B8", Offset = "0x13306B8", VA = "0x13306B8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4000B96")]
		[FieldOffset(Offset = "0x18")]
		public AimIK ik;

		[Token(Token = "0x4000B97")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x3696C", Offset = "0x3696C")]
		public float weight;

		[Token(Token = "0x4000B98")]
		[FieldOffset(Offset = "0x28")]
		public Transform target;

		[Token(Token = "0x4000B99")]
		[FieldOffset(Offset = "0x30")]
		public float targetSwitchSmoothTime;

		[Token(Token = "0x4000B9A")]
		[FieldOffset(Offset = "0x34")]
		public float weightSmoothTime;

		[Token(Token = "0x4000B9B")]
		[FieldOffset(Offset = "0x38")]
		public bool smoothTurnTowardsTarget;

		[Token(Token = "0x4000B9C")]
		[FieldOffset(Offset = "0x3C")]
		public float maxRadiansDelta;

		[Token(Token = "0x4000B9D")]
		[FieldOffset(Offset = "0x40")]
		public float maxMagnitudeDelta;

		[Token(Token = "0x4000B9E")]
		[FieldOffset(Offset = "0x44")]
		public float slerpSpeed;

		[Token(Token = "0x4000B9F")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 pivotOffsetFromRoot;

		[Token(Token = "0x4000BA0")]
		[FieldOffset(Offset = "0x54")]
		public float minDistance;

		[Token(Token = "0x4000BA1")]
		[FieldOffset(Offset = "0x58")]
		public Vector3 offset;

		[Token(Token = "0x4000BA2")]
		[FieldOffset(Offset = "0x64")]
		[AttributeAttribute(Name = "RangeAttribute", RVA = "0x36984", Offset = "0x36984")]
		public float maxRootAngle;

		[Token(Token = "0x4000BA3")]
		[FieldOffset(Offset = "0x68")]
		public bool turnToTarget;

		[Token(Token = "0x4000BA4")]
		[FieldOffset(Offset = "0x6C")]
		public float turnToTargetTime;

		[Token(Token = "0x4000BA5")]
		[FieldOffset(Offset = "0x70")]
		public bool useAnimatedAimDirection;

		[Token(Token = "0x4000BA6")]
		[FieldOffset(Offset = "0x74")]
		public Vector3 animatedAimDirection;

		[Token(Token = "0x4000BA7")]
		[FieldOffset(Offset = "0x80")]
		private Transform lastTarget;

		[Token(Token = "0x4000BA8")]
		[FieldOffset(Offset = "0x88")]
		private float switchWeight;

		[Token(Token = "0x4000BA9")]
		[FieldOffset(Offset = "0x8C")]
		private float switchWeightV;

		[Token(Token = "0x4000BAA")]
		[FieldOffset(Offset = "0x90")]
		private float weightV;

		[Token(Token = "0x4000BAB")]
		[FieldOffset(Offset = "0x94")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000BAC")]
		[FieldOffset(Offset = "0xA0")]
		private Vector3 dir;

		[Token(Token = "0x4000BAD")]
		[FieldOffset(Offset = "0xAC")]
		private bool lastSmoothTowardsTarget;

		[Token(Token = "0x4000BAE")]
		[FieldOffset(Offset = "0xAD")]
		private bool turningToTarget;

		[Token(Token = "0x4000BAF")]
		[FieldOffset(Offset = "0xB0")]
		private float turnToTargetMlp;

		[Token(Token = "0x4000BB0")]
		[FieldOffset(Offset = "0xB4")]
		private float turnToTargetMlpV;

		[Token(Token = "0x1700019F")]
		private Vector3 pivot
		{
			[Token(Token = "0x6000CD5")]
			[Address(RVA = "0x12EA620", Offset = "0x12EA620", VA = "0x12EA620")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000CD3")]
		[Address(RVA = "0x12EA59C", Offset = "0x12EA59C", VA = "0x12EA59C")]
		private void Start()
		{
		}

		[Token(Token = "0x6000CD4")]
		[Address(RVA = "0x12EA6B0", Offset = "0x12EA6B0", VA = "0x12EA6B0")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x6000CD6")]
		[Address(RVA = "0x12EAC30", Offset = "0x12EAC30", VA = "0x12EAC30")]
		private void ApplyMinDistance()
		{
		}

		[Token(Token = "0x6000CD7")]
		[Address(RVA = "0x12EAD1C", Offset = "0x12EAD1C", VA = "0x12EAD1C")]
		private void RootRotation()
		{
		}

		[Token(Token = "0x6000CD8")]
		[Address(RVA = "0x12EB000", Offset = "0x12EB000", VA = "0x12EB000")]
		private IEnumerator TurnToTarget()
		{
			return null;
		}

		[Token(Token = "0x6000CD9")]
		[Address(RVA = "0x12EB074", Offset = "0x12EB074", VA = "0x12EB074")]
		public AimController()
		{
		}
	}
}
