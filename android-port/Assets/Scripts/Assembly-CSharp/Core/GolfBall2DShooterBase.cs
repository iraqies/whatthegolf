using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using UnityEngine;

namespace Core
{
	[Token(Token = "0x200144C")]
	public abstract class GolfBall2DShooterBase : ShooterBase
	{
		[Token(Token = "0x200144D")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4910C", Offset = "0x4910C")]
		private sealed class _003CLockForDurationRoutine_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4006E66")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4006E67")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4006E68")]
			[FieldOffset(Offset = "0x20")]
			public GolfBall2DShooterBase _003C_003E4__this;

			[Token(Token = "0x4006E69")]
			[FieldOffset(Offset = "0x28")]
			public float duration;

			[Token(Token = "0x4006E6A")]
			[FieldOffset(Offset = "0x2C")]
			private float _003CendTime_003E5__2;

			[Token(Token = "0x17000ACC")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6005F12")]
				[Address(RVA = "0x17B4D28", Offset = "0x17B4D28", VA = "0x17B4D28", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current();
				}
			}

			[Token(Token = "0x17000ACD")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6005F14")]
				[Address(RVA = "0x17B4D70", Offset = "0x17B4D70", VA = "0x17B4D70", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EIEnumerator_002Eget_Current();
				}
			}

			[Token(Token = "0x6005F0F")]
			[Address(RVA = "0x17B4C04", Offset = "0x17B4C04", VA = "0x17B4C04")]
			[DebuggerHidden]
			public _003CLockForDurationRoutine_003Ed__16(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6005F10")]
			[Address(RVA = "0x17B4C30", Offset = "0x17B4C30", VA = "0x17B4C30", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6005F11")]
			[Address(RVA = "0x17B4C34", Offset = "0x17B4C34", VA = "0x17B4C34", Slot = "6")]
			private bool MoveNext()
			{
				return default;
			}

			[Token(Token = "0x6005F12")]
			[Address(RVA = "0x17B4D28", Offset = "0x17B4D28", VA = "0x17B4D28", Slot = "4")]
			[DebuggerHidden]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002Eget_Current()
			{
				return null;
			}

			[Token(Token = "0x6005F13")]
			[Address(RVA = "0x17B4D30", Offset = "0x17B4D30", VA = "0x17B4D30", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}

			[Token(Token = "0x6005F14")]
			[Address(RVA = "0x17B4D70", Offset = "0x17B4D70", VA = "0x17B4D70", Slot = "7")]
			[DebuggerHidden]
			private object System_002ECollections_002EIEnumerator_002Eget_Current()
			{
				return null;
			}
		}

		[Token(Token = "0x4006E5E")]
		[FieldOffset(Offset = "0x20")]
		protected Rigidbody2D rigidbodyC;

		[Token(Token = "0x4006E5F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float goalPullForce;

		[Token(Token = "0x4006E60")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float goalPullDistance;

		[Token(Token = "0x4006E61")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool useCurrentForce;

		[Token(Token = "0x4006E62")]
		[FieldOffset(Offset = "0x34")]
		public float sqrVelocityShootingThreshold;

		[Token(Token = "0x4006E63")]
		[FieldOffset(Offset = "0x38")]
		private float currentStillTime;

		[Token(Token = "0x4006E64")]
		[FieldOffset(Offset = "0x3C")]
		private float stillTimeThreshold;

		[Token(Token = "0x4006E65")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine lockRoutine;

		[Token(Token = "0x6005F05")]
		[Address(RVA = "0x14908A4", Offset = "0x14908A4", VA = "0x14908A4", Slot = "11")]
		protected virtual void Awake()
		{
		}

		[Token(Token = "0x6005F06")]
		[Address(RVA = "0x1490924", Offset = "0x1490924", VA = "0x1490924", Slot = "12")]
		protected virtual void FixedUpdate()
		{
		}

		[Token(Token = "0x6005F07")]
		[Address(RVA = "0x1490C20", Offset = "0x1490C20", VA = "0x1490C20", Slot = "13")]
		protected virtual bool IsBlocking()
		{
			return default;
		}

		[Token(Token = "0x6005F08")]
		[Address(RVA = "0x1490CA4", Offset = "0x1490CA4", VA = "0x1490CA4")]
		protected void StandardShoot(Vector3 boost, float pitch, float fullShootVelocity, float spin)
		{
		}

		[Token(Token = "0x6005F09")]
		[Address(RVA = "0x1490EE0", Offset = "0x1490EE0", VA = "0x1490EE0")]
		public void StopAndSleep()
		{
		}

		[Token(Token = "0x6005F0A")]
		[Address(RVA = "0x1490F14", Offset = "0x1490F14", VA = "0x1490F14")]
		public void StartAndWakeup()
		{
		}

		[Token(Token = "0x6005F0B")]
		[Address(RVA = "0x1490D70", Offset = "0x1490D70", VA = "0x1490D70")]
		protected void StandardShoot(Vector3 boost, float pitch, float minShootVelocity, float fullShootVelocity, float spin)
		{
		}

		[Token(Token = "0x6005F0C")]
		[Address(RVA = "0x1490F48", Offset = "0x1490F48", VA = "0x1490F48")]
		public void LockForDuration(float v)
		{
		}

		[Token(Token = "0x6005F0D")]
		[Address(RVA = "0x1490FF0", Offset = "0x1490FF0", VA = "0x1490FF0")]
		private IEnumerator LockForDurationRoutine(float duration)
		{
			return null;
		}

		[Token(Token = "0x6005F0E")]
		[Address(RVA = "0x1491074", Offset = "0x1491074", VA = "0x1491074")]
		protected GolfBall2DShooterBase()
		{
		}
	}
}
