using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x2001463")]
	public class SonicShooter : GolfBallShooterBase
	{
		[Token(Token = "0x2001464")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4913C", Offset = "0x4913C")]
		private sealed class _003CFreezeAndShoot_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006F9A")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006F9B")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006F9C")]
			[FieldOffset(Offset = "0x20")]
			public SonicShooter _003C_003E4__this;

			[Token(Token = "0x4006F9D")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 outVel;

			[Token(Token = "0x4006F9E")]
			[FieldOffset(Offset = "0x34")]
			public float newHigh;

			[Token(Token = "0x4006F9F")]
			[FieldOffset(Offset = "0x38")]
			private float _003Ct_003E5__2;

			[Token(Token = "0x17000AE3")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005FED")]
				[Address(RVA = "0x1852D90", Offset = "0x1852D90", VA = "0x1852D90", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000AE4")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005FEF")]
				[Address(RVA = "0x1852DD8", Offset = "0x1852DD8", VA = "0x1852DD8", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005FEA")]
			[Address(RVA = "0x1852C20", Offset = "0x1852C20", VA = "0x1852C20")]
			[DebuggerHidden]
			public _003CFreezeAndShoot_003Ed__27(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005FEB")]
			[Address(RVA = "0x1852C4C", Offset = "0x1852C4C", VA = "0x1852C4C", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005FEC")]
			[Address(RVA = "0x1852C50", Offset = "0x1852C50", VA = "0x1852C50", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005FED")]
			[Address(RVA = "0x1852D90", Offset = "0x1852D90", VA = "0x1852D90", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005FEE")]
			[Address(RVA = "0x1852D98", Offset = "0x1852D98", VA = "0x1852D98", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005FEF")]
			[Address(RVA = "0x1852DD8", Offset = "0x1852DD8", VA = "0x1852DD8", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006F85")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody rb;

		[Token(Token = "0x4006F86")]
		[FieldOffset(Offset = "0x68")]
		private float groundLevel;

		[Token(Token = "0x4006F87")]
		[FieldOffset(Offset = "0x6C")]
		private bool touchingGround;

		[Token(Token = "0x4006F88")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 levitatingPos;

		[Token(Token = "0x4006F89")]
		[FieldOffset(Offset = "0x7C")]
		public float levitatingHeight;

		[Token(Token = "0x4006F8A")]
		[FieldOffset(Offset = "0x80")]
		public float minShootVelocity;

		[Token(Token = "0x4006F8B")]
		[FieldOffset(Offset = "0x84")]
		public float fullShootVelocity;

		[Token(Token = "0x4006F8C")]
		[FieldOffset(Offset = "0x88")]
		public float pitch;

		[Token(Token = "0x4006F8D")]
		[FieldOffset(Offset = "0x8C")]
		public float spin;

		[Token(Token = "0x4006F8E")]
		[FieldOffset(Offset = "0x90")]
		private float gravity;

		[Token(Token = "0x4006F8F")]
		[FieldOffset(Offset = "0x94")]
		private bool canAim;

		[Token(Token = "0x4006F90")]
		[FieldOffset(Offset = "0x98")]
		private float drag;

		[Token(Token = "0x4006F91")]
		[FieldOffset(Offset = "0xA0")]
		private SonicBounce[] bouncers;

		[Token(Token = "0x4006F92")]
		[FieldOffset(Offset = "0xA8")]
		public ParticleSystem particle;

		[Token(Token = "0x4006F93")]
		[FieldOffset(Offset = "0xB0")]
		private LineRenderer line;

		[Token(Token = "0x4006F94")]
		[FieldOffset(Offset = "0xB8")]
		public MeshRenderer ghost;

		[Token(Token = "0x4006F95")]
		[FieldOffset(Offset = "0xC0")]
		private float thickness;

		[Token(Token = "0x4006F96")]
		[FieldOffset(Offset = "0xC8")]
		private GolfBallController controller;

		[Token(Token = "0x4006F97")]
		[FieldOffset(Offset = "0xD0")]
		private float freezeTime;

		[Token(Token = "0x4006F98")]
		[FieldOffset(Offset = "0xD4")]
		private bool frozen;

		[Token(Token = "0x4006F99")]
		[FieldOffset(Offset = "0xD8")]
		public ParticleSystem active;

		[Token(Token = "0x6005FDF")]
		[Address(RVA = "0x16C01BC", Offset = "0x16C01BC", VA = "0x16C01BC")]
		private void Start()
		{
		}

		[Token(Token = "0x6005FE0")]
		[Address(RVA = "0x16C0380", Offset = "0x16C0380", VA = "0x16C0380", Slot = "5")]
		public override void OnAimStart()
		{
		}

		[Token(Token = "0x6005FE1")]
		[Address(RVA = "0x16C043C", Offset = "0x16C043C", VA = "0x16C043C", Slot = "6")]
		public override void OnAimUpdate(Vector3 boost, bool onlyAimArrow)
		{
		}

		[Token(Token = "0x6005FE2")]
		[Address(RVA = "0x16C07CC", Offset = "0x16C07CC", VA = "0x16C07CC", Slot = "7")]
		public override void OnShoot(Vector3 boost)
		{
		}

		[Token(Token = "0x6005FE3")]
		[Address(RVA = "0x16C08B4", Offset = "0x16C08B4", VA = "0x16C08B4")]
		private void OnCollisionEnter(Collision other)
		{
		}

		[Token(Token = "0x6005FE4")]
		[Address(RVA = "0x16C0C18", Offset = "0x16C0C18", VA = "0x16C0C18")]
		private void Chill(Vector3 point)
		{
		}

		[Token(Token = "0x6005FE5")]
		[Address(RVA = "0x16C0B7C", Offset = "0x16C0B7C", VA = "0x16C0B7C")]
		private IEnumerator FreezeAndShoot(Vector3 outVel, float newHigh)
		{
			return null;
		}

		[Token(Token = "0x6005FE6")]
		[Address(RVA = "0x16C0C8C", Offset = "0x16C0C8C", VA = "0x16C0C8C")]
		private void OnCollisionExit(Collision other)
		{
		}

		[Token(Token = "0x6005FE7")]
		[Address(RVA = "0x16C0D20", Offset = "0x16C0D20", VA = "0x16C0D20")]
		private void OnCollisionStay(Collision other)
		{
		}

		[Token(Token = "0x6005FE8")]
		[Address(RVA = "0x16C0E70", Offset = "0x16C0E70", VA = "0x16C0E70", Slot = "12")]
		protected override void FixedUpdate()
		{
		}

		[Token(Token = "0x6005FE9")]
		[Address(RVA = "0x16C0FDC", Offset = "0x16C0FDC", VA = "0x16C0FDC")]
		public SonicShooter()
		{
		}
	}
}
