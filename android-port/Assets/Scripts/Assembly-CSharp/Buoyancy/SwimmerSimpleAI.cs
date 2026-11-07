using System;
using GolfCourse;
using Il2CppDummyDll;
using UnityEngine;

namespace Buoyancy
{
	[Token(Token = "0x20011E5")]
	public class SwimmerSimpleAI : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x20011E6")]
		public struct WaypointInfo
		{
			[Token(Token = "0x400602D")]
			[FieldOffset(Offset = "0x0")]
			public bool isValid;

			[Token(Token = "0x400602E")]
			[FieldOffset(Offset = "0x4")]
			public Vector3 position;

			[Token(Token = "0x400602F")]
			[FieldOffset(Offset = "0x10")]
			public Collider triggerCollider;

			[Token(Token = "0x4006030")]
			[FieldOffset(Offset = "0x18")]
			public GolfCoursePinGoal pin;

			[Token(Token = "0x60051E6")]
			[Address(RVA = "0x185FB14", Offset = "0x185FB14", VA = "0x185FB14")]
			public WaypointInfo(Transform wp)
			{
			}
		}

		[Token(Token = "0x400601E")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody rigid;

		[Token(Token = "0x400601F")]
		[FieldOffset(Offset = "0x20")]
		public BuoyancyTarget floater;

		[Token(Token = "0x4006020")]
		[FieldOffset(Offset = "0x28")]
		public float startDelay;

		[Token(Token = "0x4006021")]
		[FieldOffset(Offset = "0x30")]
		public MinMax shootWaitRange;

		[Token(Token = "0x4006022")]
		[FieldOffset(Offset = "0x38")]
		public float minVelocity;

		[Token(Token = "0x4006023")]
		[FieldOffset(Offset = "0x3C")]
		public float maxVelocity;

		[Token(Token = "0x4006024")]
		[FieldOffset(Offset = "0x40")]
		public float maxPitch;

		[Token(Token = "0x4006025")]
		[FieldOffset(Offset = "0x48")]
		public Transform WaypointContainer;

		[Token(Token = "0x4006026")]
		[FieldOffset(Offset = "0x50")]
		public float distanceThreshold;

		[Token(Token = "0x4006027")]
		[FieldOffset(Offset = "0x54")]
		private float canShootTimer;

		[Token(Token = "0x4006028")]
		[FieldOffset(Offset = "0x58")]
		private float nextRandomShootTimer;

		[Token(Token = "0x4006029")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5785C", Offset = "0x5785C")]
		private WaypointInfo CurrentWaypoint__BackingField;

		[Token(Token = "0x400602A")]
		[FieldOffset(Offset = "0x80")]
		private int wpIndex;

		[Token(Token = "0x400602B")]
		[FieldOffset(Offset = "0x88")]
		private Rigidbody[] rigidbodies;

		[Token(Token = "0x400602C")]
		[FieldOffset(Offset = "0x90")]
		private WaypointInfo[] waypointInfos;

		[Token(Token = "0x170008DB")]
		public WaypointInfo CurrentWaypoint
		{
			[Token(Token = "0x60051DE")]
			[Address(RVA = "0x16F1C1C", Offset = "0x16F1C1C", VA = "0x16F1C1C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70658", Offset = "0x70658")]
			get
			{
				return default;
			}
			[Token(Token = "0x60051DF")]
			[Address(RVA = "0x16F1C28", Offset = "0x16F1C28", VA = "0x16F1C28")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70668", Offset = "0x70668")]
			private set
			{
			}
		}

		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x16F1C34", Offset = "0x16F1C34", VA = "0x16F1C34")]
		private void Start()
		{
		}

		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x16F1E74", Offset = "0x16F1E74", VA = "0x16F1E74")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x16F239C", Offset = "0x16F239C", VA = "0x16F239C")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x16F2258", Offset = "0x16F2258", VA = "0x16F2258")]
		private bool CanShoot()
		{
			return default;
		}

		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x16F22E8", Offset = "0x16F22E8", VA = "0x16F22E8")]
		private Vector3 PitchBoost(Vector3 boost)
		{
			return default;
		}

		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x16F2464", Offset = "0x16F2464", VA = "0x16F2464")]
		public SwimmerSimpleAI()
		{
		}
	}
}
