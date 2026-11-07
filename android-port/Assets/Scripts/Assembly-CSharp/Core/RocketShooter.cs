using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001461")]
	public class RocketShooter : GolfBallShooterBase
	{
		[Token(Token = "0x2001462")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4912C", Offset = "0x4912C")]
		private sealed class _003CHitAnimation_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006F7D")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006F7E")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006F7F")]
			[FieldOffset(Offset = "0x20")]
			public RocketShooter _003C_003E4__this;

			[Token(Token = "0x4006F80")]
			[FieldOffset(Offset = "0x28")]
			public float interval;

			[Token(Token = "0x4006F81")]
			[FieldOffset(Offset = "0x2C")]
			public int times;

			[Token(Token = "0x4006F82")]
			[FieldOffset(Offset = "0x30")]
			private int _003Ccount_003E5__2;

			[Token(Token = "0x4006F83")]
			[FieldOffset(Offset = "0x34")]
			private float _003CnextFlicker_003E5__3;

			[Token(Token = "0x4006F84")]
			[FieldOffset(Offset = "0x38")]
			private bool _003CnextIsHit_003E5__4;

			[Token(Token = "0x17000AE1")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005FDC")]
				[Address(RVA = "0x1835DF4", Offset = "0x1835DF4", VA = "0x1835DF4", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000AE2")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005FDE")]
				[Address(RVA = "0x1835E3C", Offset = "0x1835E3C", VA = "0x1835E3C", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005FD9")]
			[Address(RVA = "0x1835BB0", Offset = "0x1835BB0", VA = "0x1835BB0")]
			[DebuggerHidden]
			public _003CHitAnimation_003Ed__39(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005FDA")]
			[Address(RVA = "0x1835BDC", Offset = "0x1835BDC", VA = "0x1835BDC", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005FDB")]
			[Address(RVA = "0x1835BE0", Offset = "0x1835BE0", VA = "0x1835BE0", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005FDC")]
			[Address(RVA = "0x1835DF4", Offset = "0x1835DF4", VA = "0x1835DF4", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005FDD")]
			[Address(RVA = "0x1835DFC", Offset = "0x1835DFC", VA = "0x1835DFC", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005FDE")]
			[Address(RVA = "0x1835E3C", Offset = "0x1835E3C", VA = "0x1835E3C", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006F5F")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rb;

		[Token(Token = "0x4006F60")]
		[FieldOffset(Offset = "0x68")]
		public float minShootVelocity;

		[Token(Token = "0x4006F61")]
		[FieldOffset(Offset = "0x6C")]
		public float fullShootVelocity;

		[Token(Token = "0x4006F62")]
		[FieldOffset(Offset = "0x70")]
		public float pitch;

		[Token(Token = "0x4006F63")]
		[FieldOffset(Offset = "0x74")]
		public float spin;

		[Token(Token = "0x4006F64")]
		[FieldOffset(Offset = "0x78")]
		public ParticleSystem particle;

		[Token(Token = "0x4006F65")]
		[FieldOffset(Offset = "0x80")]
		private GolfBallController controller;

		[Token(Token = "0x4006F66")]
		[FieldOffset(Offset = "0x88")]
		public float strokeInterval;

		[Token(Token = "0x4006F67")]
		[FieldOffset(Offset = "0x8C")]
		private bool ignoreFirstCollision;

		[Token(Token = "0x4006F68")]
		[FieldOffset(Offset = "0x8D")]
		private bool wasOverThreshold;

		[Token(Token = "0x4006F69")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Vector3 groundUpDirection;

		[Token(Token = "0x4006F6A")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float acceptedGroundedAngle;

		[Token(Token = "0x4006F6B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private float acceptedBoostAngle;

		[Token(Token = "0x4006F6C")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		private float collisionKnockoutRelativeVel;

		[Token(Token = "0x4006F6D")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ParticleSystem particleSystem;

		[Token(Token = "0x4006F6E")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private int particleAmount;

		[Token(Token = "0x4006F6F")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float knockoutForce;

		[Token(Token = "0x4006F70")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Animation hitAnimation;

		[Token(Token = "0x4006F71")]
		[FieldOffset(Offset = "0xC0")]
		private LayerMask groundLayer;

		[Token(Token = "0x4006F72")]
		[FieldOffset(Offset = "0xC4")]
		private LayerMask playerLayer;

		[Token(Token = "0x4006F73")]
		[FieldOffset(Offset = "0xC8")]
		private Vector3 lastAimDirection;

		[Token(Token = "0x4006F74")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		private float otherPlayerCountsAsGroundVelocity;

		[Token(Token = "0x4006F75")]
		[FieldOffset(Offset = "0xD8")]
		private Collider lastHit;

		[Token(Token = "0x4006F76")]
		[FieldOffset(Offset = "0xE0")]
		private float nextSameParticles;

		[Token(Token = "0x4006F77")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Material regularMaterial;

		[Token(Token = "0x4006F78")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Material hitMaterial;

		[Token(Token = "0x4006F79")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private List<SpriteRenderer> renderers;

		[Token(Token = "0x4006F7A")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private int hitAnimTimes;

		[Token(Token = "0x4006F7B")]
		[FieldOffset(Offset = "0x104")]
		[SerializeField]
		private float flickerDuration;

		[Token(Token = "0x4006F7C")]
		[FieldOffset(Offset = "0x108")]
		private Coroutine hitAnimCoroutine;

		[Token(Token = "0x6005FCE")]
		[Address(RVA = "0x1659A70", Offset = "0x1659A70", VA = "0x1659A70")]
		private void Start()
		{
		}

		[Token(Token = "0x6005FCF")]
		[Address(RVA = "0x1659B50", Offset = "0x1659B50", VA = "0x1659B50", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005FD0")]
		[Address(RVA = "0x1659B84", Offset = "0x1659B84", VA = "0x1659B84", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005FD1")]
		[Address(RVA = "0x1659C88", Offset = "0x1659C88", VA = "0x1659C88", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FD2")]
		[Address(RVA = "0x1659D04", Offset = "0x1659D04", VA = "0x1659D04")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6005FD3")]
		[Address(RVA = "0x165A598", Offset = "0x165A598", VA = "0x165A598")]
		private void OnCollisionStay(Collision other)
		{
		}

		[Token(Token = "0x6005FD4")]
		[Address(RVA = "0x165A198", Offset = "0x165A198", VA = "0x165A198")]
		private bool IsGround(Collision collision)
		{
			return default;
		}

		[Token(Token = "0x6005FD5")]
		[Address(RVA = "0x165A6AC", Offset = "0x165A6AC", VA = "0x165A6AC", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005FD6")]
		[Address(RVA = "0x165A2E4", Offset = "0x165A2E4", VA = "0x165A2E4")]
		private void TriggerCollisionFeedback(Collision other)
		{
		}

		[Token(Token = "0x6005FD7")]
		[Address(RVA = "0x165A50C", Offset = "0x165A50C", VA = "0x165A50C")]
		private IEnumerator HitAnimation(int times, float interval)
		{
			return null;
		}

		[Token(Token = "0x6005FD8")]
		[Address(RVA = "0x165A6B0", Offset = "0x165A6B0", VA = "0x165A6B0")]
		public RocketShooter()
		{
		}
	}
}
